using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using ProductCRUDWebApplication1.Models;
using System.IO;
using System.Drawing;

namespace ProductCRUDWebApplication1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            using (ProductDBEntities1 db = new ProductDBEntities1())
            {
                List<tblProduct> ProductList = (from data in db.tblProducts select data).ToList();

                return View(ProductList);
            }
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View(new tblProduct());
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(tblProduct product, HttpPostedFileBase postedFile)
        {
            try
            {
                // TODO: Add insert logic here
                string extension = Path.GetExtension(postedFile.FileName);
                if(extension.Equals(".jpg") || extension.Equals(".png"))
                {
                    string filename = "IMG-" + DateTime.Now.ToString("yyyymmddhhmmssffff") + extension;
                    string savepath = Server.MapPath("~/Content/Images/");
                    postedFile.SaveAs(savepath + filename);
                    product.prod_pic = filename;
                    using (ProductDBEntities1 db = new ProductDBEntities1())
                    {
                        db.tblProducts.Add(product);
                        db.SaveChanges();
                    }
                }
                else if (extension.Equals(null))
                {
                    using (ProductDBEntities1 db = new ProductDBEntities1())
                    {
                        db.SaveChanges();
                    }
                }
                else
                {
                    return Content("You can only upload JPG or PNG Files!!");
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            using (ProductDBEntities1 db = new ProductDBEntities1())
            {
                //tblProduct products = (from data in db.tblProducts
                //                       where data.prod_id == id
                //                       select data).Single();
                tblProduct products = db.tblProducts.Find(id);
                return View(products);
            }
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(tblProduct product, HttpPostedFileBase postedFile)
        {
            try
            {
                // TODO: Add update logic here
                string filename = "";
                if (postedFile != null)
                {
                    string extension = Path.GetExtension(postedFile.FileName);
                    if (extension.Equals(".jpg") || extension.Equals(".png"))
                    {
                        filename = "IMG-" + DateTime.Now.ToString("yyyymmddhhmmssffff") + extension;
                        string savepath = Server.MapPath("~/Content/Images/");
                        postedFile.SaveAs(savepath + filename);
                    }
                }
                using (ProductDBEntities1 db = new ProductDBEntities1())
                {
                    tblProduct tbl = db.tblProducts.Find(product.prod_id);
                    tbl.prod_name = product.prod_name; 
                    tbl.prod_price = product.prod_price;
                    tbl.prod_qty = product.prod_qty;
                    if (!filename.Equals(""))
                    {
                        tbl.prod_pic = filename;                        
                    }
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            using (ProductDBEntities1 db = new ProductDBEntities1())
            {
                db.tblProducts.Remove(db.tblProducts.Find(id));
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        // POST: Product/Delete/5
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
