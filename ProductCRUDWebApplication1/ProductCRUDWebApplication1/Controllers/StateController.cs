using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ProductCRUDWebApplication1.Models;

namespace ProductCRUDWebApplication1.Controllers
{
    public class StateController : Controller
    {
        // GET: State
        public ActionResult Index()
        {
            using (ProductDBEntities1 dbEntities1 = new ProductDBEntities1())
            {
                List<ewayBill> StatesList = (from data in dbEntities1.ewayBills select data).ToList();

                return View(StatesList);
            }
        }

        // GET: State/Details/5
        public ActionResult Details(int ID)
        {
            return View();
        }

        // GET: State/Create
        public ActionResult Create()
        {
            return View(new ewayBill());
        }

        // POST: State/Create
        [HttpPost]
        public ActionResult Create(ewayBill ID)
        {
            try
            {
                // TODO: Add insert logic here
                using (ProductDBEntities1 db =  new ProductDBEntities1())
                {
                    db.ewayBills.Add(ID);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Edit(int id)
        {
            using (ProductDBEntities1 db = new ProductDBEntities1())
            {
                ewayBill products = db.ewayBills.Find(id);
                return View(products);
            }
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(ewayBill state)
        {
            try
            {
                using (ProductDBEntities1 db = new ProductDBEntities1())
                {
                    ewayBill tbl = db.ewayBills.Find(state.ID);
                    tbl.GSTIN = state.GSTIN;
                    tbl.stateName = state.stateName;
                    tbl.EWBUserName = state.EWBUserName;
                    tbl.EWBPassword = state.EWBPassword;
                    
                    db.SaveChanges();
                }
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
