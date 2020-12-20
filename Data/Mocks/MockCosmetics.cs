using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Сайт.Data.interfaces;
using Сайт.Data.Models;

namespace Сайт.Data.Mocks
{
    public class MockCosmetics : ICosmetics
    {

        private readonly ICosmeticsSections _sectionsCosmetics = new MockSections();

        public IEnumerable<Cosmetics> cosmetics
        {
            get
            {
                return new List<Cosmetics>
                {
                    new Cosmetics{ name="Art-Visage primer",Information="База для лица", img="https://sun9-27.userapi.com/impg/JLhvekkhKVp3v7dRG0V-IYSb7_Vj2XNGzcte7Q/Fb7PFMrecE4.jpg?size=828x673&quality=96&proxy=1&sign=d542963c5fca219624d36123758fab1c&type=album", 
                        price=380  , Favourite=false , available=true,Sections =_sectionsCosmetics.AllSections.First() },
                    new Cosmetics{ name="Catrice primer",Information="Матирующая база для лица", img="2.jpg", price=500 , Favourite=true , available=true,Sections =_sectionsCosmetics.AllSections.First() },
                    new Cosmetics{ name="CLARINS",Information="База для лица", img="3.jpg", price=2000 , Favourite=true , available=false,Sections =_sectionsCosmetics.AllSections.First() },
                    new Cosmetics{ name="Estee Lauder ton",Information="Плотное тональное средство", img="4.jpg", price=3700 , Favourite=true , available=true,Sections =_sectionsCosmetics.AllSections.ElementAtOrDefault(1)},
                    new Cosmetics{ name="Catrice ton",Information="Матирующий тональный крем", img="5.jpg", price=595 , Favourite=false , available=false,Sections =_sectionsCosmetics.AllSections.ElementAtOrDefault(1) },
                    new Cosmetics{ name="CLINIQUE",Information="Лёгкое тональное средство", img="6.jpg", price=1500 , Favourite=false , available=true,Sections =_sectionsCosmetics.AllSections.ElementAtOrDefault(1) },
                    new Cosmetics{ name="GROUND PLAN",Information="Тональное покрытие в кушоне", img="7.jpg", price=999 , Favourite=true , available=true,Sections =_sectionsCosmetics.AllSections.ElementAtOrDefault(2)},
                    new Cosmetics{ name="MISSHA",Information="корейское тональное срество в кушоне", img="8.jpg", price=2781 , Favourite=true , available=true,Sections =_sectionsCosmetics.AllSections.ElementAtOrDefault(2) },
                    new Cosmetics{ name="WET N WILD",Information="Лёгкий тональный крем в кушоне", img="9.jpg", price=376 , Favourite=true , available=true ,Sections =_sectionsCosmetics.AllSections.ElementAtOrDefault(2)},
                    new Cosmetics{ name="Catrice",Information="Сияющие румяна", img="10.jpg", price=361 , Favourite=false , available=true,Sections =_sectionsCosmetics.AllSections.ElementAtOrDefault(3) },
                    new Cosmetics{ name="SISLEY",Information="Матовые румяна", img="11.jpg", price=6705 , Favourite=true , available=false ,Sections =_sectionsCosmetics.AllSections.ElementAtOrDefault(3)},
                    new Cosmetics{ name="Viviene Sabo",Information="Запечёные румяна", img="12.jpg", price=297 , Favourite=true , available=true,Sections =_sectionsCosmetics.AllSections.ElementAtOrDefault(3) },
                    new Cosmetics{ name="SEVEN7EEN",Information="Хайлайтер для лица", img="13.jpg", price=443 , Favourite=true , available=false,Sections =_sectionsCosmetics.AllSections.ElementAtOrDefault(4)},
                    new Cosmetics{ name="MAKEUP Revolution",Information="Палетка хайлайтеров для лица", img="14.jpg", price=459 , Favourite=true , available=true,Sections =_sectionsCosmetics.AllSections.ElementAtOrDefault(4) },
                    new Cosmetics{ name="MILANI", Information="Хайлайтер для лица",img="15.jpg", price=1209 , Favourite=false , available=false,Sections =_sectionsCosmetics.AllSections.ElementAtOrDefault(4) },
                    new Cosmetics{ name="BOBBI BROWN",Information="Скошенный карандаш для бровей", img="16.jpg", price=2790 , Favourite=false , available=true,Sections =_sectionsCosmetics.AllSections.ElementAtOrDefault(5) },
                    new Cosmetics{ name="NYX brown",Information="Тонкий карандаш для бровей", img="17.jpg", price=782 , Favourite=true , available=false,Sections =_sectionsCosmetics.AllSections.ElementAtOrDefault(5) },
                    new Cosmetics{ name="ESTRADE",Information="Средство для бровей", img="18.jpg", price=278 , Favourite=false , available=true,Sections =_sectionsCosmetics.AllSections.ElementAtOrDefault(5) },
                    new Cosmetics{ name="LIME CRIME",Information="Универсальная палетка теней", img="19.jpg", price=5880 , Favourite=true , available=true,Sections =_sectionsCosmetics.AllSections.ElementAtOrDefault(6)},
                    new Cosmetics{ name="NYX teni",Information="Яркая палетка теней ", img="20.jpg", price=1492 , Favourite=true , available=true,Sections =_sectionsCosmetics.AllSections.ElementAtOrDefault(6)},
                    new Cosmetics{ name="ESSENCE",Information="Нюдовая палетка теней", img="21.jpg", price=619 , Favourite=true , available=true,Sections =_sectionsCosmetics.AllSections.ElementAtOrDefault(6) },
                    new Cosmetics{ name="NYX lips",Information=" Матовая Кушон-помада для губ ", img="22.jpg", price=702, Favourite=true , available=true ,Sections =_sectionsCosmetics.AllSections.Last()},
                    new Cosmetics{ name="KISS",Information="Глянцевая помада для губ", img="23.jpg", price=329 , Favourite=false , available=false,Sections =_sectionsCosmetics.AllSections.Last()},
                    new Cosmetics{ name="L'OREAL Paris",Information="Матовая помада для губ", img="24.jpg", price=596 , Favourite=false , available=true,Sections =_sectionsCosmetics.AllSections.Last()},

                };
            }
        }
        public IEnumerable<Cosmetics> gerFavCosmetics { get; set; }

        public Cosmetics getObgectCosmetics(int cosmeticID)
        {
            throw new NotImplementedException();
        }
    }
}
    
