using System.Collections.Generic;
using System.Linq;


namespace ElonaCreator
{
    static class ItemSubcategoryTable
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
            {10001, "claymores"},
            {10002, "long swords/katana/light sabers"},
            {10003, "daggers/wakizashi/kitchen knives"},
            {10004, "clubs"},
            {10005, "hammers"},
            {10006, "staves/long staves"},
            {10007, "spears"},
            {10008, "halberds"},
            {10009, "axes"},
            {10010, "bardiches"},
            {10011, "sickles/scythes"},
            {12001, "helms"},
            {12002, "hats"},
            {14003, "shields"},
            {16001, "armors"},
            {16003, "clothes/robe"},
            {18001, "heavy boots"},
            {18002, "boots"},
            {19001, "girdles"},
            {20001, "cloaks/feathers/wings"},
            {22001, "gauntlets"},
            {22003, "gloves"},
            {24001, "short bows/long bows/skull bows"},
            {24003, "crossbows"},
            {24020, "pistols/machine guns/shot guns"},
            {24021, "laser guns"},
            {24030, "throwing weapons"},
            {25001, "arrows"},
            {25002, "bolts"},
            {25020, "bullets"},
            {25030, "energy cells"},
            {32001, "rings"},
            {34001, "necklaces"},
            {52001, "healing potions"},
            {52002, "alcohol"},
            {53100, "deeds"},
            {57001, "flour"},
            {57002, "raw noodle"},
            {57003, "vegetables"},
            {57004, "fruits"},
            {58005, "herbs"},
            {58500, "seeds"},
            {59500, "flying pans/pots for testing"},
            {60002, "altars"},
            {60004, "beds"},
            {60005, "musical instruments"},
            {64000, "junks(others)"},
            {64100, "junks(town)"},
            {77001, "ores"},
            {99999, "others"},
        };
    }
}
