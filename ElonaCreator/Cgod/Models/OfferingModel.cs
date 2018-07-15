namespace ElonaCreator
{
    class OfferingModel
    {
        public int Id { get; set; }


        public string Text
        {
            get
            {
                if (Id == -1)
                {
                    return "------";
                }
                else if (ItemCategoryTable.IsValid(Id))
                {
                    return ItemCategoryTable.ToString(Id);
                }
                else if (ItemSubcategoryTable.IsValid(Id))
                {
                    return ItemSubcategoryTable.ToString(Id);
                }
                else if (ItemIdTable.IsValid(Id))
                {
                    return ItemIdTable.ToString(Id);
                }
                else
                {
                    return "unknown item";
                }
            }
        }


        public OfferingModel(int id = -1)
        {
            Id = id;
        }


        public string Serialize()
        {
            return Id.ToString();
        }
    }
}
