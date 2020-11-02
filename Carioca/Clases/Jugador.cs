using Carioca.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public void Bajarse(int trios, int scale)
        {
            List<Group> _groups = groups.Where(groups => groups.name.Equals("trio")&&groups.quantity > 2).ToList();
            _groups[0].ImprGroup();
            _groups[1].ImprGroup();
        }
        public Boolean CheckTrios(int trios)
        {
            var contador = 0; 
            for (int i = 0; i < groups.Count; i++)
            {
                if (groups[i].name.Equals("trio"))
                {
                    if (groups[i].quantity > 2)
                    {
                    contador = contador + 1;
                    }
                }
            }
            if (contador >= trios)
            {
                return true;
            }
            return false;
        }
        public void Recibir(Card card)
        {
            mano.Add(card);

        }
        public void BuscarRepetidas()
        {
            Card card;
            for (int k = 1; k <= 13; k++)
            {
                List<Card> cards = new List<Card>();
                for (int i = 0; i < mano.Count; i++)
                {
                    if (mano[i].number.ToString().Equals(k.ToString()))
                    {
                        card = mano[i];
                        cards.Add(card);
                        Console.WriteLine("pase por aca  " + mano[i] + " " + card.ToString());
                    }
                }
                if(cards.Count > 1)
                CrearGroup(cards);
            }
            Agrupar();
        }
        private void CrearGroup(List<Card> cards)
        {
            if (cards.Count > 0)
            {
                groups.Add(new Group("trio", cards));
            }
        }
        public void Agrupar() { 

            for (int i = 0; i < groups.Count; i++)
            {
                for (int k = 0; k < groups[i].cards.Count; k++)
                {
                    Console.Write(groups[i].cards[k].ToString() + " ");
                }
                groups[i].imprQuantity();
                Console.Write(" ");
                groups[i].imprName();
                Console.WriteLine("");
            }
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
        public void RemoveCard(Card card)
        {
            mano.Single;
            while () { 
            for (int i = 0; i < mano.Count; i++)
            {

            }
            }

        }
    }
}


