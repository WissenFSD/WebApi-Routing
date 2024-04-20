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
        [HttpGet]
        // Ortamda sadexe tek bir get varsa, bu apiyi çalıştırırken, metot adı vermenize gerek kalmaz.
        // Bu sadece get için değil, diğer tüm action'lar için geçerlidir. Post-Put-Delete-Get
        //public IActionResult SiparisGetir()
        //{
        //    return Ok("Sipariş geldi");
        //}


        // Bu metodun route attribute ile 
        [Route("api/getir")]
        public IActionResult SiparisGetir()
        {
            return Ok("Sipariş geldi");
        }
        [HttpGet]

        //Routing'de, tilda kullanıyorsanız, Controllerden gelen routing özelliğini almayacaktır. ©®§
        [Route("~/api/urun/getir")]
        public IActionResult UrunleriGetir()
        {
            return Ok();
        }

        // Parametreye göre routing verme(uygulama çalıştırıldığında, parametre routing olarak görünecektir.)

        [HttpGet]
        [Route("{wissen}")]
        public IActionResult ParametreyeGoreIsim(string wissen)
        {
            return Ok();
        }

        // Parametreye göre kilit koyma için kullanılır.
        // Göndeirlecek parametreyi routing ??

        //?
        // 1 : parametre bu olmalıdır.
        // 2. parametre vermezsen, Wissen Beşiktaş parametre olacaktır.
        [HttpGet]
        [Route("veri/sayfa/{wissen=Wissen Beşiktaş}")]
        public IActionResult ParametreVerisineGoreIsim(string wissen)
        {

            return Ok();
        }

        //?
        [HttpGet]
        [Route("{veri?}")]
        public IActionResult NullOlabilir(string veri)
        {
            return Ok();
        }

        //Int tipinde deger parametresi alacağını routing olarak belirlemek 
        [HttpGet]
        [Route("data/{deger:int}")]
        public IActionResult IntParametre(int deger)
        {
            return Ok();
        }


    }
}
