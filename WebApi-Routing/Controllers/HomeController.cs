using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_Routing.Controllers
{

    [ApiController]

    // v1
    [Route("wissen")]

    //v2
    //[Route("besiktas/bahcesehir/wissen")]

    //v3
    // köşeli parantez içerisindeki controller, o an çalıştırılan kontrollerin adını verecektir.
    //[Route("api/[controller]")]

    public class HomeController : ControllerBase
    {
        //[HttpGet]
        // Ortamda sadexe tek bir get varsa, bu apiyi çalıştırırken, metot adı vermenize gerek kalmaz.
        // Bu sadece get için değil, diğer tüm action'lar için geçerlidir. Post-Put-Delete-Get
        //public IActionResult SiparisGetir()
        //{
        //    return Ok("Sipariş geldi");
        //}


        // Bu metodun route attribute ile 
        //[Route("api/getir")]
        //public IActionResult SiparisGetir()
        //{
        //    return Ok("Sipariş geldi");
        //}
        //[HttpGet]
        //Routing'de, tilda kullanıyorsanız, Controllerden gelen routing özelliğini almayacaktır. ©®§
        //[Route("~/api/urun/getir")]
        //public IActionResult UrunleriGetir()
        //{
        //    return Ok();
        //}

        // Parametreye göre routing verme(uygulama çalıştırıldığında, parametre routing olarak görünecektir.)

        //[HttpGet]
        //[Route("{wissen}")]
        //public IActionResult ParametreyeGoreIsim(string wissen)
        //{
        //    return Ok();
        //}

        // Parametreye göre kilit koyma için kullanılır.
        // Göndeirlecek parametreyi routing ??


      
        // 1. parametre vermezsen, Wissen Beşiktaş parametre olacaktır.
        //[HttpGet]
        //[Route("veri/sayfa/{wissen=Wissen Besiktas}")]
        //public IActionResult ParametreVerisineGoreIsim(string wissen)
        //{

        //    return Ok();
        //}


        [HttpGet]
        [Route("{peugeot?}")]
        public IActionResult NullOlabilir(string peugeot=null)
        {
            return Ok();
        }

        //Int tipinde deger parametresi alacağını routing olarak belirlemek 
        //[HttpGet]
        //[Route("data/{deger:int}")]
        //public IActionResult IntParametre(int deger)
        //{
        //    return Ok();
        //}

        // Girilen id parametresi 5'in altında bir değer olamaz
        //[HttpGet]
        //[Route("{id:int:min(5)}")]
        //public IActionResult MinParametre(int id)
        //{
        //    return Ok();
        //}

        // Girilen parametre minimum 5 maximum 15 olmalıdır.
        //[HttpGet]
        //[Route("{veri:int:min(5):max(15)}")]
        //public IActionResult MinMaxParametre(int veri)
        //{
        //    return Ok();
        //}

        //[HttpGet]
        //[Route("{data:int:range(1,3)}")]
        //public IActionResult Range(int data)
        //{
        //    return Ok();
        //}


    }
}
