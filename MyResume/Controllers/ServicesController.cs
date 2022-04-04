using Microsoft.AspNetCore.Mvc;
using MyResume.Domain;
using System;

namespace MyResume.Controllers
{
    public class ServicesController : Controller
    {
        private readonly DataManager dataManager;

        public ServicesController(DataManager _dataManager)
        {
            dataManager = _dataManager;
        }
        public IActionResult Index(Guid id)
        {
            if(id !=default)
            {
                return View("Show", dataManager.ServiceItems.GetServiceItemById(id));
            }
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageServices");
            return View(dataManager.ServiceItems.GetServiceItems());
        }
    }
}
