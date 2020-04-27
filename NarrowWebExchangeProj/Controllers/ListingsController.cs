using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NarrowWebExchangeProj.Data;
using NarrowWebExchangeProj.Models;
using System.IO;

namespace NarrowWebExchangeProj.Controllers
{
    public class ListingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ListingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult MyActivity()
        {
            List<Listing> myActivity1 = new List<Listing>();
            List<Bid> siteUserBids = new List<Bid>();
            List<Listing> bidListingIds = new List<Listing>();
            List<Listing> bidListings = new List<Listing>();
            

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var siteUserInDb = _context.SiteUsers.Where(m => m.IdentityUserId == userId).FirstOrDefault();
            siteUserBids = _context.Bids.Where(b => b.BidderId == siteUserInDb.SiteUserId).ToList();

            for (int i = 0; i < siteUserBids.Count - 1; i++)
            {
                var listing1 = _context.Listing.Where(l => l.ListingId == siteUserBids[i].BidListingId).FirstOrDefault();
                bidListings.Add(listing1);
                                
            };
                                    
            myActivity1 = _context.Listing
            .Where(e => ((e.ItemSold == true) && (siteUserInDb.SiteUserId == e.HighBidUserId)) || 
            (e.SellerUserId == siteUserInDb.SiteUserId)).ToList();

            myActivity1.AddRange(bidListings); 
            
            return View(myActivity1);
        }

        // GET: Search

        public IActionResult SearchResults()
        {
            List<Listing> searchResult = new List<Listing>();

            DateTime now = DateTime.Now;

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var siteUserInDb = _context.SiteUsers.Where(m => m.IdentityUserId == userId).FirstOrDefault();
            var searchInDb = _context.Searches.OrderByDescending(s => s.SearchId).FirstOrDefault();

            searchResult = _context.Listing
            .Where(e => ((searchInDb.SearchMake == e.Make) && (searchInDb.SearchModel == e.Model) &&
            (e.Width >= searchInDb.SearchMinWidth && e.Width <= searchInDb.SearchMaxWidth) &&
            (e.Hours >= searchInDb.SearchMinHours && e.Hours <= searchInDb.SearchMaxHours) &&
            (e.Year >= searchInDb.SearchFromYear && e.Year <= searchInDb.SearchToYear) &&
            (e.NumColors >= searchInDb.SearchMinNumColors && e.NumColors <= searchInDb.SearchMaxNumColors) &&
            (e.NumDieStations >= searchInDb.SearchMinNumDieStations && e.NumDieStations <= searchInDb.SearchMaxNumDieStations) &&
            (e.ListingType == searchInDb.SearchListingType) && (e.ItemSold == false) &&  (e.TimedOutNoSale == false) && 
            (e.ListingDateTime <= now) && (e.ListingEndDateTime >= now))).ToList();

            
            
            return View(searchResult);
        }

        // GET: Search

        public IActionResult Search()
        {

            return View();
        }
        // GET: Choose Listing Type Page
        public IActionResult ChooseListingType()
        {

            return View();
        }

        // GET: Listings
        public async Task<IActionResult> Index()
        {
            List<Listing> validListings = new List<Listing>();

            DateTime now = DateTime.Now;

            validListings =  _context.Listing.Where(e => (e.ItemSold == false) && (e.TimedOutNoSale == false) && 
            (e.ListingDateTime <= now) && (e.ListingEndDateTime >= now)).ToList();
            

            return View(validListings);
        }

        // GET: Listings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listing = await _context.Listing
                .FirstOrDefaultAsync(m => m.ListingId == id);
            if (listing == null)
            {
                return NotFound();
            }

