using System.Collections.Generic;
using System.Linq;



namespace ElonaCreator
{
    class ResistanceTable
    {
        public static bool IsValid(int id)
        {
            return 0 <= id - 50 && id - 50 < table.Length;
        }


        public static string ToString(int id)
        {
            return table[id - 50];
        }


        public static List<string> GetAll()
        {
            return table.ToList();
        }


        private static string[] table =
        {
            "fire",
            "cold",
            "lightning",
            "darkness",
            "mind",
            "nether",
            "poison",
            "sound",
            "chaos",
            "nerve",
            "magic",
            "cut",
        };
    }
}
