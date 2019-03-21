using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using TMWork.Data.Core;
using TMWork.Data.Core.Domain;
using TMWork.ViewModels;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TMWork.Controllers
{
    //[AllowAnonymous]

    //[Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContactController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        private async Task<bool> ContactExists(int id)
        {
            return await _unitOfWork.Contacts.Exist(id);
        }

        // GET: api/<controller>
        [HttpGet]
        [Route("[action]")]
        [Produces(typeof(DbSet<Contact>))]
        public IActionResult GetAllContacts([DataSourceRequest]DataSourceRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Contacts = _unitOfWork.Contacts.GetAll();
            if (Contacts == null)
            {
                return NotFound();
            }
            Request.HttpContext.Response.Headers.Add("X-Total-Count", _unitOfWork.Contacts.GetCount().ToString());

            return new JsonResult(Contacts.ToDataSourceResult(request));
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        [Route("[action]")]
        [Produces(typeof(DbSet<Contact>))]
        public ActionResult<Contact> GetContactByID([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Contact =  _unitOfWork.Contacts.SingleOrDefault(c => c.ContactId == id);
            if (Contact==null)
            {
                return NotFound();
            }

            return Ok(Contact);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult CreateContact([DataSourceRequest]DataSourceRequest request, [FromForm]Contact Contact)
        {

            //return new ObjectResult(new DataSourceResult { Data = new[] { Contact }, Total = 1 });

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Contact != null && ModelState.IsValid)
            {
                try
                {
                    var ContactToAdd = new Contact
                    {
                        Name = Contact.Name,
                        DateUpdated = DateTime.UtcNow,
                        UpdatedBy = User.Identity.Name,
                        DateCreated = DateTime.UtcNow,
                        CreatedBy = User.Identity.Name

                    };


                    _unitOfWork.Contacts.Add(ContactToAdd);
                    _unitOfWork.Complete();
                    return Json(new[] { ContactToAdd }.ToDataSourceResult(request, ModelState));
                }
                catch (DbUpdateConcurrencyException)
                {

                    {
                        return BadRequest();
                    }
                }

            }
            return CreatedAtAction(nameof(GetContactByID), new { id = Contact.ContactId }, Contact);
        }

        [HttpPut("{id}")]
        [Route("[action]")]
        public async Task<IActionResult> UpdateContact([DataSourceRequest]DataSourceRequest request, [FromForm]Contact contact)
        {
            //return new StatusCodeResult(200);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (contact == null || contact.ContactId == 0)
            {
                return BadRequest();
            }

            if (contact != null && ModelState.IsValid)
            {
                var ContactToUpdate = _unitOfWork.Contacts.SingleOrDefault(c => c.ContactId == contact.ContactId);
                ContactToUpdate.Name = contact.Name;
                ContactToUpdate.DateUpdated = DateTime.UtcNow;
                ContactToUpdate.UpdatedBy =  User.Identity.Name;
                try
                {
                    _unitOfWork.Contacts.Update(ContactToUpdate);
                    _unitOfWork.Complete();
                    return Ok(contact);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await ContactExists(contact.ContactId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        return BadRequest();
                    }
                }
            }
            return new JsonResult(ModelState.IsValid ? true : ModelState.ToDataSourceResult());
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (ModelState.IsValid)
            {
                var ContactToDelete = _unitOfWork.Contacts.SingleOrDefault(c => c.ContactId == id);

                if (ContactToDelete == null) return BadRequest();

                _unitOfWork.Contacts.Remove(ContactToDelete);
                _unitOfWork.Complete();
            }
            else
            {
                return BadRequest();
            }

            return Ok();
        }

    }
}
