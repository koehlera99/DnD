using System;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Reflection;

namespace DnD.XML.Serialized.i
{
    ///// <remarks/>
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ItemCompendium
    {

        private compendiumItem[] itemField;

        private byte versionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public compendiumItem[] item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class compendiumItem
    {

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ac", typeof(byte))]
        [System.Xml.Serialization.XmlElementAttribute("dmg1", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("dmg2", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("dmgType", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("modifier", typeof(compendiumItemModifier))]
        [System.Xml.Serialization.XmlElementAttribute("name", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("property", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("range", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("rarity", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("roll", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("stealth", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("strength", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("text", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("type", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("weight", typeof(decimal))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class compendiumItemModifier
    {

        private string categoryField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        ac,

        /// <remarks/>
        dmg1,

        /// <remarks/>
        dmg2,

        /// <remarks/>
        dmgType,

        /// <remarks/>
        modifier,

        /// <remarks/>
        name,

        /// <remarks/>
        property,

        /// <remarks/>
        range,

        /// <remarks/>
        rarity,

        /// <remarks/>
        roll,

        /// <remarks/>
        stealth,

        /// <remarks/>
        strength,

        /// <remarks/>
        text,

        /// <remarks/>
        type,

        /// <remarks/>
        value,

        /// <remarks/>
        weight,
    }

}


