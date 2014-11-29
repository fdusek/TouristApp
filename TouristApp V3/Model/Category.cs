using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristApp_V3.Model
{
    class Category
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Category(String name)
        {
            _name = name;
        }
        public Category()
        {
        }

    }
}
