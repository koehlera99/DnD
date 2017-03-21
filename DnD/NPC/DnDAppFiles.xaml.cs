using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Forms;
using System.Windows.Shapes;
using System.IO;


using System.Data;
using System.Windows.Xps.Packaging;

namespace DnD.NPC
{
    /// <summary>
    /// Interaction logic for DnDAppFiles.xaml
    /// </summary>
    public partial class DnDAppFiles : Window
    {
        public compendium MonsterList { get; set; }

        //public compendiumMonster Monster { get; set; }
        private Section section;

        public DnDAppFiles()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoadXML();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "DnDAppFiles\\Bestiary\\";
            LoadXML(path);
            cbFont.SelectedItem = new FontFamily("Calisto MT");
        }

        private void GenerateRandomList()
        {
            Random r = new Random();

            CreateDocument(MonsterList.monster[r.Next(0, MonsterList.monster.Count() - 1)]);
            CreateDocument(MonsterList.monster[r.Next(0, MonsterList.monster.Count() - 1)]);
            CreateDocument(MonsterList.monster[r.Next(0, MonsterList.monster.Count() - 1)]);
        }

        private void LoadXML(string folder = "")
        {
            MonsterList = DnDSerializer.GetMonsterCompendium();

            if(MonsterList != null)
            {
                GridMonster.ItemsSource = MonsterList.monster;
                listMonster.ItemsSource = MonsterList.monster;
                listMonster.DisplayMemberPath = "name";
            }

            //MonsterList = DnDSerializer.GetDnDXML(folder);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            //dlg.ShowNewFolderButton = false;
            //dlg.RootFolder = Environment.SpecialFolder.Personal;
            


            DialogResult r = dlg.ShowDialog();
         
            //Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            

            if(r == System.Windows.Forms.DialogResult.OK)
            {
                LoadXML(dlg.SelectedPath);
            }
            
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            StatBlockWindow w = new StatBlockWindow();
            //w.Compendium = DnDSerializer.GetDnDXML();
            //Array.Sort(w.Compendium.monster, delegate(compendiumMonster monster1, compendiumMonster monster2)
            //{
            //    return monster1.name.CompareTo(monster2.name);
            //});

            w.Monster = MonsterList.monster[GridMonster.SelectedIndex];
            //w.ItemNumber = GridMonster.SelectedIndex;
            w.Show();
        }

        private void chkMultipleMonsters_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnClearAll_Click(object sender, RoutedEventArgs e)
        {
            MainFlow.Blocks.Clear();
        }

        private void GridMonster_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //string s = GridMonster.CurrentCell.Item.ToString();
            if(chkMultipleMonsters.IsChecked == false)
                MainFlow.Blocks.Clear();

            CreateDocument((compendiumMonster)GridMonster.CurrentCell.Item);
        }

        private void listMonster_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (chkMultipleMonsters.IsChecked == false)
                MainFlow.Blocks.Clear();

            CreateDocument((compendiumMonster)listMonster.SelectedItem);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Print();
        }


        private void Print()
        {

            // Create a PrintDialog
            System.Windows.Controls.PrintDialog dlg = new System.Windows.Controls.PrintDialog();

            FlowDocument doc = MainFlowReader.Document;

            //doc.PageHeight = dlg.PrintableAreaHeight;
            //doc.PageWidth = dlg.PrintableAreaWidth;

            double w = doc.ColumnWidth;
            
            //doc.ColumnGap = 1;

            //IDocumentPaginatorSource idpSource = MainFlow;

            dlg.PrintDocument(((IDocumentPaginatorSource)doc).DocumentPaginator, "XPSPrint");


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















            //IDocumentPaginatorSource idpSource = MainFlow;

            //idpSource.DocumentPaginator.PageSize = pageSize;

            //dlg.PrintDocument(idpSource.DocumentPaginator, "XPSPrint");
            //dlg.PrintVisual(MainFlowReader, "XPSPrint");

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeFonts((FontFamily)cbFont.SelectedItem);
        }

        private void ChangeFonts(FontFamily font)
        {
            MainFlow.FontFamily = font;
        }

        
    }





}
