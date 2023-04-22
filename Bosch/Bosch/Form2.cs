using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Label = System.Windows.Forms.Label;

namespace Bosch
{
    public partial class Form2 : Form
    {
        public static int row = 0;
        public static int column = 0;
        public static int col2 = 0;


        public Form2(List<int> valuesName, List<string> valuesType, string cycleTime)
        {
            InitializeComponent();
            int c = 0;
            string type = "";
            List<string> datatype = new List<string>();
            time.Text = cycleTime;
            for (int i = 0; i < valuesName.Count; i++)
            {
                for (int j = 0; j < valuesName[i]; j++)
                {
                    Label name = new Label();

                    name.Text = c.ToString();
                    name.Location = new Point(30 + c * 100, 30);
                    this.Controls.Add(name);
                    datatype.Add(valuesType[i]);
                    c++;
                }
            }

            for (int i = 0; i < datatype.Count; i++)
            {
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = int.Parse(time.Text) * 1000;

                timer.Tick += (sender, e) => Timer_Tick2(datatype, col2++ % datatype.Count);

                timer.Start();
            }

        }
        public Form2(List<string> valuesName, List<string> valuesType, string cycleTime)
        {

            InitializeComponent();

            time.Text = cycleTime;

            for (int i = 0; i < valuesName.Count; i++)
            {
                Label name = new Label();

                name.Text = valuesName[i];
                name.Location = new Point(30 + i * 100, 30);
                this.Controls.Add(name);

                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = int.Parse(time.Text) * 1000;

                timer.Tick += (sender, e) => Timer_Tick(column++ % valuesName.Count, valuesType);

                timer.Start();
            }

        }

        private void Timer_Tick2(List<string> valueType, int i)
        {

            Random random = new Random();
            string randomText = "";
            if (valueType[i] == "int")
            {
                randomText = random.Next(100).ToString();
            }
            else if (valueType[i] == "string")
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                randomText = new string(Enumerable.Repeat(chars, 5)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            }
            else if (valueType[i] == "float")
            {
                float number = (float)(random.NextDouble() * (10.0f - 1.0f) + 10.0f);
                randomText = Math.Round(number, 4).ToString();
            }
            else if (valueType[i] == "boolean")
            {
                bool randomBool = random.Next(2) == 0;
                randomText = randomBool.ToString();
            }
            Label label = new Label();
            label.Text = randomText;

            label.Location = new Point((30 + i * 100), 80 + row * 50);
            if (i == valueType.Count - 1)
            {
                row = row + 1;
            }
            label.AutoSize = true;
            this.Controls.Add(label);


        }


        private void Timer_Tick(int col, List<string> valueType)
        {
            Random random = new Random();
            string randomText = "";
            if (valueType[col] == "int")
            {
                randomText = random.Next(100).ToString();
            }
            else if (valueType[col] == "string")
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                randomText = new string(Enumerable.Repeat(chars, 5)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            }
            else if (valueType[col] == "float")
            {
                float number = (float)(random.NextDouble() * (10.0f - 1.0f) + 10.0f);
                randomText = Math.Round(number, 4).ToString();
            }
            else if (valueType[col] == "boolean")
            {
                bool randomBool = random.Next(2) == 0;
                randomText = randomBool.ToString();
            }
            Label label = new Label();
            label.Text = randomText;

            label.Location = new Point(30 + col * 100, 80 + row * 50);
            if (col == valueType.Count - 1)
            {
                row = row + 1;
            }
            label.AutoSize = true;
            this.Controls.Add(label);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {

        }
        static public int previousScrollPosition = 0;
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
