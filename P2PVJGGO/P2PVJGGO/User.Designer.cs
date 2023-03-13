namespace P2PVJGGO
{
    partial class User
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
            this.grpBPersonalInfo = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.nmuPhoneNumber = new System.Windows.Forms.NumericUpDown();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.grpBPersonalInfo.SuspendLayout();
            this.grpContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuPhoneNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBPersonalInfo
            // 
            this.grpBPersonalInfo.Controls.Add(this.textBox1);
            this.grpBPersonalInfo.Controls.Add(this.lblAdress);
            this.grpBPersonalInfo.Controls.Add(this.txtName);
            this.grpBPersonalInfo.Controls.Add(this.lblName);
            this.grpBPersonalInfo.Location = new System.Drawing.Point(13, 13);
            this.grpBPersonalInfo.Name = "grpBPersonalInfo";
            this.grpBPersonalInfo.Size = new System.Drawing.Size(434, 123);
            this.grpBPersonalInfo.TabIndex = 0;
            this.grpBPersonalInfo.TabStop = false;
            this.grpBPersonalInfo.Text = "Información Personal";
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
            this.txtName.Location = new System.Drawing.Point(133, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 31);
            this.txtName.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 31);
            this.textBox1.TabIndex = 3;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(7, 77);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(120, 26);
            this.lblAdress.TabIndex = 2;
            this.lblAdress.Text = "Dirección";
            // 
            // grpContact
            // 
            this.grpContact.Controls.Add(this.nmuPhoneNumber);
            this.grpContact.Controls.Add(this.lblPhoneNumber);
            this.grpContact.Controls.Add(this.textBox2);
            this.grpContact.Controls.Add(this.label2);
            this.grpContact.Controls.Add(this.txtEmail);
            this.grpContact.Controls.Add(this.lblEmail);
            this.grpContact.Location = new System.Drawing.Point(13, 142);
            this.grpContact.Name = "grpContact";
            this.grpContact.Size = new System.Drawing.Size(434, 188);
            this.grpContact.TabIndex = 7;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "Información de Contacto";
            // 
            // nmuPhoneNumber
            // 
            this.nmuPhoneNumber.Location = new System.Drawing.Point(133, 126);
            this.nmuPhoneNumber.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nmuPhoneNumber.Name = "nmuPhoneNumber";
            this.nmuPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nmuPhoneNumber.Size = new System.Drawing.Size(270, 31);
            this.nmuPhoneNumber.TabIndex = 6;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(7, 126);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(108, 26);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Teléfono";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 31);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dirección";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(133, 31);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 31);
            this.txtEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(7, 31);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 26);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(467, 343);
            this.Controls.Add(this.grpContact);
            this.Controls.Add(this.grpBPersonalInfo);
            this.Font = new System.Drawing.Font("Cascadia Code PL SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "User";
            this.Text = "Usuario";
            this.grpBPersonalInfo.ResumeLayout(false);
            this.grpBPersonalInfo.PerformLayout();
            this.grpContact.ResumeLayout(false);
            this.grpContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuPhoneNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBPersonalInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.NumericUpDown nmuPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}