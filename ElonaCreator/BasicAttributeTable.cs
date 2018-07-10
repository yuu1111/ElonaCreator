using System.Collections.Generic;
using System.Linq;



namespace ElonaCreator
{
    class BasicAttributeTable
    {
        public static bool IsValid(int id)
        {
            return 0 <= id && id < table.Length && table[id] != null;
        }


        public static string ToString(int id)
        {
            return table[id];
        }


        public static List<string> GetAll()
        {
            return table.Where(x => x != null).ToList();
        }


        private static string[] table =
        {
            null,
            null,
            "Life",
            "Mana",
            null,
            null,
            null,
            null,
            null,
            null,
            "Strength",
            "Constitution",
            "Dexterity",
            "Perception",
            "Learning",
            "Will",
            "Magic",
            "Charisma",
            "Speed",
            "Luck",
        };
    }
}
