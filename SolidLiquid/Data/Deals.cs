using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidLiquid.Data
{
    public class Deals
    {
        public int Id { get; set; }
        public int ClientID { get; set; }
        public string Title { get; set; }
        public decimal Amount { get; set; }
        public DateTime FU { get; set; }
    }
}
