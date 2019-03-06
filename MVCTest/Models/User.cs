using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTest.Models
{
    public class User
    {   
       
        private string id;
        private string pass;
        private bool remember;
        public string Id { get => id; set => id = value; }
        public string Pass { get => pass; set => pass = value; }
        public bool Remember { get => remember; set => remember = value; }
    }
}