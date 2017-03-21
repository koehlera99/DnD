using System;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Reflection;
using DnD.XML.Serialized;

namespace DnD.XML
{
    /// <summary>
    /// Read/Write Serialized Monster Data
    /// </summary>
    class MonsterReadWrite
    {
        public static MonsterCompendium GetEmbeddedMonsterXML()
        {
            try
            {
                string result = string.Empty;

                using (Stream stream = typeof(MonsterReadWrite).Assembly.GetManifestResourceStream(typeof(MonsterReadWrite).Assembly.GetName().Name + "." + "XML.Compendiums.Monsters.xml"))
                {
                    using (XmlReader xmlReader = XmlReader.Create(stream))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(MonsterCompendium));

                        return serializer.Deserialize(xmlReader) as MonsterCompendium;
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Current ItemCompendium: Bestiary Compendium 2.0.1.xml
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        public static MonsterCompendium GetCustomMonsterData()
        {
            return GetData(true);
        }

        public static MonsterCompendium GetMonsterData()
        {
            return GetData();
        }

        private static MonsterCompendium GetData(bool customOnly = false)
        {
            try
            {
                if (Properties.Settings.Default.XMLFileLocation == string.Empty && !customOnly)
                    return GetEmbeddedMonsterXML();
                else
                {
                    string[] files = Directory.GetFiles(Properties.Settings.Default.XMLFileLocation);

                    foreach (string file in files)
                    {
                        if ((file.Contains("Bestiary") || file.Contains("Monsters")) && file.EndsWith(".xml"))
                        {
                            if ((customOnly && file.Contains("Custom")) || !customOnly)
                            {
                                using (FileStream xmlStream = new FileStream(file, FileMode.Open))
                                {
                                    using (XmlReader xmlReader = XmlReader.Create(xmlStream))
                                    {
                                        XmlSerializer serializer = new XmlSerializer(typeof(MonsterCompendium));

                                        return serializer.Deserialize(xmlReader) as MonsterCompendium;
                                    }
                                }
                            }
                        }
                    }

                }

                //If it reaches this, something went wrong
                if (!customOnly)
                {
                    Properties.Settings.Default.XMLFileLocation = string.Empty;
                    Properties.Settings.Default.Save();
                    return GetEmbeddedMonsterXML();
                }
                else
                    return null;
            }
            catch
            {
                //If it reaches this, something went wrong
                if (!customOnly)
                {
                    Properties.Settings.Default.XMLFileLocation = string.Empty;
                    Properties.Settings.Default.Save();
                    return GetEmbeddedMonsterXML();
                }
                else
                    return null;
            }
        }

        public static bool WriteMonsterData(MonsterCompendium monsters, string folder = "")
        {
            try
            {
                if (folder == string.Empty && Properties.Settings.Default.XMLFileLocation == string.Empty)
                {
                    System.Windows.Forms.FolderBrowserDialog dlg = new System.Windows.Forms.FolderBrowserDialog();

                    if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Properties.Settings.Default.XMLFileLocation = dlg.SelectedPath;
                        Properties.Settings.Default.Save();

                        folder = Properties.Settings.Default.XMLFileLocation;
                    }
                }
                else if(folder == string.Empty)
                    folder = Properties.Settings.Default.XMLFileLocation;

                folder += "\\CustomMonsters.xml";

                using (FileStream xmlStream = new FileStream(folder, FileMode.Create))
                {
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;

                    using (XmlWriter xmlWriter = XmlWriter.Create(xmlStream, settings))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(MonsterCompendium));
                        serializer.Serialize(xmlWriter, monsters);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error occured during save: " + ex.Message,
                    "Save Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);

                return false;
            }
        }
    }
}
