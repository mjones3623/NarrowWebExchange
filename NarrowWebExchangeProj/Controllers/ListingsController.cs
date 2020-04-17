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

namespace NarrowWebExchangeProj.Controllers
{
    public class ListingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ListingsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Choose Listing Type Page
        public IActionResult ChooseListingType()
        {

            return View();
        }

        // GET: Listings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Listing.ToListAsync());
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
                listing.SellerUserId = siteUserInDb.SiteUserId;
                listing.ListingType = "BuyItNow";

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
                listing.SellerUserId = siteUserInDb.SiteUserId;
                listing.ListingType = "Auction";

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
                listing.SellerUserId = siteUserInDb.SiteUserId;
                listing.ListingType = "BuyItNowAuction";

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
