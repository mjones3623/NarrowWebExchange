using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NarrowWebExchangeProj.Models
{
    public class Search
    {
        public int SearchId { get; set; }
        public int SearchSiteUserId { get; set; }
        [Display(Name = "Make")]
        public string SearchMake { get; set; }
        [Display(Name = "Model")]
        public string SearchModel { get; set; }
        [Display(Name = "Min Width")]
        public int SearchMinWidth { get; set; }
        [Display(Name = "MaxWidth")]
        public int SearchMaxWidth { get; set; }
        [Display(Name = "Min Hours")]
        public int SearchMinHours { get; set; }
        [Display(Name = "Max Hours")]
        public int SearchMaxHours { get; set; }
        [Display(Name = "Year from...")]
        public int SearchFromYear { get; set; }
        [Display(Name = "Year to...")]
        public int SearchToYear { get; set; }
        [Display(Name = "Min Number of Colors")]
        public int SearchMinNumColors { get; set; }
        [Display(Name = "Maximum Number of Colors")]
        public int SearchMaxNumColors { get; set; }
        [Display(Name = "Min Number of Die Stations")]
        public int SearchMinNumDieStations { get; set; }
        [Display(Name = "Max Number of Die Stations")]
        public int SearchMaxNumDieStations { get; set; }
        [Display(Name = "Listing Type")]
        public string SearchListingType { get; set; }


    }
}
