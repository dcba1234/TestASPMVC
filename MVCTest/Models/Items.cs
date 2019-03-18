using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using doiTuong;
using PagedList.Mvc;
namespace MVCTest.Models
{
    public class Items
    {
        private List<doiTuong.Items> list;

        public List<doiTuong.Items> List { get => list; set => list = value; }
        public List<doiTuong.Items> getList()
        {
            return list;
        }
    }
}