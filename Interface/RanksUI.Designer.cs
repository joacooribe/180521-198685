namespace Interface
{
    partial class RanksUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSelectTeam = new System.Windows.Forms.Button();
            this.DataGridViewTeams = new System.Windows.Forms.DataGridView();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewUserInTeam = new System.Windows.Forms.DataGridView();
            this.UserMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUserInTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Equipo";
            // 
            // BtnSelectTeam
            // 
            this.BtnSelectTeam.BackColor = System.Drawing.Color.Orange;
            this.BtnSelectTeam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSelectTeam.Location = new System.Drawing.Point(92, 385);
            this.BtnSelectTeam.Name = "BtnSelectTeam";
            this.BtnSelectTeam.Size = new System.Drawing.Size(123, 23);
            this.BtnSelectTeam.TabIndex = 48;
            this.BtnSelectTeam.Text = "Seleccionar equipo";
            this.BtnSelectTeam.UseVisualStyleBackColor = false;
            this.BtnSelectTeam.Click += new System.EventHandler(this.BtnSelectTeam_Click);
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
            this.DataGridViewTeams.Location = new System.Drawing.Point(35, 86);
            this.DataGridViewTeams.Name = "DataGridViewTeams";
            this.DataGridViewTeams.ReadOnly = true;
            this.DataGridViewTeams.Size = new System.Drawing.Size(244, 271);
            this.DataGridViewTeams.TabIndex = 47;
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
            // DataGridViewUserInTeam
            // 
            this.DataGridViewUserInTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewUserInTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserMail,
            this.UserName,
            this.UserRank});
            this.DataGridViewUserInTeam.Location = new System.Drawing.Point(343, 86);
            this.DataGridViewUserInTeam.Name = "DataGridViewUserInTeam";
            this.DataGridViewUserInTeam.Size = new System.Drawing.Size(332, 271);
            this.DataGridViewUserInTeam.TabIndex = 52;
            // 
            // UserMail
            // 
            this.UserMail.HeaderText = "Mail";
            this.UserMail.Name = "UserMail";
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Nombre";
            this.UserName.Name = "UserName";
            // 
            // UserRank
            // 
            this.UserRank.HeaderText = "Puntaje";
            this.UserRank.Name = "UserRank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Usuario";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Orange;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBack.Location = new System.Drawing.Point(557, 384);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 53;
            this.BtnBack.Text = "Volver";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // RanksUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(725, 432);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.DataGridViewUserInTeam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSelectTeam);
            this.Controls.Add(this.DataGridViewTeams);
            this.Name = "RanksUI";
            this.Text = "RanksUI";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUserInTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSelectTeam;
        private System.Windows.Forms.DataGridView DataGridViewTeams;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamDescription;
        private System.Windows.Forms.DataGridView DataGridViewUserInTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBack;
    }
}