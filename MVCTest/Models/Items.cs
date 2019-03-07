using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Object;
using PagedList.Mvc;
namespace MVCTest.Models
{
    public class Items
    {
        private List<Object.Items> list;

        public List<Object.Items> List { get => list; set => list = value; }
        public List<Object.Items> getList()
        {
            return list;
        }
    }
}