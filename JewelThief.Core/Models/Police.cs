using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelThief.Core.Models
{
    public class Police : Person
    {
        public Police(int placeInQueue, int searchPower) : base(placeInQueue)
        {
            SearchPower = searchPower;
        }

        public int SearchPower { get; private set; }

        public static bool ConfirmIdentity(char person)
        {
            return char.IsNumber(person);
        }

        public static int GetSearchPower(char value)
        {
            if (!ConfirmIdentity(value))
            {
                throw new ArgumentException($"Police officer does not have a valid value: {value}");
            }

            return (int)char.GetNumericValue(value);
        }
    }
}
