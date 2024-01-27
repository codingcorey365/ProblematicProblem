using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblematicProblem
{
    internal class Activities
    {
        private List<string> activityList = new List<string>()
        { "Movies", "Paintball", "Bowling", "Laser Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting", "Cigar Smoking" };

        public List<string> GetActivityList()
        {
            return activityList;
        }
    }
}
