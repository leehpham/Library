﻿using System.Collections.Generic;
using System.Linq;
using LibraryData;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryServices
{
    public class PatronService : IPatron
    {
        private LibraryContext _context;

        public PatronService(LibraryContext context)
        {
            _context = context;
        }

        public Patron Get(int id)
        {
            return GetAll().FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Patron> GetAll()
        {
            return _context.Patrons
                .Include(p => p.LibraryCard)
                .Include(p => p.HomeLibraryBranch);
        }

        public void Add(Patron newPatron)
        {
            _context.Add(newPatron);
            _context.SaveChanges();
        }

        public IEnumerable<CheckoutHistory> GetCheckoutHistory(int patronId)
        {
            var cardId = Get(patronId).LibraryCard.Id;

            return _context.CheckoutHistories
                .Include(co => co.LibraryCard)
                .Include(co => co.LibraryAsset)
                .Where(co => co.LibraryCard.Id == cardId)
                .OrderByDescending(co => co.CheckedOut);
        }

        public IEnumerable<Hold> GetHolds(int patronId)
        {
            var cardId = Get(patronId).LibraryCard.Id;

            return _context.Holds
                .Include(h => h.LibraryCard)
                .Include(h => h.LibraryAsset)
                .Where(h => h.LibraryCard.Id == cardId);
        }

        public IEnumerable<Checkout> GetCheckouts(int patronId)
        {
            var cardId = Get(patronId).LibraryCard.Id;

            return _context.Checkouts
                .Include(co => co.LibraryCard)
                .Include(co => co.LibraryAsset)
                .Where(co => co.LibraryCard.Id == cardId);
        }
    }
}
