using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeSheet;

namespace TimeSheetWinforms
{
    public partial class Form1 : Form
    {
        bool weekChecked = true;
        TimeCard card = new TimeCard(new DateTime(2016, 7, 3));

      
        public Form1()
        {
            InitializeComponent();
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Date1Label.Text = "7/3/2016";
            Date2Label.Text = "7/4/2016";
            Date3Label.Text = "7/5/2016";
            Date4Label.Text = "7/6/2016";
            Date5Label.Text = "7/7/2016";
            Date6Label.Text = "7/8/2016";
            Date7Label.Text = "7/9/2016";
            weekChecked = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Date1Label.Text = "7/10/2016";
            Date2Label.Text = "7/11/2016";
            Date3Label.Text = "7/12/2016";
            Date4Label.Text = "7/13/2016";
            Date5Label.Text = "7/14/2016";
            Date6Label.Text = "7/15/2016";
            Date7Label.Text = "7/16/2016";
            weekChecked = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            TextBox[] RegularHours = new TextBox[] {Reg1, Reg2, Reg3, Reg4, Reg5, Reg6, Reg7};

            for(int r = 0; r < 6; r++)
            {
                card.SetHours(r, TimeSheet.Day.HourTypes.REGULAR, Double.Parse(RegularHours[r].Text));
            }

            TextBox[] SickHours = new TextBox[] { Sick1, Sick2, Sick3, Sick4, Sick5, Sick6, Sick7 };

            for (int s = 0; s < 6; s++)
            {
                card.SetHours(s, TimeSheet.Day.HourTypes.SICK, Double.Parse(SickHours[s].Text));
            }

            TextBox[] VacationHours = new TextBox[] { Vac1, Vac2, Vac3, Vac4, Vac5, Vac6, Vac7 };

            for (int v = 0; v < 6; v++)
            {
                card.SetHours(v, TimeSheet.Day.HourTypes.VACATION, Double.Parse(VacationHours[v].Text));
            }

            label12.Text = card.GetHours(TimeSheet.Day.HourTypes.REGULAR).ToString();
            label13.Text = card.GetHours(TimeSheet.Day.HourTypes.SICK).ToString();
            label14.Text = card.GetHours(TimeSheet.Day.HourTypes.VACATION).ToString();

            if(weekChecked == true)
            {
                label15.Text = card.CalculateOverTime()[0].ToString();
            }
            else
            {
                label15.Text = card.CalculateOverTime()[1].ToString();
            }
        }

    }
}
