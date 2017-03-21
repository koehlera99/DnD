using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace CSNext
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fPlayerCharacter frm = new fPlayerCharacter();
            frm.Show();
        }

        private void bSpells_Click(object sender, EventArgs e)
        {
            Spells frmSpells = new Spells();
            frmSpells.Show();
        }

        private void btnXMLSpells_Click(object sender, EventArgs e)
        {
            SpellBook xSpells = new SpellBook();
            xSpells.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MonsterManual ms = new MonsterManual();
            ms.Show();

        }
    }


//        public void vbstuff()
//        {




//    string file  = "C:pathtofile\\Spells.xml";

        
//        dgvXML.ColumnCount = 7;
//        //dgv.ColumnHeadersVisible = True

//        dgvXML.Columns[0].Name = "Name";
//        dgvXML.Columns[1].Name = "Level";
//        dgvXML.Columns[2].Name = "School";
//        dgvXML.Columns[3].Name = "Time";
//        dgvXML.Columns[4].Name = "Range";
//        dgvXML.Columns[5].Name = "Duration";
//        dgvXML.Columns[6].Name = "Description";

//        //dgvXML.ReadXml(s)
//        System.Xml.XmlDocument xmlDoc2;
//            XmlElement root;
//            XmlNodeList nodes;
//            string xmlFile;
//            DataTable dt = new DataTable();



//        dt.Columns.Add("Name");
//        dt.Columns.Add("Level");
//        dt.Columns.Add("School");
//        dt.Columns.Add("Time");
//        dt.Columns.Add("Range");
//        dt.Columns.Add("Duration");
//        dt.Columns.Add("Description");


//        xmlDoc2.Load(file);
//        root = xmlDoc2.DocumentElement;
//        nodes = root.SelectNodes("//spellbook/spell"); //The XMLPath
//        string[] xmlarray;
//        xmlarray = new string[6];


//        foreach (XmlNode node in nodes)
//        {

//            this.dgvXML.Rows.Add();
//            this.dgvXML.Rows[0].Cells[0].Value = node["name"].InnerText;
//            this.dgvXML.Rows[0].Cells[1].Value = node["level"].InnerText;
//            this.dgvXML.Rows[0].Cells[2].Value = node["school"].InnerText;
//            this.dgvXML.Rows[0].Cells[3].Value = node["time"].InnerText;
//            this.dgvXML.Rows[0].Cells[4].Value = node["range"].InnerText;
//            this.dgvXML.Rows[0].Cells[5].Value = node["duration"].InnerText;
//            this.dgvXML.Rows[0].Cells[6].Value = node["description"].InnerText;

//                        xmlarray[0] = node["name"].InnerText;
//            xmlarray[1] = node["level"].InnerText;
//            xmlarray[2] = node["school"].InnerText;
//            xmlarray[3] = node["time"].InnerText;
//            xmlarray[4] = node["range"].InnerText;
//            xmlarray[5] = node["duration"].InnerText;
//            xmlarray[6] = node["description"].InnerText;
//            dt.Rows.Add(xmlarray);
//        }



//            XDocument xdoc = new XDocument();
//            xdoc.load
//        Dim xdoc As XDocument = xdocument.Load(file)
//        Dim spells As IEnumerable(Of XElement) = xdocument.Elements()
//        // Read the entire XML

//        Dim reader As XmlReader = xdocument.CreateReader
//        Dim ds As DataSet = New DataSet


//        ds.ReadXml(reader)


//        Dim dataSet As DataSet = New DataSet
//        Dim dt2 As DataTable = New DataTable("spell")
//        dt2.Columns.Add("Name") //, Type.GetType("System.String"))
//        dt2.Columns.Add("Level", Type.GetType("System.String"))
//        dt2.Columns.Add("School", Type.GetType("System.String"))
//        dt2.Columns.Add("Time", Type.GetType("System.String"))
//        dt2.Columns.Add("Range", Type.GetType("System.String"))
//        dt2.Columns.Add("Duration", Type.GetType("System.String"))
//        dt2.Columns.Add("Description", Type.GetType("System.String"))
//        dataSet.Tables.Add(dt2)


//        Dim data As String
//        data = spells.ToString
//        tXml.Text = spells.ToString

//        For Each spell In spells
//            data = spell.ToString
//            tXml.Text = spell.ToString

//        Next spell
//        Dim xmlSR As System.IO.StringReader = New System.IO.StringReader(data)
//        dataSet.ReadXml(xmlSR, XmlReadMode.IgnoreSchema)

//        //Catch ex As Exception
//        //    MsgBox(ex.ToString)

//        //End Try
		
//        Public Class fCharacter

//    Dim player As New PC("Bob", "Bard", "Elf", 1)


