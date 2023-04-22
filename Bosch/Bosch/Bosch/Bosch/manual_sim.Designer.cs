namespace Bosch
{
    partial class manual_sim
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
            components = new System.ComponentModel.Container();
            label7 = new Label();
            label3 = new Label();
            mode = new Label();
            cycleTime = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            noOfTags = new TextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(84, 45);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 31;
            label7.Text = "Enter Details";
            label7.Click += label7_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 102);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 28;
            label3.UseMnemonic = false;
            label3.Visible = false;
            // 
            // mode
            // 
            mode.AutoSize = true;
            mode.Location = new Point(126, 80);
            mode.Margin = new Padding(2, 0, 2, 0);
            mode.Name = "mode";
            mode.Size = new Size(0, 15);
            mode.TabIndex = 24;
            // 
            // cycleTime
            // 
            cycleTime.Location = new Point(325, 119);
            cycleTime.Margin = new Padding(2);
            cycleTime.Name = "cycleTime";
            cycleTime.Size = new Size(146, 23);
            cycleTime.TabIndex = 23;
            cycleTime.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 102);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 22;
            label2.Text = "Cycle Time (sec)";
            label2.UseMnemonic = false;
            label2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 102);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 21;
            label1.Text = "Number of Tags";
            label1.Visible = false;
            // 
            // button1
            // 
            button1.ForeColor = Color.Purple;
            button1.Location = new Point(474, 204);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(83, 24);
            button1.TabIndex = 19;
            button1.Text = "NEXT";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // noOfTags
            // 
            noOfTags.Location = new Point(143, 119);
            noOfTags.Margin = new Padding(2);
            noOfTags.Name = "noOfTags";
            noOfTags.Size = new Size(147, 23);
            noOfTags.TabIndex = 18;
            noOfTags.Visible = false;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ShowAlways = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "tags";
            toolTip1.Popup += toolTip1_Popup_1;
            // 
            // manual_sim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 255);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(mode);
            Controls.Add(cycleTime);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(noOfTags);
            Name = "manual_sim";
            Text = "manual_sim";
            Load += manual_sim_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label3;
        private Label mode;
        private TextBox cycleTime;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox noOfTags;
        private ToolTip toolTip1;
    }
}