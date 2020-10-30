using System;
using System.Collections.Generic;
using System.Text;

namespace Carioca.Clases
{
    public class Group
    {
        string name;
        int quantity = 0;
        public List<Card> group = new List<Card>();

        public Group(string name, int quantity, List<Card> group)
        {
            this.name = name;
            this.quantity = quantity;
            this.group = group;
        }

        public void AumentarQuantity()
        {
            this.quantity = quantity + 1;
        }
    }

    public class Trio
    {
        List<Card> trio;

        public Trio(Card one, Card two, Card three)
        {
            trio.Add(one);
            trio.Add(two);
            trio.Add(three);
        }

        public void AddLetter(Card letter)
        {
            trio.Add(letter);
        }

    }

    public class Scale
    {
        List<Card> scale;

        public Scale(Card one, Card two, Card three, Card four)
        {
            scale.Add(one);
            scale.Add(two);
            scale.Add(three);
            scale.Add(four);
        }

        public void AddCarta(Card card)
        {
            scale.Add(card);
        }

    }

}
