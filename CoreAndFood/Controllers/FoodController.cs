﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndFood.Data.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        Context c = new Context();
        FoodRepository foodRepository = new FoodRepository();
        public IActionResult Index()
        {
            return View(foodRepository.TList("Category"));
        }
        [HttpGet]
        public IActionResult FoodAdd()
        {
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            return View();
        }
        [HttpPost]
        public IActionResult FoodAdd(Food p)
        {
            foodRepository.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteFood(int id)
        {
            foodRepository.TDelete(new Food { FoodID = id });
            return RedirectToAction("Index");
        }
    }
}
