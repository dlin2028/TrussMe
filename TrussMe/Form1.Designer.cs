namespace TrussMe
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.archHeightBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.archWebBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.archTrussBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox9 = new System.Windows.Forms.ListBox();
            this.bitBox = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archHeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archWebBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.archHeightBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.archWebBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.archTrussBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 477);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arch Parameters";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(146, 57);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(37, 17);
            this.label.TabIndex = 6;
            this.label.Text = "Height";
            this.label.UseCompatibleTextRendering = true;
            // 
            // archHeightBox
            // 
            this.archHeightBox.Location = new System.Drawing.Point(146, 86);
            this.archHeightBox.Name = "archHeightBox";
            this.archHeightBox.Size = new System.Drawing.Size(120, 20);
            this.archHeightBox.TabIndex = 5;
            this.archHeightBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.archHeightBox.ValueChanged += new System.EventHandler(this.archHeightBox_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Webs";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // archWebBox
            // 
            this.archWebBox.Location = new System.Drawing.Point(272, 86);
            this.archWebBox.Name = "archWebBox";
            this.archWebBox.Size = new System.Drawing.Size(120, 20);
            this.archWebBox.TabIndex = 3;
            this.archWebBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.archWebBox.ValueChanged += new System.EventHandler(this.archWebBox_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Truss";
            // 
            // archTrussBox
            // 
            this.archTrussBox.FormattingEnabled = true;
            this.archTrussBox.Items.AddRange(new object[] {
            "Howe",
            "Howe Reinforced",
            "Warren",
            "Pratt",
            "Pratt Reinforced",
            "Childs ",
            "Childs Reinforced"});
            this.archTrussBox.Location = new System.Drawing.Point(6, 57);
            this.archTrussBox.Name = "archTrussBox";
            this.archTrussBox.Size = new System.Drawing.Size(120, 95);
            this.archTrussBox.TabIndex = 1;
            this.archTrussBox.SelectedIndexChanged += new System.EventHandler(this.archTrussBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listBox4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.listBox5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.listBox6);
            this.groupBox2.Location = new System.Drawing.Point(462, 477);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 426);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spandrel Parameters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Deck Truss";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Items.AddRange(new object[] {
            "Howe (Single)",
            "Howe (Single 2)",
            "Warren",
            "Pratt",
            "Pratt Reinforced",
            "Childs ",
            "Childs Reinforced"});
            this.listBox4.Location = new System.Drawing.Point(6, 189);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(120, 95);
            this.listBox4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Deck-Arch Truss";
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Items.AddRange(new object[] {
            "Howe (Single)",
            "Howe (Single 2)",
            "Warren",
            "Pratt",
            "Pratt Reinforced",
            "Childs ",
            "Childs Reinforced"});
            this.listBox5.Location = new System.Drawing.Point(163, 57);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(120, 95);
            this.listBox5.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Arch Truss";
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.Items.AddRange(new object[] {
            "Howe (Single)",
            "Howe (Single 2)",
            "Warren",
            "Pratt",
            "Pratt Reinforced",
            "Childs ",
            "Childs Reinforced"});
            this.listBox6.Location = new System.Drawing.Point(6, 57);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(120, 95);
            this.listBox6.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.listBox7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.listBox8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.listBox9);
            this.groupBox3.Location = new System.Drawing.Point(947, 477);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(499, 426);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Deck Parameters";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Deck Truss";
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.Items.AddRange(new object[] {
            "Howe (Single)",
            "Howe (Single 2)",
            "Warren",
            "Pratt",
            "Pratt Reinforced",
            "Childs ",
            "Childs Reinforced"});
            this.listBox7.Location = new System.Drawing.Point(6, 189);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(120, 95);
            this.listBox7.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Deck-Arch Truss";
            // 
            // listBox8
            // 
            this.listBox8.FormattingEnabled = true;
            this.listBox8.Items.AddRange(new object[] {
            "Howe (Single)",
            "Howe (Single 2)",
            "Warren",
            "Pratt",
            "Pratt Reinforced",
            "Childs ",
            "Childs Reinforced"});
            this.listBox8.Location = new System.Drawing.Point(163, 57);
            this.listBox8.Name = "listBox8";
            this.listBox8.Size = new System.Drawing.Size(120, 95);
            this.listBox8.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Arch Truss";
            // 
            // listBox9
            // 
            this.listBox9.FormattingEnabled = true;
            this.listBox9.Items.AddRange(new object[] {
            "Howe (Single)",
            "Howe (Single 2)",
            "Warren",
            "Pratt",
            "Pratt Reinforced",
            "Childs ",
            "Childs Reinforced"});
            this.listBox9.Location = new System.Drawing.Point(6, 57);
            this.listBox9.Name = "listBox9";
            this.listBox9.Size = new System.Drawing.Size(120, 95);
            this.listBox9.TabIndex = 1;
            // 
            // bitBox
            // 
            this.bitBox.Location = new System.Drawing.Point(12, 12);
            this.bitBox.Name = "bitBox";
            this.bitBox.Size = new System.Drawing.Size(1434, 459);
            this.bitBox.TabIndex = 9;
            this.bitBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 915);
            this.Controls.Add(this.bitBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TrussMe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archHeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archWebBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox archTrussBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown archWebBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox9;
        private System.Windows.Forms.PictureBox bitBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.NumericUpDown archHeightBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

