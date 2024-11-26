namespace Regression
{
    partial class BagWords
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblWords = new System.Windows.Forms.Label();
            this.btnWord2Vec = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadTrainingSet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(13)))));
            this.button2.Location = new System.Drawing.Point(299, 617);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 58);
            this.button2.TabIndex = 36;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(13)))));
            this.button1.Location = new System.Drawing.Point(12, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 58);
            this.button1.TabIndex = 35;
            this.button1.Text = "Display Words";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.ForeColor = System.Drawing.Color.White;
            this.lblWords.Location = new System.Drawing.Point(9, 588);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(53, 16);
            this.lblWords.TabIndex = 34;
            this.lblWords.Text = "Words: ";
            // 
            // btnWord2Vec
            // 
            this.btnWord2Vec.BackColor = System.Drawing.Color.Transparent;
            this.btnWord2Vec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWord2Vec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWord2Vec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(13)))));
            this.btnWord2Vec.Location = new System.Drawing.Point(12, 512);
            this.btnWord2Vec.Name = "btnWord2Vec";
            this.btnWord2Vec.Size = new System.Drawing.Size(542, 60);
            this.btnWord2Vec.TabIndex = 33;
            this.btnWord2Vec.Text = "Word to Vector";
            this.btnWord2Vec.UseVisualStyleBackColor = false;
            this.btnWord2Vec.Click += new System.EventHandler(this.btnWord2Vec_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(12, 133);
            this.txtFile.Multiline = true;
            this.txtFile.Name = "txtFile";
            this.txtFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFile.Size = new System.Drawing.Size(539, 373);
            this.txtFile.TabIndex = 32;
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.Transparent;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(13)))));
            this.btnPreview.Location = new System.Drawing.Point(376, 74);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(175, 53);
            this.btnPreview.TabIndex = 31;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(73, 105);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(82, 22);
            this.numericUpDown1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Files:";
            // 
            // btnLoadTrainingSet
            // 
            this.btnLoadTrainingSet.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadTrainingSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadTrainingSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadTrainingSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(13)))));
            this.btnLoadTrainingSet.Location = new System.Drawing.Point(12, 12);
            this.btnLoadTrainingSet.Name = "btnLoadTrainingSet";
            this.btnLoadTrainingSet.Size = new System.Drawing.Size(539, 52);
            this.btnLoadTrainingSet.TabIndex = 28;
            this.btnLoadTrainingSet.Text = "Load Training Set";
            this.btnLoadTrainingSet.UseVisualStyleBackColor = false;
            this.btnLoadTrainingSet.Click += new System.EventHandler(this.btnLoadTrainingSet_Click);
            // 
            // BagWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(554, 711);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWords);
            this.Controls.Add(this.btnWord2Vec);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadTrainingSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BagWords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BagWords";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Button btnWord2Vec;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadTrainingSet;
    }
}