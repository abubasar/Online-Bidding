using OnlineBidding.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBidding.Web.ViewModels
{
    public class AuctionsListViewModel:PageViewModel
    {
        public List<Auction> AllAuctions { get; set; }
    }
}