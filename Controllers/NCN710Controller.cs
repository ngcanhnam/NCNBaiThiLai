

using Microsoft.AspNetCore.Mvc;


namespace NCNBaiThiLai.Controllers{
    public class NCN710Controller : Controller{

        public IActionResult Index(){
            return View();
        }

        [HttpPost]
        public IActionResult Index(string x){
            x = "xin chao";
            int  age =21;
            string Name ="CN";
            
            ViewData["x"] = x + Name + " "+ age;
            return View();
        }
    }
}