using OnlineBidding.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBidding.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("BiddingConnection")
        {

        }
        public DbSet<Auction> Auctions  { get; set; }
   
    }
}
