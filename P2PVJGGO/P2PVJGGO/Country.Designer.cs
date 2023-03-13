namespace P2PVJGGO
{
    partial class Country
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
            this.grpCountryInfo = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.lblCapital = new System.Windows.Forms.Label();
            this.txtLang = new System.Windows.Forms.TextBox();
            this.lblLang = new System.Windows.Forms.Label();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.grpCountryInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCountryInfo
            // 
            this.grpCountryInfo.Controls.Add(this.numericUpDown1);
            this.grpCountryInfo.Controls.Add(this.lblPopulation);
            this.grpCountryInfo.Controls.Add(this.txtCurrency);
            this.grpCountryInfo.Controls.Add(this.lblCurrency);
            this.grpCountryInfo.Controls.Add(this.txtLang);
            this.grpCountryInfo.Controls.Add(this.lblLang);
            this.grpCountryInfo.Controls.Add(this.txtCapital);
            this.grpCountryInfo.Controls.Add(this.lblCapital);
            this.grpCountryInfo.Controls.Add(this.txtName);
            this.grpCountryInfo.Controls.Add(this.lblName);
            this.grpCountryInfo.Location = new System.Drawing.Point(13, 13);
            this.grpCountryInfo.Name = "grpCountryInfo";
            this.grpCountryInfo.Size = new System.Drawing.Size(545, 224);
            this.grpCountryInfo.TabIndex = 0;
            this.grpCountryInfo.TabStop = false;
            this.grpCountryInfo.Text = "Información del País";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(183, 29);
            this.txtName.MaxLength = 60;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(356, 31);
            this.txtName.TabIndex = 1;
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(183, 66);
            this.txtCapital.MaxLength = 60;
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(356, 31);
            this.txtCapital.TabIndex = 3;
            // 
            // lblCapital
            // 
            this.lblCapital.AutoSize = true;
            this.lblCapital.Location = new System.Drawing.Point(7, 68);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(96, 26);
            this.lblCapital.TabIndex = 2;
            this.lblCapital.Text = "Capital";
            // 
            // txtLang
            // 
            this.txtLang.Location = new System.Drawing.Point(183, 103);
            this.txtLang.MaxLength = 60;
            this.txtLang.Name = "txtLang";
            this.txtLang.Size = new System.Drawing.Size(356, 31);
            this.txtLang.TabIndex = 5;
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(7, 105);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(84, 26);
            this.lblLang.TabIndex = 4;
            this.lblLang.Text = "Idioma";
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(183, 140);
            this.txtCurrency.MaxLength = 60;
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(356, 31);
            this.txtCurrency.TabIndex = 7;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(7, 142);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(84, 26);
            this.lblCurrency.TabIndex = 6;
            this.lblCurrency.Text = "Moneda";
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Location = new System.Drawing.Point(7, 179);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(132, 26);
            this.lblPopulation.TabIndex = 8;
            this.lblPopulation.Text = "Habitantes";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(183, 179);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(356, 31);
            this.numericUpDown1.TabIndex = 9;
            // 
            // Country
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(569, 249);
            this.Controls.Add(this.grpCountryInfo);
            this.Font = new System.Drawing.Font("Cascadia Code PL SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Country";
            this.Text = "País";
            this.grpCountryInfo.ResumeLayout(false);
            this.grpCountryInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCountryInfo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.TextBox txtLang;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.Label lblCapital;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}