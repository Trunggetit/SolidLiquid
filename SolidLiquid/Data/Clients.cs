using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SolidLiquid.Data
{
    public class Clients
    {
        [Key]
        public int Id { get; set; }

        public int Type { get; set; }
        public string Title { get; set; }
        public DateTime FU { get; set; }
        public int IsDeleted { get; set; }

    }
}
