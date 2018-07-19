using System.Collections.Generic;
using System.Linq;



namespace ElonaCreator
{
    static class EnchantmentTable
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
            {1021, "Blessing of the god causes random teleport."},
            {1045, "Blessing of the god sucks blood of the wielder."},
            {1046, "Blessing of the god disturbs believer's growth."},
            {1047, "Blessing of the god attracts monsters."},
            {1022, "Blessing of the god prevents believer from teleporting."},
            {1023, "Blessing of the god negates the effect of blindness."},
            {1024, "Blessing of the god negates the effect of paralysis."},
            {1025, "Blessing of the god negates the effect of confusion."},
            {1026, "Blessing of the god negates the effect of fear."},
            {1027, "Blessing of the god negates the effect of sleep."},
            {1028, "Blessing of the god negates the effect of poison."},
            {1041, "Blessing of the god protects believer from thieves."},
            {1042, "Blessing of the god allows believer to digest rotten food."},
            {1029, "Blessing of the god speeds up believer's travel progress."},
            {1030, "Blessing of the god protects believer from Etherwind."},
            {1031, "Blessing of the god negates the effect of being stranded by bad weather."},
            {1048, "Blessing of the god prevents aliens from entering believer's body."},
            {1032, "Blessing of the god floats believer."},
            {1033, "Blessing of the god protects believer from mutation."},
            {1035, "Blessing of the god allows believer to see invisible creatures."},
            {1039, "Blessing of the god gives believer a chance to throw an absolute piercing attak."},
            {1044, "Blessing of the god increases believer's chance to deliver critical hits."},
            {1050, "Blessing of the god increases the chance of extra melee attack."},
            {1051, "Blessing of the god increases the chance of extra ranged attack."},
            {1043, "Blessing of the god protects believer from cursing words."},
            {1052, "Blessing of the god decreases physical damage believer take."},
            {1053, "Blessing of the god sometimes nullifies damage believer take."},
            {1054, "Blessing of the god deals cut damage to the attacker."},
            {1055, "Blessing of the god diminishs bleeding."},
            {1056, "Blessing of the god catches signals from God."},
            {1059, "Blessing of the god reveals religion."},
        };
    }
}
