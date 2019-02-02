using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBidding.Entity
{
   public class Auction
    {
        [Key]
        public string ActionId { get; set; }
        public string Title { get; set; }
        public string PictureUrl { get; set; }
        public string Description { get; set; }
        public decimal ActualAmount { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }
    }
}
