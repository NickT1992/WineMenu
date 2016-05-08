using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WineMenu.Models;

namespace WineMenu.Controllers
{
    public class MenuController : Controller
    {
        //
        // GET: /Menu/

        public ActionResult Index()
        {
            var menus = new List<Menu>
              {
                  new Menu { MenuName = "Menu 1"},
                  new Menu { MenuName = "Menu 2"},
                  new Menu { MenuName = "Menu 3"}
              };

            return View(menus);

            //**********************************************
            //**********************************************

            List<SelectListItem> wineTypeList = new List<SelectListItem>();
            DropDown dropDown = new DropDown();

            dropDown.Id = 1;
            dropDown.Value = "White";

            wineTypeList.Add(new SelectListItem() { Value = dropDown.Value, Text = dropDown.Id.ToString() });

            dropDown.Id = 2;
            dropDown.Value = "Red";

            wineTypeList.Add(new SelectListItem() { Value = dropDown.Value, Text = dropDown.Id.ToString() });

            dropDown.Id = 3;
            dropDown.Value = "Rose";

            wineTypeList.Add(new SelectListItem() { Value = dropDown.Value, Text = dropDown.Id.ToString() });

            ViewBag.DropDownValues = new SelectList(wineTypeList, "Text", "Value");
            return View();
            
            getWines();
        }

        public ActionResult CreateMenu()
        {
            var menu = new Menu { MenuId = 1, MenuName = "Menu 1", MenuLastUpdated = new DateTime(12/12/2012) };
            
            return View(menu);
        }

        public ActionResult BrowseMenus(string menuId)
        {
            var menu = new Menu { MenuId = 222, MenuName = "Menu 2", MenuLastUpdated = new DateTime(2012, 02, 02) };

            return View(menu);
        }
        public ActionResult getWines()
        {
            List<SelectListItem> wineList = new List<SelectListItem>();
            DropDown dropDown = new DropDown();

            dropDown.Id = 1;
            dropDown.Value = "House White";

            wineList.Add(new SelectListItem() { Value = dropDown.Value, Text = dropDown.Id.ToString() });

            dropDown.Id = 2;
            dropDown.Value = "House Red";

            wineList.Add(new SelectListItem() { Value = dropDown.Value, Text = dropDown.Id.ToString() });

            dropDown.Id = 3;
            dropDown.Value = "House Rose";

            wineList.Add(new SelectListItem() { Value = dropDown.Value, Text = dropDown.Id.ToString() });

            ViewBag.DropDownValues = new SelectList(wineList, "Text", "Value");
            return View(wineList);
        }
    }
}
