using System;
using System.Linq;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Shapes;
using DnD.XML.Serialized;
using DnD.XML;

namespace DnD.DnDAppClasses
{
    /// <summary>
    /// Interaction logic for FlowDocumentReaderMain.xaml
    /// </summary>
    public partial class FlowDocumentReaderMain : Window
    {
        public Monster Monster { get; set; }
        private MonsterCompendium MonsterList { get; set; }
        private Section section;

        public FlowDocumentReaderMain()
        {
            InitializeComponent();
        }

        private void Section_Loaded(object sender, RoutedEventArgs e)
        {
            Random();

        }

        private void Random()
        {
            Random r = new Random();

            LoadXML();

            Monster = MonsterList.Monsters[r.Next(0, MonsterList.Monsters.Count() - 1)];
            CreateDocument();

            Monster = MonsterList.Monsters[r.Next(0, MonsterList.Monsters.Count() - 1)];
            CreateDocument(true);

            Monster = MonsterList.Monsters[r.Next(0, MonsterList.Monsters.Count() - 1)];
            CreateDocument(true);
        }

        private void LoadXML()
        {
            MonsterList = MonsterReadWrite.GetMonsterData();
        }

        private string GetMonsterSize()
        {
            switch (Monster.Size.ToUpper())
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
                    return Monster.Size;
            }
        }

