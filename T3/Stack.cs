using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Stack
    {
        public List<Card> cards { get; }
         public Stack()
        {
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public void PrintCollection()
        {
            Console.WriteLine("Cards in the collection: ");
            foreach (Card card in cards)
            {
                Console.WriteLine(card.ToString());
            }
        }
    }
}
