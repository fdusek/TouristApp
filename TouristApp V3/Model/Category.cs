using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristApp_V3.Model
{
    class Category
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Category(String name, int ID)
        {
            _name = name;
            _id = ID;
        }
        public Category()
        {
        }

    }
}
