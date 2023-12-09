using firstproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstproject.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            ViewBag.ItemList = "Computer Shop";
            List<ItemList> itemList = new List<ItemList>()
            {
                new ItemList{ID="001",Name="Acer",Price=500,Category="Laptop"},
                new ItemList{ID="002",Name="Mac",Price=1500,Category="Laptop"},
                new ItemList{ID="003",Name="Asus",Price=600,Category="Laptop"},
                new ItemList{ID="001",Name="Dell",Price=580,Category="Laptop"},
            };
            itemList.Add(new ItemList { ID = "005", Name = "MSI", Price = 900, Category = "Laptop" });
            return View(itemList);
        }
    }
}