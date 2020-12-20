using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Сайт.Data.Models;

namespace Сайт.Data.interfaces
{
   public interface ICosmetics
    {
        IEnumerable<Cosmetics> cosmetics { get; }
        IEnumerable<Cosmetics> gerFavCosmetics { get; set; }
        Cosmetics getObgectCosmetics(int cosmeticID);
    }
}
