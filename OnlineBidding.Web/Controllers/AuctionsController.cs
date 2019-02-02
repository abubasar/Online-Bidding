using OnlineBidding.Entity;
using OnlineBidding.Service;
using OnlineBidding.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBidding.Web.Controllers
{
    public class AuctionsController : Controller
    {

        private readonly AuctionService service;
        public AuctionsController()
        {
            this.service = new AuctionService();
        }
        // GET: Auction
        public ActionResult Index()
        {
            AuctionsListViewModel viewModel = new AuctionsListViewModel();
            viewModel.PageTitle = "Auctions list";
            viewModel.PageDescription = "this is Auctions list Page";
            viewModel.AllAuctions = service.GetAll();
            return View(viewModel);
        }

        public ActionResult List()
        {
           
            return PartialView("_List");
        }

        public ActionResult Details(string id)
        {
            AuctionsViewModel actionsViewModel = new AuctionsViewModel();
            actionsViewModel.PageTitle = " Auction Details Page";
            actionsViewModel.PageDescription = "This is Auction Details Page";
            var auction = service.GetById(id);
            return View(auction);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView("_Create");
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
            return PartialView("_Edit",auction);
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