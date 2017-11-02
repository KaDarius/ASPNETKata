using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETKata.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            var list = new List<Person>();
            list.Add(new Person { Age = 44, IsOwnerMinor = false, Name = "Ashe" });
            list.Add(new Person { Age = 87, IsOwnerMinor = false, Name = "Zilean" });
            list.Add(new Person { Age = 7, IsOwnerMinor = true, Name = "Fratrick" });
            list.Add(new Person { Age = 87, IsOwnerMinor = false, Name = "DEEBO" });


            public int ProductId { get; set; }
            public Guid RowGuid { get; set; }
            public string Name { get; set; }
            public string ProductNumber { get; set; }
            public double ListPrice { get; set; }
            public string Color { get; set; }
            public int DaysToManufacture { get; set; }
            public double StandardCost { get; set; }    
            

            return View(list);
    }

    // GET: Person/Details/5
    public ActionResult Details(int id)
    {
        return View();
    }

    // GET: Person/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: Person/Create
    [HttpPost]
    public ActionResult Create(FormCollection collection)
    {
        try
        {
            // TODO: Add insert logic here

            return RedirectToAction("Index");
        }
        catch
        {
            return View();
        }
    }

    // GET: Person/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: Person/Edit/5
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

    // GET: Person/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: Person/Delete/5
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
