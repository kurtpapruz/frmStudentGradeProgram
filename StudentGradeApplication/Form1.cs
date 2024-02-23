using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            double eng = Convert.ToDouble(EnglishBox.Text);
            double math = Convert.ToDouble(MathBox.Text);
            double science = Convert.ToDouble(ScienceBox.Text);
            double fil = Convert.ToDouble(FilipinoBox.Text);
            double his = Convert.ToDouble(HistoryBox.Text);


            double avg = eng + math + science + fil + his ;

            double totalavg = avg / 5;

            result.Text = totalavg >= 75 ? name + ", " + "You Passed!!! \nYour Average is: " + totalavg 
                                         : name + ", " + "You Failed!!! \nYour Average is: " + totalavg;
            

        }

     
    }
}
