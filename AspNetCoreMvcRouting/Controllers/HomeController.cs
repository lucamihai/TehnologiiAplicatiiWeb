using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcRouting.Controllers
{
    public class HomeController : Controller
    {
        //public ViewResult Index() => View("Result", new Result { Controller = nameof(HomeController), Action = nameof(Index) });

        //public ViewResult CustomVariable(string id)
        //{
        //    Result r = new Result
        //    {
        //        Controller = nameof(HomeController),
        //        Action = nameof(CustomVariable),
        //    };

        //    r.Data["Id"] = id ?? "<no value>";
        //    r.Data["Url"] = Url.Action("CustomVariable", "Home", new { id = 100 });

        //    return View("Result", r);
        //}

        public ViewResult Index() => View("SimpleForm");

        //public void ReceiveForm(string name, string city)
        //{
        //    byte[] content = Encoding.ASCII.GetBytes($"<html><body>{name} lives in {city}</body>");

        //    Response.StatusCode = 200;
        //    Response.ContentType = "text/html";
        //    Response.Body.WriteAsync(content, 0, content.Length);
        //}

        //public IActionResult ReceiveForm(string name, string city) => new CustomHtmlResult { Content = $"{name} lives in {city}" };

        [HttpPost]
        public RedirectToActionResult ReceiveForm(string name, string city)
        {
            TempData["name"] = name; TempData["city"] = city; 

            return RedirectToAction(nameof(Data));
        }

        public ViewResult Data()
        {
            string name = TempData["name"] as string;
            string city = TempData["city"] as string;
            
            return View("Result", $"{name} lives in {city}");
        }
    }
}
