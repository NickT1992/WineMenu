using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WineMenu.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public DateTime MenuLastUpdated { get; set; }
    }
}