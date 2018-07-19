using System;
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
        public ObservableCollection<MiracleModel> Miracles { get; set; } = new ObservableCollection<MiracleModel>();




        private SpecialPowerModel _specialPower = new SpecialPowerModel();
        private string fileName;

        public SpecialPowerModel SpecialPower
        {
            get { return _specialPower; }
            set
            {
                if (_specialPower != value)
                {
                    _specialPower = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public CgodModel()
        {
            ClearOfferings();
            ClearAbilityBonuses();
            ClearFoodBonuses();
            ClearSpecialFoodBonuses();
            ClearMiracles();
        }


        public CgodModel(string fileName)
        {
            throw new NotImplementedException();
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


        public void ClearMiracles()
        {
            Miracles.Clear();
            for (int i = 0; i < 2; ++i)
            {
                Miracles.Add(new MiracleModel());
            }
        }


        public void Save(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}