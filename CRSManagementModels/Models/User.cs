using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace CRSManagementModels.Models
{
    public class User : IdentityUser
    {
        
        public string Id { get; set; }

        //public ICollection<Control> Controls { get; set; }

        public ICollection<Customer> Customers { get; set; }

        public ICollection<Report> Reports { get; set; }

        public ICollection<Supplier> Suppliers { get; set; }
    }
}
