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
    public class PHIEU_MUONController : Controller
    {
        private QuanLyThuVienEntities db = new QuanLyThuVienEntities();

        // GET: PHIEU_MUON
        public ActionResult Index()
        {
            var pHIEU_MUON = db.PHIEU_MUON.Include(p => p.DOC_GIA).Include(p => p.SACH);
            return View(pHIEU_MUON.ToList());
        }

        // GET: PHIEU_MUON/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEU_MUON pHIEU_MUON = db.PHIEU_MUON.Find(id);
            if (pHIEU_MUON == null)
            {
                return HttpNotFound();
            }
            return View(pHIEU_MUON);
        }

        // GET: PHIEU_MUON/Create
        public ActionResult Create()
        {
            ViewBag.MaDocGia = new SelectList(db.DOC_GIA, "MaDocGia", "HoTen");
            ViewBag.MaSach = new SelectList(db.SACHes, "MaSach", "TenSach");
            return View();
        }

        // POST: PHIEU_MUON/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPhieuMuon,MaDocGia,MaSach,NgayMuon,NgayTraDuKien,NgayTraThucTe")] PHIEU_MUON pHIEU_MUON)
        {
            if (ModelState.IsValid)
            {
                db.PHIEU_MUON.Add(pHIEU_MUON);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaDocGia = new SelectList(db.DOC_GIA, "MaDocGia", "HoTen", pHIEU_MUON.MaDocGia);
            ViewBag.MaSach = new SelectList(db.SACHes, "MaSach", "TenSach", pHIEU_MUON.MaSach);
            return View(pHIEU_MUON);
        }

        // GET: PHIEU_MUON/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEU_MUON pHIEU_MUON = db.PHIEU_MUON.Find(id);
            if (pHIEU_MUON == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaDocGia = new SelectList(db.DOC_GIA, "MaDocGia", "HoTen", pHIEU_MUON.MaDocGia);
            ViewBag.MaSach = new SelectList(db.SACHes, "MaSach", "TenSach", pHIEU_MUON.MaSach);
            return View(pHIEU_MUON);
        }

        // POST: PHIEU_MUON/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaPhieuMuon,MaDocGia,MaSach,NgayMuon,NgayTraDuKien,NgayTraThucTe")] PHIEU_MUON pHIEU_MUON)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pHIEU_MUON).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaDocGia = new SelectList(db.DOC_GIA, "MaDocGia", "HoTen", pHIEU_MUON.MaDocGia);
            ViewBag.MaSach = new SelectList(db.SACHes, "MaSach", "TenSach", pHIEU_MUON.MaSach);
            return View(pHIEU_MUON);
        }

        // GET: PHIEU_MUON/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEU_MUON pHIEU_MUON = db.PHIEU_MUON.Find(id);
            if (pHIEU_MUON == null)
            {
                return HttpNotFound();
            }
            return View(pHIEU_MUON);
        }

        // POST: PHIEU_MUON/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PHIEU_MUON pHIEU_MUON = db.PHIEU_MUON.Find(id);
            db.PHIEU_MUON.Remove(pHIEU_MUON);
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
