namespace Interface
{
    partial class BlackboardUI
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
            this.PnlBlackboard = new System.Windows.Forms.Panel();
            this.BtnCreateText = new System.Windows.Forms.Button();
            this.BtnCreateImage = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DescriptionComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSolve = new System.Windows.Forms.Button();
            this.BtnDeleteComment = new System.Windows.Forms.Button();
            this.BtnElement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlBlackboard
            // 
            this.PnlBlackboard.BackColor = System.Drawing.SystemColors.Control;
            this.PnlBlackboard.Location = new System.Drawing.Point(309, 93);
            this.PnlBlackboard.Name = "PnlBlackboard";
            this.PnlBlackboard.Size = new System.Drawing.Size(556, 393);
            this.PnlBlackboard.TabIndex = 0;
            // 
            // BtnCreateText
            // 
            this.BtnCreateText.Location = new System.Drawing.Point(309, 30);
            this.BtnCreateText.Name = "BtnCreateText";
            this.BtnCreateText.Size = new System.Drawing.Size(75, 23);
            this.BtnCreateText.TabIndex = 1;
            this.BtnCreateText.Text = "Crear Texto";
            this.BtnCreateText.UseVisualStyleBackColor = true;
            // 
            // BtnCreateImage
            // 
            this.BtnCreateImage.Location = new System.Drawing.Point(423, 30);
            this.BtnCreateImage.Name = "BtnCreateImage";
            this.BtnCreateImage.Size = new System.Drawing.Size(92, 23);
            this.BtnCreateImage.TabIndex = 2;
            this.BtnCreateImage.Text = "Crear Imagen";
            this.BtnCreateImage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescriptionComment,
            this.Creator});
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 359);
            this.dataGridView1.TabIndex = 3;
            // 
            // DescriptionComment
            // 
            this.DescriptionComment.HeaderText = "Descripción ";
            this.DescriptionComment.Name = "DescriptionComment";
            // 
            // Creator
            // 
            this.Creator.HeaderText = "Creador";
            this.Creator.Name = "Creator";
            // 
            // BtnSolve
            // 
            this.BtnSolve.Location = new System.Drawing.Point(12, 30);
            this.BtnSolve.Name = "BtnSolve";
            this.BtnSolve.Size = new System.Drawing.Size(113, 23);
            this.BtnSolve.TabIndex = 4;
            this.BtnSolve.Text = "Resolver comentario";
            this.BtnSolve.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteComment
            // 
            this.BtnDeleteComment.Location = new System.Drawing.Point(150, 30);
            this.BtnDeleteComment.Name = "BtnDeleteComment";
            this.BtnDeleteComment.Size = new System.Drawing.Size(106, 23);
            this.BtnDeleteComment.TabIndex = 5;
            this.BtnDeleteComment.Text = "Eliminar comentario";
            this.BtnDeleteComment.UseVisualStyleBackColor = true;
            // 
            // BtnElement
            // 
            this.BtnElement.Location = new System.Drawing.Point(561, 29);
            this.BtnElement.Name = "BtnElement";
            this.BtnElement.Size = new System.Drawing.Size(94, 23);
            this.BtnElement.TabIndex = 6;
            this.BtnElement.Text = "Borrar Elemento";
            this.BtnElement.UseVisualStyleBackColor = true;
            // 
            // BlackboardUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(890, 498);
            this.Controls.Add(this.BtnElement);
            this.Controls.Add(this.BtnDeleteComment);
            this.Controls.Add(this.BtnSolve);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnCreateImage);
            this.Controls.Add(this.BtnCreateText);
            this.Controls.Add(this.PnlBlackboard);
            this.Name = "BlackboardUI";
            this.Text = "BlackboardUI";
            this.Load += new System.EventHandler(this.BlackboardUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBlackboard;
        private System.Windows.Forms.Button BtnCreateText;
        private System.Windows.Forms.Button BtnCreateImage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creator;
        private System.Windows.Forms.Button BtnSolve;
        private System.Windows.Forms.Button BtnDeleteComment;
        private System.Windows.Forms.Button BtnElement;
    }
}