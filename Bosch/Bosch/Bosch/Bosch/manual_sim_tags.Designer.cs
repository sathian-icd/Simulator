﻿namespace Bosch
{
    partial class manual_sim_tags
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
            button2 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.ForeColor = Color.Purple;
            button2.Location = new Point(466, 42);
            button2.Margin = new Padding(2, 11, 2, 0);
            button2.Name = "button2";
            button2.Size = new Size(79, 23);
            button2.TabIndex = 12;
            button2.Text = "NEXT";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // manual_sim_tags
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 332);
            Controls.Add(button2);
            Name = "manual_sim_tags";
            Text = "manual_sim_tags";
            Load += manual_sim_tags_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private TextBox CycleTimev;
    }
}