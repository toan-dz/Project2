using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Web_Quản_lý_sách_trong_thư_viện.Models;

namespace Web_Quản_lý_sách_trong_thư_viện.Controllers
{
    public class QuanLySachController : Controller
    {
        private LibraryContext db = new LibraryContext();

       
        public ActionResult Index()
        {
            var sachList = db.SachVaTheLoai.Include(s => s.TheLoai).ToList();
            return View(sachList);
        }

       
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SachVaTheLoai sach = db.SachVaTheLoai.Find(id);
            if (sach == null)
            {
                return HttpNotFound();
            }
            return View(sach);
        }

   
        public ActionResult Create()
        {
            ViewBag.MaTheLoai = new SelectList(db.TheLoai, "MaTheLoai", "TenTheLoai");
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSach,TenSach,TacGia,NamXuatBan,NhaXuatBan,SoLuong,Gia,MaTheLoai")] SachVaTheLoai sach)
        {
            if (ModelState.IsValid)
            {
                db.SachVaTheLoai.Add(sach);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaTheLoai = new SelectList(db.TheLoai, "MaTheLoai", "TenTheLoai", sach.MaTheLoai);
            return View(sach);
        }

    
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SachVaTheLoai sach = db.SachVaTheLoai.Find(id);
            if (sach == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaTheLoai = new SelectList(db.TheLoai, "MaTheLoai", "TenTheLoai", sach.MaTheLoai);
            return View(sach);
        }

     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSach,TenSach,TacGia,NamXuatBan,NhaXuatBan,SoLuong,Gia,MaTheLoai")] SachVaTheLoai sach)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sach).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaTheLoai = new SelectList(db.TheLoai, "MaTheLoai", "TenTheLoai", sach.MaTheLoai);
            return View(sach);
        }

       
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SachVaTheLoai sach = db.SachVaTheLoai.Find(id);
            if (sach == null)
            {
                return HttpNotFound();
            }
            return View(sach);
        }

     
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SachVaTheLoai sach = db.SachVaTheLoai.Find(id);
            db.SachVaTheLoai.Remove(sach);
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
