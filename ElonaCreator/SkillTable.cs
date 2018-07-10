using System.Collections.Generic;
using System.Linq;



namespace ElonaCreator
{
    class SkillTable
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
            {100, "Long Sword"},
            {101, "Short Sword"},
            {102, "Axe"},
            {103, "Blunt"},
            {104, "Polearm"},
            {105, "Stave"},
            {107, "Scythe"},
            {108, "Bow"},
            {109, "Crossbow"},
            {110, "Firearm"},
            {111, "Throwing"},
            {106, "Martial Arts"},
            {168, "Shield"},
            {173, "Evasion"},
            {166, "Dual Wield"},
            {167, "Two Hand"},
            {153, "Weight Lifting"},
            {152, "Tactics"},
            {189, "Marksman"},
            {154, "Healing"},
            {163, "Mining"},
            {176, "Carpentry"},
            {169, "Heavy Armor"},
            {170, "Medium Armor"},
            {171, "Light Armor"},
            {158, "Lock Picking"},
            {175, "Disarm Trap"},
            {177, "Tailoring"},
            {179, "Jeweler"},
            {300, "Pickpocket"},
            {157, "Stealth"},
            {159, "Detection"},
            {162, "Sense Quality"},
            {186, "Eye of Mind"},
            {185, "Fishing"},
            {187, "Greater Evasion"},
            {161, "Anatomy"},
            {150, "Literacy"},
            {165, "Memorization"},
            {178, "Alchemy"},
            {180, "Gardening"},
            {151, "Gene engineer"},
            {184, "Cooking"},
            {155, "Meditation"},
            {174, "Magic Device"},
            {172, "Casting"},
            {188, "Control Magic"},
            {164, "Magic Capacity"},
            {181, "Faith"},
            {182, "Traveling"},
            {301, "Riding"},
            {156, "Negotiation"},
            {160, "Investing"},
            {183, "Performer"},
        };
    }
}
