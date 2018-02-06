using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    abstract class Player
    {
        private string name;
        private int rashvalue;

        public abstract int GenerateRashambo();

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public int RashValue
        {
            set { rashvalue = value; }
            get { return rashvalue; }
        }

        public Player(string _name, int r)
        {
            this.name = _name;
            this.rashvalue = r;
        }

        public Player(int r)
        {
            this.rashvalue = r;
        }

        public Player()
        {
            this.name = "";
            this.rashvalue = 0;
        }
    }
}
