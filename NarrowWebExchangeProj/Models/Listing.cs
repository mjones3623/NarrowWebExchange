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
        public double BuyItNowPrice { get; set; }
        [Display(Name = "Reserve Price")]
        public double ReservePrice { get; set; }
        [Display(Name = "Date & Time to Start Listing")]
        public DateTime ListingDateTime { get; set; }
        [Display(Name = "Number of Days For Your Auction")]
        
        public int ListingDays { get; set; }
        //No user input below here
        public DateTime ListingEndDateTime { get; set; }
        public double CurrentBid { get; set; }        
        public int NumberOfBids { get; set; }
        public double HighBidPrice { get; set; }
        public int HighBidUserId { get; set; }
        public bool ItemSold { get; set; }
        public bool TimedOutNoSale { get; set; }
        public bool ReserveMet { get; set; }
        public double Commission { get; set; }
        public double DueSeller { get; set; }
        public bool PaymentReceived { get; set; }
        [Display(Name = "Upload Image File")]
        public string Image1 { get; set; }
        [Display(Name = "Upload Image File")]
        public string Image2 { get; set; }
        [Display(Name = "Upload Image File")]
        public string Image3 { get; set; }
        [Display(Name = "Upload Image File")]
        public string Image4 { get; set; }
        


    }
}
