namespace Interface
{
    partial class AdministratorUI
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
            this.BtnTeams = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnRankUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(35, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 361);
            this.panel1.TabIndex = 0;
            // 
            // BtnTeams
            // 
            this.BtnTeams.BackColor = System.Drawing.Color.Orange;
            this.BtnTeams.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTeams.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTeams.Location = new System.Drawing.Point(35, 28);
            this.BtnTeams.Name = "BtnTeams";
            this.BtnTeams.Size = new System.Drawing.Size(75, 23);
            this.BtnTeams.TabIndex = 1;
            this.BtnTeams.Text = "Equipos";
            this.BtnTeams.UseVisualStyleBackColor = false;
            this.BtnTeams.Click += new System.EventHandler(this.BtnTeams_Click);
            // 
            // BtnModify
            // 
            this.BtnModify.BackColor = System.Drawing.Color.Orange;
            this.BtnModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModify.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModify.Location = new System.Drawing.Point(175, 27);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(116, 23);
            this.BtnModify.TabIndex = 2;
            this.BtnModify.Text = "Modificar Usuario";
            this.BtnModify.UseVisualStyleBackColor = false;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.Color.Orange;
            this.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLogOut.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.Location = new System.Drawing.Point(645, 29);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(100, 23);
            this.BtnLogOut.TabIndex = 3;
            this.BtnLogOut.Text = "Cerrar Sesión";
            this.BtnLogOut.UseVisualStyleBackColor = false;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.Orange;
            this.BtnRegister.FlatAppearance.BorderSize = 3;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegister.Location = new System.Drawing.Point(496, 28);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(109, 23);
            this.BtnRegister.TabIndex = 5;
            this.BtnRegister.Text = "Crear Usuario";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnRankUser
            // 
            this.BtnRankUser.BackColor = System.Drawing.Color.Orange;
            this.BtnRankUser.FlatAppearance.BorderSize = 3;
            this.BtnRankUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRankUser.Location = new System.Drawing.Point(332, 26);
            this.BtnRankUser.Name = "BtnRankUser";
            this.BtnRankUser.Size = new System.Drawing.Size(121, 23);
            this.BtnRankUser.TabIndex = 6;
            this.BtnRankUser.Text = "Puntaciones";
            this.BtnRankUser.UseVisualStyleBackColor = false;
            this.BtnRankUser.Click += new System.EventHandler(this.BtnRankUser_Click);
            // 
            // AdministratorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(757, 478);
            this.Controls.Add(this.BtnRankUser);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.BtnTeams);
            this.Controls.Add(this.panel1);
            this.Name = "AdministratorUI";
            this.Text = "AdministratorUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnTeams;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnRankUser;
    }
}