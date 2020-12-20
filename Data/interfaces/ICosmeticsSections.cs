using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Сайт.Data.Models;

namespace Сайт.Data.interfaces
{
   public interface ICosmeticsSections
    {
        IEnumerable <Sections> AllSections { get; }
    }
}
