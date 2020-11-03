using Carioca.Clases;
using System;

namespace Carioca
{
    class Program
    {

        static void Main(string[] args)
        {
            Mazo mazo = new Mazo();
            Table table = new Table();

            Jugador jugador1 = new Jugador("Sole");
            jugador1.mano = mazo.Repartir();
            jugador1.ImprimirMano();

            Jugador jugador2 = new Jugador("Jacob");
            jugador2.mano = mazo.Repartir();
            jugador2.ImprimirMano();

            jugador1.Receive(mazo.Dar());
            jugador1.SortCards();
            if (!jugador1.down)
                if (jugador1.CheckTrios(2))
                {
                    table.AddTrio
                }
        }

    }
}