//    Private Sub frmCharacter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
//        player.Level = 1

//        }

//    End Sub

//    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
//        Dim fxp As New fAddXP
//        fxp.ShowDialog()

//    End Sub

//    Private Sub cbRace_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRace.SelectedIndexChanged
//        
//    Private Sub ChooseStat()
//        tRStr.ReadOnly = False
//        tRDex.ReadOnly = False
//        tRCon.ReadOnly = False
//        tRInt.ReadOnly = False
//        tRWis.ReadOnly = False
//        tRCha.ReadOnly = False
//    End Sub

//    //Private Sub tRStr_TextChanged(sender As Object, e As EventArgs) Handles tRStr.TextChanged, tRDex.TextChanged, _
//    //tRCon.TextChanged, tRInt.TextChanged, tRWis.TextChanged, tRCha.TextChanged

//    //End Sub
//End Class

//Public Class PC
//    Public Property Name() As String
//    Public Property PClass() As String
//    Public Property Race() As String
//    Public Property Level() As Short
//    Public Property Eyes() As String
//    Public Property Hair() As String
//    Public Property Height() As String
//    Public Property Weight() As String
//    Private XP As Long
//    Private NextLevel(20) As Integer
//    Public Stats As Ability



//    Public Function GetXP() As Long
//        Return XP
//    End Function

//    Public Sub SetXP(ByVal AddXP As Long)
//        XP = XP + AddXP
//        If XP >= NextLevel(Level) Then
//            Level = Level + 1
//        End If
//    End Sub

//    Public Structure Ability
//        Private Str As Byte
//        Private Dex As Byte
//        Private Con As Byte
//        Private Int As Byte
//        Private Wis As Byte
//        Private Cha As Byte

//        Public Function GetStat(ByVal s As String) As Byte
//            Select Case s
//                Case "str"
//                    Return Str
//                Case "dex"
//                    Return Dex
//                Case "con"
//                    Return Con
//                Case "int"
//                    Return Int
//                Case "wis"
//                    Return Wis
//                Case "cha"
//                    Return Cha
//                Case Else
//                    Return 0
//            End Select
//        End Function

//        Public Sub SetStat(ByVal s As String, val As Byte)
//            Select Case s
//                Case "str"
//                    Str = val
//                Case "dex"
//                    Dex = val
//                Case "con"
//                    Con = val
//                Case "int"
//                    Int = val
//                Case "wis"
//                    Wis = val
//                Case "cha"
//                    Cha = val
//            End Select
//        End Sub

//        Public Sub SetStat(ByVal s As Byte, d As Byte, co As Byte, i As Byte, _
//                           w As Byte, ch As Byte)
//            Str = s
//            Dex = d
//            Con = co
//            Int = i
//            Wis = w
//            Cha = ch
//        End Sub


//        Public Function Modifier(ByVal s As Byte) As SByte
//            //Return (s - 10) / 2

//            Select Case s
//                Case 1
//                    Return -5
//                Case 2, 3
//                    Return -4
//                Case 4, 5
//                    Return -3
//                Case 6, 7
//                    Return -2
//                Case 8, 9
//                    Return -1
//                Case 10, 11
//                    Return 0
//                Case 12, 13
//                    Return 1
//                Case 14, 15
//                    Return 2
//                Case 16, 17
//                    Return 3
//                Case 18, 19
//                    Return 4
//                Case 20, 21
//                    Return 5
//                Case 22, 23
//                    Return 6
//                Case 24, 25
//                    Return 7
//                Case 26, 27
//                    Return 8
//                Case 28, 29
//                    Return 9
//                Case 30
//                    Return 10
//                Case Else
//                    Return 0
//            End Select
//        End Function

//        Public Function GetMod(ByVal s As String) As SByte
//            Return Modifier(GetStat(s))
//        End Function

//    End Structure

//    Public Enum Alignment
//        LG
//        NG
//        CG
//        LN
//        N
//        CN
//        LE
//        NE
//        CE
//    End Enum

//    Public Enum Gender
//        Male
//        Female
//    End Enum

//    Public Sub New(ByVal n As String, pc As String, pr As String, lvl As Short)
//        Name = n
//        PClass = pc
//        Race = pr
//        Level = lvl
//        NextLevel = New Integer() {0, 250, 950, 2250, 4750, 9500, 16000, 25000, 38000, 56000, _
//                                   77000, 96000, 120000, 150000, 190000, 230000, 280000, 330000, 390000, 460000}

//    End Sub



//End Class

//Public Class Initiative
//    Private Init As Integer
//    Private Name As String
//    Private HP As Integer
//    Private Conditions() As String

//End Class
//        }

//    }
}
