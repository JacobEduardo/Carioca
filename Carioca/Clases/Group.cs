using System;
using System.Collections.Generic;
using System.Text;

namespace Carioca.Clases
{
    public class Group
    {
        public string name;
        public int quantity = 0;
        public List<Card> group = new List<Card>();

        public Group(string name, List<Card> group)
        {
            this.name = name;
            this.group = group;
        }

        public void AumentarQuantity()
        {
            this.quantity = quantity + 1;
        }
        public void imprQuantity()
        {
            Console.Write(quantity.ToString() );
        }
        public void imprName()
        {
            Console.Write(name);
        }

        public void ImprGroup()
        {
            for (int i = 0; i < group.Count; i++)
            {
                for (int k = 0; k < group.Count; k++)
                {
                    Console.Write(group[k].ToString() + " ");
                    AumentarQuantity();
                }
                imprQuantity();
                Console.Write(" ");
                imprName();
                Console.WriteLine("");
            }
        }

    }

   

}
