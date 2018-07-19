using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;




namespace ElonaCreator
{
    class CgodViewModel : ViewModelBase
    {
        private CgodModel _cgod = new CgodModel();
        public CgodModel Cgod
        {
            get { return _cgod; }
            set
            {
                if (_cgod != value)
                {
                    _cgod = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public struct AbilityBonusRank
        {
            public int Rank { get; set; }
            public string Description { get; set; }

            public AbilityBonusRank(int rank, string description)
            {
                Rank = rank;
                Description = description;
            }
        }

        public List<AbilityBonusRank> AbilityBonusRanks
        {
            get
            {
                var descriptions = new string[] {
                    "Meaningless",
                    "Meaningless",
                    "Meaningless",
                    "Meaningless",
                    "Meaningless",
                    "Meaningless",
                    "Meaningless",
                    "Meaningless",
                    "Meaningless",
                    "Low",
                    "Low",
                    "Low",
                    "Low",
                    "Normal",
                    "Normal",
                    "Normal",
                    "High",
                    "High",
                    "High",
                    "Extremely high",
                };
                return descriptions.Select((description, index) =>
                    new AbilityBonusRank(index, $"{index}: {description}")).ToList();
            }
        }



        public ICommand ClearOfferings { get; private set; }
        public ICommand EditOffering { get; private set; }
        public ICommand ClearAbilityBonuses { get; private set; }
        public ICommand EditAbilityBonus { get; private set; }
        public ICommand EditSpecialPower { get; private set; }
        public ICommand FileNew { get; private set; }
        public ICommand FileOpen { get; private set; }
        public ICommand FileSave { get; private set; }


        public CgodViewModel()
        {
            ClearOfferings = CreateCommand(_ =>
            {
                Cgod.ClearOfferings();
            });


            EditOffering = CreateCommand(offering =>
            {
                new ChooseOfferingDialog().ShowDialog();
            });


            ClearAbilityBonuses = CreateCommand(_ =>
            {
                Cgod.ClearAbilityBonuses();
            });


            EditAbilityBonus = CreateCommand(offering =>
            {
                new ChooseAbilityBonusDialog().ShowDialog();
            });


            EditSpecialPower = CreateCommand(offering =>
            {
                new ChooseSpecialPowerDialog().ShowDialog();
            });


            FileNew = CreateCommand(_ =>
            {
                Cgod = new CgodModel();
            });


            FileOpen = CreateCommand(_ =>
            {
                var dialog = new OpenFileDialog();
                dialog.Title = "Open file";
                dialog.Filter = "custom god files|*.txt";
                if (dialog.ShowDialog() == true)
                {
                    Cgod = new CgodModel(dialog.FileName);
                }
            });


            FileSave = CreateCommand(_ =>
            {
                var dialog = new SaveFileDialog();
                dialog.Title = "Save file";
                dialog.Filter = "custom god files|*.txt";
                if (dialog.ShowDialog() == true)
                {
                    Cgod.Save(dialog.FileName);
                }
            });
        }
    }
}
