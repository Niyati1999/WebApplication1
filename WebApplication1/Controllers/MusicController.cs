using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MusicController : Controller
    {
        //to display the page which contains the hyperlink
        public IActionResult Index()
        {
            return View();
        }
        //To display the view of AddMethod taking input from user
        public IActionResult AddMethod()
        {
            IEnumerable<SelectListItem> albumTypes = new List<SelectListItem>()
            {
                new SelectListItem(){Text="Spanish",Value="Spanish"},
                new SelectListItem(){Text="Jazz",Value="Jazz"},
                new SelectListItem(){Text="Romantic",Value="romantic"},
                new SelectListItem(){Text="Poetic",Value="Poetic"},
                new SelectListItem(){Text="DJ",Value="DJ"},
                new SelectListItem(){Text="Christmas",Value="Christmas"}
            };
            ViewBag.albumTypes = albumTypes;
            IEnumerable<SelectListItem> soundTypes = new List<SelectListItem>()
            {
                new SelectListItem(){Text="high",Value="high"},
                new SelectListItem(){Text="medium",Value="medium"},
                new SelectListItem(){Text="low",Value="low"}
            };
            ViewBag.soundTypes = soundTypes;
            return View();
        }
        public IActionResult Details(int id, string Category, string Searchby)
        {
            var list = Album.GetList();
            if (Searchby == "Search by ID")
            {
                var result = (from album in list where album.Id == id select album).FirstOrDefault();

                return View(result);
            }
            
            var resultlist = (from album in list where album.Category.Equals (Category) select album).ToList();
            return View("SearchResultList",resultlist);
        }
        [HttpPost]
        //the input taken from the user is stored in object album 
        public IActionResult AddMethod(Album album)
        {
            return View("Display",album);
        }
        //to display the view of Display 
        public IActionResult Display()
        {
            return View();
        }
        public IActionResult GetList()
        {
            var list = Album.GetList();
            return View("GetList",list);
        }
        public IActionResult SearchAlbum()
        {
             return View();
        }
        [HttpPost]
        public IActionResult SearchAlbum(int Id)
        {
            ViewData["Id"] = Id;
            var list = Album.GetList();
            Album result=null;
            foreach (var item in list)
            {
                if (item.Id == Id)
                {
                    result = item;
                    break;
                }
            }
            return View("SearchResult",result);
        }
    }
}
