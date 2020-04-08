using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MedicalStaffController : Controller
    {
        private ProjectPart12Entities db = new ProjectPart12Entities();

        // GET: MedicalStaff
        public async Task<ActionResult> Index()
        {
            return View(await db.MedicalStaffs.ToListAsync());
        }

        // GET: MedicalStaff/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalStaff medicalStaff = await db.MedicalStaffs.FindAsync(id);
            if (medicalStaff == null)
            {
                return HttpNotFound();
            }
            return View(medicalStaff);
        }

        // GET: MedicalStaff/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedicalStaff/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "DoctorID,FirstName,LastName,SocialSecurity,Street,City,Email,State,MTF")] MedicalStaff medicalStaff)
        {
            if (ModelState.IsValid)
            {
                db.MedicalStaffs.Add(medicalStaff);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(medicalStaff);
        }

        // GET: MedicalStaff/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalStaff medicalStaff = await db.MedicalStaffs.FindAsync(id);
            if (medicalStaff == null)
            {
                return HttpNotFound();
            }
            return View(medicalStaff);
        }

        // POST: MedicalStaff/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "DoctorID,FirstName,LastName,SocialSecurity,Street,City,Email,State,MTF")] MedicalStaff medicalStaff)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medicalStaff).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(medicalStaff);
        }

        // GET: MedicalStaff/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalStaff medicalStaff = await db.MedicalStaffs.FindAsync(id);
            if (medicalStaff == null)
            {
                return HttpNotFound();
            }
            return View(medicalStaff);
        }

        // POST: MedicalStaff/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            MedicalStaff medicalStaff = await db.MedicalStaffs.FindAsync(id);
            db.MedicalStaffs.Remove(medicalStaff);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
