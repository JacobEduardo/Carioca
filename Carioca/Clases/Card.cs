namespace Carioca.Clases
{
    public class Card
    {
        readonly public string number;
        string pinta;
        public Card(string number, string pinta)
        {
            this.number = number;
            this.pinta = pinta;
        }

        public override string ToString()
        {
            if (number == "11")
            {
                return "|" + "J" + pinta + "|";
            }
            if (number == "12")
            {
                return "|" + "Q" + pinta + "|";
            }
            if (number == "13")
            {
                return "|" + "K" + pinta + "|";
            }
            else
            {
                string str = "|" + number + pinta + "|";
                return str;
            }
        }
    }
}
