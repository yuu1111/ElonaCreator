using System.Collections.Generic;
using System.Linq;


namespace ElonaCreator
{
    class OfferingCandidate
    {
        public string Type { get; set; }
        public string Name { get; set; }
    }


    class ChooseOfferingViewModel : ViewModelBase
    {
        public List<OfferingCandidate> Candidates
        {
            get
            {
                var ret = new List<OfferingCandidate>();
                if (SearchesFromItemCategory)
                {
                    ret.AddRange(ItemCategoryTable.GetAll().Select(c => new OfferingCandidate()
                    {
                        Type = "category",
                        Name = c
                    }));
                }
                if(SearchesFromItemSubcategory)
                {
                    ret.AddRange(ItemSubcategoryTable.GetAll().Select(c => new OfferingCandidate()
                    {
                        Type = "subcategory",
                        Name = c
                    }));
                }
                if(SearchesFromItemId)
                {
                    ret.AddRange(ItemIdTable.GetAll().Select(c => new OfferingCandidate()
                    {
                        Type = "ID",
                        Name = c
                    }));
                }
                return ret.Where(c => string.IsNullOrEmpty(SearchQuery) || c.Name.Contains(SearchQuery)).ToList();
            }
        }



        private string _searchQuery = "";
        public string SearchQuery
        {
            get
            {
                return _searchQuery;
            }
            set
            {
                if (_searchQuery != value)
                {
                    _searchQuery = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged(nameof(Candidates));
                }
            }
        }


        private bool _searchesFromItemCategory = true;
        public bool SearchesFromItemCategory
        {
            get
            {
                return _searchesFromItemCategory;
            }
            set
            {
                if (_searchesFromItemCategory != value)
                {
                    _searchesFromItemCategory = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged(nameof(Candidates));
                }
            }
        }


        private bool _searchesFromItemSubcategory = true;
        public bool SearchesFromItemSubcategory
        {
            get
            {
                return _searchesFromItemSubcategory;
            }
            set
            {
                if (_searchesFromItemSubcategory != value)
                {
                    _searchesFromItemSubcategory = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged(nameof(Candidates));
                }
            }
        }


        private bool _searchesFromItemId = true;
        public bool SearchesFromItemId
        {
            get
            {
                return _searchesFromItemId;
            }
            set
            {
                if (_searchesFromItemId != value)
                {
                    _searchesFromItemId = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged(nameof(Candidates));
                }
            }
        }
    }
}
