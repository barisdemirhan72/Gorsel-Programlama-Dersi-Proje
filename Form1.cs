using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takvim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displaDays();
        }
        private void displaDays()
        {
            DateTime now = DateTime.Now;
            DateTime startofthemonth = new DateTime(now.Year,now.Month,1);
            int days = DateTime.DaysInMonth(now.Year,now.Month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) +1 ;
            for(int i = 1; i< dayoftheweek ; i++) 
            {
                UserControlBlank ucblank = new UserControlBlank();
                gunler.Controls.Add(ucblank);
            }
        }
    }
}
