using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ProductCRUDWebApplication1.Models;

namespace ProductCRUDWebApplication1.Controllers
{
    public class StateController : Controller
    {
        /*
        private readonly MLPLEntities context;
        public StateController(MLPLEntities context)
        {
            this.context = context;
        }
        public async Task<ActionResult> GetData()
        {
            var data = await context.CL_Master_User.ToListAsync();
            return Json(data, JsonRequestBehavior.AllowGet);

        }
        */

        // GET: State
        public ActionResult Index()
        {
            using (ProductDBEntities1 dbEntities1 = new ProductDBEntities1())
            {
                List<State> StatesList = (from data in dbEntities1.States select data).ToList();

                return View(StatesList);
            }
        }

        // GET: State/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: State/Create
        public ActionResult Create()
        {
            return View(new State());
        }

        // POST: State/Create
        [HttpPost]
        public ActionResult Create(State state)
        {
            try
            {
                // TODO: Add insert logic here
                using (ProductDBEntities1 db =  new ProductDBEntities1())
                {
                    db.States.Add(state);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: State/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: State/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: State/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: State/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
