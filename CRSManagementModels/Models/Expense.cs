﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRSManagementModels.Models
{
    public class Expense
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }

        public int Total { get; set; }
    }
}
