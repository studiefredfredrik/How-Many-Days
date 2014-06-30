using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace How_Many_Days
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDifference.Text = "";
        }

        private void btnGetDifference_Click(object sender, EventArgs e)
        {
            DateTime fromDate = monthCalendar1.SelectionStart;
            DateTime toDate = monthCalendar2.SelectionEnd;
            int daysPassed = 0;
            
            while(fromDate.Date != toDate.Date)
            {
                fromDate = fromDate.AddDays(1);
                daysPassed += 1;
                if (daysPassed > 900) break;
            }
            if (daysPassed != 901) lblDifference.Text = "The difference is: " + daysPassed + " days.";
            else lblDifference.Text = "Some error occured, sorry";
        }
    }
}
