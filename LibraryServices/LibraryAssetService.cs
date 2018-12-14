using System;
using System.Collections.Generic;
using System.Linq;
using LibraryData;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryServices
{
    public class LibraryAssetService : ILibraryAsset
    {
        private LibraryContext _context;

        public LibraryAssetService(LibraryContext context)
        {
            _context = context;
        }

        public IEnumerable<LibraryAsset> GetAll()
        {
            // Include addtional entities from LibraryAsset definition
            return _context.LibraryAssets
                .Include(asset => asset.Status)
                .Include(asset => asset.Location);
        }

        public LibraryAsset GetById(int id)
        {
            return GetAll()
                .FirstOrDefault(asset => asset.Id == id);
        }

        public void Add(LibraryAsset newAsset)
        {
            _context.Add(newAsset);
            _context.SaveChanges();
        }

        public string GetDeweyIndex(int id)
        {
            throw new NotImplementedException();
        }

        public string GetType(int id)
        {
            throw new NotImplementedException();
        }

        public string GetTitle(int id)
        {
            throw new NotImplementedException();
        }

        public string GetIsbn(int id)
        {
            throw new NotImplementedException();
        }

        public LibraryBranch GetCurrentLocation(int id)
        {
            return GetById(id).Location;
        }

        public string GetAuthorOrDirector(int id)
        {
            throw new NotImplementedException();
        }
    }
}