        public void CreateDocument(bool pageBreak = false)
        {
            section = new Section();
            section.BreakPageBefore = pageBreak;
            
            Paragraph para;
            Run run;
            
            AddHeaderFooterLine();

            para = new Paragraph(new Run(Monster.Name));
            para.Margin = new Thickness(5);
            para.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
            para.FontFamily = new FontFamily("Calisto MT");
            para.FontSize = 22;
            para.FontWeight = FontWeights.SemiBold;

            section.Blocks.Add(para);

            para = new Paragraph(new Run(GetMonsterSize() + " " + Monster.Type + ", " + Monster.Alignment));
            para.Margin = new Thickness(5);
            para.FontStyle = FontStyles.Italic;
            para.FontSize = 10;

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
            run.FontFamily = new FontFamily("Calisto MT");
            run.FontSize = 12;

            para.Inlines.Add(run);

            run = new Run(Monster.AC);
            run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
            run.FontFamily = new FontFamily("Calisto MT");
            run.FontSize = 10;

            para.Inlines.Add(run);
            para.Inlines.Add(new LineBreak());

            //HitPoints
            run = new Run("Hit Points: ");
            run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
            run.FontWeight = FontWeights.Bold;
            run.FontFamily = new FontFamily("Calisto MT");
            run.FontSize = 12;

            para.Inlines.Add(run);

            run = new Run(Monster.HP);
            run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
            run.FontFamily = new FontFamily("Calisto MT");
            run.FontSize = 10;

            para.Inlines.Add(run);
            para.Inlines.Add(new LineBreak());

            //Speed
            run = new Run("Speed: ");
            run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
            run.FontWeight = FontWeights.Bold;
            run.FontFamily = new FontFamily("Calisto MT");
            run.FontSize = 12;

            para.Inlines.Add(run);

            run = new Run(Monster.Speed);
            run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
            run.FontFamily = new FontFamily("Calisto MT");
            run.FontSize = 10;

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

            header.Style = (Style)MainFlow.Resources["statName"];
            statRow.Style = (Style)MainFlow.Resources["statNumber"];

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
            stat = Monster.Strength;

            bonus = (int)Decimal.Floor((stat - 10) / 2);
       
            if (bonus < 0)
                statBonusText = stat.ToString() + "(" + bonus.ToString() + ")";
            else
                statBonusText = stat.ToString() + "(+" + bonus.ToString() + ")";


            statRow.Cells.Add(new TableCell(new Paragraph(new Run(statBonusText))));

            //Dexterity
            stat = Monster.Dexterity;

            bonus = (int)Decimal.Floor((stat - 10) / 2);

            if (bonus < 0)
                statBonusText = stat.ToString() + "(" + bonus.ToString() + ")";
            else
                statBonusText = stat.ToString() + "(+" + bonus.ToString() + ")";


            statRow.Cells.Add(new TableCell(new Paragraph(new Run(statBonusText))));

            //Constitution
            stat = Monster.Constitution;

            bonus = (int)Decimal.Floor((stat - 10) / 2);

            if (bonus < 0)
                statBonusText = stat.ToString() + "(" + bonus.ToString() + ")";
            else
                statBonusText = stat.ToString() + "(+" + bonus.ToString() + ")";


            statRow.Cells.Add(new TableCell(new Paragraph(new Run(statBonusText))));

            //Intelligence
            stat = Monster.Intelligence;

            bonus = (int)Decimal.Floor((stat - 10) / 2);

            if (bonus < 0)
                statBonusText = stat.ToString() + "(" + bonus.ToString() + ")";
            else
                statBonusText = stat.ToString() + "(+" + bonus.ToString() + ")";


            statRow.Cells.Add(new TableCell(new Paragraph(new Run(statBonusText))));

            //Wisdom
            stat = Monster.Wisdom;

            bonus = (int)Decimal.Floor((stat - 10) / 2);

            if (bonus < 0)
                statBonusText = stat.ToString() + "(" + bonus.ToString() + ")";
            else
                statBonusText = stat.ToString() + "(+" + bonus.ToString() + ")";


            statRow.Cells.Add(new TableCell(new Paragraph(new Run(statBonusText))));

            //Charisma
            stat = Monster.Charisma;

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
            para.LineHeight = 16;

            //Saves
            if (Monster.Save != null && Monster.Save != string.Empty)
            {
                run = new Run("Saving Throws: ");
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                run.FontFamily = new FontFamily("Calisto MT");
                run.FontWeight = FontWeights.Bold;
                run.FontSize = 11;
                para.Inlines.Add(run);

                run = new Run(Monster.Save);
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                run.FontFamily = new FontFamily("Calisto MT");
                run.FontSize = 10;
                para.Inlines.Add(run);

                para.Inlines.Add(new LineBreak());
            }

            //Skills
            if (Monster.Skill != null && Monster.Skill != string.Empty)
            {
                run = new Run("Skills: ");
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                run.FontFamily = new FontFamily("Calisto MT");
                run.FontWeight = FontWeights.Bold;
                run.FontSize = 11;
                para.Inlines.Add(run);

                run = new Run(Monster.Skill);
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                run.FontFamily = new FontFamily("Calisto MT");
                run.FontSize = 10;
                para.Inlines.Add(run);

                para.Inlines.Add(new LineBreak());
            }

            //Resist
            if (Monster.Resist != null && Monster.Resist != string.Empty)
            {
                run = new Run("Resistances: ");
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                run.FontFamily = new FontFamily("Calisto MT");
                run.FontWeight = FontWeights.Bold;
                run.FontSize = 11;
                para.Inlines.Add(run);

                run = new Run(Monster.Resist);
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                run.FontFamily = new FontFamily("Calisto MT");
                run.FontSize = 10;
                para.Inlines.Add(run);

                para.Inlines.Add(new LineBreak());
            }

            //vulnerable
            if (Monster.Vulnerable != null && Monster.Vulnerable != string.Empty)
            {
                run = new Run("Vulnerabilities: ");
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                run.FontFamily = new FontFamily("Calisto MT");
                run.FontWeight = FontWeights.Bold;
                run.FontSize = 11;
                para.Inlines.Add(run);

                run = new Run(Monster.Vulnerable);
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                run.FontFamily = new FontFamily("Calisto MT");
                run.FontSize = 10;
                para.Inlines.Add(run);

                para.Inlines.Add(new LineBreak());
            }

            //Immunities
            if (Monster.Immune != null && Monster.Immune != string.Empty)
            {
                run = new Run("Immunities: ");
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                run.FontFamily = new FontFamily("Calisto MT");
                run.FontWeight = FontWeights.Bold;
                run.FontSize = 11;
                para.Inlines.Add(run);

                run = new Run(Monster.Immune);
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                run.FontFamily = new FontFamily("Calisto MT");
                run.FontSize = 10;
                para.Inlines.Add(run);

                para.Inlines.Add(new LineBreak());
            }

            //Condition Immunities
            if (Monster.ConditionImmune != null && Monster.ConditionImmune != string.Empty)
            {
                run = new Run("Immunities: ");
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                run.FontFamily = new FontFamily("Calisto MT");
                run.FontWeight = FontWeights.Bold;
                run.FontSize = 11;
                para.Inlines.Add(run);

                run = new Run(Monster.ConditionImmune);
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                run.FontFamily = new FontFamily("Calisto MT");
                run.FontSize = 10;
                para.Inlines.Add(run);

                para.Inlines.Add(new LineBreak());
            }

            //Senses
            if (Monster.Senses != null && Monster.Senses != string.Empty)
            {
                run = new Run("Senses: ");
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                run.FontFamily = new FontFamily("Calisto MT");
                run.FontWeight = FontWeights.Bold;
                run.FontSize = 11;
                para.Inlines.Add(run);

                run = new Run(Monster.Senses);
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                run.FontFamily = new FontFamily("Calisto MT");
                run.FontSize = 10;
                para.Inlines.Add(run);

                para.Inlines.Add(new LineBreak());
            }

            //languages
            if (Monster.Languages != null && Monster.Languages != string.Empty)
            {
                run = new Run("Languages: ");
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                run.FontFamily = new FontFamily("Calisto MT");
                run.FontWeight = FontWeights.Bold;
                run.FontSize = 11;
                para.Inlines.Add(run);

                run = new Run(Monster.Languages);
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                run.FontFamily = new FontFamily("Calisto MT");
                run.FontSize = 10;
                para.Inlines.Add(run);

                para.Inlines.Add(new LineBreak());
            }

            if (Monster.CR != null && Monster.CR != string.Empty)
            {
                run = new Run("experience: ");
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                run.FontFamily = new FontFamily("Calisto MT");
                run.FontWeight = FontWeights.Bold;
                run.FontSize = 11;
                para.Inlines.Add(run);

                run = new Run(Monster.CR);
                run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                run.FontFamily = new FontFamily("Calisto MT");
                run.FontSize = 10;
                para.Inlines.Add(run);

                //para.Inlines.Add(new LineBreak());
            }

            section.Blocks.Add(para);
            AddDivider();

            //Creature Traits
            if (Monster.Trait != null)
            {
                para = new Paragraph();
                para.Margin = new Thickness(5);
                para.LineHeight = 16;

                foreach (MonsterTrait t in Monster.Trait)
                {
                    run = new Run(t.Name + ". ");
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                    run.FontFamily = new FontFamily("Calisto MT");
                    run.FontWeight = FontWeights.Bold;
                    run.FontSize = 11;

                    para.Inlines.Add(run);

                    run = new Run(String.Join(", ", t.Text));
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                    run.FontFamily = new FontFamily("Calisto MT");
                    run.FontSize = 10;

                    para.Inlines.Add(run);
                    para.Inlines.Add(new LineBreak());
                }

                para.Inlines.Remove(para.Inlines.LastInline);
                
                section.Blocks.Add(para);
            }

            //Actions Header
            para = new Paragraph(new Run("Actions"));
            para.Margin = new Thickness(5);
            para.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
            para.FontFamily = new FontFamily("Calisto MT");
            para.FontSize = 22;
            para.FontWeight = FontWeights.SemiBold;

            section.Blocks.Add(para);

            AddDivider();

            //Creature Senses, immunities and Vulnerablities
            if (Monster.Action != null)
            {
                para = new Paragraph();
                para.Margin = new Thickness(5);
                para.LineHeight = 14;

                foreach (MonsterAction a in Monster.Action)
                {
                    run = new Run(a.Name + ". ");
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAC2F2F"));
                    run.FontFamily = new FontFamily("Calisto MT");
                    run.FontStyle = FontStyles.Italic;
                    run.FontWeight = FontWeights.Bold;
                    run.FontSize = 11;

                    para.Inlines.Add(run);

                    //attack text
                    run = new Run(String.Join(", ", a.Text));
                    run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                    run.FontFamily = new FontFamily("Calisto MT");
                    run.FontSize = 10;

                    para.Inlines.Add(run);

                    //attack values
                    if(a.Attack != null)
                    {
                        run = new Run(String.Join(", ", a.Attack));
                        run.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF000000"));
                        run.FontFamily = new FontFamily("Calisto MT");
                        run.FontSize = 10;

                        para.Inlines.Add(run);
                    }
                    
                    para.Inlines.Add(new LineBreak());
                }

                section.Blocks.Add(para);
            }

            AddHeaderFooterLine();
            MainFlow.Blocks.Add(section);
        }

        /// <summary>
        /// Adds a basic line break to the stat block
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
