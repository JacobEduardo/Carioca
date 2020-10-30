using Carioca.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Carioca.Clases
{
    class Jugador
    {
        readonly string name;
        public List<Card> mano;
        public List<Group> groups = new List<Group>();

        public Jugador(string name)
        {
            mano = new List<Card>();
            this.name = name;
        }
        public void Jugar2Trios()
        {
            OrdenarCartas();
        }
        public void OrdenarCartas()
        {
            Card card;
            for (int i = 0; i < mano.Count; i++)
            {
                List<Card> cards = new List<Card>();

                for (int k = 1; k <= 13; k++)
                {
                    if (mano[i].number.ToString().Equals(k.ToString()))
                    {
                        card = mano[i];
                        cards.Add(card);
                        Console.WriteLine("pase por aca  " + mano[i] + " " + card.ToString() );
                    }
                }
                if (cards.Count > 0) {
                    groups.Add(new Group("trio", 1, cards));
                }
            }

            for (int i = 0; i < groups.Count; i++)
            {
                Console.WriteLine("1236666");
                for (int k = 0; k < groups[i].group.Count; k++)
                {
                    groups[i].group[k].ToString();
                    Console.WriteLine("123");
                }
            }
        }

        public void Bajarse()
        {

        }
        public void Botar()
        {

        }
        public void Elejir()
        {

        }

        public void ImprimirMano()
        {
            Console.WriteLine(name);
            for (int i = 0; i < mano.Count; i++)
            {
                Console.Write(mano[i].ToString() + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}


