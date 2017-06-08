namespace Interface
{
    partial class ModifyTeamUI
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.NudMaxUsers = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewUserInTeam = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxUsers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserList = new System.Windows.Forms.Label();
            this.lblUserListInTeam = new System.Windows.Forms.Label();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudMaxUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserInTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(324, 79);
            this.TxtName.Name = "TxtName";
            this.TxtName.ReadOnly = true;
            this.TxtName.Size = new System.Drawing.Size(124, 20);
            this.TxtName.TabIndex = 0;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(324, 127);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(124, 20);
            this.TxtDescription.TabIndex = 1;
            // 
            // NudMaxUsers
            // 
            this.NudMaxUsers.Location = new System.Drawing.Point(324, 185);
            this.NudMaxUsers.Name = "NudMaxUsers";
            this.NudMaxUsers.Size = new System.Drawing.Size(127, 20);
            this.NudMaxUsers.TabIndex = 2;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mail,
            this.Nombre,
            this.Apellido});
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 250);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(310, 150);
            this.dataGridViewUsers.TabIndex = 27;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // dataGridViewUserInTeam
            // 
            this.dataGridViewUserInTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserInTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewUserInTeam.Location = new System.Drawing.Point(464, 250);
            this.dataGridViewUserInTeam.Name = "dataGridViewUserInTeam";
            this.dataGridViewUserInTeam.Size = new System.Drawing.Size(308, 150);
            this.dataGridViewUserInTeam.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mail";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(345, 296);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 23);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Agregar usuario";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(247, 421);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 30;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(443, 421);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre:";
            // 
            // txtMaxUsers
            // 
            this.txtMaxUsers.AutoSize = true;
            this.txtMaxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxUsers.Location = new System.Drawing.Point(147, 187);
            this.txtMaxUsers.Name = "txtMaxUsers";
            this.txtMaxUsers.Size = new System.Drawing.Size(171, 13);
            this.txtMaxUsers.TabIndex = 33;
            this.txtMaxUsers.Text = "Cantidad maxima de usuarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Descripcion de funciones:";
            // 
            // lblUserList
            // 
            this.lblUserList.AutoSize = true;
            this.lblUserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserList.Location = new System.Drawing.Point(75, 223);
            this.lblUserList.Name = "lblUserList";
            this.lblUserList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserList.Size = new System.Drawing.Size(170, 13);
            this.lblUserList.TabIndex = 35;
            this.lblUserList.Text = "Lista de usuarios disponibles";
            // 
            // lblUserListInTeam
            // 
            this.lblUserListInTeam.AutoSize = true;
            this.lblUserListInTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserListInTeam.Location = new System.Drawing.Point(519, 223);
            this.lblUserListInTeam.Name = "lblUserListInTeam";
            this.lblUserListInTeam.Size = new System.Drawing.Size(177, 13);
            this.lblUserListInTeam.TabIndex = 36;
            this.lblUserListInTeam.Text = "Lista de usuarios en el equipo";
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(345, 344);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(106, 23);
            this.BtnRemove.TabIndex = 37;
            this.BtnRemove.Text = "Quitar";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "Modificación de equipo";
            // 
            // ModifyTeamUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 475);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.lblUserListInTeam);
            this.Controls.Add(this.lblUserList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaxUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewUserInTeam);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.NudMaxUsers);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.TxtName);
            this.Name = "ModifyTeamUI";
            this.Text = "ModifyTeamUI";
            this.Load += new System.EventHandler(this.ModifyTeamUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudMaxUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserInTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.NumericUpDown NudMaxUsers;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridView dataGridViewUserInTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtMaxUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserList;
        private System.Windows.Forms.Label lblUserListInTeam;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Label label2;
    }
}