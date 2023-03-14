namespace P2PVJGGO
{
    partial class City
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
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.numZipCode = new System.Windows.Forms.NumericUpDown();
            this.numPopulation = new System.Windows.Forms.NumericUpDown();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.txtTimeZone = new System.Windows.Forms.TextBox();
            this.lblTimeZone = new System.Windows.Forms.Label();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZipCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulation)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.txtTimeZone);
            this.grpInfo.Controls.Add(this.lblTimeZone);
            this.grpInfo.Controls.Add(this.numPopulation);
            this.grpInfo.Controls.Add(this.lblPopulation);
            this.grpInfo.Controls.Add(this.numZipCode);
            this.grpInfo.Controls.Add(this.lblZipCode);
            this.grpInfo.Controls.Add(this.txtState);
            this.grpInfo.Controls.Add(this.lblState);
            this.grpInfo.Controls.Add(this.txtName);
            this.grpInfo.Controls.Add(this.lblName);
            this.grpInfo.Location = new System.Drawing.Point(13, 13);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(629, 224);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Información de la Ciudad";
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
            this.txtName.Location = new System.Drawing.Point(177, 29);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(443, 31);
            this.txtName.TabIndex = 1;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(177, 66);
            this.txtState.MaxLength = 100;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(443, 31);
            this.txtState.TabIndex = 3;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(7, 68);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(84, 26);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "Estado";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(7, 105);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(168, 26);
            this.lblZipCode.TabIndex = 4;
            this.lblZipCode.Text = "Código Postal";
            // 
            // numZipCode
            // 
            this.numZipCode.Location = new System.Drawing.Point(177, 103);
            this.numZipCode.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numZipCode.Name = "numZipCode";
            this.numZipCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numZipCode.Size = new System.Drawing.Size(443, 31);
            this.numZipCode.TabIndex = 5;
            // 
            // numPopulation
            // 
            this.numPopulation.Location = new System.Drawing.Point(177, 140);
            this.numPopulation.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numPopulation.Name = "numPopulation";
            this.numPopulation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numPopulation.Size = new System.Drawing.Size(443, 31);
            this.numPopulation.TabIndex = 7;
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Location = new System.Drawing.Point(7, 142);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(120, 26);
            this.lblPopulation.TabIndex = 6;
            this.lblPopulation.Text = "Población";
            // 
            // txtTimeZone
            // 
            this.txtTimeZone.Location = new System.Drawing.Point(177, 178);
            this.txtTimeZone.MaxLength = 100;
            this.txtTimeZone.Name = "txtTimeZone";
            this.txtTimeZone.Size = new System.Drawing.Size(443, 31);
            this.txtTimeZone.TabIndex = 9;
            // 
            // lblTimeZone
            // 
            this.lblTimeZone.AutoSize = true;
            this.lblTimeZone.Location = new System.Drawing.Point(7, 180);
            this.lblTimeZone.Name = "lblTimeZone";
            this.lblTimeZone.Size = new System.Drawing.Size(156, 26);
            this.lblTimeZone.TabIndex = 8;
            this.lblTimeZone.Text = "Zona Horaria";
            // 
            // City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(647, 246);
            this.Controls.Add(this.grpInfo);
            this.Font = new System.Drawing.Font("Cascadia Code PL SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "City";
            this.Text = "Ciudad";
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZipCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.NumericUpDown numZipCode;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown numPopulation;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.TextBox txtTimeZone;
        private System.Windows.Forms.Label lblTimeZone;
    }
}