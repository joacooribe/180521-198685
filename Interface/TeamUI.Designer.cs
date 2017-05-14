namespace Interface
{
    partial class TeamUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstTeams
            // 
            this.LstTeams.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstTeams.FormattingEnabled = true;
            this.LstTeams.ItemHeight = 14;
            this.LstTeams.Location = new System.Drawing.Point(56, 53);
            this.LstTeams.Name = "LstTeams";
            this.LstTeams.Size = new System.Drawing.Size(165, 228);
            this.LstTeams.TabIndex = 1;
            // 
            // BtnSelect
            // 
            this.BtnSelect.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelect.Location = new System.Drawing.Point(279, 268);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(163, 23);
            this.BtnSelect.TabIndex = 2;
            this.BtnSelect.Text = "Seleccionar Equipo";
            this.BtnSelect.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Equipos";
            // 
            // TeamUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.LstTeams);
            this.Location = new System.Drawing.Point(35, 86);
            this.Name = "TeamUI";
            this.Size = new System.Drawing.Size(680, 361);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstTeams;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Label label1;
    }
}
