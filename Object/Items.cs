using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class Items
    {
        string id;
        string name;
        string img;
        public Items()
        {

        }
        public Items(string id, string name, string img)
        {
            this.id = id;
            this.name = name;
            this.img = img;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Img { get => img; set => img = value; }
    }
}
