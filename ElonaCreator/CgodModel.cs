using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;



namespace ElonaCreator
{
    class CgodModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


        /*
        %Elona Custom God

author. "作者"
author_en. "作者"
name. "Jure of Healing,癒しのジュア"
shortname. "Jure,ジュア"
filter. ""
give. "204,77001"
bonus. "150016,1540018,1550010,1610009,1840008,1740010,1640012"
specialpower. "623,{faith}"
specialpoweralias.
foodbonus.
specialfoodbonus.
miracle0. / miracle1.
*/

        public string SpecialPower;
        public string SpecialPowerAlias;
        public string FoodBonus;
        public string SpecialFoodBonus;
        public string Miracle0;
        public string Miracle1;



        private string _authorJapanese = "";
        public string AuthorJapanese
        {
            get { return _authorJapanese; }
            set
            {
                if (_authorJapanese != value)
                {
                    _authorJapanese = value;
                    NotifyPropertyChanged();
                }
            }
        }



        private string _authorEnglish = "";
        public string AuthorEnglish
        {
            get { return _authorEnglish; }
            set
            {
                if (_authorEnglish != value)
                {
                    _authorEnglish = value;
                    NotifyPropertyChanged();
                }
            }
        }



        private string _shortNameJapanese = "";
        public string ShortNameJapanese
        {
            get { return _shortNameJapanese; }
            set
            {
                if (_shortNameJapanese != value)
                {
                    _shortNameJapanese = value;
                    NotifyPropertyChanged();
                }
            }
        }



        private string _shortNameEnglish = "";
        public string ShortNameEnglish
        {
            get { return _shortNameEnglish; }
            set
            {
                if (_shortNameEnglish != value)
                {
                    _shortNameEnglish = value;
                    NotifyPropertyChanged();
                }
            }
        }



        private string _fullNameJapanese = "";
        public string FullNameJapanese
        {
            get { return _fullNameJapanese; }
            set
            {
                if (_fullNameJapanese != value)
                {
                    _fullNameJapanese = value;
                    NotifyPropertyChanged();
                }
            }
        }



        private string _fullNameEnglish = "";
        public string FullNameEnglish
        {
            get { return _fullNameEnglish; }
            set
            {
                if (_fullNameEnglish != value)
                {
                    _fullNameEnglish = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public ObservableCollection<OfferingModel> Offerings { get; set; } = new ObservableCollection<OfferingModel>();


        public ObservableCollection<AbilityBonusModel> AbilityBonuses { get; set; } = new ObservableCollection<AbilityBonusModel>();
        public ObservableCollection<AbilityBonusModel> FoodBonuses { get; set; } = new ObservableCollection<AbilityBonusModel>();
        public ObservableCollection<AbilityBonusModel> SpecialFoodBonuses { get; set; } = new ObservableCollection<AbilityBonusModel>();



        public CgodModel()
        {
            ClearOfferings();
            ClearAbilityBonuses();
            ClearFoodBonuses();
            ClearSpecialFoodBonuses();
        }


        public void ClearOfferings()
        {
            Offerings.Clear();
            Offerings.Add(new OfferingModel(204));
            for (int i = 0; i < 9; ++i)
            {
                Offerings.Add(new OfferingModel());
            }
        }


        public void ClearAbilityBonuses()
        {
            AbilityBonuses.Clear();
            for (int i = 0; i < 10; ++i)
            {
                AbilityBonuses.Add(new AbilityBonusModel(14));
            }
        }


        public void ClearFoodBonuses()
        {
            FoodBonuses.Clear();
            for (int i = 0; i < 8; ++i)
            {
                FoodBonuses.Add(new AbilityBonusModel(3));
            }
        }


        public void ClearSpecialFoodBonuses()
        {
            SpecialFoodBonuses.Clear();
            for (int i = 0; i < 8; ++i)
            {
                SpecialFoodBonuses.Add(new AbilityBonusModel(150));
            }
        }
    }
}