using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateJourney
{
    public class Bus
    {
        public const int CAPACITY = 5;
        public int Space { get { return CAPACITY - _passengers.Count; } }

        private LinkedList <Passenger> _passengers=new LinkedList<Passenger>();

        public bool Load(Passenger passenger)
        {
            if (Space < 1)
                return false;

           _passengers.AddLast(passenger);
            Console.WriteLine($"{passenger} got on Bus");
            return true;
        }
        public void ArriveAt(string place)
        {

            Console.WriteLine($"\n Bus Arriving At terminus");

            if (_passengers.Count == 0)
                return;
      
                LinkedListNode<Passenger> currentNode = _passengers.First;
                while (_passengers != null)
                {
                    LinkedListNode<Passenger> nextNode = currentNode.Next;
                    if (currentNode.Value.Destination == place)
                    {
                        Console.WriteLine($"{currentNode.Value.Name} is getting off at {place}");
                        _passengers.Remove(currentNode);

                    }
                    currentNode = nextNode;
                }
                Console.WriteLine($"There are {_passengers.Count} persons are left in bus"); 
        }

    }
}
