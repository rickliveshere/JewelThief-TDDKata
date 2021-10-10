
using JewelThief.Core.Models;

namespace JewelThief.Core.Factories
{
    public class QueueFactory
    {
        private string _queuePattern;

        public QueueFactory(string queuePattern)
        {
            _queuePattern = queuePattern;
        }

        public virtual Queue MakeQueue()
        {
            Queue queue = new Queue();
            if (string.IsNullOrWhiteSpace(_queuePattern))
            {
                return queue;
            }

            var people = _queuePattern.Trim().ToCharArray();

            int placeInQueue = 0;
            foreach (var person in people)
            {
                if (Thief.ConfirmIdentity(person))
                {
                    queue.Thieves.Add(new Thief(placeInQueue));
                }
                else if (Police.ConfirmIdentity(person))
                {
                    int searchPower = Police.GetSearchPower(person);
                    queue.Police.Add(new Police(placeInQueue, searchPower));
                }

                placeInQueue++;
            }

            return queue;
        }
    }
}
