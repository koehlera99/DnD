using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using DnD.XML.Serialized;
using DnD.XML;

namespace DnD.NPC
{
    /// <summary>
    /// Interaction logic for MonsterViewer.xaml
    /// </summary>



    public partial class MonsterViewer : UserControl
    {
        public MonsterCompendium MonsterList { get; set; }
        public MonsterCompendium CustomMonsterList { get; set; }

        public MonsterViewer()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if(MonsterList == null)
            {
                LoadXML();
                MainFlowReader.cbFont.SelectedItem = new FontFamily("Calisto MT");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoadXML();
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

        private void chkMultipleMonsters_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnClearAll_Click(object sender, RoutedEventArgs e)
        {
            MainFlowReader.MonsterFlow.Blocks.Clear();
        }

        //private void GridMonster_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    //string s = GridMonster.CurrentCell.Item.ToString();
        //    if (chkMultipleMonsters.IsChecked == false)
        //        MainFlow.Blocks.Clear();

        //    Section section = CreateDocument((Monster)GridMonster.CurrentCell.Item);

        //    MainFlow.Blocks.Add(section);
        //    MainFlow.Blocks.LastBlock.BringIntoView();
        //}

        private void listMonster_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MainFlowReader.chkMultipleMonsters.IsChecked == false)
                MainFlowReader.MonsterFlow.Blocks.Clear();

            if(listMonster.SelectedItem.GetType() == typeof(Monster))
            {
                MainFlowReader.CreateDocument((Monster)listMonster.SelectedItem);

                //CreateDocument((Monster)listMonster.SelectedItem);


            }
        }

        private void LoadXML()
        {
            MonsterList = MonsterReadWrite.GetMonsterData();
            CustomMonsterList = MonsterReadWrite.GetCustomMonsterData();

            if (CustomMonsterList != null)
            {
                foreach (Monster m in CustomMonsterList.Monsters)
                {
                    MonsterList.Monsters.Add(m);
                }
            }

            //MonsterList.Monsters.Add(new Monster());

            if (MonsterList != null)
            {
                //GridMonster.ItemsSource = MonsterList.Monsters;
                listMonster.ItemsSource = MonsterList.Monsters;
                listMonster.DisplayMemberPath = "Name";
            }

            //MonsterList = MonsterSerializer.GetDnDXML(folder);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
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

            doc.PageHeight = 11;

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

        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    ChangeFonts((FontFamily)MainFlowReader.cbFont.SelectedItem);
        //}

        //private void ChangeFonts(FontFamily font)
        //{
        //    MainFlowReader.MonsterFlowReader.FontFamily = font;
        //}

        
    }
}
