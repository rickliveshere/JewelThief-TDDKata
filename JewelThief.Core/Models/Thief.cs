using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelThief.Core.Models
{
    public class Thief : Person
    {
        private const char THIEF_IDENTITY_UPPER_CASE = 'X';
        private const char THIEF_IDENTITY_LOWER_CASE = 'x';

        public Thief(int placeInQueue) : base(placeInQueue)
        {            
        }

        public static bool ConfirmIdentity(char person)
        {
            return person == THIEF_IDENTITY_UPPER_CASE || person == THIEF_IDENTITY_LOWER_CASE;
        }
    }
}
