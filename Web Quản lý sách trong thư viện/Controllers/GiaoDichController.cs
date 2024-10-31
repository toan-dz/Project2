using Quản_Lý_Sách.Models;
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
    public class GiaoDichController : Controller
    {
        private LibraryContext db = new LibraryContext();

        // GET: GiaoDich
        public ActionResult Index()
        {
            var giaoDichs = db.ThanhToan.Include(g => g.KhachHang).Include(g => g.Sach);
            return View(giaoDichs.ToList());
        }

        // GET: GiaoDich/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiaoDich giaoDich = db.ThanhToan.Find(id);
            if (giaoDich == null)
            {
                return HttpNotFound();
            }
            return View(giaoDich);
        }

        // GET: GiaoDich/Create
        public ActionResult Create()
        {
            ViewBag.MaKH = new SelectList(db.KhachHang, "MaKH", "HoTen");
            ViewBag.MaSach = new SelectList(db.Sach, "MaSach", "TenSach");
            return View();
        }

        // POST: GiaoDich/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaGD,MaKH,MaSach,NgayMuon,NgayTraDuKien,NgayTraThucTe")] GiaoDich giaoDich)
        {
            if (ModelState.IsValid)
            {
                db.ThanhToan.Add(giaoDich);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKH = new SelectList(db.KhachHang, "MaKH", "HoTen", giaoDich.MaKH);
            ViewBag.MaSach = new SelectList(db.Sach, "MaSach", "TenSach", giaoDich.MaSach);
            return View(giaoDich);
        }

        // GET: GiaoDich/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiaoDich giaoDich = db.ThanhToan.Find(id);
            if (giaoDich == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKH = new SelectList(db.KhachHang, "MaKH", "HoTen", giaoDich.MaKH);
            ViewBag.MaSach = new SelectList(db.Sach, "MaSach", "TenSach", giaoDich.MaSach);
            return View(giaoDich);
        }

        // POST: GiaoDich/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaGD,MaKH,MaSach,NgayMuon,NgayTraDuKien,NgayTraThucTe")] GiaoDich giaoDich)
        {
            if (ModelState.IsValid)
            {
                db.Entry(giaoDich).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKH = new SelectList(db.KhachHang, "MaKH", "HoTen", giaoDich.MaKH);
            ViewBag.MaSach = new SelectList(db.Sach, "MaSach", "TenSach", giaoDich.MaSach);
            return View(giaoDich);
        }

        // GET: GiaoDich/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiaoDich giaoDich = db.ThanhToan.Find(id);
            if (giaoDich == null)
            {
                return HttpNotFound();
            }
            return View(giaoDich);
        }

        // POST: GiaoDich/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GiaoDich giaoDich = db.ThanhToan.Find(id);
            db.ThanhToan.Remove(giaoDich);
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
