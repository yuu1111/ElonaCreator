namespace ElonaCreator
{
    class AbilityBonusModel
    {
        public int Id { get; set; } = -1;
        public int Rank { get; set; } = 14;



        public string Text
        {
            get
            {
                if (Id == -1)
                {
                    return "------";
                }
                else if (BasicAttributeTable.IsValid(Id))
                {
                    return BasicAttributeTable.ToString(Id);
                }
                else if (ResistanceTable.IsValid(Id))
                {
                    return ResistanceTable.ToString(Id);
                }
                else if (SkillTable.IsValid(Id))
                {
                    return SkillTable.ToString(Id);
                }
                else if (SpellTable.IsValid(Id))
                {
                    return SpellTable.ToString(Id);
                }
                else
                {
                    return "unknown ability";
                }
            }
        }


        public AbilityBonusModel(int rank)
        {
            Rank = rank;
        }
    }
}
