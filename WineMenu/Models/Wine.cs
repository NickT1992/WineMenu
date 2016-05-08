using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WineMenu.Models
{
    public class Wine
    {
        public int WineId { get; set; }
        public string WineName { get; set; }
        public string WineType { get; set; }
        public string WineDescription { get; set; }
        public string WineSize { get; set; }
        public decimal WinePrice { get; set; }
    }
}