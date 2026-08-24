namespace My_WebCrawler
{
    partial class FileTypeForm
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
            this.numericUpDownMaxSize = new System.Windows.Forms.NumericUpDown();
            this.textBoxTypeDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownMinSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinSize)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownMaxSize
            // 
            this.numericUpDownMaxSize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDownMaxSize.Location = new System.Drawing.Point(92, 75);
            this.numericUpDownMaxSize.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownMaxSize.Name = "numericUpDownMaxSize";
            this.numericUpDownMaxSize.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownMaxSize.TabIndex = 29;
            this.numericUpDownMaxSize.Tag = "";
            // 
            // textBoxTypeDescription
            // 
            this.textBoxTypeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTypeDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTypeDescription.Location = new System.Drawing.Point(12, 25);
            this.textBoxTypeDescription.Name = "textBoxTypeDescription";
            this.textBoxTypeDescription.Size = new System.Drawing.Size(272, 20);
            this.textBoxTypeDescription.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "MIME Type:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Minimum size:";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(300, 22);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 21;
            this.buttonOK.Text = "OK";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(300, 46);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Cancel";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Maimum size:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(164, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "(KB)";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(164, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "(KB)";
            // 
            // numericUpDownMinSize
            // 
            this.numericUpDownMinSize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDownMinSize.Location = new System.Drawing.Point(92, 51);
            this.numericUpDownMinSize.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownMinSize.Name = "numericUpDownMinSize";
            this.numericUpDownMinSize.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownMinSize.TabIndex = 28;
            this.numericUpDownMinSize.Tag = "";
            // 
            // FileTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 107);
            this.Controls.Add(this.numericUpDownMaxSize);
            this.Controls.Add(this.textBoxTypeDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownMinSize);
            this.Name = "FileTypeForm";
            this.Text = "FileTypeForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown numericUpDownMaxSize;
        public System.Windows.Forms.TextBox textBoxTypeDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown numericUpDownMinSize;

    }
}