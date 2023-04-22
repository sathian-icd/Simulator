using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bosch
{
    public partial class manual_sim : Form
    {
        public manual_sim()
        {
            InitializeComponent();
            noOfTags.Visible = true;
            cycleTime.Visible = true;
            button1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void manual_sim_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            manual_sim_tags tags=new manual_sim_tags(noOfTags, cycleTime);
            tags.Show();
            this.Hide();
        }
    }
}
