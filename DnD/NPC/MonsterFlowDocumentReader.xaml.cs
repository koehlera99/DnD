using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Collections.Generic;
using DnD.XML.Serialized;

namespace DnD.NPC
{
    /// <summary>
    /// Interaction logic for MonsterFlowDocumentReader.xaml
    /// </summary>
    public partial class MonsterFlowDocumentReader : UserControl
    {
        public List<Monster> Monsters { get; set; }

        private Section section;
        private Experience xp;
        

        public MonsterFlowDocumentReader()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Monsters = new List<Monster>();
            xp = new Experience();
        }

        private void chkMultipleMonsters_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnClearAll_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeFonts((FontFamily)cbFont.SelectedItem);
        }

        private void ChangeFonts(FontFamily font)
        {
            MonsterFlowReader.FontFamily = font;
        }

        public void Clear()
        {
            MonsterFlow.Blocks.Clear();
            Monsters.Clear();
            UpdateCount();
        }

        private void UpdateCount()
        {
            string count = Monsters.Count.ToString();

            int totalXP = 0;

            foreach(Monster m in Monsters)
            {
                totalXP += xp.GetXP(m.CR);
            }

            string cr = xp.GetCR(totalXP);

            lblCount.Content = "Monsters: " + count  + " (XP Total: " + totalXP.ToString() + ")" + Environment.NewLine  + Environment.NewLine + "[CR: " + cr + "]";
        }


        /// <summary>
        /// Creates the stat block
        /// </summary>
        /// <param name="monster"></param>
        public void CreateDocument(Monster monster)
        {
            try
            {

                if (chkMultipleMonsters.IsChecked == false)
                {
                    this.Clear();
                }

                Monsters.Add(monster);

                UpdateCount();

                const double headerFontSize = 12.25;
                const double textFontSize = 11.5;
                const double lineHeight = 17.5;

                section = new Section();

                if (chkPageBreak.IsChecked == true)
                {

                    if (MonsterFlow.Blocks.Count >= 1)
                        section.BreakPageBefore = true;
                }
                else
                {
                    section.BreakPageBefore = false;

                    if (chkMultipleMonsters.IsChecked == true)
                        section.Blocks.Add(new Paragraph(new LineBreak()));
                }

                Paragraph para;
                Run run;

                AddHeaderFooterLine();

                para = new Paragraph(new Run(monster.Name));
                para.Margin = new Thickness(5);
                para.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                para.FontSize = 22;
                para.FontWeight = FontWeights.SemiBold;

                section.Blocks.Add(para);

                para = new Paragraph(new Run(GetMonsterSize(monster) + " " + monster.Type + ", " + monster.Alignment));
                para.Margin = new Thickness(5);
                para.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));

                para.FontStyle = FontStyles.Italic;
                para.FontSize = textFontSize;

                section.Blocks.Add(para);

                //Divider
                AddDivider();

                //Battle Stats
                para = new Paragraph();
                para.Margin = new Thickness(5);
                para.LineHeight = 18;


                //ArmorClass
                run = new Run("Armor Class: ");
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                run.FontWeight = FontWeights.Bold;
                run.FontSize = headerFontSize;

                para.Inlines.Add(run);

                run = new Run(monster.AC);
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                //run.FontFamily = new FontFamily("Calisto MT");
                run.FontSize = textFontSize;

                para.Inlines.Add(run);
                para.Inlines.Add(new LineBreak());

                //HitPoints
                run = new Run("Hit Points: ");
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                run.FontWeight = FontWeights.Bold;
                //run.FontFamily = new FontFamily("Calisto MT");
                run.FontSize = headerFontSize;

                para.Inlines.Add(run);

                run = new Run(monster.HP);
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                //run.FontFamily = new FontFamily("Calisto MT");
                run.FontSize = textFontSize;

                para.Inlines.Add(run);
                para.Inlines.Add(new LineBreak());

                //Speed
                run = new Run("Speed: ");
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                run.FontWeight = FontWeights.Bold;
                //run.FontFamily = new FontFamily("Calisto MT");
                run.FontSize = headerFontSize;

                para.Inlines.Add(run);

                run = new Run(monster.Speed);
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                //run.FontFamily = new FontFamily("Calisto MT");
                run.FontSize = textFontSize;

                para.Inlines.Add(run);

                section.Blocks.Add(para);

                //Divider
                AddDivider();

                //MainFlow.Blocks.Add(StatTable);


                Table mainStatTable = new Table();
                mainStatTable.FontSize = 13;
                mainStatTable.TextAlignment = TextAlignment.Center;
                mainStatTable.Margin = new Thickness(0);

                for (int i = 0; i < 6; i++)
                    mainStatTable.Columns.Add(new TableColumn());

                mainStatTable.RowGroups.Add(new TableRowGroup());

                //Add two rows
                mainStatTable.RowGroups[0].Rows.Add(new TableRow());
                mainStatTable.RowGroups[0].Rows.Add(new TableRow());

                TableRow header = mainStatTable.RowGroups[0].Rows[0];
                TableRow statRow = mainStatTable.RowGroups[0].Rows[1];

                header.Style = (Style)MonsterFlow.Resources["statName"];
                statRow.Style = (Style)MonsterFlow.Resources["statNumber"];

                header.Cells.Add(new TableCell(new Paragraph(new Run("STR"))));
                header.Cells.Add(new TableCell(new Paragraph(new Run("DEX"))));
                header.Cells.Add(new TableCell(new Paragraph(new Run("CON"))));
                header.Cells.Add(new TableCell(new Paragraph(new Run("INT"))));
                header.Cells.Add(new TableCell(new Paragraph(new Run("WIS"))));
                header.Cells.Add(new TableCell(new Paragraph(new Run("CHA"))));

                int stat;
                int bonus;
                string statBonusText;

                //Strength
                stat = monster.Strength;

                bonus = (int)Decimal.Floor((stat - 10) / 2);

                if (bonus < 0)
                    statBonusText = stat.ToString() + "(" + bonus.ToString() + ")";
                else
                    statBonusText = stat.ToString() + "(+" + bonus.ToString() + ")";


                statRow.Cells.Add(new TableCell(new Paragraph(new Run(statBonusText))));

                //Dexterity
                stat = monster.Dexterity;

                bonus = (int)Decimal.Floor((stat - 10) / 2);

                if (bonus < 0)
                    statBonusText = stat.ToString() + "(" + bonus.ToString() + ")";
                else
                    statBonusText = stat.ToString() + "(+" + bonus.ToString() + ")";


                statRow.Cells.Add(new TableCell(new Paragraph(new Run(statBonusText))));

                //Constitution
                stat = monster.Constitution;

                bonus = (int)Decimal.Floor((stat - 10) / 2);

                if (bonus < 0)
                    statBonusText = stat.ToString() + "(" + bonus.ToString() + ")";
                else
                    statBonusText = stat.ToString() + "(+" + bonus.ToString() + ")";


                statRow.Cells.Add(new TableCell(new Paragraph(new Run(statBonusText))));

                //Intelligence
                stat = monster.Intelligence;

                bonus = (int)Decimal.Floor((stat - 10) / 2);

                if (bonus < 0)
                    statBonusText = stat.ToString() + "(" + bonus.ToString() + ")";
                else
                    statBonusText = stat.ToString() + "(+" + bonus.ToString() + ")";


                statRow.Cells.Add(new TableCell(new Paragraph(new Run(statBonusText))));

                //Wisdom
                stat = monster.Wisdom;

                bonus = (int)Decimal.Floor((stat - 10) / 2);

                if (bonus < 0)
                    statBonusText = stat.ToString() + "(" + bonus.ToString() + ")";
                else
                    statBonusText = stat.ToString() + "(+" + bonus.ToString() + ")";


                statRow.Cells.Add(new TableCell(new Paragraph(new Run(statBonusText))));

                //Charisma
                stat = monster.Charisma;

                bonus = (int)Decimal.Floor((stat - 10) / 2);

                if (bonus < 0)
                    statBonusText = stat.ToString() + "(" + bonus.ToString() + ")";
                else
                    statBonusText = stat.ToString() + "(+" + bonus.ToString() + ")";


                statRow.Cells.Add(new TableCell(new Paragraph(new Run(statBonusText))));

                section.Blocks.Add(mainStatTable);

                AddDivider();

                //Creature Senses / Immunities
                para = new Paragraph();
                para.Margin = new Thickness(5);
                para.LineHeight = lineHeight;

                //Saves
                if (monster.Save != null && monster.Save != string.Empty)
                {
                    run = new Run("Saving Throws: ");
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                    //run.FontFamily = new FontFamily("Calisto MT");
                    run.FontWeight = FontWeights.Bold;
                    run.FontSize = headerFontSize;
                    para.Inlines.Add(run);

                    run = new Run(monster.Save);
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                    //run.FontFamily = new FontFamily("Calisto MT");
                    run.FontSize = textFontSize;
                    para.Inlines.Add(run);

                    para.Inlines.Add(new LineBreak());
                }

                //Skills
                if (monster.Skill != null && monster.Skill != string.Empty)
                {
                    run = new Run("Skills: ");
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                    //run.FontFamily = new FontFamily("Calisto MT");
                    run.FontWeight = FontWeights.Bold;
                    run.FontSize = headerFontSize;
                    para.Inlines.Add(run);

                    run = new Run(monster.Skill);
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                    //run.FontFamily = new FontFamily("Calisto MT");
                    run.FontSize = textFontSize;
                    para.Inlines.Add(run);

                    para.Inlines.Add(new LineBreak());
                }

                //Resist
                if (monster.Resist != null && monster.Resist != string.Empty)
                {
                    run = new Run("Resistances: ");
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                    //run.FontFamily = new FontFamily("Calisto MT");
                    run.FontWeight = FontWeights.Bold;
                    run.FontSize = headerFontSize;
                    para.Inlines.Add(run);

                    run = new Run(monster.Resist);
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                    //run.FontFamily = new FontFamily("Calisto MT");
                    run.FontSize = textFontSize;
                    para.Inlines.Add(run);

                    para.Inlines.Add(new LineBreak());
                }

                //vulnerable
                if (monster.Vulnerable != null && monster.Vulnerable != string.Empty)
                {
                    run = new Run("Vulnerabilities: ");
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                    //run.FontFamily = new FontFamily("Calisto MT");
                    run.FontWeight = FontWeights.Bold;
                    run.FontSize = headerFontSize;
                    para.Inlines.Add(run);

                    run = new Run(monster.Vulnerable);
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                    //run.FontFamily = new FontFamily("Calisto MT");
                    run.FontSize = textFontSize;
                    para.Inlines.Add(run);

                    para.Inlines.Add(new LineBreak());
                }

                //Immunities
                if (monster.Immune != null && monster.Immune != string.Empty)
                {
                    run = new Run("Immunities: ");
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                    //run.FontFamily = new FontFamily("Calisto MT");
                    run.FontWeight = FontWeights.Bold;
                    run.FontSize = headerFontSize;
                    para.Inlines.Add(run);

                    run = new Run(monster.Immune);
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                    //run.FontFamily = new FontFamily("Calisto MT");
                    run.FontSize = textFontSize;
                    para.Inlines.Add(run);

                    para.Inlines.Add(new LineBreak());
                }

                //Condition Immunities
                if (monster.ConditionImmune != null && monster.ConditionImmune != string.Empty)
                {
                    run = new Run("Immunities: ");
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                    run.FontWeight = FontWeights.Bold;
                    run.FontSize = headerFontSize;
                    para.Inlines.Add(run);

                    run = new Run(monster.ConditionImmune);
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                    run.FontSize = textFontSize;
                    para.Inlines.Add(run);

                    para.Inlines.Add(new LineBreak());
                }

                //Senses
                if (monster.Senses != null && monster.Senses != string.Empty)
                {
                    run = new Run("Senses: ");
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                    run.FontWeight = FontWeights.Bold;
                    run.FontSize = headerFontSize;
                    para.Inlines.Add(run);

                    run = new Run(monster.Senses);
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                    run.FontSize = textFontSize;
                    para.Inlines.Add(run);

                    para.Inlines.Add(new LineBreak());
                }

                //languages
                if (monster.Languages != null && monster.Languages != string.Empty)
                {
                    run = new Run("Languages: ");
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                    run.FontWeight = FontWeights.Bold;
                    run.FontSize = headerFontSize;
                    para.Inlines.Add(run);

                    run = new Run(monster.Languages);
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                    run.FontSize = textFontSize;
                    para.Inlines.Add(run);

                    para.Inlines.Add(new LineBreak());
                }

                if (monster.CR != null && monster.CR != string.Empty)
                {
                    run = new Run("CR: ");
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                    run.FontWeight = FontWeights.Bold;
                    run.FontSize = headerFontSize;
                    para.Inlines.Add(run);

                    run = new Run(monster.CR);
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                    run.FontSize = textFontSize;
                    para.Inlines.Add(run);

                    run = new Run(" (" + xp.GetXP(monster.CR).ToString() + ")");
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                    run.FontSize = textFontSize;
                    para.Inlines.Add(run);
                }

                section.Blocks.Add(para);
                AddDivider();

                //Creature Traits
                if (monster.Trait != null && monster.Trait.Count > 0)
                {
                    para = new Paragraph();
                    para.Margin = new Thickness(5);
                    para.LineHeight = lineHeight;

                    foreach (MonsterTrait t in monster.Trait)
                    {
                        run = new Run(t.Name + ". ");
                        run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                        run.FontWeight = FontWeights.Bold;
                        run.FontSize = headerFontSize;

                        para.Inlines.Add(run);

                        if (t.Name.Trim().ToUpper() == "SPELLCASTING" || t.Name.Trim().ToUpper().Contains("SPELLCASTING"))
                        {
                            foreach (string spell in t.Text)
                            {
                                if (spell.Trim() == string.Empty)
                                {

                                }
                                else
                                {
                                    int split = spell.IndexOf("):") + 2;

                                    if (split > 1)
                                    {
                                        string head = spell.Substring(0, split);
                                        string list = spell.Substring(split, spell.Length - split);

                                        run = new Run(head);
                                        run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                                        run.FontWeight = FontWeights.Bold;
                                        run.FontSize = 10.5;

                                        para.Inlines.Add(run);

                                        run = new Run(list);
                                        run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                                        run.FontSize = textFontSize;

                                        para.Inlines.Add(run);
                                        para.Inlines.Add(new LineBreak());
                                    }
                                    else
                                    {
                                        run = new Run(spell);
                                        run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                                        run.FontSize = textFontSize;

                                        para.Inlines.Add(run);
                                        para.Inlines.Add(new LineBreak());
                                    }
                                }
                            }

                            para.Inlines.Add(new LineBreak());
                        }
                        else
                        {
                            run = new Run(String.Join(", ", t.Text));
                            run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                            run.FontSize = textFontSize;

                            para.Inlines.Add(run);
                            para.Inlines.Add(new LineBreak());
                        }
                    }

                    para.Inlines.Remove(para.Inlines.LastInline);

                    section.Blocks.Add(para);
                }

                //Actions Header
                para = new Paragraph(new Run("Actions"));
                para.Margin = new Thickness(5);
                para.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                para.FontSize = 22;
                para.FontWeight = FontWeights.SemiBold;

                section.Blocks.Add(para);

                AddDivider();

                //Creature Senses, immunities and Vulnerablities
                if (monster.Action != null && monster.Action.Count > 0)
                {
                    para = new Paragraph();
                    para.Margin = new Thickness(5);
                    para.LineHeight = lineHeight;

                    foreach (MonsterAction a in monster.Action)
                    {
                        run = new Run(a.Name + ". ");
                        run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                        run.FontStyle = FontStyles.Italic;
                        run.FontWeight = FontWeights.Bold;
                        run.FontSize = headerFontSize;

                        para.Inlines.Add(run);

                        //attack text
                        if (a.Name == "Lair Actions")
                        {
                            foreach (string action in a.Text)
                            {
                                string actionText = action;

                                if (actionText.Contains("\t"))
                                {
                                    actionText = action.Replace("\t", string.Empty);
                                }

                                run = new Run(actionText);
                                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                                run.FontSize = textFontSize;

                                para.Inlines.Add(run);
                                para.Inlines.Add(new LineBreak());
                            }
                        }
                        else
                        {
                            run = new Run(String.Join(", ", a.Text));
                            run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                            run.FontSize = textFontSize;

                            para.Inlines.Add(run);
                        }

                        //attack values
                        if (a.Attack != null)
                        {
                            run = new Run(String.Join(", ", a.Attack));
                            run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                            run.FontSize = textFontSize;

                            para.Inlines.Add(run);
                        }

                        para.Inlines.Add(new LineBreak());
                    }

                    section.Blocks.Add(para);
                }

                //Reactions
                if (monster.Reaction != null)
                {
                    //Reactions Header
                    para = new Paragraph(new Run("Reactions"));
                    para.Margin = new Thickness(5);
                    para.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                    para.FontSize = 22;
                    para.FontWeight = FontWeights.SemiBold;

                    section.Blocks.Add(para);

                    AddDivider();

                    para = new Paragraph();
                    para.Margin = new Thickness(5);
                    para.LineHeight = lineHeight;

                    run = new Run(monster.Reaction.Name + ". ");
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                    run.FontStyle = FontStyles.Italic;
                    run.FontWeight = FontWeights.Bold;
                    run.FontSize = headerFontSize;

                    para.Inlines.Add(run);

                    //reaction text
                    foreach (string s in monster.Reaction.Text)
                    {
                        run = new Run(s);
                        run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                        run.FontSize = textFontSize;

                        para.Inlines.Add(run);
                        para.Inlines.Add(new LineBreak());
                    }

                    //reaction attack values
                    if (monster.Reaction.Attack != null)
                    {
                        run = new Run(String.Join(", ", monster.Reaction.Attack));
                        run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                        run.FontSize = textFontSize;

                        para.Inlines.Add(run);
                    }

                    para.Inlines.Add(new LineBreak());
                    section.Blocks.Add(para);
                }

                //Legendary Actions
                if (monster.Legendary != null && monster.Legendary.Count > 0)
                {
                    //Reactions Header
                    para = new Paragraph(new Run("Lgendary Actions"));
                    para.Margin = new Thickness(5);
                    para.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                    para.FontSize = 22;
                    para.FontWeight = FontWeights.SemiBold;

                    section.Blocks.Add(para);

                    AddDivider();

                    foreach (MonsterLegendary l in monster.Legendary)
                    {
                        para = new Paragraph();
                        para.Margin = new Thickness(5);
                        para.LineHeight = lineHeight;

                        //legendary name
                        if (l.Name != null && l.Name != string.Empty)
                        {
                            run = new Run(l.Name + ". ");
                            run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                            run.FontStyle = FontStyles.Italic;
                            run.FontWeight = FontWeights.Bold;
                            run.FontSize = headerFontSize;

                            para.Inlines.Add(run);
                        }

                        //legendary text
                        run = new Run(l.Text);
                        run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                        run.FontSize = textFontSize;

                        para.Inlines.Add(run);

                        //legendar attack values
                        if (l.Attack != null)
                        {
                            run = new Run(l.Attack);
                            run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                            run.FontSize = textFontSize;

                            para.Inlines.Add(run);
                        }

                        section.Blocks.Add(para);
                    }
                }

                AddHeaderFooterLine();

                MonsterFlow.Blocks.Add(section);
                MonsterFlow.Blocks.LastBlock.BringIntoView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading information: " + ex.Message, "Load Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private string GetMonsterSize(Monster monster)
        {
            if (monster.Size != null)
            {
                switch (monster.Size.ToUpper())
                {
                    case "T":
                        return "Tiny";
                    case "S":
                        return "Small";
                    case "M":
                        return "Medium";
                    case "L":
                        return "Large";
                    case "H":
                        return "Huge";
                    case "G":
                        return "Gargantuan";
                    default:
                        return monster.Size;
                }
            }
            else
                return string.Empty;
        }

        /// <summary>
        /// Adds r basic line break to the stat block
        /// </summary>
        private void AddLineBreak()
        {
            section.Blocks.Add(new Paragraph(new LineBreak()));
        }

        /// <summary>
        /// Adds primary header or footer line to the stat block
        /// </summary>
        private void AddHeaderFooterLine()
        {
            Rectangle rect = new Rectangle();
            rect.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFE69A28"));
            rect.Height = 5;
            rect.Stroke = Brushes.Black;
            rect.StrokeThickness = 1;
            rect.VerticalAlignment = VerticalAlignment.Top;
            rect.Margin = new Thickness(0, 0, 1, 0);

            section.Blocks.Add(new BlockUIContainer(rect));
        }

        /// <summary>
        /// Adds the common seperator line to the statblock
        /// </summary>
        private void AddDivider()
        {
            //Common Line
            Line line = new Line();
            line.Stretch = Stretch.Fill;
            line.X1 = 0;
            line.X2 = 100;
            line.StrokeThickness = 4;
            line.StrokeEndLineCap = PenLineCap.Triangle;

            //Common Line Brush
            LinearGradientBrush lb = new LinearGradientBrush();

            lb.EndPoint = new Point(1, 0);
            lb.MappingMode = BrushMappingMode.RelativeToBoundingBox;
            lb.StartPoint = new Point(0.5, 0);

            //Common Line Brush Gradient Stop One
            GradientStop one = new GradientStop();
            one.Color = (Color)ColorConverter.ConvertFromString("#FF892323");
            one.Offset = 0;

            //Common Line Brush Gradient Stop Two
            GradientStop two = new GradientStop();
            two.Color = (Color)ColorConverter.ConvertFromString("#FFF19797");
            two.Offset = 1;

            lb.GradientStops.Add(one);
            lb.GradientStops.Add(two);

            line.Stroke = lb;

            //Divider
            section.Blocks.Add(new BlockUIContainer(line));
        }
    }
}
