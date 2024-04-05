using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace StajProje.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        BlogManager bm=new BlogManager(new EfBlogRepository());
        Context c= new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1=bm.GetList().Count();
            ViewBag.v2=c.Contacts.Count();
            ViewBag.v3=c.Comments.Count();

            string api = "a09c53da9b733b3eda444b4b577d0347";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v4 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            return View();
        }
    }
}
