using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NarrowWebExchangeProj.Models
{
    public class Bid
    {
        public int BidId { get; set; }
        public int BidderId { get; set; }
        public int BidListingId { get; set; }
    }
}
