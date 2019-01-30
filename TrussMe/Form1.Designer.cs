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
            this.label3 = new System.Windows.Forms.Label();
            this.archExtraBox = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            this.archHeightBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.archWebBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.archTrussBox = new System.Windows.Forms.ListBox();
            this.bitBox = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deckHeightBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.deckWebBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.deckTrussBox = new System.Windows.Forms.ListBox();
            this.thiccBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.extraDeckMembers = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.spandrelExtraMembers = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.spandrelWebBox = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.spandrelTrussBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archExtraBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archHeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archWebBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deckHeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckWebBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thiccBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraDeckMembers)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spandrelExtraMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spandrelWebBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.archExtraBox);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.archHeightBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.archWebBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.archTrussBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 477);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 260);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arch Parameters";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Extra Members";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // archExtraBox
            // 
            this.archExtraBox.Location = new System.Drawing.Point(146, 123);
            this.archExtraBox.Name = "archExtraBox";
            this.archExtraBox.Size = new System.Drawing.Size(120, 20);
            this.archExtraBox.TabIndex = 10;
            this.archExtraBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.archExtraBox.ValueChanged += new System.EventHandler(this.archExtraBox_ValueChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(146, 16);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(37, 17);
            this.label.TabIndex = 6;
            this.label.Text = "Height";
            this.label.UseCompatibleTextRendering = true;
            // 
            // archHeightBox
            // 
            this.archHeightBox.DecimalPlaces = 2;
            this.archHeightBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.archHeightBox.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.archHeightBox.Location = new System.Drawing.Point(146, 36);
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
            this.label2.Location = new System.Drawing.Point(146, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Webs";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // archWebBox
            // 
            this.archWebBox.Location = new System.Drawing.Point(146, 79);
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
            this.label1.Location = new System.Drawing.Point(6, 16);
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
            "Warren",
            "Pratt",
            "K-Truss"});
            this.archTrussBox.Location = new System.Drawing.Point(6, 32);
            this.archTrussBox.Name = "archTrussBox";
            this.archTrussBox.Size = new System.Drawing.Size(120, 95);
            this.archTrussBox.TabIndex = 1;
            this.archTrussBox.SelectedIndexChanged += new System.EventHandler(this.archTrussBox_SelectedIndexChanged);
            // 
            // bitBox
            // 
            this.bitBox.Location = new System.Drawing.Point(12, 12);
            this.bitBox.Name = "bitBox";
            this.bitBox.Size = new System.Drawing.Size(1170, 436);
            this.bitBox.TabIndex = 9;
            this.bitBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.extraDeckMembers);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.thiccBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.deckHeightBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.deckWebBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.deckTrussBox);
            this.groupBox2.Location = new System.Drawing.Point(320, 477);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 260);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deck Parameters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Height";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // deckHeightBox
            // 
            this.deckHeightBox.DecimalPlaces = 2;
            this.deckHeightBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.deckHeightBox.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.deckHeightBox.Location = new System.Drawing.Point(146, 36);
            this.deckHeightBox.Name = "deckHeightBox";
            this.deckHeightBox.Size = new System.Drawing.Size(120, 20);
            this.deckHeightBox.TabIndex = 5;
            this.deckHeightBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.deckHeightBox.ValueChanged += new System.EventHandler(this.deckHeightBox_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Webs";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // deckWebBox
            // 
            this.deckWebBox.Location = new System.Drawing.Point(146, 123);
            this.deckWebBox.Name = "deckWebBox";
            this.deckWebBox.Size = new System.Drawing.Size(120, 20);
            this.deckWebBox.TabIndex = 3;
            this.deckWebBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.deckWebBox.ValueChanged += new System.EventHandler(this.deckWebBox_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Truss";
            // 
            // deckTrussBox
            // 
            this.deckTrussBox.FormattingEnabled = true;
            this.deckTrussBox.Items.AddRange(new object[] {
            "Howe",
            "Warren",
            "Pratt",
            "K-Truss"});
            this.deckTrussBox.Location = new System.Drawing.Point(6, 32);
            this.deckTrussBox.Name = "deckTrussBox";
            this.deckTrussBox.Size = new System.Drawing.Size(120, 95);
            this.deckTrussBox.TabIndex = 1;
            this.deckTrussBox.SelectedIndexChanged += new System.EventHandler(this.deckTrussBox_SelectedIndexChanged);
            // 
            // thiccBox
            // 
            this.thiccBox.DecimalPlaces = 2;
            this.thiccBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.thiccBox.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.thiccBox.Location = new System.Drawing.Point(146, 79);
            this.thiccBox.Name = "thiccBox";
            this.thiccBox.Size = new System.Drawing.Size(120, 20);
            this.thiccBox.TabIndex = 11;
            this.thiccBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thiccBox.ValueChanged += new System.EventHandler(this.thiccBox_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Thicc";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // extraDeckMembers
            // 
            this.extraDeckMembers.Location = new System.Drawing.Point(146, 166);
            this.extraDeckMembers.Name = "extraDeckMembers";
            this.extraDeckMembers.Size = new System.Drawing.Size(120, 20);
            this.extraDeckMembers.TabIndex = 11;
            this.extraDeckMembers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.extraDeckMembers.ValueChanged += new System.EventHandler(this.extraDeckMembers_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Extra Members";
            this.label8.UseCompatibleTextRendering = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.spandrelExtraMembers);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.spandrelWebBox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.spandrelTrussBox);
            this.groupBox3.Location = new System.Drawing.Point(638, 477);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 260);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Spandrel Parameters";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(146, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Extra Members";
            this.label9.UseCompatibleTextRendering = true;
            // 
            // spandrelExtraMembers
            // 
            this.spandrelExtraMembers.Location = new System.Drawing.Point(146, 102);
            this.spandrelExtraMembers.Name = "spandrelExtraMembers";
            this.spandrelExtraMembers.Size = new System.Drawing.Size(120, 20);
            this.spandrelExtraMembers.TabIndex = 11;
            this.spandrelExtraMembers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spandrelExtraMembers.ValueChanged += new System.EventHandler(this.spandrelExtraMembers_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(144, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Webs";
            this.label12.UseCompatibleTextRendering = true;
            // 
            // spandrelWebBox
            // 
            this.spandrelWebBox.Location = new System.Drawing.Point(146, 36);
            this.spandrelWebBox.Name = "spandrelWebBox";
            this.spandrelWebBox.Size = new System.Drawing.Size(120, 20);
            this.spandrelWebBox.TabIndex = 3;
            this.spandrelWebBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spandrelWebBox.ValueChanged += new System.EventHandler(this.spandrelWebBox_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Truss";
            // 
            // spandrelTrussBox
            // 
            this.spandrelTrussBox.FormattingEnabled = true;
            this.spandrelTrussBox.Items.AddRange(new object[] {
            "Howe",
            "Warren",
            "Pratt",
            "K-Truss"});
            this.spandrelTrussBox.Location = new System.Drawing.Point(6, 32);
            this.spandrelTrussBox.Name = "spandrelTrussBox";
            this.spandrelTrussBox.Size = new System.Drawing.Size(120, 95);
            this.spandrelTrussBox.TabIndex = 1;
            this.spandrelTrussBox.SelectedIndexChanged += new System.EventHandler(this.spandrelTrussBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 749);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bitBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TrussMe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archExtraBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archHeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archWebBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deckHeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckWebBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thiccBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraDeckMembers)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spandrelExtraMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spandrelWebBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox archTrussBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown archWebBox;
        private System.Windows.Forms.PictureBox bitBox;
        private System.Windows.Forms.Label label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown archExtraBox;
        private System.Windows.Forms.NumericUpDown archHeightBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown deckHeightBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown deckWebBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox deckTrussBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown thiccBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown extraDeckMembers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown spandrelExtraMembers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown spandrelWebBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox spandrelTrussBox;
    }
}

