using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Triopod.Models;

namespace Triopod.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            Enquiry enq = new Enquiry();
            enq.DateTime = System.DateTime.Now;
            return View(enq);
        }
        //For Enquiry create partial view in index
        public ActionResult Enquiry()
        {
            Enquiry enq = new Enquiry();
            enq.DateTime = System.DateTime.Now;
            return View(enq);
        }
        // POST: Employee/Create
        [HttpPost]
        public ActionResult Enquiry(Enquiry enquiry)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Enquiries.Add(enquiry);
                    db.SaveChanges();
                    return RedirectToAction("ViewEnquiry");
                }
                catch
                {
                    return View(enquiry);
                }

            }
            else
            {
                return View();
            }
        }
        //To list all Enquiries
        public ActionResult ViewEnquiry()
        {
            var enq = db.Enquiries.ToList();
            return View(enq);
        }
        // GET: Employee/Delete/5
        public ActionResult DeleteEnquiry(int id)
        {
            var emp = db.Enquiries.Single(x => x.EnquiryId == id);

            return View(emp);

        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult DeleteEnquiry(int id, Enquiry enquiry)
        {
            try
            {
                enquiry.EnquiryId = id;

                db.Entry(enquiry).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
