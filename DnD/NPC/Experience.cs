using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.NPC
{
    class Experience
    {
        public Dictionary<string, int> CR { get; private set; }

        public Experience()
        {
            LoadExp();
        }

        public string GetCR(int xp)
        {
            string cr = CR.FirstOrDefault(x => x.Value == xp).Key;

            if(cr == null)
            {
                //Get CR by next lowest XP value
                int low = int.MinValue;
               
                var lowValue =
                    from k in CR
                    where k.Value < xp
                    select k.Value;

                foreach(var l in lowValue)
                {
                    if (l > low)
                        low = l;
                }

                ////Get CR by next highest XP value
                //int high = int.MaxValue;

                //var highValue =
                //    from k in CR
                //    where k.Value > xp
                //    select k.Value;


                //foreach (var v in highValue)
                //{
                //    if (v < high)
                //        high = v;
                //}

                cr = CR.FirstOrDefault(x => x.Value == low).Key;
            }


            return cr;
        }

        public int GetXP(string cr)
        {
            return this.CR[cr];
        }

        private void LoadExp()
        {
            CR = new Dictionary<string, int>();

            CR.Add("00", 10);
            CR.Add("0", 10);
            CR.Add("1/8", 25);
            CR.Add("1/4", 50);
            CR.Add("1/2", 100);
            CR.Add("1", 200);
            CR.Add("2", 450);
            CR.Add("3", 700);
            CR.Add("4", 1100);
            CR.Add("5", 1800);
            CR.Add("6", 2300);
            CR.Add("7", 2900);
            CR.Add("8", 3900);
            CR.Add("9", 5000);
            CR.Add("10", 5900);
            CR.Add("11", 7200);
            CR.Add("12", 8400);
            CR.Add("13", 10000);
            CR.Add("14", 11500);
            CR.Add("15", 13000);
            CR.Add("16", 15000);
            CR.Add("17", 18000);
            CR.Add("18", 20000);
            CR.Add("19", 22000);
            CR.Add("20", 25000);
            CR.Add("21", 33000);
            CR.Add("22", 41000);
            CR.Add("23", 50000);
            CR.Add("24", 62000);
            CR.Add("25", 75000);
            CR.Add("26", 90000);
            CR.Add("27", 105000);
            CR.Add("28", 120000);
            CR.Add("29", 135000);
            CR.Add("30", 155000);
        }
    }
}


































