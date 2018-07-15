using System.Collections.Generic;
using System.Linq;


namespace ElonaCreator
{
    class AbilityBonusCandidate
    {
        public string Type { get; set; }
        public string Name { get; set; }
    }


    class ChooseAbilityBonusViewModel : ViewModelBase
    {
        public List<AbilityBonusCandidate> Candidates
        {
            get
            {
                var ret = new List<AbilityBonusCandidate>();
                if (SearchesFromBasicAttribute)
                {
                    ret.AddRange(BasicAttributeTable.GetAll().Select(c => new AbilityBonusCandidate()
                    {
                        Type = "basic attribute",
                        Name = c
                    }));
                }
                if (SearchesFromResistance)
                {
                    ret.AddRange(ResistanceTable.GetAll().Select(c => new AbilityBonusCandidate()
                    {
                        Type = "resistance",
                        Name = c
                    }));
                }
                if (SearchesFromSkill)
                {
                    ret.AddRange(SkillTable.GetAll().Select(c => new AbilityBonusCandidate()
                    {
                        Type = "skill",
                        Name = c
                    }));
                }
                if (SearchesFromSpell)
                {
                    ret.AddRange(SpellTable.GetAll().Select(c => new AbilityBonusCandidate()
                    {
                        Type = "spell",
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


        private bool _searchesFromBasicAttribute = true;
        public bool SearchesFromBasicAttribute
        {
            get
            {
                return _searchesFromBasicAttribute;
            }
            set
            {
                if (_searchesFromBasicAttribute != value)
                {
                    _searchesFromBasicAttribute = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged(nameof(Candidates));
                }
            }
        }


        private bool _searchesFromResistance = true;
        public bool SearchesFromResistance
        {
            get
            {
                return _searchesFromResistance;
            }
            set
            {
                if (_searchesFromResistance != value)
                {
                    _searchesFromResistance = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged(nameof(Candidates));
                }
            }
        }


        private bool _searchesFromSkill = true;
        public bool SearchesFromSkill
        {
            get
            {
                return _searchesFromSkill;
            }
            set
            {
                if (_searchesFromSkill != value)
                {
                    _searchesFromSkill = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged(nameof(Candidates));
                }
            }
        }


        private bool _searchesFromSpell = true;
        public bool SearchesFromSpell
        {
            get
            {
                return _searchesFromSpell;
            }
            set
            {
                if (_searchesFromSpell != value)
                {
                    _searchesFromSpell = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged(nameof(Candidates));
                }
            }
        }
    }
}
