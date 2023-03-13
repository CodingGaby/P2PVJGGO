namespace P2PVJGGO
{
    partial class Employee
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
            this.grpPersonalInfo = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.numSalary = new System.Windows.Forms.NumericUpDown();
            this.lblSalary = new System.Windows.Forms.Label();
            this.grpPersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPersonalInfo
            // 
            this.grpPersonalInfo.Controls.Add(this.numSalary);
            this.grpPersonalInfo.Controls.Add(this.lblSalary);
            this.grpPersonalInfo.Controls.Add(this.txtJobTitle);
            this.grpPersonalInfo.Controls.Add(this.lblJobTitle);
            this.grpPersonalInfo.Controls.Add(this.numericUpDown1);
            this.grpPersonalInfo.Controls.Add(this.lblEmpId);
            this.grpPersonalInfo.Controls.Add(this.txtArea);
            this.grpPersonalInfo.Controls.Add(this.lblArea);
            this.grpPersonalInfo.Controls.Add(this.txtRole);
            this.grpPersonalInfo.Controls.Add(this.lblRole);
            this.grpPersonalInfo.Controls.Add(this.txtName);
            this.grpPersonalInfo.Controls.Add(this.lblName);
            this.grpPersonalInfo.Location = new System.Drawing.Point(20, 21);
            this.grpPersonalInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPersonalInfo.Name = "grpPersonalInfo";
            this.grpPersonalInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPersonalInfo.Size = new System.Drawing.Size(628, 271);
            this.grpPersonalInfo.TabIndex = 0;
            this.grpPersonalInfo.TabStop = false;
            this.grpPersonalInfo.Text = "Información Personal";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(216, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(363, 31);
            this.txtName.TabIndex = 1;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(216, 70);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(363, 31);
            this.txtRole.TabIndex = 3;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(8, 70);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(48, 26);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Rol";
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Location = new System.Drawing.Point(7, 151);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(180, 26);
            this.lblEmpId.TabIndex = 6;
            this.lblEmpId.Text = "ID de Empleado";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(215, 107);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(363, 31);
            this.txtArea.TabIndex = 5;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(7, 107);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(60, 26);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Area";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(215, 147);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(363, 31);
            this.numericUpDown1.TabIndex = 7;
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(216, 184);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(363, 31);
            this.txtJobTitle.TabIndex = 9;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(8, 184);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(204, 26);
            this.lblJobTitle.TabIndex = 8;
            this.lblJobTitle.Text = "Titulo de empleo";
            // 
            // numSalary
            // 
            this.numSalary.Location = new System.Drawing.Point(216, 221);
            this.numSalary.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numSalary.Name = "numSalary";
            this.numSalary.Size = new System.Drawing.Size(363, 31);
            this.numSalary.TabIndex = 11;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(8, 225);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(96, 26);
            this.lblSalary.TabIndex = 10;
            this.lblSalary.Text = "Salario";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(663, 307);
            this.Controls.Add(this.grpPersonalInfo);
            this.Font = new System.Drawing.Font("Cascadia Code PL SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Employee";
            this.Text = "Empleado";
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonalInfo;
        private System.Windows.Forms.NumericUpDown numSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}