using OnlineBidding.Entity;
using OnlineBidding.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBidding.Web.Controllers
{
    public class AuctionController : Controller
    {
       
        private readonly AuctionService service;
        public AuctionController()
        {
            this.service = new AuctionService();
        }
        // GET: Auction
        public ActionResult Index()
        {
            List<Auction> auctions = service.GetAll();
            return View(auctions);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Auction auction)
        {
            auction.ActionId = Guid.NewGuid().ToString();
            service.Save(auction);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            Auction auction = service.GetById(id);
            return View(auction);
        }
        [HttpPost]
        public ActionResult Edit(Auction auction)
        {
           
            service.Update(auction);
            return RedirectToAction("Index");
        }

        
        public ActionResult Delete(string id)
        {

            service.Delete(id);
            return RedirectToAction("Index");
        }


    }
}