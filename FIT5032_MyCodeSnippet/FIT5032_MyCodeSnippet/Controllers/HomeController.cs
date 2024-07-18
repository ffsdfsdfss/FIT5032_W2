using FIT5032_Week03.HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIT5032_MyCodeSnippet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            // 注释掉原有代码
            // ViewBag.Message = "Your application description page.";

            // 创建Hello对象的实例
            Hello hello = new Hello();

            // 调用GetHello方法，并将结果赋值给ViewBag.Message
            ViewBag.Message = hello.GetHello();

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}