using MVCTest.Code;
using MVCTest.Models;
using System.Web.Mvc;
using DAL;
using Object;
using PagedList.Mvc;
using System.Collections.Generic;
using System.Linq;
using PagedList;

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
        public ActionResult home(int? page)
        {
            Models.Items l = new Models.Items();
            l.List = Login.getData();
            ViewBag.home = "đây là trang home";
            if (page == null) page = 1;
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            //IEnumerable<Object.Items> list = l.OrderBy();

            Object.Items[] pets = l.List.ToArray();

            IEnumerable<Object.Items> query = pets.OrderBy(pet => pet.Name);

            return View(query.ToPagedList(pageNumber,pageSize));
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