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
            this.LstTeams = new System.Windows.Forms.ListBox();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnDeleteTeam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCreateTeam = new System.Windows.Forms.Button();
            this.BtnModifyTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstTeams
            // 
            this.LstTeams.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstTeams.FormattingEnabled = true;
            this.LstTeams.ItemHeight = 14;
            this.LstTeams.Location = new System.Drawing.Point(47, 54);
            this.LstTeams.Name = "LstTeams";
            this.LstTeams.Size = new System.Drawing.Size(165, 228);
            this.LstTeams.TabIndex = 2;
            // 
            // BtnSelect
            // 
            this.BtnSelect.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelect.Location = new System.Drawing.Point(250, 259);
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
            this.BtnDeleteTeam.Location = new System.Drawing.Point(250, 122);
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
            this.BtnCreateTeam.Location = new System.Drawing.Point(250, 54);
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
            this.BtnModifyTeam.Location = new System.Drawing.Point(250, 188);
            this.BtnModifyTeam.Name = "BtnModifyTeam";
            this.BtnModifyTeam.Size = new System.Drawing.Size(163, 23);
            this.BtnModifyTeam.TabIndex = 8;
            this.BtnModifyTeam.Text = "Modificar Equipo";
            this.BtnModifyTeam.UseVisualStyleBackColor = true;
            this.BtnModifyTeam.Click += new System.EventHandler(this.BtnModifyTeam_Click);
            // 
            // TeamAdministratorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnModifyTeam);
            this.Controls.Add(this.BtnCreateTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDeleteTeam);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.LstTeams);
            this.Location = new System.Drawing.Point(35, 86);
            this.Name = "TeamAdministratorUI";
            this.Size = new System.Drawing.Size(680, 361);
            this.Load += new System.EventHandler(this.TeamAdministratorUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstTeams;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnDeleteTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCreateTeam;
        private System.Windows.Forms.Button BtnModifyTeam;
    }
}
