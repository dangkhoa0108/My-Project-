namespace testEntityFarmwork
{
    partial class RoleForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRole = new System.Windows.Forms.DataGridView();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnSetRole = new MetroFramework.Controls.MetroButton();
            this.tbRoleName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvRole);
            this.panel1.Location = new System.Drawing.Point(11, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 118);
            this.panel1.TabIndex = 0;
            // 
            // dgvRole
            // 
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.Location = new System.Drawing.Point(9, 11);
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.Size = new System.Drawing.Size(289, 96);
            this.dgvRole.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 33);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(89, 260);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(69, 33);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(169, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 33);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSetRole
            // 
            this.btnSetRole.Location = new System.Drawing.Point(248, 260);
            this.btnSetRole.Name = "btnSetRole";
            this.btnSetRole.Size = new System.Drawing.Size(69, 33);
            this.btnSetRole.TabIndex = 8;
            this.btnSetRole.Text = "Set Role";
            this.btnSetRole.Click += new System.EventHandler(this.btnSetRole_Click);
            // 
            // tbRoleName
            // 
            this.tbRoleName.Location = new System.Drawing.Point(96, 193);
            this.tbRoleName.Name = "tbRoleName";
            this.tbRoleName.Size = new System.Drawing.Size(213, 28);
            this.tbRoleName.TabIndex = 9;
            this.tbRoleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRoleName_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 197);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(35, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Role";
            // 
            // RoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 313);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbRoleName);
            this.Controls.Add(this.btnSetRole);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoleForm";
            this.Text = "RoleForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RoleForm_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRole;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnSetRole;
        private MetroFramework.Controls.MetroTextBox tbRoleName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}