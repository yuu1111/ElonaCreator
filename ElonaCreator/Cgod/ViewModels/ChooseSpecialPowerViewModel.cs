using System.Collections.Generic;
using System.Linq;


namespace ElonaCreator
{
    class SpecialPowerCandidate
    {
        public string Type { get; set; }
        public string Name { get; set; }
    }


    class ChooseSpecialPowerViewModel : ViewModelBase
    {
        public List<SpecialPowerCandidate> Candidates
        {
            get
            {
                var ret = new List<SpecialPowerCandidate>();
                if (SearchesFromSpecialActions)
                {
                    ret.AddRange(SpecialActionTable.GetAll().Select(c => new SpecialPowerCandidate()
                    {
                        Type = "special actions",
                        Name = c
                    }));
                }
                if (SearchesFromEnchantments)
                {
                    ret.AddRange(EnchantmentTable.GetAll().Select(c => new SpecialPowerCandidate()
                    {
                        Type = "enchantments",
                        Name = c
                    }));
                }
                if (SearchesFromBitFlags)
                {
                    ret.AddRange(BitFlagTable.GetAll().Select(c => new SpecialPowerCandidate()
                    {
                        Type = "bit flags",
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


        private bool _searchesFromSpecialActions = true;
        public bool SearchesFromSpecialActions
        {
            get
            {
                return _searchesFromSpecialActions;
            }
            set
            {
                if (_searchesFromSpecialActions != value)
                {
                    _searchesFromSpecialActions = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged(nameof(Candidates));
                }
            }
        }


        private bool _searchesFromEnchantments = true;
        public bool SearchesFromEnchantments
        {
            get
            {
                return _searchesFromEnchantments;
            }
            set
            {
                if (_searchesFromEnchantments != value)
                {
                    _searchesFromEnchantments = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged(nameof(Candidates));
                }
            }
        }


        private bool _searchesFromBitFlags = true;
        public bool SearchesFromBitFlags
        {
            get
            {
                return _searchesFromBitFlags;
            }
            set
            {
                if (_searchesFromBitFlags != value)
                {
                    _searchesFromBitFlags = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged(nameof(Candidates));
                }
            }
        }
    }
}
