using System.Collections.Generic;
using System.Linq;



namespace ElonaCreator
{
    static class SpecialActionTable
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
            {644, "Suicide Attack"},
            {637, "Rain of sanity"},
            {642, "Summon Fire"},
            {641, "Summon Pawn"},
            {639, "Summon Cats"},
            {640, "Summon Yeek"},
            {643, "Summon sister"},
            {634, "Ether Ground"},
            {645, "Curse"},
            {647, "Boost"},
            {646, "Death Word"},
            {622, "Punishment"},
            {625, "Lulwy's Trick"},
            {621, "Harvest Mana"},
            {601, "Drain Blood"},
            {612, "Power Breath"},
            {602, "Fire Breath"},
            {603, "Cold Breath"},
            {604, "Lightning Breath"},
            {606, "Chaos Breath"},
            {610, "Poison Breath"},
            {608, "Nether Breath"},
            {607, "Sound Breath"},
            {605, "Darkness Breath"},
            {611, "Mind Breath"},
            {609, "Nerve Breath"},
            {619, "Shadow Step"},
            {627, "Dimensional Move"},
            {620, "Draw Shadow"},
            {623, "Prayer of Jure"},
            {624, "Absorb Magic"},
            {654, "Pregnant"},
            {613, "Touch of Weakness"},
            {614, "Touch of Hunger"},
            {615, "Touch of Poison"},
            {616, "Touch of Nerve"},
            {617, "Touch of Fear"},
            {618, "Touch of Sleep"},
            {635, "Suspicious Hand"},
            {651, "Scavenge"},
            {658, "Decapitation"},
            {660, "Mani's Disassembly"},
            {632, "Eye of Mutation"},
            {633, "Eye of Ether"},
            {636, "Eye of Insanity"},
            {638, "Eye of dimness"},
            {652, "Eye of Mana"},
            {648, "Insult"},
            {653, "Vanish"},
            {649, "Distant Attack"},
            {650, "Distant Attack"},
            {628, "Change"},
            {629, "Draw Charge"},
            {630, "Fill Charge"},
            {631, "Swarm"},
            {656, "Cheer"},
            {657, "Mewmewmew!"},
            {626, "Mirror"},
            {655, "Grenade"},
            {659, "Drop Mine"},
        };
    }
}
