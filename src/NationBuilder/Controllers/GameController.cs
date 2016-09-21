using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NationBuilder.Models;
using Microsoft.AspNetCore.Identity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NationBuilder.Controllers
{
    public class GameController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public GameController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var list = _db.Nations.ToList();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(nation newNation)
        {
            newNation.population = 10000000;
            newNation.capital = 50;
            newNation.resources = 50;
            newNation.stability = 50;
            if (newNation.government == "Democracy")
            {
                newNation.stability -= 25;
                newNation.resources += 10;
                newNation.capital += 10;
            } else if (newNation.government == "Theology")
            {
                newNation.stability += 15;
                newNation.capital -= 10;
            } else if (newNation.government == "Junta")
            {
                newNation.stability += 30;
                newNation.resources -= 15;
                newNation.capital -= 15;
            }
            if (newNation.economy == "Banking")
            {
                newNation.resources -= 10;
                newNation.capital += 25;
            }
            else if (newNation.economy == "Exports")
            {
                newNation.resources += 25;
            }
            else if (newNation.economy == "Viking")
            {
                newNation.stability += 5;
                newNation.capital -= 10;
            }
            else if (newNation.economy == "Tourism")
            {
                newNation.capital += 15;
                newNation.resources -= 10;
            } else
            {
                newNation.capital -= 25;
                newNation.resources += 5;
            }
            if (newNation.geography == "deserts")
            {
                newNation.capital -= 5;
                newNation.resources += 10;
            }
            else if (newNation.geography == "caves")
            {
                newNation.capital -= 5;
                newNation.resources -= 5;
            }
            _db.Nations.Add(newNation);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }

        public IActionResult Details(int Id)
        {
            nation ntn = _db.Nations.FirstOrDefault(i => i.Id == Id);
            return View(ntn);
        }
        public IActionResult DisplayEvent()
        {
            Event newEvent = _db.Events.FirstOrDefault(i => i.Id == 2);
            return Json(newEvent);
        }

        [HttpPost]
        public IActionResult ProcessEvent(int Id, int popChange, int capChange, int stabChange, int resChange)
        {
            nation currentNation = _db.Nations.FirstOrDefault(i => i.Id == Id);
            currentNation.population += popChange;
            currentNation.capital += capChange;
            currentNation.resources += resChange;
            currentNation.stability += stabChange;
            _db.SaveChanges();
            return RedirectToAction("Details", Id);
        }


    }
}
