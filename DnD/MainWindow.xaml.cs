using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using DnD.OOTA;
using DnD.Campaign;
using DnD.XML;
using DnD.XML.Serialized;
using System.Windows.Data;
using System.Collections.Generic;
using System.Linq;

namespace DnD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MonsterCompendium MonsterList { get; set; }
        public MonsterCompendium FilteredMonsterList { get; set; }
        public MonsterCompendium CustomMonsterList { get; set; }

        private bool supress = false;
        private Monster customMonster;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (MonsterList == null)
            {
                LoadXML();
                MainFlowReader.cbFont.SelectedItem = new FontFamily("Calisto MT");
            }
        }

        private void btnCharacterSheet_Click(object sender, RoutedEventArgs e)
        {
            CharacterSheet f = new CharacterSheet();
            f.Show();
        }

        private void btnOOTAEncounterGen_Click(object sender, RoutedEventArgs e)
        {
            frmDarklakeRandomEncounters f = new OOTA.frmDarklakeRandomEncounters();
            f.Show();
        }

        private void btnNPC_Click(object sender, RoutedEventArgs e)
        {
            NPC.Monsters w = new NPC.Monsters();
            w.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dlg = new System.Windows.Forms.FolderBrowserDialog();

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.XMLFileLocation = dlg.SelectedPath;
                LoadXML();

                if (MonsterList == null)
                    Properties.Settings.Default.XMLFileLocation = string.Empty;

                Properties.Settings.Default.Save();
            }
        }

        private void LoadXML()
        {
            //MonsterList = MonsterReadWrite.GetEmbeddedMonsterXML();
            //CustomMonsterList = MonsterReadWrite.GetEmbeddedMonsterXML();

            MonsterList = MonsterReadWrite.GetMonsterData();
            CustomMonsterList = MonsterReadWrite.GetCustomMonsterData();

            if (CustomMonsterList != null)
            {
                foreach (Monster m in CustomMonsterList.Monsters)
                {
                    MonsterList.Monsters.Add(m);
                }
            }

            MonsterList.Monsters.Sort((x, y) => x.Name.CompareTo(y.Name));


            if (MonsterList != null)
            {
                listMonster.ItemsSource = MonsterList.Monsters;
                listMonster.DisplayMemberPath = "Name";
            }
        }

        private void listMonster_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listMonster.SelectedItem != null && listMonster.SelectedItem.GetType() == typeof(Monster))
            {
                Monster monster = (Monster)listMonster.SelectedItem;

                MainFlowReader.CreateDocument(monster);
                LoadCustomMonster(monster);
            }
        }

        private void LoadCustomMonster(Monster monster)
        {
            supress = true;

            customMonster = monster.Copy();

            txtName.Text = customMonster.Name;
            txtSize.Text = customMonster.Size;
            txtType.Text = customMonster.Type;
            txtAlignment.Text = customMonster.Alignment;
            txtAC.Text = customMonster.AC;
            txtHP.Text = customMonster.HP;
            txtSpeed.Text = customMonster.Speed;
            txtSave.Text = customMonster.Save;
            txtSkill.Text = customMonster.Skill;
            txtResist.Text = customMonster.Resist;
            txtVulnerable.Text = customMonster.Vulnerable;
            txtImmune.Text = customMonster.Immune;
            txtConditionImmune.Text = customMonster.ConditionImmune;
            txtSenses.Text = customMonster.Senses;
            txtPassive.Text = customMonster.Passive.ToString();
            txtLanguages.Text = customMonster.Languages;
            txtCR.Text = customMonster.CR;
            txtSpells.Text = customMonster.Spells;

            //TraitsGrid.ItemsSource = customMonster.Trait;
            //ActionsGrid.ItemsSource = customMonster.Action;
            //LegendaryGrid.ItemsSource = customMonster.Legendary;

            CustomFlowReader.CreateDocument(customMonster);

            supress = false;
        }

        private void CustomText_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!supress)
            {
                customMonster.Name = txtName.Text;
                customMonster.Size = txtSize.Text;
                customMonster.Type = txtType.Text;
                customMonster.Alignment = txtAlignment.Text;
                customMonster.AC = txtAC.Text;
                customMonster.HP = txtHP.Text;
                customMonster.Speed = txtSpeed.Text;
                customMonster.Save = txtSave.Text;
                customMonster.Skill = txtSkill.Text;
                customMonster.Resist = txtResist.Text;
                customMonster.Vulnerable = txtVulnerable.Text;
                customMonster.Immune = txtImmune.Text;
                customMonster.ConditionImmune = txtConditionImmune.Text;
                customMonster.Senses = txtSenses.Text;
                customMonster.Passive = byte.Parse(txtPassive.Text);
                customMonster.Languages = txtLanguages.Text;
                customMonster.CR = txtCR.Text;
                customMonster.Spells = txtSpells.Text;

                CustomFlowReader.CreateDocument(customMonster);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (CustomMonsterList == null)
                CustomMonsterList = new MonsterCompendium();

            CustomMonsterList.Monsters.Add(customMonster);

            if (MonsterReadWrite.WriteMonsterData(CustomMonsterList))
            {
                MessageBox.Show("Custom customMonster saved as: " + customMonster.Name, "Custom Monster Saved", MessageBoxButton.OK, MessageBoxImage.Information);
                LoadXML();
            }
        }


        #region Random
        private void Random()
        {
            //Random r = new Random();

            //LoadXML();
            //MonsterCompendium Monster = MonsterList.Monsters[r.Next(0, MonsterList.Monsters.Count() - 1)];
            //CreateDocument();

            //Monster = MonsterList.Monsters[r.Next(0, MonsterList.Monsters.Count() - 1)];
            //CreateDocument(true);

            //Monster = MonsterList.Monsters[r.Next(0, MonsterList.Monsters.Count() - 1)];
            //CreateDocument(true);
        }
        #endregion

        private void MenuPrint_Click(object sender, RoutedEventArgs e)
        {
            Print();
        }

        private void Print()
        {

            // Create a PrintDialog
            System.Windows.Controls.PrintDialog dlg = new System.Windows.Controls.PrintDialog();

            FlowDocument doc = MainFlowReader.MonsterFlowReader.Document;

            
            //doc.PageHeight = dlg.PrintableAreaHeight;
            //doc.PageWidth = dlg.PrintableAreaWidth;

            double w = doc.ColumnWidth;

            //doc.ColumnGap = 1;

            //IDocumentPaginatorSource idpSource = MainFlow;

            dlg.PrintDocument(((IDocumentPaginatorSource)doc).DocumentPaginator, "XPSPrint");

            
            //MainFlowReader.MonsterFlowReader.Print();


            //var pageSize = new Size(8.26 * 96, 11.69 * 96); // A4 page, at 96 dpi
            //var document = new FixedDocument();
            //document.DocumentPaginator.PageSize = pageSize;

            //// Create FixedPage
            //var fixedPage = new FixedPage();
            //fixedPage.Width = pageSize.Width;
            //fixedPage.Height = pageSize.Height;
            //// Add visual, measure/arrange page.
            //fixedPage.Children.Add((UIElement)MainFlow);
            //fixedPage.Measure(pageSize);
            //fixedPage.Arrange(new Rect(new Point(), pageSize));
            //fixedPage.UpdateLayout();

            //// Add page to document
            //var pageContent = new PageContent();
            //((System.Windows.Markup.IAddChild)pageContent).AddChild(fixedPage);
            //document.Pages.Add(pageContent);

            //// Send to the printer.
            //var pd = new System.Windows.Controls.PrintDialog();
            //pd.PrintDocument(document.DocumentPaginator, "My Document");

            //IDocumentPaginatorSource idpSource = MainFlow;
            //System.Windows.Controls.PrintDialog dlg = new System.Windows.Controls.PrintDialog();
            //// create a document
            //FixedDocument document = new FixedDocument();
            //document.DocumentPaginator.PageSize = new Size(dlg.PrintableAreaWidth, dlg.PrintableAreaHeight);

            //for (int i = 1; i < idpSource.DocumentPaginator.PageCount; i++)
            //{





            //    // create a page
            //    FixedPage page1 = new FixedPage();
            //    page1.Width = document.DocumentPaginator.PageSize.Width;
            //    page1.Height = document.DocumentPaginator.PageSize.Height;


            //    // add some text to the page
            //    TextBlock page1Text = new TextBlock();
            //    page1Text.Text = "This is the first page";
            //    page1Text.FontSize = 40; // 30pt text
            //    page1Text.Margin = new Thickness(96); // 1 inch margin
            //    //page1.Children.Add((UIElemnt)idpSource.DocumentPaginator.GetPage(i).Visual);
            //    // add the page to the document

            //    PageContent page1Content = new PageContent();
            //    //page1Content = (PageContent)idpSource.DocumentPaginator.GetPage(i);



            //    ((System.Windows.Markup.IAddChild)page1Content).AddChild(idpSource.DocumentPaginator.GetPage(i));
            //    document.Pages.Add(page1Content);


            //    i++;

            //    // do the same for the second page
            //    FixedPage page2 = new FixedPage();
            //    page2.Width = document.DocumentPaginator.PageSize.Width;
            //    page2.Height = document.DocumentPaginator.PageSize.Height;



            //    //TextBlock page2Text = new TextBlock();
            //    //page2Text.Text = "This is NOT the first page";
            //    //page2Text.FontSize = 40;
            //    //page2Text.Margin = new Thickness(96);
            //    //page2.Children.Add(page2Text);
            //    PageContent page2Content = new PageContent();
            //    ((System.Windows.Markup.IAddChild)page2Content).AddChild(idpSource.DocumentPaginator.GetPage(i));
            //    document.Pages.Add(page2Content);
            //    // and print
            //    dlg.PrintDocument(document.DocumentPaginator, "My first document");
            //}




            //System.Windows.Controls.PrintDialog dlg = new System.Windows.Controls.PrintDialog();

            //// create a document
            //FixedDocument document = new FixedDocument();
            //document.DocumentPaginator.PageSize = new Size(dlg.PrintableAreaWidth, dlg.PrintableAreaHeight);

            //// create a page
            //FixedPage page1 = new FixedPage();
            //page1.Width = document.DocumentPaginator.PageSize.Width;
            //page1.Height = document.DocumentPaginator.PageSize.Height;

            //// add some text to the page
            //TextBlock page1Text = new TextBlock();
            //page1Text.Text = "This is the first page";
            //page1Text.FontSize = 40; // 30pt text
            //page1Text.Margin = new Thickness(96); // 1 inch margin
            //page1.Children.Add(page1Text);
            //// add the page to the document
            //PageContent page1Content = new PageContent();
            //((System.Windows.Markup.IAddChild)page1Content).AddChild(page1);
            //document.Pages.Add(page1Content);

            //// do the same for the second page
            //FixedPage page2 = new FixedPage();
            //page2.Width = document.DocumentPaginator.PageSize.Width;
            //page2.Height = document.DocumentPaginator.PageSize.Height;
            //TextBlock page2Text = new TextBlock();
            //page2Text.Text = "This is NOT the first page";
            //page2Text.FontSize = 40;
            //page2Text.Margin = new Thickness(96);
            //page2.Children.Add(page2Text);
            //PageContent page2Content = new PageContent();
            //((System.Windows.Markup.IAddChild)page2Content).AddChild(page2);
            //document.Pages.Add(page2Content);
            //// and print
            //dlg.PrintDocument(document.DocumentPaginator, "My first document");




            //IDocumentPaginatorSource idpSource = MainFlow;
            //System.Windows.Controls.PrintDialog dlg = new System.Windows.Controls.PrintDialog();
            //// create a document



            //if ((bool)dlg.ShowDialog().GetValueOrDefault())
            //{
            //    for (int i = 0; i < MainFlowReader.Document.Blocks.Count - 1; i++)
            //    {
            //        MainFlowReader.Document.Blocks.ElementAt(i).BringIntoView();

            //        Size pageSize = new Size(dlg.PrintableAreaWidth, dlg.PrintableAreaHeight);
            //        MainFlowReader.Measure(pageSize);
            //        MainFlowReader.Arrange(new Rect(5, 5, pageSize.Width, pageSize.Height));

            //        dlg.PrintVisual(MainFlowReader, "XPSPrint" + i.ToString());
            //    }

            //   // dlg.PrintVisual(MainFlowReader, "XPSPrint");

            //}

        }

        private void txtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<string> res = new List<string>();

            var r = from m in MonsterList.Monsters
                    where m.Type.Contains(txtFilter.Text)
                    select m;

            FilteredMonsterList = new MonsterCompendium();

            foreach (var item in r)
            {
                FilteredMonsterList.Monsters.Add(item);
            }

            
            if(FilteredMonsterList.Monsters.Count > 0)
                listMonster.ItemsSource = FilteredMonsterList.Monsters;
            else
                listMonster.ItemsSource = MonsterList.Monsters;




        }
    }

    public class AddConverter : DependencyObject, IMultiValueConverter
    {
        public int test = 0; 

        public object Parameter
        {
            get { return (object)GetValue(ParameterProperty); }
            set { SetValue(ParameterProperty, value); }
        }

        public static readonly DependencyProperty ParameterProperty =
            DependencyProperty.Register("Parameter", typeof(object), typeof(AddConverter), new PropertyMetadata(null));

        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            test++;

            string result = "";

            List<string> list;

            for(int i = 0; i < values.Length; i++)
            {
                list = values[i] as List<string>;

                if(list != null)
                {
                    foreach (string s in list)
                    {
                        result += s;
                    }
                }
            }

            return result;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException("Cannot convert back");
        }
    }
}

