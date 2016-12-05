using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCGApp.Application.Models
{
    public enum Attribute
    {
        Dark,
        Earth,
        Fire,
        Light,
        Water,
        Wind
    }

    public enum MonsterType
    {
        Heaps
    }


    public class YugiohCard : Card
    {
        public Attribute Attribute { get; set; }
        public string Name { get; set; }
        public MonsterType Type { get; set; }
        public int ATK { get; set; }
        public int DEF { get; set; }
        public string Information { get; set; }

    }
}
