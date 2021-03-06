﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CaregiversController : Controller
    {
        private ProjectPart10Entities db = new ProjectPart10Entities();

        // GET: Caregivers
        public async Task<ActionResult> Index()
        {
            return View(await db.Caregivers.ToListAsync());
        }

        // GET: Caregivers/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Caregiver caregiver = await db.Caregivers.FindAsync(id);
            if (caregiver == null)
            {
                return HttpNotFound();
            }
            return View(caregiver);
        }

        // GET: Caregivers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Caregivers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CaregiverID,FirstName,LastName,SocialSecurity,Street,City,HouseNum,Email,State")] Caregiver caregiver)
        {
            if (ModelState.IsValid)
            {
                db.Caregivers.Add(caregiver);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(caregiver);
        }

        // GET: Caregivers/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Caregiver caregiver = await db.Caregivers.FindAsync(id);
            if (caregiver == null)
            {
                return HttpNotFound();
            }
            return View(caregiver);
        }

        // POST: Caregivers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CaregiverID,FirstName,LastName,SocialSecurity,Street,City,HouseNum,Email,State")] Caregiver caregiver)
        {
            if (ModelState.IsValid)
            {
                db.Entry(caregiver).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(caregiver);
        }

        // GET: Caregivers/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Caregiver caregiver = await db.Caregivers.FindAsync(id);
            if (caregiver == null)
            {
                return HttpNotFound();
            }
            return View(caregiver);
        }

        // POST: Caregivers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Caregiver caregiver = await db.Caregivers.FindAsync(id);
            db.Caregivers.Remove(caregiver);
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
