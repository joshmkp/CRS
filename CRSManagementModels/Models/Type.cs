using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRSManagementModels.Models
{
    public class Type
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public ICollection<Control> Controls { get; set; }

        public ICollection<Report> Reports { get; set; }
    }
}
