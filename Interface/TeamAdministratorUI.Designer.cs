namespace Interface
{
    partial class TeamAdministratorUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnDeleteTeam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCreateTeam = new System.Windows.Forms.Button();
            this.BtnModifyTeam = new System.Windows.Forms.Button();
            this.DataGridViewTeams = new System.Windows.Forms.DataGridView();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTeamBelongs = new System.Windows.Forms.DataGridView();
            this.TeamNameBelongs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamDescriptionBelongs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTeamBelongs)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSelect
            // 
            this.BtnSelect.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelect.Location = new System.Drawing.Point(263, 233);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(163, 23);
            this.BtnSelect.TabIndex = 3;
            this.BtnSelect.Text = "Seleccionar Equipo";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnDeleteTeam
            // 
            this.BtnDeleteTeam.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteTeam.Location = new System.Drawing.Point(263, 109);
            this.BtnDeleteTeam.Name = "BtnDeleteTeam";
            this.BtnDeleteTeam.Size = new System.Drawing.Size(163, 23);
            this.BtnDeleteTeam.TabIndex = 5;
            this.BtnDeleteTeam.Text = "Eliminar Equipo";
            this.BtnDeleteTeam.UseVisualStyleBackColor = true;
            this.BtnDeleteTeam.Click += new System.EventHandler(this.BtnDeleteTeam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Equipos (Administrador)";
            // 
            // BtnCreateTeam
            // 
            this.BtnCreateTeam.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateTeam.Location = new System.Drawing.Point(263, 54);
            this.BtnCreateTeam.Name = "BtnCreateTeam";
            this.BtnCreateTeam.Size = new System.Drawing.Size(163, 23);
            this.BtnCreateTeam.TabIndex = 7;
            this.BtnCreateTeam.Text = "Crear Equipo";
            this.BtnCreateTeam.UseVisualStyleBackColor = true;
            this.BtnCreateTeam.Click += new System.EventHandler(this.BtnCreateTeam_Click);
            // 
            // BtnModifyTeam
            // 
            this.BtnModifyTeam.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifyTeam.Location = new System.Drawing.Point(263, 168);
            this.BtnModifyTeam.Name = "BtnModifyTeam";
            this.BtnModifyTeam.Size = new System.Drawing.Size(163, 23);
            this.BtnModifyTeam.TabIndex = 8;
            this.BtnModifyTeam.Text = "Modificar Equipo";
            this.BtnModifyTeam.UseVisualStyleBackColor = true;
            this.BtnModifyTeam.Click += new System.EventHandler(this.BtnModifyTeam_Click);
            // 
            // DataGridViewTeams
            // 
            this.DataGridViewTeams.AllowUserToDeleteRows = false;
            this.DataGridViewTeams.AllowUserToResizeColumns = false;
            this.DataGridViewTeams.AllowUserToResizeRows = false;
            this.DataGridViewTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamName,
            this.TeamDescription});
            this.DataGridViewTeams.Location = new System.Drawing.Point(3, 54);
            this.DataGridViewTeams.Name = "DataGridViewTeams";
            this.DataGridViewTeams.ReadOnly = true;
            this.DataGridViewTeams.Size = new System.Drawing.Size(244, 271);
            this.DataGridViewTeams.TabIndex = 9;
            // 
            // TeamName
            // 
            this.TeamName.HeaderText = "Name";
            this.TeamName.Name = "TeamName";
            this.TeamName.ReadOnly = true;
            // 
            // TeamDescription
            // 
            this.TeamDescription.HeaderText = "Description";
            this.TeamDescription.Name = "TeamDescription";
            this.TeamDescription.ReadOnly = true;
            // 
            // DataGridViewTeamBelongs
            // 
            this.DataGridViewTeamBelongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTeamBelongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamNameBelongs,
            this.TeamDescriptionBelongs});
            this.DataGridViewTeamBelongs.Location = new System.Drawing.Point(432, 54);
            this.DataGridViewTeamBelongs.Name = "DataGridViewTeamBelongs";
            this.DataGridViewTeamBelongs.Size = new System.Drawing.Size(243, 271);
            this.DataGridViewTeamBelongs.TabIndex = 10;
            // 
            // TeamNameBelongs
            // 
            this.TeamNameBelongs.HeaderText = "Name";
            this.TeamNameBelongs.Name = "TeamNameBelongs";
            this.TeamNameBelongs.ReadOnly = true;
            // 
            // TeamDescriptionBelongs
            // 
            this.TeamDescriptionBelongs.HeaderText = "Description";
            this.TeamDescriptionBelongs.Name = "TeamDescriptionBelongs";
            this.TeamDescriptionBelongs.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Equipos al que pertenece";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Equipos ";
            // 
            // TeamAdministratorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGridViewTeamBelongs);
            this.Controls.Add(this.DataGridViewTeams);
            this.Controls.Add(this.BtnModifyTeam);
            this.Controls.Add(this.BtnCreateTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDeleteTeam);
            this.Controls.Add(this.BtnSelect);
            this.Name = "TeamAdministratorUI";
            this.Size = new System.Drawing.Size(680, 361);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTeamBelongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnDeleteTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCreateTeam;
        private System.Windows.Forms.Button BtnModifyTeam;
        private System.Windows.Forms.DataGridView DataGridViewTeams;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamDescription;
        private System.Windows.Forms.DataGridView DataGridViewTeamBelongs;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamNameBelongs;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamDescriptionBelongs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
