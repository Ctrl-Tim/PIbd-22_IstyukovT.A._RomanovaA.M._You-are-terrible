﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonContracts.BindingModel
{
    public class CosmeticBindingModel
    {
        public int? Id { get; set; }

        public int? EmployeeId { get; set; }

        public string CosmeticName { get; set; }

        public decimal Price { get; set; }
    }
}
