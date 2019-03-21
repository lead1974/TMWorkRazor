using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DNTBreadCrumb.Core;
using TMWork.Data.Core;
using TMWork.Data.Core.Domain;
using TMWork.Services;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Text.RegularExpressions;
using TMWork.ViewModels;
using AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace TMWork.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public readonly GlobalService _service;
        private readonly IConfiguration _config;
        private readonly IHostingEnvironment _env;
        private readonly IEmailSender _sendemail;

        public IndexModel(IUnitOfWork unitOfWork, GlobalService service, IConfiguration config, IHostingEnvironment env, IEmailSender sendemail)
        {
            _unitOfWork = unitOfWork;
            _service = service;
            _config = config;
            _env = env;
            _sendemail = sendemail;
        }

        [TempData]
        public string StatusMessage { get; set; }
        [TempData]
        public string ErrorMessage { get; set; }

        [BindProperty]
        public ContactVM contact { get; set; }
        public void OnGet()
        {
            contact = new ContactVM();
        }

        public async Task<IActionResult> OnPost()
        {
           if (!ModelState.IsValid)
            {
                string messages = string.Join("; ", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));
                if (messages.ToLower().Contains("recaptcha"))
                {
                    ModelState.Clear();
                    //ModelState.AddModelError("", "Are you a human?");
                    StatusMessage = "ERROR: Are you a robot?";
                }
                return Page();
            };

            if (contact.Name != null && contact.Name.Length > 0)
            {
                var addContact = new Data.Core.Domain.Contact()
                {
                    Name = contact.Name,
                    Phone = contact.Phone,
                    Email = contact.Email,
                    Message = contact.Message,
                    DateUpdated = DateTime.UtcNow,
                    UpdatedBy = contact.Name,
                    DateCreated = DateTime.UtcNow,
                    CreatedBy = contact.Name
                };
                _unitOfWork.Contacts.Add(addContact);
                _unitOfWork.Complete();

                string body = this.createEmailBody_Contact(addContact);
                await _sendemail.SendEmailAsync("", "from Contact page", body);

                StatusMessage = "Dear Customer, thank you for reaching out! Our team will contact you shortly!";
            }
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostContact(ContactVM model)
        {
            string messageBack = "Dear Customer, thank you for reaching out! Our team will contact you shortly!";


            if (!ModelState.IsValid)
            {
                string messages = string.Join("; ", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));
                //if (messages.ToLower().Contains("recaptcha"))
                //{
                //    ModelState.Clear();
                //    //ModelState.AddModelError("", "Are you a human?");
                //    //messageBack = "ERROR: Are you a robot?";
                //    //return new JsonResult(new { messageBack = messageBack });
                //}
                
            };

            var contact = Mapper.Map<ContactVM, Contact>(model);

            //check email
            if (model.Email!=null)
            {
                var foo = new EmailAddressAttribute();
                if (!foo.IsValid(model.Email))
                {
                    messageBack = "ERROR: Email is not valid!";
                    return new JsonResult(new { messageBack = messageBack });
                }
            }
            else
            {
                messageBack = "ERROR: Email is not valid!";
                return new JsonResult(new { messageBack = messageBack });
            }

            //Search for SPAM
            bool containsAny = false;
            string[] spam = _config.GetSection("ContactInfoSettintgs")["SpamInclude"].Trim().Split('|');
            foreach(string value in spam)
            {
                if (model.Message.ToLower().Trim().Contains(value.Trim().ToLower()))
                {
                    containsAny = true;
                    break;
                }
            }

            if (containsAny)
            {
                messageBack = "ERROR: Let's play fair, we are blocking spam messages! Please ensure you enter work related informaiton!";
                return new JsonResult(new { messageBack = messageBack });
            }

            // Insert new contact and send email
            if (contact.Name != null && contact.Name.Length > 0)
            {
                var addContact = new Data.Core.Domain.Contact()
                {
                    Name = contact.Name,
                    Phone = contact.Phone,
                    Email = contact.Email,
                    Message = contact.Message,
                    DateUpdated = DateTime.UtcNow,
                    UpdatedBy = contact.Name,
                    DateCreated = DateTime.UtcNow,
                    CreatedBy = contact.Name
                };
                try
                {
                    _unitOfWork.Contacts.Add(addContact);
                    _unitOfWork.Complete();
                }
                catch (Exception ex)
                { }

                if (!model.AgreeTerms)
                {
                    string body = this.createEmailBody_Contact(contact);
                    await _sendemail.SendEmailAsync("", "from Contact page", body);
                }

                //StatusMessage = "Dear Customer, thank you for reaching out! Our team will contact you shortly!";
            }
            return new JsonResult(new { messageBack = messageBack });
        }

        private string createEmailBody_Contact(Contact model)
        {

            string body = string.Empty;

            var pathToFile = _env.WebRootPath
                    + Path.DirectorySeparatorChar.ToString()
                    + "templates"
                    + Path.DirectorySeparatorChar.ToString()
                    + "EmailTemplate"
                    + Path.DirectorySeparatorChar.ToString()
                    + "ContactUs.html";

            body = System.IO.File.ReadAllText(pathToFile);

            body = body.Replace("{Name}", model.Name); //replacing the required things  
            body = body.Replace("{Phone}", model.Phone);
            body = body.Replace("{Email}", model.Email);
            body = body.Replace("{Message}", model.Message);
            return body;
        }

    }
}
