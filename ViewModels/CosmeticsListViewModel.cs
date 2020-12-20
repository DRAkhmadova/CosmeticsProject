using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Сайт.Data.Models;

namespace Сайт.ViewModels
{
    public class CosmeticsListViewModel
    {
        public IEnumerable<Cosmetics> allCosmetics { get; set; }

        public string cosmSection { get; set; }
    }
}
