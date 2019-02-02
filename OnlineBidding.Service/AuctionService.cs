using OnlineBidding.Data;
using OnlineBidding.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBidding.Service
{
   public class AuctionService
    {
        private readonly DataContext Context;
        public AuctionService()
        {
            Context = new DataContext();
        }
        public List<Auction> GetAll()
        {
            List<Auction> auctions= Context.Auctions.ToList();
            return auctions;
        }

        public List<Auction> GetPromotedAuctions()
        {
            List<Auction> auctions = Context.Auctions.Take(4).ToList();
            return auctions;
        }
        public Auction GetById(string id)
        {
            Auction auction = Context.Auctions.Find(id);
            return auction;
        }
        public bool Save(Auction auction)
        {
            Context.Auctions.Add(auction);
            
            return Context.SaveChanges()>0;
        }
        
        public bool Update(Auction auction)
        {
            Context.Entry(auction).State = System.Data.Entity.EntityState.Modified;

            return Context.SaveChanges() > 0;
        }

        public bool Delete(string id)
        {
           Auction auction= GetById(id);
            Context.Auctions.Remove(auction);
            return Context.SaveChanges() > 0;
        }
    }
}