            return View(listing);
        }

        // GET: Listings/Create
        public IActionResult Create()
        {
            ViewData["Makes"] = new SelectList(_context.Makes, "MakeName", "MakeName");
            ViewData["Conditions"] = new SelectList(_context.Conditions, "ConditionName", "ConditionName");

            return View();
        }

        // POST: Listings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ListingId,SellerUserId,Make,Model,Hours,Year,Width,NumColors,NumDieStations,Condition,ToolingIncluded,FeaturesAndComments,ListingType,BuyItNowPrice,ReservePrice,ListingDateTime,ListingDays,CurrentBid,NumberOfBids,HighBidPrice,HighBidUserId,ReserveMet,Commission,DueSeller,PaymentReceived,Image1,Image2,Image3,Image4")] Listing listing)
        {
            if (ModelState.IsValid)
            {
                              
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var siteUserInDb = _context.SiteUsers.Where(m => m.IdentityUserId == userId).FirstOrDefault();

                listing.ListingEndDateTime = listing.ListingDateTime.AddDays(listing.ListingDays);

                listing.SellerUserId = siteUserInDb.SiteUserId;
                listing.ListingType = "BuyItNow";
                listing.Image1 = "~/images/" + listing.Image1;
                listing.Image2 = "~/images/" + listing.Image2;
                listing.Image3 = "~/images/" + listing.Image3;
                listing.Image4 = "~/images/" + listing.Image4;

                _context.Add(listing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(listing);
        }
        // GET: Listings/Create
        public IActionResult CreateAuction()
        {
            ViewData["Makes"] = new SelectList(_context.Makes, "MakeName", "MakeName");
            ViewData["Conditions"] = new SelectList(_context.Conditions, "ConditionName", "ConditionName");

            return View();
        }

        // POST: Listings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAuction([Bind("ListingId,SellerUserId,Make,Model,Hours,Year,Width,NumColors,NumDieStations,Condition,ToolingIncluded,FeaturesAndComments,ListingType,BuyItNowPrice,ReservePrice,ListingDateTime,ListingDays,CurrentBid,NumberOfBids,HighBidPrice,HighBidUserId,ReserveMet,Commission,DueSeller,PaymentReceived,Image1,Image2,Image3,Image4")] Listing listing)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var siteUserInDb = _context.SiteUsers.Where(m => m.IdentityUserId == userId).FirstOrDefault();

                listing.ListingEndDateTime = listing.ListingDateTime.AddDays(listing.ListingDays);

                listing.SellerUserId = siteUserInDb.SiteUserId;
                listing.ListingType = "Auction";
                listing.Image1 = "~/images/" + listing.Image1;
                listing.Image2 = "~/images/" + listing.Image2;
                listing.Image3 = "~/images/" + listing.Image3;
                listing.Image4 = "~/images/" + listing.Image4;

                _context.Add(listing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(listing);
        }
        // GET: Listings/Create
        public IActionResult CreateBuyItNowAuction()
        {
            ViewData["Makes"] = new SelectList(_context.Makes, "MakeName", "MakeName");
            ViewData["Conditions"] = new SelectList(_context.Conditions, "ConditionName", "ConditionName");

            return View();
        }

        // POST: Listings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBuyItNowAuction([Bind("ListingId,SellerUserId,Make,Model,Hours,Year,Width,NumColors,NumDieStations,Condition,ToolingIncluded,FeaturesAndComments,ListingType,BuyItNowPrice,ReservePrice,ListingDateTime,ListingDays,CurrentBid,NumberOfBids,HighBidPrice,HighBidUserId,ReserveMet,Commission,DueSeller,PaymentReceived,Image1,Image2,Image3,Image4")] Listing listing)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var siteUserInDb = _context.SiteUsers.Where(m => m.IdentityUserId == userId).FirstOrDefault();

                listing.ListingEndDateTime = listing.ListingDateTime.AddDays(listing.ListingDays);

                listing.SellerUserId = siteUserInDb.SiteUserId;
                listing.ListingType = "BuyItNowAuction";
                listing.Image1 = "~/images/" + listing.Image1;
                listing.Image2 = "~/images/" + listing.Image2;
                listing.Image3 = "~/images/" + listing.Image3;
                listing.Image4 = "~/images/" + listing.Image4;

                _context.Add(listing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(listing);
        }

        // GET: Listings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listing = await _context.Listing.FindAsync(id);
            if (listing == null)
            {
                return NotFound();
            }
            return View(listing);
        }

        // POST: Listings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ListingId,SellerUserId,Make,Model,Hours,Year,Width,NumColors,NumDieStations,Condition,ToolingIncluded,FeaturesAndComments,ListingType,BuyItNowPrice,ReservePrice,ListingDateTime,ListingDays,CurrentBid,NumberOfBids,HighBidPrice,HighBidUserId,ReserveMet,Commission,DueSeller,PaymentReceived,Image1,Image2,Image3,Image4")] Listing listing)
        {
            if (id != listing.ListingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listing);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListingExists(listing.ListingId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(listing);
        }

        // GET: Listings/Edit/5
        public async Task<IActionResult> EditBuyItNow(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listing = await _context.Listing.FindAsync(id);
            if (listing == null)
            {
                return NotFound();
            }
            return View(listing);
        }

        // POST: Listings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBuyItNow(int id, [Bind("ListingId")] Listing listing)
        {
            var itemSold = listing.ItemSold;

            var ListingInDb = _context.Listing.Where(m => m.ListingId == listing.ListingId).FirstOrDefault();
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var siteUserInDb = _context.SiteUsers.Where(m => m.IdentityUserId == userId).FirstOrDefault();

            listing = ListingInDb;

            
            if (id != listing.ListingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (itemSold == true)
                    {
                        listing.ItemSold = true;
                        listing.HighBidUserId = siteUserInDb.SiteUserId;
                        listing.HighBidPrice = listing.BuyItNowPrice;
                        listing.Commission = listing.BuyItNowPrice * 0.05;
                        listing.DueSeller = listing.BuyItNowPrice * 0.95;

                        _context.Update(listing);
                        await _context.SaveChangesAsync();

                    }
                    else
                    {
                        return View();
                    }

                   
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListingExists(listing.ListingId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(listing);
        }

        // GET: Listings/Edit/5
        public async Task<IActionResult> EditAuction(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listing = await _context.Listing.FindAsync(id);
            if (listing == null)
            {
                return NotFound();
            }
            return View(listing);
        }

        // POST: Listings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAuction(int id, [Bind("ListingId,SellerUserId,Make,Model,Hours,Year,Width,NumColors,NumDieStations,Condition,ToolingIncluded,FeaturesAndComments,ListingType,BuyItNowPrice,ReservePrice,ListingDateTime,ListingDays,CurrentBid,NumberOfBids,HighBidPrice,HighBidUserId,ReserveMet,Commission,DueSeller,PaymentReceived,Image1,Image2,Image3,Image4")] Listing listing)
        {
            var highBidPrice = listing.HighBidPrice;

            var ListingInDb = _context.Listing.Where(m => m.ListingId == listing.ListingId).FirstOrDefault();
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var siteUserInDb = _context.SiteUsers.Where(m => m.IdentityUserId == userId).FirstOrDefault();

            listing = ListingInDb;


            if (id != listing.ListingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if(highBidPrice >= listing.ReservePrice && highBidPrice > listing.HighBidPrice)
                    {
                        listing.ReserveMet = true;
                        listing.HighBidPrice = highBidPrice;
                        listing.HighBidUserId = siteUserInDb.SiteUserId;
                        listing.NumberOfBids++;
                        listing.CurrentBid = highBidPrice;
                        Bid bid = new Bid();
                        bid.BidListingId = listing.ListingId;
                        bid.BidderId = siteUserInDb.SiteUserId;
                        _context.Add(bid);
                        await _context.SaveChangesAsync();
                        _context.Update(listing);
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        return View();
                    }
                    
                }
                
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListingExists(listing.ListingId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(listing);
        }

        // GET: Listings/Edit/5
        public async Task<IActionResult> EditBuyItNowAuction(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listing = await _context.Listing.FindAsync(id);
            if (listing == null)
            {
                return NotFound();
            }
            return View(listing);
        }

        // POST: Listings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBuyItNowAuction(int id, [Bind("ListingId,HighBidPrice,ItemSold")] Listing listing)
        {
            var highBidPrice = listing.HighBidPrice;
            var itemSold = listing.ItemSold;

            var ListingInDb = _context.Listing.Where(m => m.ListingId == listing.ListingId).FirstOrDefault();
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var siteUserInDb = _context.SiteUsers.Where(m => m.IdentityUserId == userId).FirstOrDefault();

            listing = ListingInDb;


            if (id != listing.ListingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (itemSold == true && highBidPrice > 0)
                    {

                        return View();
                    }
                    else if (itemSold == true)
                    {
                        listing.ItemSold = true;
                        listing.HighBidUserId = siteUserInDb.SiteUserId;
                        listing.HighBidPrice = listing.BuyItNowPrice;
                        listing.Commission = listing.BuyItNowPrice * 0.05;
                        listing.DueSeller = listing.BuyItNowPrice * 0.95;

                        _context.Update(listing);
                        await _context.SaveChangesAsync();
                    }
                    else if (highBidPrice >= listing.ReservePrice && highBidPrice > listing.HighBidPrice)
                    {
                        listing.ReserveMet = true;
                        listing.HighBidPrice = highBidPrice;
                        listing.HighBidUserId = siteUserInDb.SiteUserId;
                        listing.NumberOfBids++;
                        listing.ListingType = "Auction";
                        listing.CurrentBid = highBidPrice;
                        Bid bid = new Bid();
                        bid.BidListingId = listing.ListingId;
                        bid.BidderId = siteUserInDb.SiteUserId;
                        _context.Add(bid);
                        await _context.SaveChangesAsync();
                        _context.Update(listing);
                        await _context.SaveChangesAsync();
                    }
                    else if (highBidPrice > listing.HighBidPrice)
                    {
                        
                        listing.HighBidPrice = highBidPrice;
                        listing.HighBidUserId = siteUserInDb.SiteUserId;
                        listing.NumberOfBids++;
                        
                        listing.CurrentBid = highBidPrice;
                        Bid bid = new Bid();
                        bid.BidListingId = listing.ListingId;
                        bid.BidderId = siteUserInDb.SiteUserId;
                        _context.Add(bid);
                        await _context.SaveChangesAsync();
                        _context.Update(listing);
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        return View();
                    }



                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListingExists(listing.ListingId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(listing);
        }

        // GET: Listings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listing = await _context.Listing
                .FirstOrDefaultAsync(m => m.ListingId == id);
            if (listing == null)
            {
                return NotFound();
            }

            return View(listing);
        }

        // POST: Listings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var listing = await _context.Listing.FindAsync(id);
            _context.Listing.Remove(listing);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListingExists(int id)
        {
            return _context.Listing.Any(e => e.ListingId == id);
        }
    }
}
