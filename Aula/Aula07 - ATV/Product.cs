using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_07___ATV
{
    public class Product
{
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public string? Barcode { get; set; }

        private static int _nextBarcode = 1;

        public Product (int id, string name, string location, string barcode)
        {
            Id = id;
            Name = name;
            Location = location;
            Barcode = barcode;

            barcode = _nextBarcode.ToString("D3");
            _nextBarcode++;
        }

        public Product()
        {
            Barcode = _nextBarcode.ToString("D3");
            _nextBarcode++;
        }

    }
}