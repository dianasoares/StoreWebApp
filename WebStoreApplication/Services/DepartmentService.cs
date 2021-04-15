using System;
using System.Collections.Generic;
using System.Linq;

using WebStoreApplication.Data;
using WebStoreApplication.Models;

namespace WebStoreApplication.Services
{
    public class DepartmentService
    {
        private readonly WebStoreApplicationContext _context;

        public DepartmentService(WebStoreApplicationContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
