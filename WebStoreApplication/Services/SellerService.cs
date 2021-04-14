using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreApplication.Data;
using WebStoreApplication.Models;

namespace WebStoreApplication.Services
{
    public class SellerService
    {
        private readonly WebStoreApplicationContext _context;

        public SellerService(WebStoreApplicationContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();

        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}
