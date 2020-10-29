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
        public List<Group> groups;

        public Jugador(string name)
        {
            mano = new List<Card>();
            this.name = name;
        }
        public void Jugar2Trios()
        {
            
        }
        public void OrdenarCartas()
        {
            
            for (int i = 0; i < 13; i++)
            {
                Card card;
                List<Card> cards = new List<Card>();
                if ( mano[i].name.ToString().Equals(i.ToString())){
                    card = mano[i];
                    cards.Add(card);
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


