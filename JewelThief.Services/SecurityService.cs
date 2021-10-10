using JewelThief.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace JewelThief.Services
{
    public class SecurityService
    {
        private Queue _queue;
        public SecurityService(Queue queue)
        {
            _queue = queue;
        }

        public int CatchThieves()
        {
            if (_queue == null)
            {
                return 0;
            }

            if (_queue.IsEmpty() || _queue.Thieves.Count == 0)
            {
                return 0;
            }

            HashSet<Thief> thievesCaught = new HashSet<Thief>();
            foreach (var officer in _queue.Police)
            {
                thievesCaught.UnionWith(
                    _queue.Thieves.Where(
                        x => ((x.PlaceInQueue >= (officer.PlaceInQueue - officer.SearchPower)) && x.PlaceInQueue < officer.PlaceInQueue)
                          || ((x.PlaceInQueue <= (officer.PlaceInQueue + officer.SearchPower)) && x.PlaceInQueue > officer.PlaceInQueue))
                    );
            }

            return thievesCaught.Count;
        }
    }
}
