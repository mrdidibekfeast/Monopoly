using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    
    public static class BoardConstants
    {
        //Board Movement
        public const int GOIndex = 0;
        public const int JailIndex = 10;
        public const int ParkingIndex = 20;
        public const int GoToJailIndex = 30;
        public const int JumpValue = 65;

        public const int LeftScreen = 125;
        public const int TopScreen = 65;
        public const int BottomScreen = 700;
        public const int RightScreen = 770;

        //Setup
        public const int PlayerCount = 4;


        //properties
        public enum PropertyColors
        {
            Brown,
            BabyBlue,
            Magenta,
            Orange,
            Red,
            Yellow,
            Green,
            DarkBlue,
            Railroad
        }
        
    }
}
