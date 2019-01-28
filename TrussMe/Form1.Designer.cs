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
            this.bitBox = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.archExtraBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archHeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archWebBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archExtraBox)).BeginInit();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 749);
            this.Controls.Add(this.bitBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TrussMe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archHeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archWebBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archExtraBox)).EndInit();
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
    }
}

