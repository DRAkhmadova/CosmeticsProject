using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Сайт.Data.Models
{
    public class Cosmetics
    {
        public int id { set; get; }
        public string name { set; get; }
        public string Information { set; get; } // краткое описание
        public string img { set; get; } 
        public ushort price { set; get; } // цена
        public bool Favourite { set; get; } 
        public bool available { set; get; } //информация о наличии
        public int SectionsID { set; get; }
        public virtual Sections Sections { set; get; }



    }
}
