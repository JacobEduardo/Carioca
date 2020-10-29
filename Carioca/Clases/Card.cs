using System;
using System.Collections.Generic;
using System.Text;

namespace Carioca.Clases
{
    public class Card
    {
        public string name;
        string pinta;
        public Card(string name, string pinta)
        {
            this.name = name;
            this.pinta = pinta;
        }

        public override string ToString()
        {
            if (name=="11"){
                return "|" + "J" + pinta + "|";
            }
            if (name == "12")
            {
                return "|" + "Q" + pinta + "|";
            }
            if (name == "13")
            {
                return "|" + "K" + pinta + "|";
            }
            else
            {
                string str = "|" + name + pinta + "|";
                return str;
            }
        }
    }
}
