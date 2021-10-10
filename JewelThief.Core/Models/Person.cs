using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelThief.Core.Models
{
    public abstract class Person
    {
        public Person(int placeInQueue)
        {
            PlaceInQueue = placeInQueue;
        }

        public int PlaceInQueue { get; protected set; }
    }
}
