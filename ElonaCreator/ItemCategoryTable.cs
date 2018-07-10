using System.Collections.Generic;
using System.Linq;



namespace ElonaCreator
{
    static class ItemCategoryTable
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
            {10000, "melee weapons"},
            {12000, "helms"},
            {14000, "shields"},
            {16000, "armors"},
            {18000, "boots"},
            {19000, "girdles"},
            {20000, "mantles"},
            {22000, "armwears"},
            {24000, "ranged weapons"},
            {25000, "ammos"},
            {32000, "rings"},
            {34000, "necklaces"},
            {52000, "potions"},
            {53000, "scrolls"},
            {54000, "spellbooks"},
            {55000, "books"},
            {56000, "rods"},
            {57000, "foods"},
            {59000, "tools"},
            {60000, "furniture"},
            {60001, "wells"},
            {60002, "altars"},
            {62000, "figures/cards/remains"},
            {64000, "junks"},
            {68000, "gold pieces"},
            {69000, "platinum coins"},
            {72000, "treasure chests"},
            {77000, "ores"},
            {80000, "trees"},
            {91000, "travelers' food"},
            {92000, "trade goods"},
        };
    }
}
