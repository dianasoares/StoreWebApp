using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreApplication.Models;
using WebStoreApplication.Models.Enums;

namespace WebStoreApplication.Data
{
    public class SeedingService
    {
        private WebStoreApplicationContext _context;

        public SeedingService(WebStoreApplicationContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.salesRecord.Any())
            {
                return; //DB has been seeded
            }

            Department d1 = new Department(1, "IT");
            Department d2 = new Department(2, "Financials");
            Department d3 = new Department(3, "Human Resources");
            Department d4 = new Department(4, "Research and Development");
            Department d5 = new Department(5, "Engineering");

            Seller s1 = new Seller(1, "Maria Silva", "maria@email.com", new DateTime(1974, 6, 23), 1056.00, d1);
            Seller s2 = new Seller(2, "Maria das Dores", "mariadores@email.com", new DateTime(1984, 1, 12), 1000.00, d3);
            Seller s3 = new Seller(3, "João Santos", "joao@email.com", new DateTime(1994, 01, 22), 1500.00, d1);
            Seller s4 = new Seller(4, "Pedro José", "pedro@email.com", new DateTime(1999, 6, 10), 2000.00, d1);
            Seller s5 = new Seller(5, "Osvaldo Oliveira", "osvaldo@email.com", new DateTime(2000, 7, 3), 1067.00, d2);
            Seller s6 = new Seller(6, "Mariana da Silva", "mariana@email.com", new DateTime(2003, 12, 3), 4000.00, d5);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2021, 02, 08), 1300, SaleStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2021, 02, 4), 1300, SaleStatus.Canceled, s1);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2021, 02, 12), 1300, SaleStatus.Pendind, s1);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2021, 02, 2), 300, SaleStatus.Billed, s2);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2021, 02, 10), 137, SaleStatus.Billed, s3);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2021, 02, 11), 177, SaleStatus.Canceled, s4);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(2021, 01, 29), 1110, SaleStatus.Billed, s5);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(2021, 01, 20), 1300, SaleStatus.Pendind, s6);
            SalesRecord sr9 = new SalesRecord(9, new DateTime(2021, 01, 20), 130, SaleStatus.Billed, s1);
            SalesRecord sr10 = new SalesRecord(10, new DateTime(2021, 02, 08), 14500, SaleStatus.Billed, s1);
            SalesRecord sr11 = new SalesRecord(11, new DateTime(2021, 02, 4), 1300, SaleStatus.Canceled, s4);
            SalesRecord sr12 = new SalesRecord(12, new DateTime(2021, 02, 12), 121, SaleStatus.Pendind, s1);
            SalesRecord sr13 = new SalesRecord(13, new DateTime(2021, 02, 2), 230, SaleStatus.Billed, s2);
            SalesRecord sr14 = new SalesRecord(14, new DateTime(2021, 02, 13), 550, SaleStatus.Billed, s3);
            SalesRecord sr15 = new SalesRecord(15, new DateTime(2021, 02, 12), 100, SaleStatus.Canceled, s4);
            SalesRecord sr16 = new SalesRecord(16, new DateTime(2021, 01, 29), 1300, SaleStatus.Billed, s5);
            SalesRecord sr17 = new SalesRecord(17, new DateTime(2021, 01, 20), 2300, SaleStatus.Pendind, s6);
            SalesRecord sr18 = new SalesRecord(18, new DateTime(2021, 01, 20), 5000, SaleStatus.Billed, s1);
            SalesRecord sr19 = new SalesRecord(19, new DateTime(2021, 02, 08), 1300, SaleStatus.Billed, s1);
            SalesRecord sr20 = new SalesRecord(20, new DateTime(2021, 02, 4), 1300, SaleStatus.Canceled, s1);
            SalesRecord sr21 = new SalesRecord(21, new DateTime(2021, 02, 12), 1300, SaleStatus.Pendind, s1);
            SalesRecord sr22 = new SalesRecord(22, new DateTime(2021, 02, 2), 300, SaleStatus.Billed, s2);
            SalesRecord sr23 = new SalesRecord(23, new DateTime(2021, 02, 21), 137, SaleStatus.Billed, s3);
            SalesRecord sr24 = new SalesRecord(24, new DateTime(2021, 02, 20), 137, SaleStatus.Billed, s3);
            SalesRecord sr25 = new SalesRecord(25, new DateTime(2021, 02, 19), 137, SaleStatus.Billed, s3);
            SalesRecord sr26 = new SalesRecord(26, new DateTime(2021, 02, 18), 177, SaleStatus.Canceled, s4);
            SalesRecord sr27 = new SalesRecord(27, new DateTime(2021, 01, 29), 1110, SaleStatus.Billed, s5);
            SalesRecord sr28 = new SalesRecord(28, new DateTime(2021, 01, 21), 1300, SaleStatus.Pendind, s6);
            SalesRecord sr29 = new SalesRecord(29, new DateTime(2021, 01, 22), 130, SaleStatus.Billed, s1);
            SalesRecord sr30 = new SalesRecord(30, new DateTime(2021, 02, 08), 14500, SaleStatus.Billed, s1);
            SalesRecord sr31 = new SalesRecord(31, new DateTime(2021, 02, 4), 1300, SaleStatus.Canceled, s4);
            SalesRecord sr32 = new SalesRecord(32, new DateTime(2021, 02, 12), 121, SaleStatus.Pendind, s1);
            SalesRecord sr33 = new SalesRecord(33, new DateTime(2021, 02, 2), 230, SaleStatus.Billed, s2);
            SalesRecord sr34 = new SalesRecord(34, new DateTime(2021, 02, 15), 550, SaleStatus.Billed, s3);
            SalesRecord sr35 = new SalesRecord(45, new DateTime(2021, 02, 14), 100, SaleStatus.Canceled, s4);
            SalesRecord sr36 = new SalesRecord(36, new DateTime(2021, 01, 29), 1300, SaleStatus.Billed, s5);
            SalesRecord sr37 = new SalesRecord(37, new DateTime(2021, 01, 20), 2300, SaleStatus.Pendind, s6);
            SalesRecord sr38 = new SalesRecord(38, new DateTime(2021, 01, 20), 5000, SaleStatus.Billed, s1);

            _context.Department.AddRange(d1, d2, d3, d4, d5);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.salesRecord.AddRange(
                sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8, sr9, sr10,
                sr11, sr12, sr13, sr14, sr15, sr16, sr17, sr18, sr19, sr20,
                sr21, sr22, sr23, sr24, sr25, sr26, sr27, sr28, sr29, sr30,
                sr31, sr32, sr33, sr34, sr35, sr35, sr36, sr37, sr38

            );
            _context.SaveChanges();

        }
    }
}
