using System;
using System.Collections.Generic;
using System.Text;

namespace Carioca.Clases
{
    public class Group
    {
        public string name;
        public int quantity = 0;
        public List<Card> cards = new List<Card>();
        public Group(string name, List<Card> cards)
        {
            this.name = name;
            quantity = cards.Count;
            this.cards = cards;
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
            Console.WriteLine("-------------------------------------");
                for (int k = 0; k < cards.Count; k++)
                {
                    Console.Write(cards[k].ToString() + " ");
                }
                imprQuantity();
                Console.Write(" ");
                imprName();
                Console.WriteLine("");
            Console.WriteLine("-------------------------------------");
        }

    }

   

}
