using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doiTuong
{
    public class Items
    {
        int id;
        string name;
        string img;
        public Items()
        {

        }
        public Items(int id, string name, string img)
        {
            this.id = id;
            this.name = name;
            this.img = img;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Img { get => img; set => img = value; }
    }
}
