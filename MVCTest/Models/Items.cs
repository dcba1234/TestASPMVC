using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Object;
namespace MVCTest.Models
{
    public class Items
    {
        private List<Object.Items> list;

        public List<Object.Items> List { get => list; set => list = value; }
    }
}