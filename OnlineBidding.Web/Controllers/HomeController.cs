using OnlineBidding.Service;
using OnlineBidding.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBidding.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly AuctionService service;
        public HomeController()
        {
            this.service = new AuctionService();
        }
        public ActionResult Index()
        {
            AuctionsViewModel actionsViewModel = new AuctionsViewModel();
            ViewBag.PageTitle = "Home Page";
            ViewBag.PageDescription = "This is Home Page";
            actionsViewModel.AllAuctions = service.GetAll();
            actionsViewModel.PromotedAuctions = service.GetPromotedAuctions();

          //  ViewBag.AllAuctions = service.GetAll();

            return View(actionsViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}