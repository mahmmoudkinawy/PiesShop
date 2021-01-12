using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository pieReporitory;
        private readonly ICategoryRepository categoryRepository;

        public PieController(IPieRepository pieReporitory, ICategoryRepository categoryRepository )
        {
            this.pieReporitory = pieReporitory;
            this.categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = pieReporitory.AllPies;

            piesListViewModel.CurrentCategory = "Cheese cakes";
            return View(piesListViewModel);
        }

        public IActionResult Details(int id)
        {
            var pie = pieReporitory.GetPieById(id);
            if (pie == null)
                return NotFound();
            return View(pie);
        }

    }
}
