using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NarrowWebExchangeProj.Models
{
    public class Listing
    {
        public int ListingId { get; set; }
        [ForeignKey("SiteUser")]
        public int SellerUserId { get; set; }
        public SiteUser UserId { get; set; }
        [Display(Name = "Make")]
        public string Make { get; set; }
        [Display(Name = "Model")]
        public string Model { get; set; }
        [Display(Name = "Hours")]
        public int Hours { get; set; }
        [Display(Name = "Year")]
        public int Year { get; set; }
        [Display(Name = "Width: in or mm")]
        public int Width { get; set; }
        [Display(Name = "Number of Print Stations")]
        public int NumColors { get; set; }
        [Display(Name = "Number of Die-Stations")]
        public int NumDieStations { get; set; }
        [Display(Name = "Condition")]
        public string Condition { get; set; }
        [Display(Name = "List Tooling Included")]
        public string ToolingIncluded { get; set; }
        [Display(Name = "Features & Comments")]
        public string FeaturesAndComments { get; set; }
        //Listing Format
        [Display(Name = "Listing Type")]
        public string ListingType { get; set; }
        [Display(Name = "BuyItNow Price")]
        public int BuyItNowPrice { get; set; }
        [Display(Name = "Reserve Price")]
        public int ReservePrice { get; set; }
        [Display(Name = "Date & Time to Start Listing")]
        public DateTime ListingDateTime { get; set; }
        [Display(Name = "Number of Days For Your Auction")]
        
        public int ListingDays { get; set; }
        //No user input below here
        public int NumberOfBids { get; set; }
        public int HighBidPrice { get; set; }
        public int HighBidUserId { get; set; }
        public bool ReserveMet { get; set; }
        public int Commission { get; set; }
        public int DueSeller { get; set; }
        public bool PaymentReceived { get; set; }


    }
}
