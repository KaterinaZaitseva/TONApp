using Microsoft.AspNetCore.Mvc;
using TONWebApp.Models;

namespace TONWebApp.Controllers;

public class HomeController : Controller {

    public IEnumerable<Card> products = new List<Card>() {
        new Card(){
            Title = "Погружные (скважинные) насосы типа ЭЦВ",
            Description = "Тоже что то написать",
            ColorClass="bg-purple-box"
        },

        new Card(){
            Title = "Аккумуляторные батареи",
            Description = "В онисании перечислить какие",
            ColorClass="bg-blue-box"
        },
    
        new Card(){
            Title = "Эмаль ПФ-115",
            Description = "Указать цвета",
            ColorClass="bg-green-box"
        },
   
        new Card(){
            Title = "Токарные резцы",
            Description = "Тоже что то написать",
            ColorClass="bg-yellow-box"
        },

        new Card(){
            Title = "Отрезные, шлифовальные круги",
            Description = "Тоже что то написать",
            ColorClass="bg-purple-box"
        },

        new Card(){
            Title = "Сварочные электроды",
            Description = "Тоже что то написать",
            ColorClass="bg-blue-box"
        },

         new Card(){
            Title = "Резиновые рукова",
            Description = "Напорные, напорно-всасывающие",
            ColorClass="bg-green-box"
        },

         new Card(){
            Title = "Товары для сварки",
            Description = "Резаки, горелки, редуктора",
            ColorClass="bg-yellow-box"
        },
    };

    public IEnumerable<Card> services = new List<Card>() {
        new Card(){
            Title = "Диагностика и ремонт ТНВД",
            Description = "ЯМЗ, УТН, НД, ЛСТН, МОТОРПАЛ",
            ColorClass="bg-purple-box"
        },

        new Card(){
            Title = "Диагностика и ремонт форсунок",
            Description = "171, 175",
            ColorClass="bg-blue-box"
        },

        new Card(){
            Title = "Обменный фонд",
            Description = "Описание",
            ColorClass="bg-green-box"
        },
    };

    public IActionResult Index() => View();
    public IActionResult Contact() => View();
    public IActionResult Products() => View(products); 
    public IActionResult Services() => View(services);
}
