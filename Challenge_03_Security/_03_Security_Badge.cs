using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_03_Security
{
    class _03_Security_Badge
    {
        public _03_Security_Badge() { }
        public _03_Security_Badge(int badgeId, List<string> doorNames)
        {
            BadgeId = badgeId;
            DoorNames = doorNames;
            //BadgeName = badgeName;
        }

        public int BadgeId { get; set; }
        //public string BadgeName { get; set; }
        public List<string> DoorNames { get; set; } 
    }

       
}


