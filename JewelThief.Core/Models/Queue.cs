using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelThief.Core.Models
{
    public class Queue
    {
        public Queue()
        {
            Thieves = new List<Thief>();
            Police = new List<Police>();
        }

        public Queue(List<Thief> thieves, List<Police> police)
        {
            Thieves = thieves;
            Police = police;
        }

        public List<Thief> Thieves { get; private set; }
        public List<Police> Police { get; private set; }

        public bool IsEmpty()
        {
            return Thieves.Count == 0 && Police.Count == 0;
        }
    }
}
