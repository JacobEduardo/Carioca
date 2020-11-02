using Carioca.Clases;
using System;

namespace Carioca
{
    class Program
    {

        static void Main(string[] args)
        {
            Mazo mazo = new Mazo();

            Jugador jugador1 = new Jugador("Sole");
            jugador1.mano = mazo.Repartir();
            jugador1.ImprimirMano();

            Jugador jugador2 = new Jugador("Jacob");
            jugador2.mano = mazo.Repartir();
            jugador2.ImprimirMano();

            jugador1.mano.Add(mazo.Dar());
            jugador1.Jugar2Trios();


        }

    }
}

