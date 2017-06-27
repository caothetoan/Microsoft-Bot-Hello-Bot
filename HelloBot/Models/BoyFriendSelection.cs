using System;
using System.Collections.Generic;

namespace HelloBot.Models
{
    [Serializable]
    public class BoyFriendSelection
    {
        public String YourName;
        public Int32 YourAge;
        public BoyFriendPackage BoyFriendPackage;
        public Man YourMan;
    }

    [Serializable]
    public class Man
    {
        public ManType ManType;
        public Int32? ManAge;
    }
    public enum ManType
    {
        Serious,
        Romantics,
        Funny,
        Smart
    }

    public enum BoyFriendPackage
    {
        Basic,
        Standard,
        Premium
    }
}