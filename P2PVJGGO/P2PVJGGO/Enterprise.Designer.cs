namespace P2PVJGGO
{
    partial class Enterprise
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
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.lblWeb = new System.Windows.Forms.Label();
            this.lblNumEmplo = new System.Windows.Forms.Label();
            this.numNumEmp = new System.Windows.Forms.NumericUpDown();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.numNumEmp);
            this.grpInfo.Controls.Add(this.lblNumEmplo);
            this.grpInfo.Controls.Add(this.txtWeb);
            this.grpInfo.Controls.Add(this.lblWeb);
            this.grpInfo.Controls.Add(this.txtType);
            this.grpInfo.Controls.Add(this.lblType);
            this.grpInfo.Controls.Add(this.txtDesc);
            this.grpInfo.Controls.Add(this.lblDesc);
            this.grpInfo.Controls.Add(this.txt);
            this.grpInfo.Controls.Add(this.lblName);
            this.grpInfo.Location = new System.Drawing.Point(13, 13);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(711, 261);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Información de la empresa";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(209, 68);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(490, 31);
            this.txtDesc.TabIndex = 3;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(7, 70);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(144, 26);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Descripción";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(209, 31);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(490, 31);
            this.txt.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(209, 105);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(490, 31);
            this.txtType.TabIndex = 5;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(7, 107);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(192, 26);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Tipo de empresa";
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(209, 142);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(490, 31);
            this.txtWeb.TabIndex = 7;
            // 
            // lblWeb
            // 
            this.lblWeb.AutoSize = true;
            this.lblWeb.Location = new System.Drawing.Point(7, 144);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(120, 26);
            this.lblWeb.TabIndex = 6;
            this.lblWeb.Text = "Sitio Web";
            // 
            // lblNumEmplo
            // 
            this.lblNumEmplo.AutoSize = true;
            this.lblNumEmplo.Location = new System.Drawing.Point(7, 188);
            this.lblNumEmplo.Name = "lblNumEmplo";
            this.lblNumEmplo.Size = new System.Drawing.Size(240, 26);
            this.lblNumEmplo.TabIndex = 8;
            this.lblNumEmplo.Text = "Número de Empleados";
            // 
            // numNumEmp
            // 
            this.numNumEmp.Location = new System.Drawing.Point(6, 217);
            this.numNumEmp.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numNumEmp.Name = "numNumEmp";
            this.numNumEmp.Size = new System.Drawing.Size(490, 31);
            this.numNumEmp.TabIndex = 9;
            // 
            // Enterprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(740, 287);
            this.Controls.Add(this.grpInfo);
            this.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Enterprise";
            this.Text = "Empresa";
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown numNumEmp;
        private System.Windows.Forms.Label lblNumEmplo;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.Label lblWeb;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblType;
    }
}