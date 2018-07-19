namespace ElonaCreator
{
    class SpecialPowerModel
    {
        public string AliasJapanese { get; set; }
        public string AliasEnglish { get; set; }
        public int Id { get; set; }
        public string PowerExpression { get; set; }


        public string Text
        {
            get
            {
                if (SpecialActionTable.IsValid(Id))
                {
                    return SpecialActionTable.ToString(Id);
                }
                else if (EnchantmentTable.IsValid(Id))
                {
                    return EnchantmentTable.ToString(Id);
                }
                else if (BitFlagTable.IsValid(Id))
                {
                    return BitFlagTable.ToString(Id);
                }
                else
                {
                    return "----";
                }
            }
        }
    }
}
