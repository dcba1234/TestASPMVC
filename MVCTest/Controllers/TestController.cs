using MVCTest.Code;
using MVCTest.Models;
using System.Web.Mvc;
using DAL;
using doiTuong;
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
            ViewBag.test = "Không có sesstion ";

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
        public ActionResult home(int? page,string testSelect)
        {
            getViewBag();
            Models.Items l = new Models.Items();
            l.List = Login.getData();
            ViewBag.home = "đây là trang home" + testSelect;
            if (page == null) page = 1;
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            //IEnumerable<Object.Items> list = l.OrderBy();

            doiTuong.Items[] pets = l.List.ToArray();

            IEnumerable<doiTuong.Items> query = pets.OrderByDescending(pet => pet.Id);
            Home h = new Home();
            h.List = query.ToPagedList(pageNumber, pageSize);
            
            return View(h);
        }
        [HttpPost]
        public ActionResult home(doiTuong.Items item, string testSelect)
        {
            getViewBag();
            
            Login.insert(item.Name.ToString(), item.Img);
            ViewBag.home = testSelect;
            Models.Items l = new Models.Items();
            l.List = Login.getData();
            doiTuong.Items[] pets = l.List.ToArray();

            IEnumerable<doiTuong.Items> query = pets.OrderBy(pet => pet.Id);

            Home h = new Home();
            h.List = query.ToPagedList(1, 5);
            return View(h);
        }

        public void getViewBag()
        {
            ViewBag.list = DAL.Login.getData();
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