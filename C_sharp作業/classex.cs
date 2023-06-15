using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace C_sharp作業
{
    public class classex
    {
        
        //public  double ttmoney ;
        //public  double rate ;
        //public  double ptime;
        //public  double fpay;
        public static double ttmoney { get; set; }
        public static double rate { get; set; }
        public static double ptime { get; set; }
        public static double fpay { get; set; }

        void stu_sc()
        {

        }
        public static int guess_n;
        public static void guess_num()
        {
            Random random = new Random();
            guess_n = random.Next(1,101);
        }

    }
        public struct student_score
        {
            public string name { get; set; }
            public string ch_sc { get; set; }
            public string en_sc { get; set; }
            public string ma_sc { get; set; }
            public string na_sc { get; set; }

            public student_score(string name, string ch_sc, string en_sc, string ma_sc, string na_sc)
            {
                this.name = name;
                this.ch_sc = ch_sc;   
                this.en_sc = en_sc;
                this.ma_sc = ma_sc;
                this.na_sc = na_sc;

            }
            

        }
        public struct student_data
        {
        public string name;
        public string ch;
        public string en;
        public string ma;

            public student_data(string name, string ch, string en, string ma)
            {
                this.name = name;
                this.ch = ch;
                this.en = en;
                this.ma = ma;

            }
        }
    
}
