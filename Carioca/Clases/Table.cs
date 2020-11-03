using System;
using System.Collections.Generic;
using System.Text;

namespace Carioca.Clases
{
    public class Table
    {
        List<Trio> trios;
        List<Scale> scales;

        public Table()
        {
            trios = new List<Trio>();
            scales = new List<Scale>();
        }

        public void AddTrio(Card one, Card two,Card three)
        {
            Trio trio = new Trio(one, two, three);
            trios.Add(trio);
        }
        public void AddScale(Card one,Card two, Card Three,Card four)
        {
            Scale scale = new Scale(one, two, Three, four);
            scales.Add(scale);
        }

        public void ImprTable()
        {
            trios.ForEach(t => t.ImprTrio());
        }
    }
    class Trio
    {
        List<Card> trio;

        public Trio(Card one, Card two, Card three)
        {
            trio = new List<Card>();
            trio.Add(one);
            trio.Add(two);
            trio.Add(three);
        }

        public void AddLetter(Card letter)
        {
            trio.Add(letter);
        }

        public void ImprTrio()
        {
            trio.ForEach(trio => trio.ToString());
        }
    }

    class Scale
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
