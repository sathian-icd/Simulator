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
    public partial class Form3 : Form
    {

        public static int count = 0;
        public Form3()
        {
            InitializeComponent();

            manualButton.Checked = true;

        }

        private void noOfTags_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nooftags = int.Parse(noOfTags.Text);



            Label name = new Label();
            Label datatype = new Label();

            name.Text = "TagName";
            name.Location = new Point(137, 340);
            this.Controls.Add(name);
            datatype.Text = "DataType";
            datatype.Location = new Point(340, 340);
            this.Controls.Add(datatype);

            for (int i = 0; i < nooftags; i++)
            {
                TextBox textbox = new TextBox();
                textbox.Name = "textbox" + i.ToString();
                textbox.Size = new System.Drawing.Size(200, 75);
                textbox.Location = new Point(137, 380 + i * 50);
                this.Controls.Add(textbox);

                ComboBox comboBox = new ComboBox();
                comboBox.Name = "comboBox" + i.ToString();
                comboBox.Size = new System.Drawing.Size(200, 75);
                comboBox.Location = new Point(340, 380 + i * 50);
                comboBox.Items.Add("string");
                comboBox.Items.Add("int");
                comboBox.Items.Add("float");
                comboBox.Items.Add("boolean");
                this.Controls.Add(comboBox);


            }
            button2.Visible = true;
            button2.Location = new Point(137, 380 + nooftags * 50);
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
            Form2 form2 = new Form2(valuesName, valuesType, cycleTime.Text);
            form2.Show();
            this.Hide();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (manualButton.Checked == true)
            {
                noOfTags.Visible = true;
                cycleTime.Visible = true;
                button1.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                textBox1.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                mode.Text = manualButton.Text;
            }
            else if (autoButton.Checked == true)
            {
                noOfTags.Visible = false;
                cycleTime.Visible = false;
                button1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                textBox1.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                button5.Visible = true;
                button6.Visible = true;



                TextBox textbox = new TextBox();
                textbox.Name = "totalTags" + count.ToString();
                textbox.Size = new System.Drawing.Size(200, 75);
                textbox.Location = new Point(136, 380 + count * 50);
                this.Controls.Add(textbox);

                ComboBox comboBox = new ComboBox();
                comboBox.Name = "datatype" + count.ToString();
                comboBox.Size = new System.Drawing.Size(200, 75);
                comboBox.Location = new Point(340, 380 + count * 50);
                comboBox.Items.Add("string");
                comboBox.Items.Add("int");
                comboBox.Items.Add("float");
                comboBox.Items.Add("boolean");
                this.Controls.Add(comboBox);
                button6.Location = new Point(137, 430 + count * 50);
                count++;

                mode.Text = autoButton.Text;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            TextBox textbox = new TextBox();
            textbox.Name = "totalTags" + count.ToString();
            textbox.Size = new System.Drawing.Size(200, 75);
            textbox.Location = new Point(137, 380 + count * 50);
            this.Controls.Add(textbox);

            ComboBox comboBox = new ComboBox();
            comboBox.Name = "datatype" + count.ToString();
            comboBox.Size = new System.Drawing.Size(200, 75);
            comboBox.Location = new Point(340, 380 + count * 50);
            comboBox.Items.Add("string");
            comboBox.Items.Add("int");
            comboBox.Items.Add("float");
            comboBox.Items.Add("boolean");
            this.Controls.Add(comboBox);

            button5.Location = new Point(602, 380 + count * 50);
            button6.Location = new Point(137, 430 + count * 50);
            count++;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<int> valuesTags = new List<int>();
            List<string> valuesType = new List<string>();
            foreach (Control control in this.Controls)
            {

                if (control is TextBox || control is ComboBox)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;

                        if (textBox.Name.Contains("totalTags"))
                        {
                            valuesTags.Add(int.Parse(textBox.Text));
                        }
                    }
                    if (control is ComboBox)
                    {

                        ComboBox comboBox = (ComboBox)control;
                        if (comboBox.Name.Contains("datatype"))
                        {
                            valuesType.Add(comboBox.Text);
                        }
                    }

                }

            }

            Form2 form2 = new Form2(valuesTags, valuesType, textBox1.Text);
            form2.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


    }
}
