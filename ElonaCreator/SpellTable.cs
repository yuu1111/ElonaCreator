using System.Collections.Generic;
using System.Linq;



namespace ElonaCreator
{
    class SpellTable
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
            {400, "Heal Light"},
            {401, "Heal Critical"},
            {402, "Cure of Eris"},
            {403, "Cure of Jure"},
            {404, "Healing Rain"},
            {405, "Healing Touch"},
            {406, "Holy Light"},
            {407, "Vanquish Hex"},
            {408, "Teleport"},
            {409, "Teleport Other"},
            {410, "Short Teleport"},
            {411, "Identify"},
            {412, "Uncurse"},
            {413, "Oracle"},
            {414, "Magic Dart"},
            {415, "Nether Arrow"},
            {416, "Nerve Arrow"},
            {417, "Chaos eye"},
            {418, "Dark eye"},
            {419, "Ice Bolt"},
            {420, "Fire Bolt"},
            {421, "Lightning Bolt"},
            {422, "Darkness Bolt"},
            {423, "Mind Bolt"},
            {424, "Summon Monsters"},
            {425, "Summon Wild"},
            {428, "Return"},
            {429, "Magic Map"},
            {430, "Sense Object"},
            {431, "Ice Ball"},
            {432, "Fire Ball"},
            {433, "Chaos Ball"},
            {434, "Raging Roar"},
            {435, "Dominate"},
            {436, "Web"},
            {437, "Mist of Darkness"},
            {438, "Wall Creation"},
            {439, "Restore Body"},
            {440, "Restore Spirit"},
            {441, "Wish"},
            {442, "Holy Shield"},
            {443, "Mist of Silence"},
            {444, "Regeneration"},
            {445, "Elemental Shield"},
            {446, "Speed"},
            {447, "Slow"},
            {448, "Hero"},
            {449, "Mist of frailness"},
            {450, "Element Scar"},
            {451, "Holy Veil"},
            {452, "Nightmare"},
            {453, "Divine Wisdom"},
            {454, "Mutation"},
            {455, "Acid Ground"},
            {456, "Fire Wall"},
            {457, "Door Creation"},
            {458, "Incognito"},
            {459, "Crystal Spear"},
            {460, "Magic Storm"},
            {461, "Resurrection"},
            {462, "Contingency"},
            {463, "4-Dimensional Pocket"},
            {464, "Wizard's Harvest"},
            {465, "Meteor"},
            {466, "Gravity"},
        };
    }
}
