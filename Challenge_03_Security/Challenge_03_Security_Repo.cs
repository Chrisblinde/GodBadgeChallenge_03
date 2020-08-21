using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_03_Security
{
    class Challenge_03_Security_Repo
    {
        private readonly Dictionary<int , List<string>> _badgeDict = new Dictionary<int, List<string>>();
        
        public void AddToDictionary (int badgeId, List<string>doorNames)
        {
            _badgeDict.Add(badgeId, doorNames);
           
        }

        public Dictionary<int, List<string>> GetDictionary()
        {
            return _badgeDict;
        }
        
    }
}
