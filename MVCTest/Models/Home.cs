using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList.Mvc;
using PagedList;
using doiTuong;

namespace MVCTest.Models
{
    public class Home
    {
        PagedList.IPagedList<doiTuong.Items> list;
        doiTuong.Items item;
        public IPagedList<doiTuong.Items> List { get => list; set => list = value; }
        public doiTuong.Items Item { get => item; set => item = value; }
    }
}