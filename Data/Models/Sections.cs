using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Сайт.Data.Models
{
    public class Sections
    {
        public int id { set; get; }

        public string sectionsName { set; get; }

        public string sectionsInformation { set; get; }

        public List<Cosmetics> cosmetics { set; get; }
    }
}
