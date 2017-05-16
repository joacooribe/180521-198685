namespace Interface
{
    partial class TeamRegisterUI
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
            this.nudMaxUsers = new System.Windows.Forms.NumericUpDown();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.brnAgregar = new System.Windows.Forms.Button();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxUsers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserListInTeam = new System.Windows.Forms.Label();
            this.lblUserList = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewUserForTeam = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserForTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // nudMaxUsers
            // 
            this.nudMaxUsers.Location = new System.Drawing.Point(328, 138);
            this.nudMaxUsers.Name = "nudMaxUsers";
            this.nudMaxUsers.Size = new System.Drawing.Size(120, 20);
            this.nudMaxUsers.TabIndex = 0;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(328, 94);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(120, 20);
            this.txtTeamName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(328, 181);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(120, 20);
            this.txtDescription.TabIndex = 2;
            // 
            // brnAgregar
            // 
            this.brnAgregar.Location = new System.Drawing.Point(328, 313);
            this.brnAgregar.Name = "brnAgregar";
            this.brnAgregar.Size = new System.Drawing.Size(103, 23);
            this.brnAgregar.TabIndex = 4;
            this.brnAgregar.Text = "Agregar usuario";
            this.brnAgregar.UseVisualStyleBackColor = true;
            this.brnAgregar.Click += new System.EventHandler(this.brnAgregar_Click);
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipo.Location = new System.Drawing.Point(311, 41);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(158, 24);
            this.lblEquipo.TabIndex = 7;
            this.lblEquipo.Text = "Alta de Equipos";
            this.lblEquipo.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre:";
            // 
            // txtMaxUsers
            // 
            this.txtMaxUsers.AutoSize = true;
            this.txtMaxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxUsers.Location = new System.Drawing.Point(151, 140);
            this.txtMaxUsers.Name = "txtMaxUsers";
            this.txtMaxUsers.Size = new System.Drawing.Size(171, 13);
            this.txtMaxUsers.TabIndex = 20;
            this.txtMaxUsers.Text = "Cantidad maxima de usuarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Descripcion de funciones:";
            // 
            // lblUserListInTeam
            // 
            this.lblUserListInTeam.AutoSize = true;
            this.lblUserListInTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserListInTeam.Location = new System.Drawing.Point(506, 215);
            this.lblUserListInTeam.Name = "lblUserListInTeam";
            this.lblUserListInTeam.Size = new System.Drawing.Size(157, 13);
            this.lblUserListInTeam.TabIndex = 22;
            this.lblUserListInTeam.Text = "Lista de usuario a ingresar";
            this.lblUserListInTeam.Click += new System.EventHandler(this.lblUserListInTeam_Click);
            // 
            // lblUserList
            // 
            this.lblUserList.AutoSize = true;
            this.lblUserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserList.Location = new System.Drawing.Point(74, 215);
            this.lblUserList.Name = "lblUserList";
            this.lblUserList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserList.Size = new System.Drawing.Size(170, 13);
            this.lblUserList.TabIndex = 23;
            this.lblUserList.Text = "Lista de usuarios disponibles";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(296, 413);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 24;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(394, 413);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mail,
            this.Nombre,
            this.Apellido});
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 247);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(310, 150);
            this.dataGridViewUsers.TabIndex = 26;
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
            // dataGridViewUserForTeam
            // 
            this.dataGridViewUserForTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserForTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewUserForTeam.Location = new System.Drawing.Point(437, 247);
            this.dataGridViewUserForTeam.Name = "dataGridViewUserForTeam";
            this.dataGridViewUserForTeam.Size = new System.Drawing.Size(308, 150);
            this.dataGridViewUserForTeam.TabIndex = 27;
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
            // TeamRegisterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 478);
            this.Controls.Add(this.dataGridViewUserForTeam);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblUserList);
            this.Controls.Add(this.lblUserListInTeam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaxUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.brnAgregar);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.nudMaxUsers);
            this.Name = "TeamRegisterUI";
            this.Text = "TeamRegisterUI";
            this.Load += new System.EventHandler(this.TeamRegisterUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserForTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudMaxUsers;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button brnAgregar;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtMaxUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserListInTeam;
        private System.Windows.Forms.Label lblUserList;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridView dataGridViewUserForTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}