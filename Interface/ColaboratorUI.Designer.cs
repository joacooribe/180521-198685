namespace Interface
{
    partial class ColaboratorUI
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
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.ColaboratorUIPanel = new System.Windows.Forms.Panel();
            this.BtnTeams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnModify
            // 
            this.BtnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModify.Location = new System.Drawing.Point(326, 35);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(113, 23);
            this.BtnModify.TabIndex = 1;
            this.BtnModify.Text = "Modificar Usuario";
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.Location = new System.Drawing.Point(610, 35);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(105, 23);
            this.BtnLogOut.TabIndex = 2;
            this.BtnLogOut.Text = "Cerrar Sesión";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // ColaboratorUIPanel
            // 
            this.ColaboratorUIPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ColaboratorUIPanel.Location = new System.Drawing.Point(35, 86);
            this.ColaboratorUIPanel.Name = "ColaboratorUIPanel";
            this.ColaboratorUIPanel.Size = new System.Drawing.Size(680, 361);
            this.ColaboratorUIPanel.TabIndex = 4;
            this.ColaboratorUIPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ColaboratorUIPanel_Paint);
            // 
            // BtnTeams
            // 
            this.BtnTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTeams.Location = new System.Drawing.Point(54, 35);
            this.BtnTeams.Name = "BtnTeams";
            this.BtnTeams.Size = new System.Drawing.Size(75, 23);
            this.BtnTeams.TabIndex = 5;
            this.BtnTeams.Text = "Equipos";
            this.BtnTeams.UseVisualStyleBackColor = true;
            this.BtnTeams.Click += new System.EventHandler(this.BtnTeams_Click);
            // 
            // ColaboratorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(757, 478);
            this.Controls.Add(this.BtnTeams);
            this.Controls.Add(this.ColaboratorUIPanel);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.BtnModify);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "ColaboratorUI";
            this.Text = "ColaboratorUI";
            this.Load += new System.EventHandler(this.ColaboratorUI_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Panel ColaboratorUIPanel;
        private System.Windows.Forms.Button BtnTeams;
    }
}