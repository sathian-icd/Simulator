namespace Bosch
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            noOfTags = new TextBox();
            button1 = new Button();
            label1 = new Label();
            manualButton = new RadioButton();
            autoButton = new RadioButton();
            mode = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button2 = new Button();
            label2 = new Label();
            cycleTime = new TextBox();
            SuspendLayout();
            // 
            // noOfTags
            // 
            noOfTags.Location = new Point(365, 114);
            noOfTags.Margin = new Padding(2, 2, 2, 2);
            noOfTags.Name = "noOfTags";
            noOfTags.Size = new Size(106, 23);
            noOfTags.TabIndex = 0;
            noOfTags.Visible = false;
            noOfTags.TextChanged += noOfTags_TextChanged;
            // 
            // button1
            // 
            button1.ForeColor = Color.Purple;
            button1.Location = new Point(343, 159);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(83, 24);
            button1.TabIndex = 1;
            button1.Text = "NEXT";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(365, 97);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 3;
            label1.Text = "Number of Tags";
            label1.Visible = false;
            // 
            // manualButton
            // 
            manualButton.AutoSize = true;
            manualButton.Location = new Point(128, 90);
            manualButton.Margin = new Padding(2, 2, 2, 2);
            manualButton.Name = "manualButton";
            manualButton.Size = new Size(65, 19);
            manualButton.TabIndex = 6;
            manualButton.TabStop = true;
            manualButton.Text = "Manual";
            manualButton.UseVisualStyleBackColor = true;
            // 
            // autoButton
            // 
            autoButton.AutoSize = true;
            autoButton.Location = new Point(199, 90);
            autoButton.Margin = new Padding(2, 2, 2, 2);
            autoButton.Name = "autoButton";
            autoButton.Size = new Size(51, 19);
            autoButton.TabIndex = 7;
            autoButton.TabStop = true;
            autoButton.Text = "Auto";
            autoButton.UseVisualStyleBackColor = true;
            // 
            // mode
            // 
            mode.AutoSize = true;
            mode.Location = new Point(309, 79);
            mode.Margin = new Padding(2, 0, 2, 0);
            mode.Name = "mode";
            mode.Size = new Size(0, 15);
            mode.TabIndex = 8;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.FlatAppearance.BorderColor = Color.Goldenrod;
            button4.FlatAppearance.BorderSize = 0;
            button4.ForeColor = Color.Purple;
            button4.Location = new Point(98, 125);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(82, 24);
            button4.TabIndex = 9;
            button4.Text = "NEXT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.ForeColor = Color.Purple;
            button5.Location = new Point(527, 287);
            button5.Margin = new Padding(2, 11, 2, 0);
            button5.Name = "button5";
            button5.Size = new Size(82, 26);
            button5.TabIndex = 10;
            button5.Text = "ADD";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.ForeColor = Color.Purple;
            button6.Location = new Point(531, 361);
            button6.Margin = new Padding(2, 11, 2, 0);
            button6.Name = "button6";
            button6.Size = new Size(79, 23);
            button6.TabIndex = 11;
            button6.Text = "NEXT";
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(365, 114);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 23);
            textBox1.TabIndex = 12;
            textBox1.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(365, 97);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 13;
            label3.Text = "Cycle Time (sec)";
            label3.UseMnemonic = false;
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 255);
            label4.Margin = new Padding(2, 11, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 14;
            label4.Text = "Number of Tags";
            label4.Visible = false;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(277, 255);
            label5.Margin = new Padding(2, 11, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 15;
            label5.Text = "Datatype";
            label5.Visible = false;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(79, 56);
            label6.Name = "label6";
            label6.Size = new Size(159, 20);
            label6.TabIndex = 16;
            label6.Text = "Select Simulation Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(315, 58);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 17;
            label7.Text = "Enter Details";
            // 
            // button2
            // 
            button2.ForeColor = Color.Purple;
            button2.Location = new Point(532, 325);
            button2.Margin = new Padding(2, 11, 2, 0);
            button2.Name = "button2";
            button2.Size = new Size(77, 23);
            button2.TabIndex = 2;
            button2.Text = "NEXT";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(494, 97);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 4;
            label2.Text = "Cycle Time (sec)";
            label2.UseMnemonic = false;
            label2.Visible = false;
            // 
            // cycleTime
            // 
            cycleTime.Location = new Point(494, 114);
            cycleTime.Margin = new Padding(2);
            cycleTime.Name = "cycleTime";
            cycleTime.Size = new Size(106, 23);
            cycleTime.TabIndex = 5;
            cycleTime.Visible = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Purple;
            ClientSize = new Size(782, 574);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(mode);
            Controls.Add(autoButton);
            Controls.Add(manualButton);
            Controls.Add(cycleTime);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(noOfTags);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(2, 2, 2, 2);
            MinimumSize = new Size(398, 45);
            Name = "Form3";
            Text = "Simulator";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox noOfTags;
        private Button button1;
        private Label label1;
        private Button button3;
        private RadioButton manualButton;
        private RadioButton autoButton;
        private Label mode;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button2;
        private Label label2;
        private TextBox cycleTime;
    }
}