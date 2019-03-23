using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TMWork.Data.Core;
using TMWork.Services;

namespace TMWork.Pages.Admin.Contact
{
    public class SendMailModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public readonly  GlobalService _service;
        private readonly IConfiguration _config;
        private readonly IHostingEnvironment _env;
        private readonly IEmailSender _sendemail;

        public SendMailModel(IUnitOfWork unitOfWork, GlobalService service, IConfiguration config, IHostingEnvironment env, IEmailSender sendemail)
        {
            _unitOfWork = unitOfWork;
            _service = service;
            _config = config;
            _env = env;
            _sendemail = sendemail;
        }
        public async Task OnGetAsync()
        {
            var contacts = _unitOfWork.Contacts.GetAll().Where(x => x.Sent == false && x.AgreeTerms == false).ToList();

            foreach(Data.Core.Domain.Contact contact in contacts)
            {
                //check for spam
                bool containsAny = false;
                string[] spam = _config.GetSection("ContactInfoSettintgs")["SpamInclude"].Trim().Split('|');
                foreach (string value in spam)
                {
                    if (contact.Message.ToLower().Trim().Contains(value.Trim().ToLower()))
                    {
                        containsAny = true;
                        break;
                    }
                }

                if (!containsAny)
                {

                    string body = this.createEmailBody_Contact(contact);
                    await _sendemail.SendEmailAsync("", "from Contact page", body);

                    contact.Sent = true;
                    contact.DateUpdated = DateTime.Now;

                    try
                    {
                        _unitOfWork.Contacts.Update(contact);
                        _unitOfWork.Complete();
                    }
                    catch (Exception ex)
                    { }
                }
                else if (containsAny && !contact.AgreeTerms)
                {
                    contact.AgreeTerms = true;
                    contact.DateUpdated = DateTime.Now;

                    try
                    {
                        _unitOfWork.Contacts.Update(contact);
                        _unitOfWork.Complete();
                    }
                    catch (Exception ex)
                    { }
                }
            }

        }

        private string createEmailBody_Contact(TMWork.Data.Core.Domain.Contact model)
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