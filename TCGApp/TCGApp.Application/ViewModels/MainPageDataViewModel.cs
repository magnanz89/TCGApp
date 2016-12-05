using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCGApp.Application.Models;
using TCGApp.Common;
using Attribute = TCGApp.Application.Models.Attribute;

namespace TCGApp.Application.ViewModels
{
    public class MainPageDataViewModel : ObservableObject
    {
        //just to test
        public List<YugiohCard> YugiohCards { get; set; }
        public List<TcgType> ListOfCardTypes { get; set; }

        private TcgType _selectedTcgType;

        public TcgType SelectedTcgType
        {
            get { return _selectedTcgType; }
            set
            {
                Set(ref _selectedTcgType, value);
            }
        }


        public MainPageDataViewModel()
        {
            LoadTcgTypes();
            LoadTestYugioh();
        }

        private void LoadTestYugioh()
        {
            YugiohCards = new List<YugiohCard>
             {
                 new YugiohCard
                 {
                     Attribute = Attribute.Dark,
                     Name = "Blue eyes",
                     ATK = 3000,
                     DEF = 2000,
                     Information = "Stuff",
                     ReleaseDate = DateTime.Today,
                     Type = MonsterType.Heaps
                 },
                 new YugiohCard
                 {
                     Attribute = Attribute.Dark,
                     Name = "Blue eyes",
                     ATK = 3000,
                     DEF = 2000,
                     Information = "Stuff",
                     ReleaseDate = DateTime.Today,
                     Type = MonsterType.Heaps
                 },
             };
        }

        private void LoadTcgTypes()
        {
            ListOfCardTypes = new List<TcgType>
            {
                new TcgType
                {
                    Name = "Yugioh",
                    Image = null
                },
                new TcgType
                {
                    Name = "Hearthstone",
                    Image = null
                },
                new TcgType
                {
                    Name = "Pokemon",
                    Image = null
                },
                new TcgType
                {
                    Name = "DBZ",
                    Image = null
                }
            };
        }
    }

}
