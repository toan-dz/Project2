using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web_Quản_lý_sách_trong_thư_viện.Models;

namespace Web_Quản_lý_sách_trong_thư_viện.Controllers
{
    public class DOC_GIAController : Controller
    {
        private QuanLyThuVienEntities db = new QuanLyThuVienEntities();

        // GET: DOC_GIA
        public ActionResult Index()
        {
            return View(db.DOC_GIA.ToList());
        }

        // GET: DOC_GIA/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DOC_GIA dOC_GIA = db.DOC_GIA.Find(id);
            if (dOC_GIA == null)
            {
                return HttpNotFound();
            }
            return View(dOC_GIA);
        }

        // GET: DOC_GIA/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DOC_GIA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDocGia,HoTen,NgaySinh,DiaChi,Email,SoDienThoai")] DOC_GIA dOC_GIA)
        {
            if (ModelState.IsValid)
            {
                db.DOC_GIA.Add(dOC_GIA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dOC_GIA);
        }

        // GET: DOC_GIA/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DOC_GIA dOC_GIA = db.DOC_GIA.Find(id);
            if (dOC_GIA == null)
            {
                return HttpNotFound();
            }
            return View(dOC_GIA);
        }

        // POST: DOC_GIA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDocGia,HoTen,NgaySinh,DiaChi,Email,SoDienThoai")] DOC_GIA dOC_GIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dOC_GIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dOC_GIA);
        }

        // GET: DOC_GIA/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DOC_GIA dOC_GIA = db.DOC_GIA.Find(id);
            if (dOC_GIA == null)
            {
                return HttpNotFound();
            }
            return View(dOC_GIA);
        }

        // POST: DOC_GIA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DOC_GIA dOC_GIA = db.DOC_GIA.Find(id);
            db.DOC_GIA.Remove(dOC_GIA);
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
