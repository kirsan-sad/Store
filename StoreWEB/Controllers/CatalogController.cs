using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreBL;
using StoreDAL.Entity;

namespace StoreWEB.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IRepositoryGetItem<Item> _repositoryGetItem;

        public CatalogController(IRepositoryGetItem<Item> repositoryGetItem)
        {
            _repositoryGetItem = repositoryGetItem;
        }

        public IActionResult Index()
        {
            ICollection<Item> result = _repositoryGetItem.GetItemByCategory("Notebooks"); //default

            ViewBag.Content = result;
            return View();
        }

        public IActionResult Notebooks()
        {
            ICollection<Item> result = _repositoryGetItem.GetItemByCategory("Notebooks");

            ViewBag.Content = result;
            return View();
        }

        public IActionResult Phones()
        {
            ICollection<Item> result = _repositoryGetItem.GetItemByCategory("Phones");

            ViewBag.Content = result;
            return View();
        }

        public IActionResult Cameras()
        {
            ICollection<Item> result = _repositoryGetItem.GetItemByCategory("Cameras");

            ViewBag.Content = result;
            return View();
        }

        public IActionResult Headphoneses()
        {
            ICollection<Item> result = _repositoryGetItem.GetItemByCategory("Headphoneses");

            ViewBag.Content = result;
            return View();
        }

        public IActionResult Details (int? id)
        {
            if (id == null)
                return NotFound();

            var item = _repositoryGetItem.GetItemById(id);

            return View(item);
        }
    }
}