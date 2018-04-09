using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetAdoption.Web.Daos;
using PetAdoption.Web.Models;

namespace PetAdoption.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            PetDao _petDao = new PetDao();

            List<PetJsonModel> pets = _petDao.GetAll().Take(10).ToList();

            return View(pets);
        }
    }
}