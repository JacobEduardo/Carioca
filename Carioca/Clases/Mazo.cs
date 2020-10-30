using Carioca.Clases;
using System;
using System.Collections.Generic;

namespace Carioca.Clases
{
    public class Mazo
    {
        public List<Card> Cartas = new List<Card>();
        
        public Mazo()
        {
            Cartas.Add(new Card("1","♥"));
            Cartas.Add(new Card("2", "♥"));
            Cartas.Add(new Card("3", "♥"));
            Cartas.Add(new Card("4", "♥"));
            Cartas.Add(new Card("5", "♥"));
            Cartas.Add(new Card("6", "♥"));
            Cartas.Add(new Card("7", "♥"));
            Cartas.Add(new Card("8", "♥"));
            Cartas.Add(new Card("9", "♥"));
            Cartas.Add(new Card("10", "♥"));
            Cartas.Add(new Card("11", "♥"));
            Cartas.Add(new Card("12", "♥"));
            Cartas.Add(new Card("13", "♥"));

            Cartas.Add(new Card("1","♠"));
            Cartas.Add(new Card("2", "♠"));
            Cartas.Add(new Card("3", "♠"));
            Cartas.Add(new Card("4", "♠"));
            Cartas.Add(new Card("5", "♠"));
            Cartas.Add(new Card("6", "♠"));
            Cartas.Add(new Card("7", "♠"));
            Cartas.Add(new Card("8", "♠"));
            Cartas.Add(new Card("9", "♠"));
            Cartas.Add(new Card("10", "♠"));
            Cartas.Add(new Card("11", "♠"));
            Cartas.Add(new Card("12", "♠"));
            Cartas.Add(new Card("13", "♠"));

            Cartas.Add(new Card("1","♦"));
            Cartas.Add(new Card("2", "♦"));
            Cartas.Add(new Card("3", "♦"));
            Cartas.Add(new Card("4", "♦"));
            Cartas.Add(new Card("5", "♦"));
            Cartas.Add(new Card("6", "♦"));
            Cartas.Add(new Card("7", "♦"));
            Cartas.Add(new Card("8", "♦"));
            Cartas.Add(new Card("9", "♦"));
            Cartas.Add(new Card("10", "♦"));
            Cartas.Add(new Card("11", "♦"));
            Cartas.Add(new Card("12", "♦"));
            Cartas.Add(new Card("13", "♦"));

            Cartas.Add(new Card("1","♣"));
            Cartas.Add(new Card("2", "♣"));
            Cartas.Add(new Card("3", "♣"));
            Cartas.Add(new Card("4", "♣"));
            Cartas.Add(new Card("5", "♣"));
            Cartas.Add(new Card("6", "♣"));
            Cartas.Add(new Card("7", "♣"));
            Cartas.Add(new Card("8", "♣"));
            Cartas.Add(new Card("9", "♣"));
            Cartas.Add(new Card("10", "♣"));
            Cartas.Add(new Card("11", "♣"));
            Cartas.Add(new Card("12", "♣"));
            Cartas.Add(new Card("13", "♣"));

            Cartas.Add(new Card("☺", ""));
            Cartas.Add(new Card("☻", ""));

            Cartas.Add(new Card("1", "♥"));
            Cartas.Add(new Card("2", "♥"));
            Cartas.Add(new Card("3", "♥"));
            Cartas.Add(new Card("4", "♥"));
            Cartas.Add(new Card("5", "♥"));
            Cartas.Add(new Card("6", "♥"));
            Cartas.Add(new Card("7", "♥"));
            Cartas.Add(new Card("8", "♥"));
            Cartas.Add(new Card("9", "♥"));
            Cartas.Add(new Card("10", "♥"));
            Cartas.Add(new Card("11", "♥"));
            Cartas.Add(new Card("12", "♥"));
            Cartas.Add(new Card("13", "♥"));

            Cartas.Add(new Card("1", "♠"));
            Cartas.Add(new Card("2", "♠"));
            Cartas.Add(new Card("3", "♠"));
            Cartas.Add(new Card("4", "♠"));
            Cartas.Add(new Card("5", "♠"));
            Cartas.Add(new Card("6", "♠"));
            Cartas.Add(new Card("7", "♠"));
            Cartas.Add(new Card("8", "♠"));
            Cartas.Add(new Card("9", "♠"));
            Cartas.Add(new Card("10", "♠"));
            Cartas.Add(new Card("11", "♠"));
            Cartas.Add(new Card("12", "♠"));
            Cartas.Add(new Card("13", "♠"));

            Cartas.Add(new Card("1", "♦"));
            Cartas.Add(new Card("2", "♦"));
            Cartas.Add(new Card("3", "♦"));
            Cartas.Add(new Card("4", "♦"));
            Cartas.Add(new Card("5", "♦"));
            Cartas.Add(new Card("6", "♦"));
            Cartas.Add(new Card("7", "♦"));
            Cartas.Add(new Card("8", "♦"));
            Cartas.Add(new Card("9", "♦"));
            Cartas.Add(new Card("10", "♦"));
            Cartas.Add(new Card("11", "♦"));
            Cartas.Add(new Card("12", "♦"));
            Cartas.Add(new Card("13", "♦"));

            Cartas.Add(new Card("1", "♣"));
            Cartas.Add(new Card("2", "♣"));
            Cartas.Add(new Card("3", "♣"));
            Cartas.Add(new Card("4", "♣"));
            Cartas.Add(new Card("5", "♣"));
            Cartas.Add(new Card("6", "♣"));
            Cartas.Add(new Card("7", "♣"));
            Cartas.Add(new Card("8", "♣"));
            Cartas.Add(new Card("9", "♣"));
            Cartas.Add(new Card("10", "♣"));
            Cartas.Add(new Card("11", "♣"));
            Cartas.Add(new Card("12", "♣"));
            Cartas.Add(new Card("13", "♣"));

            Cartas.Add(new Card("☺", ""));
            Cartas.Add(new Card("☻", ""));
        }

        public Card Dar()
        {
            Random rng = new Random();
            int index = rng.Next(Cartas.Count);
            Card carta = Cartas[index];
            Cartas.RemoveAt(index);
            return carta;
        }

        public List<Card> Repartir()
        {
            List<Card> mano = new List<Card>();
            for (int i = 1; i <= 12; i++)
            {
                mano.Add(Dar());
            }
            return mano;
        }

    }
}



