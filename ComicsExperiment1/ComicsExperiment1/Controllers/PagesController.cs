using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ComicsExperiment1.Models;

namespace ComicsExperiment1.Controllers
{
    public class PagesController : Controller
    {
        private ComicDBContext db = new ComicDBContext();

        // GET: Pages
        public async Task<ActionResult> Index()
        {
            return View(await db.Pages.ToListAsync());
        }

        // GET: Pages/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Page page = await db.Pages.FindAsync(id);
            if (page == null)
            {
                return HttpNotFound();
            }
            return View(page);
        }

        // GET: Pages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,ImageUri,PageNumber,Title")] Page page)
        {
            if (ModelState.IsValid)
            {
                db.Pages.Add(page);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(page);
        }

        // GET: Pages/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Page page = await db.Pages.FindAsync(id);
            if (page == null)
            {
                return HttpNotFound();
            }
            return View(page);
        }

        // POST: Pages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,ImageUri,PageNumber,Title")] Page page)
        {
            if (ModelState.IsValid)
            {
                db.Entry(page).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(page);
        }

        // GET: Pages/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Page page = await db.Pages.FindAsync(id);
            if (page == null)
            {
                return HttpNotFound();
            }
            return View(page);
        }

        // POST: Pages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Page page = await db.Pages.FindAsync(id);
            db.Pages.Remove(page);
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
