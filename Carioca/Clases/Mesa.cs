using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carioca.Clases
{
    class Mesa
    {
        public List<Card> comida = new List<Card>();
        public List<Card> basura = new List<Card>();

        public Mesa(Card basura, List<Card> comida)
        {
            this.basura.Add(basura);
            this.comida = comida;
        }

        public void ImprimirComida ()
        {
            for (int i = 0; i < comida.Count; i++)
            {
                Console.Write(comida[i].ToString() + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public void ImprimirBasura()
        {
            Console.WriteLine(basura.Last().ToString());
        }
    }
}
