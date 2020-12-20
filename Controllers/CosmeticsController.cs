using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Сайт.Data.interfaces;
using Сайт.ViewModels;

namespace Сайт.Controllers
{
    public class CosmeticsController: Controller
    {
        private readonly ICosmetics _allCosmetics;
        private readonly ICosmeticsSections _allSection;

        public CosmeticsController (ICosmetics icosmetics, ICosmeticsSections isection)
        {
            _allCosmetics = icosmetics;
            _allSection = isection;
        }

        public ViewResult List()
        {
            CosmeticsListViewModel obj = new CosmeticsListViewModel();
            obj.allCosmetics = _allCosmetics.cosmetics;
            obj.cosmSection = "Косметика";
            return View(obj);
        }
    }
}
