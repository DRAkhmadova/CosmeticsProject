using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Сайт.Data.interfaces;
using Сайт.Data.Models;

namespace Сайт.Data.Mocks
{
    public class MockSections : ICosmeticsSections
    {
        public IEnumerable<Sections> AllSections
        {
            get
            {
                return new List<Sections>
                {
                    new Sections { sectionsName = "Праймеры", sectionsInformation= "База под макияж"},
                    new Sections { sectionsName = "Тональные средства",     sectionsInformation= "Тональные средства"},
                    new Sections { sectionsName = "Кушоны", sectionsInformation= "Тональные средства"},
                    new Sections { sectionsName = "Румяна", sectionsInformation= "декоративная косметика"},
                    new Sections { sectionsName = "Хайлайтеры", sectionsInformation= "декоративная косметика"},
                    new Sections { sectionsName = "Карандаши для бровей", sectionsInformation= "пигмент для коррекции бровей"},
                    new Sections { sectionsName = "Тени для глаз", sectionsInformation= "декоративная косметика"},
                    new Sections { sectionsName = "Помады", sectionsInformation= "средства для губ"}
                };
            }
        }
    }
}
