namespace Interface
{
    partial class Start
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
            this.BtnRegister = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdoColaborator = new System.Windows.Forms.RadioButton();
            this.RdoAdmin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "¿No esta registrado?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.SystemColors.Info;
            this.BtnRegister.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.Location = new System.Drawing.Point(550, 403);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(87, 25);
            this.BtnRegister.TabIndex = 5;
            this.BtnRegister.Text = "Registrarse";
            this.BtnRegister.UseVisualStyleBackColor = false;
            // 
            // TxtPassword
            // 
            this.TxtPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.TxtPassword.Location = new System.Drawing.Point(248, 182);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(184, 20);
            this.TxtPassword.TabIndex = 6;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(248, 107);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(184, 20);
            this.TxtEmail.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdoColaborator);
            this.groupBox1.Controls.Add(this.RdoAdmin);
            this.groupBox1.Location = new System.Drawing.Point(234, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 108);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Usuario";
            // 
            // RdoColaborator
            // 
            this.RdoColaborator.AutoSize = true;
            this.RdoColaborator.Checked = true;
            this.RdoColaborator.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoColaborator.Location = new System.Drawing.Point(23, 69);
            this.RdoColaborator.Name = "RdoColaborator";
            this.RdoColaborator.Size = new System.Drawing.Size(96, 18);
            this.RdoColaborator.TabIndex = 1;
            this.RdoColaborator.TabStop = true;
            this.RdoColaborator.Text = "Colaborador";
            this.RdoColaborator.UseVisualStyleBackColor = true;
            // 
            // RdoAdmin
            // 
            this.RdoAdmin.AutoSize = true;
            this.RdoAdmin.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoAdmin.Location = new System.Drawing.Point(23, 32);
            this.RdoAdmin.Name = "RdoAdmin";
            this.RdoAdmin.Size = new System.Drawing.Size(105, 18);
            this.RdoAdmin.TabIndex = 0;
            this.RdoAdmin.TabStop = true;
            this.RdoAdmin.Text = "Administrador";
            this.RdoAdmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bienvenido a Pizarrones Uy";
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.BackColor = System.Drawing.SystemColors.Info;
            this.BtnLogIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnLogIn.Location = new System.Drawing.Point(290, 403);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(102, 23);
            this.BtnLogIn.TabIndex = 12;
            this.BtnLogIn.Text = "Iniciar Sesión";
            this.BtnLogIn.UseVisualStyleBackColor = false;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 475);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdoColaborator;
        private System.Windows.Forms.RadioButton RdoAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnLogIn;
    }
}