using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WidgetsERPSite.Models;

namespace WidgetsERPSite.Controllers
{
    public class Line_itemController : Controller
    {
        private widgets_erpEntities db = new widgets_erpEntities();

        // GET: Line_item
        public ActionResult Index()
        {
            var line_item = db.Line_item.Include(l => l.Invoice).Include(l => l.Item);
            return View(line_item.ToList());
        }

        // GET: Line_item/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Line_item line_item = db.Line_item.Find(id);
            if (line_item == null)
            {
                return HttpNotFound();
            }
            return View(line_item);
        }

        // GET: Line_item/Create
        public ActionResult Create()
        {
            ViewBag.PKFK_InvoiceNo = new SelectList(db.Invoices, "PK_InvoiceNo", "PK_InvoiceNo");
            ViewBag.PKFK_ItemID = new SelectList(db.Items, "PK_ItemID", "Description");
            return View();
        }

        // POST: Line_item/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PKFK_ItemID,PKFK_InvoiceNo,Qty,ItemTotal")] Line_item line_item)
        {
            if (ModelState.IsValid)
            {
                db.Line_item.Add(line_item);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PKFK_InvoiceNo = new SelectList(db.Invoices, "PK_InvoiceNo", "PK_InvoiceNo", line_item.PKFK_InvoiceNo);
            ViewBag.PKFK_ItemID = new SelectList(db.Items, "PK_ItemID", "Description", line_item.PKFK_ItemID);
            return View(line_item);
        }

        // GET: Line_item/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Line_item line_item = db.Line_item.Find(id);
            if (line_item == null)
            {
                return HttpNotFound();
            }
            ViewBag.PKFK_InvoiceNo = new SelectList(db.Invoices, "PK_InvoiceNo", "PK_InvoiceNo", line_item.PKFK_InvoiceNo);
            ViewBag.PKFK_ItemID = new SelectList(db.Items, "PK_ItemID", "Description", line_item.PKFK_ItemID);
            return View(line_item);
        }

        // POST: Line_item/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PKFK_ItemID,PKFK_InvoiceNo,Qty,ItemTotal")] Line_item line_item)
        {
            if (ModelState.IsValid)
            {
                db.Entry(line_item).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PKFK_InvoiceNo = new SelectList(db.Invoices, "PK_InvoiceNo", "PK_InvoiceNo", line_item.PKFK_InvoiceNo);
            ViewBag.PKFK_ItemID = new SelectList(db.Items, "PK_ItemID", "Description", line_item.PKFK_ItemID);
            return View(line_item);
        }

        // GET: Line_item/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Line_item line_item = db.Line_item.Find(id);
            if (line_item == null)
            {
                return HttpNotFound();
            }
            return View(line_item);
        }

        // POST: Line_item/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Line_item line_item = db.Line_item.Find(id);
            db.Line_item.Remove(line_item);
            db.SaveChanges();
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
