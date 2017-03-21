using System.Collections.Generic;

namespace DnD.XML.Serialized
{
    public partial class Monster
    {
        public Monster()
        {
            //Trait = new List<MonsterTrait>();
            //Action = new List<MonsterAction>();
            //Legendary = new List<MonsterLegendary>();
        }


        public Monster Copy()
        {
            return (Monster)this.MemberwiseClone();
        }
    }
}