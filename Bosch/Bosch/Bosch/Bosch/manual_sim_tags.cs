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
    public partial class manual_sim_tags : Form
    {
        public manual_sim_tags(TextBox noOfTags, TextBox CycleTime)
        {
            InitializeComponent();
            int nooftags = int.Parse(noOfTags.Text);



            Label name = new Label();
            Label datatype = new Label();

            name.Text = "TagName";
            name.Location = new Point(50, 42);
            this.Controls.Add(name);
            datatype.Text = "DataType";
            datatype.Location = new Point(300, 42);
            this.Controls.Add(datatype);

            for (int i = 0; i < nooftags; i++)
            {
                TextBox textbox = new TextBox();
                textbox.Name = "textbox" + i.ToString();
                textbox.Size = new System.Drawing.Size(200, 75);
                textbox.Location = new Point(50, 110 + i * 50);
                this.Controls.Add(textbox);

                ComboBox comboBox = new ComboBox();
                comboBox.Name = "comboBox" + i.ToString();
                comboBox.Size = new System.Drawing.Size(200, 75);
                comboBox.Location = new Point(300, 110 + i * 50);
                comboBox.Items.Add("string");
                comboBox.Items.Add("int");
                comboBox.Items.Add("float");
                comboBox.Items.Add("boolean");
                this.Controls.Add(comboBox);


            }
            CycleTimev = CycleTime;
            button2.Visible = true;
            button2.Location = new Point(75, 110 + nooftags * 50);
        }

        private void manual_sim_tags_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> valuesName = new List<string>();
            List<string> valuesType = new List<string>();
            foreach (Control control in this.Controls)
            {

                if (control is TextBox || control is ComboBox)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;

                        if (textBox.Name.Contains("textbox"))
                        {
                            valuesName.Add(textBox.Text);
                        }
                    }
                    if (control is ComboBox)
                    {

                        ComboBox comboBox = (ComboBox)control;
                        if (comboBox.Name.Contains("comboBox"))
                        {
                            valuesType.Add(comboBox.Text);
                        }
                    }

                }

            }
            Form2 form2 = new Form2(valuesName, valuesType, CycleTimev.Text);
            form2.Show();
            this.Hide();

        }
    }
}
