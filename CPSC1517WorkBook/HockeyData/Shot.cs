using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyData
{
    internal class Shot
    {
        // data fields
        private string _name;

        // properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // constructors
        public Shot(string name)
        {
            _name = name;
        }
    }
}
