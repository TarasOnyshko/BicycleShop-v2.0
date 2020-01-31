using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bikes_MS_.Models;

namespace Bikes_MS_.Controllers
{
    public class CartController : Controller
    {
        Bike_context db = new Bike_context();
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add(int id)
        {

            IEnumerable<Bike> bikes = db.Bikes;
            ViewBag.Bikes = bikes;
            // ViewBag.Id = id;
            //Bike bike = ViewBag.Id;

            // Bike bike2 = bikes.Single(p => p.Id.Equals(id));
            Bike bike2 = bikes.FirstOrDefault(p => p.Id == id);
            if (Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Bike = bike2, Quantity = 1 });
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Bike = bike2, Quantity = 1 });
                }
                Session["cart"] = cart;
            }
            //return RedirectToAction("Shop", "Home");
            return View();
        }


        private int isExist(int id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Bike.Id.Equals(id))
                    return i;
            return -1;
        }

        public ActionResult Remove(int id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            int index = isExist(id);
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return RedirectToAction("Shop", "Home");

        }
    }
}