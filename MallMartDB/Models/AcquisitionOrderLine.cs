﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallMartDB.Models
{
    public class AcquisitionOrderLine
    {
        public int AcquisitionOrderId { get; set; }
        public int ProductId { get; set; }
        public float? UnitPrice { get; set; }
        public int Quantity { get; set; }

        public AcquisitionOrder AcquisitionOrder { get; set; }
        public Product Product { get; set; }

        public override string ToString()
        {
            return $"{Product.Name} - {Quantity}";
        }
    }
}
