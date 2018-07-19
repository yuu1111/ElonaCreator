using System.Collections.Generic;
using System.Linq;



namespace ElonaCreator
{
    static class BitFlagTable
    {
        public static bool IsValid(int id)
        {
            return table.ContainsKey(id);
        }


        public static string ToString(int id)
        {
            return table[id];
        }


        public static List<string> GetAll()
        {
            return table.Values.ToList();
        }


        private static Dictionary<int, string> table = new Dictionary<int, string>
        {
            {2005, "Believer is floating."},
            {2006, "Believer is invisible."},
            {2007, "Believer can see invisible creatures."},
            {2008, "Believer is immune to confusion."},
            {2009, "Believer is immune to blindness."},
            {2010, "Believer is immune to fear."},
            {2011, "Believer is immune to sleep."},
            {2012, "Believer is immune to paralysis."},
            {2013, "Believer is immune to poison."},
            {2014, "Believer can digest rotten foods."},
            {2015, "Believer is protected from thieves."},
            {2017, "Believer always drops their gold."},
            {2018, "Believer explodes on damage."},
            {2019, "Believer sentences death."},
            {2020, "Believer can cast spells several times in a row."},
            {2022, "Believer is suitable for mount."},
            {2025, "Believer is severely unsuitable for mount."},
            {2029, "Believer cures thier cut damage quickly."},
            {2030, "Believer has more chance to bash with thier shield."},
            {2031, "Believer is immune to landmine."},
        };
    }
}
