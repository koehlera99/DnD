using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;


namespace CSNext
{
    class CombineXML
    {


        public void CombineTables()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("PathToFile//Name.ext");

            DataTable combine = new DataTable();
            combine.Columns.Add("Names");
            combine.Columns.Add("Type");
            combine.Columns.Add("AC");
            combine.Columns.Add("HP");
            combine.Columns.Add("Speed");
            combine.Columns.Add("Str");
            combine.Columns.Add("Dex");
            combine.Columns.Add("Con");
            combine.Columns.Add("Int");
            combine.Columns.Add("Wis");
            combine.Columns.Add("Cha");
            combine.Columns.Add("Languages");
            combine.Columns.Add("Traits");
            combine.Columns.Add("Actions");
            combine.Columns.Add("EncounterBuilding");
            combine.Columns.Add("Level");
            combine.Columns.Add("XP");
            combine.Columns.Add("Customization");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {


                //tbl1.Rows[i]["newcol"] = tbl2.Rows[i]["newCol"];
                //tbl1.Rows[i]["date"] = tbl2.Rows[i]["date"];

                combine.Rows.Add();
                combine.Rows[i]["Names"] = ds.Tables[0].Rows[i][0];
                combine.Rows[i]["Type"] = ds.Tables[1].Rows[i][0];
                combine.Rows[i]["AC"] = ds.Tables[2].Rows[i][0];
                combine.Rows[i]["HP"] = ds.Tables[3].Rows[i][0];
                combine.Rows[i]["Speed"] = ds.Tables[4].Rows[i][0];
                combine.Rows[i]["Str"] = ds.Tables[5].Rows[i][0];
                combine.Rows[i]["Dex"] = ds.Tables[6].Rows[i][0];
                combine.Rows[i]["Con"] = ds.Tables[7].Rows[i][0];
                combine.Rows[i]["Int"] = ds.Tables[8].Rows[i][0];
                combine.Rows[i]["Wis"] = ds.Tables[9].Rows[i][0];
                combine.Rows[i]["Cha"] = ds.Tables[10].Rows[i][0];
                combine.Rows[i]["Languages"] = ds.Tables[11].Rows[i][0];
                combine.Rows[i]["Traits"] = ds.Tables[12].Rows[i][0];
                combine.Rows[i]["Actions"] = ds.Tables[13].Rows[i][0];
                combine.Rows[i]["EncounterBuilding"] = ds.Tables[14].Rows[i][0];
                combine.Rows[i]["Level"] = ds.Tables[15].Rows[i][0];
                combine.Rows[i]["XP"] = ds.Tables[16].Rows[i][0];
                combine.Rows[i]["Customization"] = ds.Tables[17].Rows[i][0];
            }

            combine.TableName = "Monsters";

            using (Stream fstream = new FileStream("NewMonster2.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                combine.WriteXml(fstream);
            }
        }
        
    }
}
