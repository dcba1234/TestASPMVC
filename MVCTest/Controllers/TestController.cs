using MVCTest.Code;
using MVCTest.Models;
using System.Web.Mvc;
using DAL;
using Object;
namespace MVCTest.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        static int i = 0;
       

        public ActionResult Index()
        {


            if (Session["login"] == null)
            {
                ViewBag.test = "Không có sesstion ";
            }
            else
            {
                ViewBag.test = "dsdsdsdsdsdsdasaaaaaaaaaaa";
                return RedirectToAction("home", "Test");
            }


            return View();
        }
        public ActionResult home()
        {

            ViewBag.home = "đây là trang home";

            Models.Items l = new Models.Items();
            l.List = Login.getData();

            return View(l);
        }
        public Message GetMessage()
        {
            Message m = new Message();
            m.tt = "Đây là từ model";
            return m;
        }
        // RedirectToAction("Index","Home");
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(User l)
        {
            int kq = new DAL.Login().login(l.Id, l.Pass);

            if (kq == 0 )
            {
                ModelState.AddModelError("", "Đăng nhập không thành công");
            }
            else
            {
                //UserSesstion s = new UserSesstion
                //{
                //    Username = l.Id
                //};
                // getSesstion.SetSesstion(s);
                Session["login"] = l.Id;
                return RedirectToAction("home", "Test");
            }
            return View(l);
        }

    }
}