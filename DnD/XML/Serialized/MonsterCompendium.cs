using System.Collections.Generic;

namespace DnD.XML.Serialized
{

    /// <summary>
    /// Full Compendium of Monsters
    /// </summary>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", ElementName = "compendium", IsNullable = false)]
    public partial class MonsterCompendium
    {
        [System.Xml.Serialization.XmlElementAttribute("monster")]
        public List<Monster> Monsters { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute("version")]
        public byte Version { get; set; }

        public MonsterCompendium()
        {
            Monsters = new List<Monster>();
        }
    }

    /// <summary>
    /// Single Monster Object
    /// </summary>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Monster
    {
        #region Lists of Traits, Actions, Legendaries
        [System.Xml.Serialization.XmlElementAttribute("trait")]
        public List<MonsterTrait> Trait { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("action")]
        public List<MonsterAction> Action { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("legendary")]
        public List<MonsterLegendary> Legendary { get; set; }
        #endregion

        [System.Xml.Serialization.XmlElementAttribute("name")]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("size")]
        public string Size { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("type")]
        public string Type { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("alignment")]
        public string Alignment { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ac")]
        public string AC { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("hp")]
        public string HP { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("speed")]
        public string Speed { get; set; }

        #region Base Stats
        [System.Xml.Serialization.XmlElementAttribute("str")]
        public byte Strength { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("dex")]
        public byte Dexterity { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("con")]
        public byte Constitution { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("int")]
        public byte Intelligence { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("wis")]
        public byte Wisdom { get; set; }
 
        [System.Xml.Serialization.XmlElementAttribute("cha")]
        public byte Charisma { get; set; }
        #endregion

        [System.Xml.Serialization.XmlElementAttribute("save")]
        public string Save { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("skill")]
        public string Skill { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("resist")]
        public string Resist { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("vulnerable")]
        public string Vulnerable { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("immune")]
        public string Immune { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("conditionImmune")]
        public string ConditionImmune { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("senses")]
        public string Senses { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("passive")]
        public byte Passive { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("languages")]
        public string Languages { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("cr")]
        public string CR { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("reaction")]
        public MonsterReaction Reaction { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("spells")]
        public string Spells { get; set; }


    }

    /// <summary>
    /// Monster Traits
    /// </summary>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MonsterTrait
    {
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("text")]
        public List<string> Text { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("attack")]
        public string Attack { get; set; }
    }

    /// <summary>
    /// Monster Actions
    /// </summary>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MonsterAction
    {
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("text")]
        public List<string> Text { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("attack")]
        public List<string> Attack { get; set; }
    }

    /// <summary>
    /// Monster Reactions
    /// </summary>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MonsterReaction
    {
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("text")]
        public List<string> Text { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("attack")]
        public string Attack { get; set; }
    }

    /// <summary>
    /// Monster Legendary Actions
    /// </summary>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MonsterLegendary
    {
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("text")]
        public string Text { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("attack")]
        public string Attack { get; set; }
    }
}
