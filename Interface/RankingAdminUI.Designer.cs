namespace Interface
{
    partial class RankingAdminUI
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
            this.DataGridViewTeams = new System.Windows.Forms.DataGridView();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSelectTeam = new System.Windows.Forms.Button();
            this.RdoBadRankCreate = new System.Windows.Forms.RadioButton();
            this.Rdo2RegularCreate = new System.Windows.Forms.RadioButton();
            this.Rdo3GoodCreation = new System.Windows.Forms.RadioButton();
            this.Rdo4VeryGoodCreation = new System.Windows.Forms.RadioButton();
            this.Rdo5ExcelentCreation = new System.Windows.Forms.RadioButton();
            this.GrpCreateBlackboard = new System.Windows.Forms.GroupBox();
            this.GrpEliminateBlackBoard = new System.Windows.Forms.GroupBox();
            this.Rdo1BadElimination = new System.Windows.Forms.RadioButton();
            this.Rdo5ExcelentElimination = new System.Windows.Forms.RadioButton();
            this.Rdo2RegularElimination = new System.Windows.Forms.RadioButton();
            this.Rdo4VeryGoodElimination = new System.Windows.Forms.RadioButton();
            this.Rdo3GoodElimination = new System.Windows.Forms.RadioButton();
            this.GrpAddElement = new System.Windows.Forms.GroupBox();
            this.Rdo1BadAddElement = new System.Windows.Forms.RadioButton();
            this.Rdo5ExcelentAddElement = new System.Windows.Forms.RadioButton();
            this.Rdo2RegularAddElement = new System.Windows.Forms.RadioButton();
            this.Rdo4VeryGoodAddElement = new System.Windows.Forms.RadioButton();
            this.Rdo3GoodAddElement = new System.Windows.Forms.RadioButton();
            this.GrpAddComment = new System.Windows.Forms.GroupBox();
            this.Rdo1BadAddComment = new System.Windows.Forms.RadioButton();
            this.Rdo5ExcelentAddComment = new System.Windows.Forms.RadioButton();
            this.Rdo2RegularAddComment = new System.Windows.Forms.RadioButton();
            this.Rdo4VeryGoodAddComment = new System.Windows.Forms.RadioButton();
            this.Rdo3GoodAddComment = new System.Windows.Forms.RadioButton();
            this.GrpSolvedComments = new System.Windows.Forms.GroupBox();
            this.Rdo1BadResolved = new System.Windows.Forms.RadioButton();
            this.Rdo5ExcelentResolved = new System.Windows.Forms.RadioButton();
            this.Rdo2RegularResolved = new System.Windows.Forms.RadioButton();
            this.Rdo4VeryGoodResolved = new System.Windows.Forms.RadioButton();
            this.RdoGoodResolved = new System.Windows.Forms.RadioButton();
            this.BtnRankResolve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LblUserSelected = new System.Windows.Forms.Label();
            this.BtnResetRank = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTeams)).BeginInit();
            this.GrpCreateBlackboard.SuspendLayout();
            this.GrpEliminateBlackBoard.SuspendLayout();
            this.GrpAddElement.SuspendLayout();
            this.GrpAddComment.SuspendLayout();
            this.GrpSolvedComments.SuspendLayout();
            this.SuspendLayout();
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
            this.DataGridViewTeams.Location = new System.Drawing.Point(103, 109);
            this.DataGridViewTeams.Name = "DataGridViewTeams";
            this.DataGridViewTeams.ReadOnly = true;
            this.DataGridViewTeams.Size = new System.Drawing.Size(244, 271);
            this.DataGridViewTeams.TabIndex = 10;
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
            // BtnSelectTeam
            // 
            this.BtnSelectTeam.BackColor = System.Drawing.Color.Orange;
            this.BtnSelectTeam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSelectTeam.Location = new System.Drawing.Point(164, 406);
            this.BtnSelectTeam.Name = "BtnSelectTeam";
            this.BtnSelectTeam.Size = new System.Drawing.Size(123, 23);
            this.BtnSelectTeam.TabIndex = 30;
            this.BtnSelectTeam.Text = "Seleccionar equipo";
            this.BtnSelectTeam.UseVisualStyleBackColor = false;
            this.BtnSelectTeam.Click += new System.EventHandler(this.BtnSelectTeam_Click);
            // 
            // RdoBadRankCreate
            // 
            this.RdoBadRankCreate.AutoSize = true;
            this.RdoBadRankCreate.Location = new System.Drawing.Point(6, 19);
            this.RdoBadRankCreate.Name = "RdoBadRankCreate";
            this.RdoBadRankCreate.Size = new System.Drawing.Size(32, 18);
            this.RdoBadRankCreate.TabIndex = 32;
            this.RdoBadRankCreate.TabStop = true;
            this.RdoBadRankCreate.Text = "1";
            this.RdoBadRankCreate.UseVisualStyleBackColor = true;
            // 
            // Rdo2RegularCreate
            // 
            this.Rdo2RegularCreate.AutoSize = true;
            this.Rdo2RegularCreate.Location = new System.Drawing.Point(58, 19);
            this.Rdo2RegularCreate.Name = "Rdo2RegularCreate";
            this.Rdo2RegularCreate.Size = new System.Drawing.Size(32, 18);
            this.Rdo2RegularCreate.TabIndex = 33;
            this.Rdo2RegularCreate.TabStop = true;
            this.Rdo2RegularCreate.Text = "2";
            this.Rdo2RegularCreate.UseVisualStyleBackColor = true;
            // 
            // Rdo3GoodCreation
            // 
            this.Rdo3GoodCreation.AutoSize = true;
            this.Rdo3GoodCreation.Location = new System.Drawing.Point(109, 19);
            this.Rdo3GoodCreation.Name = "Rdo3GoodCreation";
            this.Rdo3GoodCreation.Size = new System.Drawing.Size(32, 18);
            this.Rdo3GoodCreation.TabIndex = 34;
            this.Rdo3GoodCreation.TabStop = true;
            this.Rdo3GoodCreation.Text = "3";
            this.Rdo3GoodCreation.UseVisualStyleBackColor = true;
            // 
            // Rdo4VeryGoodCreation
            // 
            this.Rdo4VeryGoodCreation.AutoSize = true;
            this.Rdo4VeryGoodCreation.Location = new System.Drawing.Point(156, 19);
            this.Rdo4VeryGoodCreation.Name = "Rdo4VeryGoodCreation";
            this.Rdo4VeryGoodCreation.Size = new System.Drawing.Size(32, 18);
            this.Rdo4VeryGoodCreation.TabIndex = 35;
            this.Rdo4VeryGoodCreation.TabStop = true;
            this.Rdo4VeryGoodCreation.Text = "4";
            this.Rdo4VeryGoodCreation.UseVisualStyleBackColor = true;
            // 
            // Rdo5ExcelentCreation
            // 
            this.Rdo5ExcelentCreation.AutoSize = true;
            this.Rdo5ExcelentCreation.Location = new System.Drawing.Point(206, 19);
            this.Rdo5ExcelentCreation.Name = "Rdo5ExcelentCreation";
            this.Rdo5ExcelentCreation.Size = new System.Drawing.Size(32, 18);
            this.Rdo5ExcelentCreation.TabIndex = 36;
            this.Rdo5ExcelentCreation.TabStop = true;
            this.Rdo5ExcelentCreation.Text = "5";
            this.Rdo5ExcelentCreation.UseVisualStyleBackColor = true;
            // 
            // GrpCreateBlackboard
            // 
            this.GrpCreateBlackboard.Controls.Add(this.RdoBadRankCreate);
            this.GrpCreateBlackboard.Controls.Add(this.Rdo5ExcelentCreation);
            this.GrpCreateBlackboard.Controls.Add(this.Rdo2RegularCreate);
            this.GrpCreateBlackboard.Controls.Add(this.Rdo4VeryGoodCreation);
            this.GrpCreateBlackboard.Controls.Add(this.Rdo3GoodCreation);
            this.GrpCreateBlackboard.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCreateBlackboard.Location = new System.Drawing.Point(506, 111);
            this.GrpCreateBlackboard.Name = "GrpCreateBlackboard";
            this.GrpCreateBlackboard.Size = new System.Drawing.Size(243, 42);
            this.GrpCreateBlackboard.TabIndex = 37;
            this.GrpCreateBlackboard.TabStop = false;
            this.GrpCreateBlackboard.Text = "Crear pizarrón";
            // 
            // GrpEliminateBlackBoard
            // 
            this.GrpEliminateBlackBoard.Controls.Add(this.Rdo1BadElimination);
            this.GrpEliminateBlackBoard.Controls.Add(this.Rdo5ExcelentElimination);
            this.GrpEliminateBlackBoard.Controls.Add(this.Rdo2RegularElimination);
            this.GrpEliminateBlackBoard.Controls.Add(this.Rdo4VeryGoodElimination);
            this.GrpEliminateBlackBoard.Controls.Add(this.Rdo3GoodElimination);
            this.GrpEliminateBlackBoard.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpEliminateBlackBoard.Location = new System.Drawing.Point(506, 174);
            this.GrpEliminateBlackBoard.Name = "GrpEliminateBlackBoard";
            this.GrpEliminateBlackBoard.Size = new System.Drawing.Size(243, 42);
            this.GrpEliminateBlackBoard.TabIndex = 38;
            this.GrpEliminateBlackBoard.TabStop = false;
            this.GrpEliminateBlackBoard.Text = "Eliminar pizarrón";
            // 
            // Rdo1BadElimination
            // 
            this.Rdo1BadElimination.AutoSize = true;
            this.Rdo1BadElimination.Location = new System.Drawing.Point(6, 19);
            this.Rdo1BadElimination.Name = "Rdo1BadElimination";
            this.Rdo1BadElimination.Size = new System.Drawing.Size(32, 18);
            this.Rdo1BadElimination.TabIndex = 32;
            this.Rdo1BadElimination.TabStop = true;
            this.Rdo1BadElimination.Text = "1";
            this.Rdo1BadElimination.UseVisualStyleBackColor = true;
            // 
            // Rdo5ExcelentElimination
            // 
            this.Rdo5ExcelentElimination.AutoSize = true;
            this.Rdo5ExcelentElimination.Location = new System.Drawing.Point(206, 19);
            this.Rdo5ExcelentElimination.Name = "Rdo5ExcelentElimination";
            this.Rdo5ExcelentElimination.Size = new System.Drawing.Size(32, 18);
            this.Rdo5ExcelentElimination.TabIndex = 36;
            this.Rdo5ExcelentElimination.TabStop = true;
            this.Rdo5ExcelentElimination.Text = "5";
            this.Rdo5ExcelentElimination.UseVisualStyleBackColor = true;
            // 
            // Rdo2RegularElimination
            // 
            this.Rdo2RegularElimination.AutoSize = true;
            this.Rdo2RegularElimination.Location = new System.Drawing.Point(58, 19);
            this.Rdo2RegularElimination.Name = "Rdo2RegularElimination";
            this.Rdo2RegularElimination.Size = new System.Drawing.Size(32, 18);
            this.Rdo2RegularElimination.TabIndex = 33;
            this.Rdo2RegularElimination.TabStop = true;
            this.Rdo2RegularElimination.Text = "2";
            this.Rdo2RegularElimination.UseVisualStyleBackColor = true;
            // 
            // Rdo4VeryGoodElimination
            // 
            this.Rdo4VeryGoodElimination.AutoSize = true;
            this.Rdo4VeryGoodElimination.Location = new System.Drawing.Point(156, 19);
            this.Rdo4VeryGoodElimination.Name = "Rdo4VeryGoodElimination";
            this.Rdo4VeryGoodElimination.Size = new System.Drawing.Size(32, 18);
            this.Rdo4VeryGoodElimination.TabIndex = 35;
            this.Rdo4VeryGoodElimination.TabStop = true;
            this.Rdo4VeryGoodElimination.Text = "4";
            this.Rdo4VeryGoodElimination.UseVisualStyleBackColor = true;
            // 
            // Rdo3GoodElimination
            // 
            this.Rdo3GoodElimination.AutoSize = true;
            this.Rdo3GoodElimination.Location = new System.Drawing.Point(109, 19);
            this.Rdo3GoodElimination.Name = "Rdo3GoodElimination";
            this.Rdo3GoodElimination.Size = new System.Drawing.Size(32, 18);
            this.Rdo3GoodElimination.TabIndex = 34;
            this.Rdo3GoodElimination.TabStop = true;
            this.Rdo3GoodElimination.Text = "3";
            this.Rdo3GoodElimination.UseVisualStyleBackColor = true;
            // 
            // GrpAddElement
            // 
            this.GrpAddElement.Controls.Add(this.Rdo1BadAddElement);
            this.GrpAddElement.Controls.Add(this.Rdo5ExcelentAddElement);
            this.GrpAddElement.Controls.Add(this.Rdo2RegularAddElement);
            this.GrpAddElement.Controls.Add(this.Rdo4VeryGoodAddElement);
            this.GrpAddElement.Controls.Add(this.Rdo3GoodAddElement);
            this.GrpAddElement.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpAddElement.Location = new System.Drawing.Point(506, 243);
            this.GrpAddElement.Name = "GrpAddElement";
            this.GrpAddElement.Size = new System.Drawing.Size(243, 42);
            this.GrpAddElement.TabIndex = 38;
            this.GrpAddElement.TabStop = false;
            this.GrpAddElement.Text = "Agregar elemento";
            // 
            // Rdo1BadAddElement
            // 
            this.Rdo1BadAddElement.AutoSize = true;
            this.Rdo1BadAddElement.Location = new System.Drawing.Point(6, 19);
            this.Rdo1BadAddElement.Name = "Rdo1BadAddElement";
            this.Rdo1BadAddElement.Size = new System.Drawing.Size(32, 18);
            this.Rdo1BadAddElement.TabIndex = 32;
            this.Rdo1BadAddElement.TabStop = true;
            this.Rdo1BadAddElement.Text = "1";
            this.Rdo1BadAddElement.UseVisualStyleBackColor = true;
            // 
            // Rdo5ExcelentAddElement
            // 
            this.Rdo5ExcelentAddElement.AutoSize = true;
            this.Rdo5ExcelentAddElement.Location = new System.Drawing.Point(206, 19);
            this.Rdo5ExcelentAddElement.Name = "Rdo5ExcelentAddElement";
            this.Rdo5ExcelentAddElement.Size = new System.Drawing.Size(32, 18);
            this.Rdo5ExcelentAddElement.TabIndex = 36;
            this.Rdo5ExcelentAddElement.TabStop = true;
            this.Rdo5ExcelentAddElement.Text = "5";
            this.Rdo5ExcelentAddElement.UseVisualStyleBackColor = true;
            // 
            // Rdo2RegularAddElement
            // 
            this.Rdo2RegularAddElement.AutoSize = true;
            this.Rdo2RegularAddElement.Location = new System.Drawing.Point(58, 19);
            this.Rdo2RegularAddElement.Name = "Rdo2RegularAddElement";
            this.Rdo2RegularAddElement.Size = new System.Drawing.Size(32, 18);
            this.Rdo2RegularAddElement.TabIndex = 33;
            this.Rdo2RegularAddElement.TabStop = true;
            this.Rdo2RegularAddElement.Text = "2";
            this.Rdo2RegularAddElement.UseVisualStyleBackColor = true;
            // 
            // Rdo4VeryGoodAddElement
            // 
            this.Rdo4VeryGoodAddElement.AutoSize = true;
            this.Rdo4VeryGoodAddElement.Location = new System.Drawing.Point(156, 19);
            this.Rdo4VeryGoodAddElement.Name = "Rdo4VeryGoodAddElement";
            this.Rdo4VeryGoodAddElement.Size = new System.Drawing.Size(32, 18);
            this.Rdo4VeryGoodAddElement.TabIndex = 35;
            this.Rdo4VeryGoodAddElement.TabStop = true;
            this.Rdo4VeryGoodAddElement.Text = "4";
            this.Rdo4VeryGoodAddElement.UseVisualStyleBackColor = true;
            // 
            // Rdo3GoodAddElement
            // 
            this.Rdo3GoodAddElement.AutoSize = true;
            this.Rdo3GoodAddElement.Location = new System.Drawing.Point(109, 19);
            this.Rdo3GoodAddElement.Name = "Rdo3GoodAddElement";
            this.Rdo3GoodAddElement.Size = new System.Drawing.Size(32, 18);
            this.Rdo3GoodAddElement.TabIndex = 34;
            this.Rdo3GoodAddElement.TabStop = true;
            this.Rdo3GoodAddElement.Text = "3";
            this.Rdo3GoodAddElement.UseVisualStyleBackColor = true;
            // 
            // GrpAddComment
            // 
            this.GrpAddComment.Controls.Add(this.Rdo1BadAddComment);
            this.GrpAddComment.Controls.Add(this.Rdo5ExcelentAddComment);
            this.GrpAddComment.Controls.Add(this.Rdo2RegularAddComment);
            this.GrpAddComment.Controls.Add(this.Rdo4VeryGoodAddComment);
            this.GrpAddComment.Controls.Add(this.Rdo3GoodAddComment);
            this.GrpAddComment.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpAddComment.Location = new System.Drawing.Point(506, 306);
            this.GrpAddComment.Name = "GrpAddComment";
            this.GrpAddComment.Size = new System.Drawing.Size(243, 42);
            this.GrpAddComment.TabIndex = 38;
            this.GrpAddComment.TabStop = false;
            this.GrpAddComment.Text = "Agregar comentario";
            // 
            // Rdo1BadAddComment
            // 
            this.Rdo1BadAddComment.AutoSize = true;
            this.Rdo1BadAddComment.Location = new System.Drawing.Point(6, 19);
            this.Rdo1BadAddComment.Name = "Rdo1BadAddComment";
            this.Rdo1BadAddComment.Size = new System.Drawing.Size(32, 18);
            this.Rdo1BadAddComment.TabIndex = 32;
            this.Rdo1BadAddComment.TabStop = true;
            this.Rdo1BadAddComment.Text = "1";
            this.Rdo1BadAddComment.UseVisualStyleBackColor = true;
            // 
            // Rdo5ExcelentAddComment
            // 
            this.Rdo5ExcelentAddComment.AutoSize = true;
            this.Rdo5ExcelentAddComment.Location = new System.Drawing.Point(206, 19);
            this.Rdo5ExcelentAddComment.Name = "Rdo5ExcelentAddComment";
            this.Rdo5ExcelentAddComment.Size = new System.Drawing.Size(32, 18);
            this.Rdo5ExcelentAddComment.TabIndex = 36;
            this.Rdo5ExcelentAddComment.TabStop = true;
            this.Rdo5ExcelentAddComment.Text = "5";
            this.Rdo5ExcelentAddComment.UseVisualStyleBackColor = true;
            // 
            // Rdo2RegularAddComment
            // 
            this.Rdo2RegularAddComment.AutoSize = true;
            this.Rdo2RegularAddComment.Location = new System.Drawing.Point(58, 19);
            this.Rdo2RegularAddComment.Name = "Rdo2RegularAddComment";
            this.Rdo2RegularAddComment.Size = new System.Drawing.Size(32, 18);
            this.Rdo2RegularAddComment.TabIndex = 33;
            this.Rdo2RegularAddComment.TabStop = true;
            this.Rdo2RegularAddComment.Text = "2";
            this.Rdo2RegularAddComment.UseVisualStyleBackColor = true;
            // 
            // Rdo4VeryGoodAddComment
            // 
            this.Rdo4VeryGoodAddComment.AutoSize = true;
            this.Rdo4VeryGoodAddComment.Location = new System.Drawing.Point(156, 19);
            this.Rdo4VeryGoodAddComment.Name = "Rdo4VeryGoodAddComment";
            this.Rdo4VeryGoodAddComment.Size = new System.Drawing.Size(32, 18);
            this.Rdo4VeryGoodAddComment.TabIndex = 35;
            this.Rdo4VeryGoodAddComment.TabStop = true;
            this.Rdo4VeryGoodAddComment.Text = "4";
            this.Rdo4VeryGoodAddComment.UseVisualStyleBackColor = true;
            // 
            // Rdo3GoodAddComment
            // 
            this.Rdo3GoodAddComment.AutoSize = true;
            this.Rdo3GoodAddComment.Location = new System.Drawing.Point(109, 19);
            this.Rdo3GoodAddComment.Name = "Rdo3GoodAddComment";
            this.Rdo3GoodAddComment.Size = new System.Drawing.Size(32, 18);
            this.Rdo3GoodAddComment.TabIndex = 34;
            this.Rdo3GoodAddComment.TabStop = true;
            this.Rdo3GoodAddComment.Text = "3";
            this.Rdo3GoodAddComment.UseVisualStyleBackColor = true;
            // 
            // GrpSolvedComments
            // 
            this.GrpSolvedComments.Controls.Add(this.Rdo1BadResolved);
            this.GrpSolvedComments.Controls.Add(this.Rdo5ExcelentResolved);
            this.GrpSolvedComments.Controls.Add(this.Rdo2RegularResolved);
            this.GrpSolvedComments.Controls.Add(this.Rdo4VeryGoodResolved);
            this.GrpSolvedComments.Controls.Add(this.RdoGoodResolved);
            this.GrpSolvedComments.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpSolvedComments.Location = new System.Drawing.Point(506, 373);
            this.GrpSolvedComments.Name = "GrpSolvedComments";
            this.GrpSolvedComments.Size = new System.Drawing.Size(243, 42);
            this.GrpSolvedComments.TabIndex = 38;
            this.GrpSolvedComments.TabStop = false;
            this.GrpSolvedComments.Text = "Resolución Comentarios";
            // 
            // Rdo1BadResolved
            // 
            this.Rdo1BadResolved.AutoSize = true;
            this.Rdo1BadResolved.Location = new System.Drawing.Point(6, 19);
            this.Rdo1BadResolved.Name = "Rdo1BadResolved";
            this.Rdo1BadResolved.Size = new System.Drawing.Size(32, 18);
            this.Rdo1BadResolved.TabIndex = 32;
            this.Rdo1BadResolved.TabStop = true;
            this.Rdo1BadResolved.Text = "1";
            this.Rdo1BadResolved.UseVisualStyleBackColor = true;
            // 
            // Rdo5ExcelentResolved
            // 
            this.Rdo5ExcelentResolved.AutoSize = true;
            this.Rdo5ExcelentResolved.Location = new System.Drawing.Point(206, 19);
            this.Rdo5ExcelentResolved.Name = "Rdo5ExcelentResolved";
            this.Rdo5ExcelentResolved.Size = new System.Drawing.Size(32, 18);
            this.Rdo5ExcelentResolved.TabIndex = 36;
            this.Rdo5ExcelentResolved.TabStop = true;
            this.Rdo5ExcelentResolved.Text = "5";
            this.Rdo5ExcelentResolved.UseVisualStyleBackColor = true;
            // 
            // Rdo2RegularResolved
            // 
            this.Rdo2RegularResolved.AutoSize = true;
            this.Rdo2RegularResolved.Location = new System.Drawing.Point(58, 19);
            this.Rdo2RegularResolved.Name = "Rdo2RegularResolved";
            this.Rdo2RegularResolved.Size = new System.Drawing.Size(32, 18);
            this.Rdo2RegularResolved.TabIndex = 33;
            this.Rdo2RegularResolved.TabStop = true;
            this.Rdo2RegularResolved.Text = "2";
            this.Rdo2RegularResolved.UseVisualStyleBackColor = true;
            // 
            // Rdo4VeryGoodResolved
            // 
            this.Rdo4VeryGoodResolved.AutoSize = true;
            this.Rdo4VeryGoodResolved.Location = new System.Drawing.Point(156, 19);
            this.Rdo4VeryGoodResolved.Name = "Rdo4VeryGoodResolved";
            this.Rdo4VeryGoodResolved.Size = new System.Drawing.Size(32, 18);
            this.Rdo4VeryGoodResolved.TabIndex = 35;
            this.Rdo4VeryGoodResolved.TabStop = true;
            this.Rdo4VeryGoodResolved.Text = "4";
            this.Rdo4VeryGoodResolved.UseVisualStyleBackColor = true;
            // 
            // RdoGoodResolved
            // 
            this.RdoGoodResolved.AutoSize = true;
            this.RdoGoodResolved.Location = new System.Drawing.Point(109, 19);
            this.RdoGoodResolved.Name = "RdoGoodResolved";
            this.RdoGoodResolved.Size = new System.Drawing.Size(32, 18);
            this.RdoGoodResolved.TabIndex = 34;
            this.RdoGoodResolved.TabStop = true;
            this.RdoGoodResolved.Text = "3";
            this.RdoGoodResolved.UseVisualStyleBackColor = true;
            // 
            // BtnRankResolve
            // 
            this.BtnRankResolve.BackColor = System.Drawing.Color.Orange;
            this.BtnRankResolve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRankResolve.Location = new System.Drawing.Point(827, 262);
            this.BtnRankResolve.Name = "BtnRankResolve";
            this.BtnRankResolve.Size = new System.Drawing.Size(75, 23);
            this.BtnRankResolve.TabIndex = 43;
            this.BtnRankResolve.Text = "Puntuar";
            this.BtnRankResolve.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Puntuar A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Equipo";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Orange;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBack.Location = new System.Drawing.Point(719, 452);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 47;
            this.BtnBack.Text = "Volver";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(432, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 22);
            this.label4.TabIndex = 48;
            this.label4.Text = "Puntuaciones";
            // 
            // LblUserSelected
            // 
            this.LblUserSelected.AutoSize = true;
            this.LblUserSelected.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserSelected.Location = new System.Drawing.Point(653, 75);
            this.LblUserSelected.Name = "LblUserSelected";
            this.LblUserSelected.Size = new System.Drawing.Size(83, 15);
            this.LblUserSelected.TabIndex = 49;
            this.LblUserSelected.Text = "Team name";
            this.LblUserSelected.Visible = false;
            // 
            // BtnResetRank
            // 
            this.BtnResetRank.BackColor = System.Drawing.Color.Orange;
            this.BtnResetRank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnResetRank.Location = new System.Drawing.Point(534, 451);
            this.BtnResetRank.Name = "BtnResetRank";
            this.BtnResetRank.Size = new System.Drawing.Size(99, 23);
            this.BtnResetRank.TabIndex = 51;
            this.BtnResetRank.Text = "Resetear Puntaje";
            this.BtnResetRank.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 15);
            this.label5.TabIndex = 52;
            this.label5.Text = "Resetear Puntaje a Equipo";
            // 
            // RankingAdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(993, 506);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnResetRank);
            this.Controls.Add(this.LblUserSelected);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRankResolve);
            this.Controls.Add(this.GrpSolvedComments);
            this.Controls.Add(this.GrpAddComment);
            this.Controls.Add(this.GrpAddElement);
            this.Controls.Add(this.GrpEliminateBlackBoard);
            this.Controls.Add(this.GrpCreateBlackboard);
            this.Controls.Add(this.BtnSelectTeam);
            this.Controls.Add(this.DataGridViewTeams);
            this.Name = "RankingAdminUI";
            this.Text = "RankingAdminUI";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTeams)).EndInit();
            this.GrpCreateBlackboard.ResumeLayout(false);
            this.GrpCreateBlackboard.PerformLayout();
            this.GrpEliminateBlackBoard.ResumeLayout(false);
            this.GrpEliminateBlackBoard.PerformLayout();
            this.GrpAddElement.ResumeLayout(false);
            this.GrpAddElement.PerformLayout();
            this.GrpAddComment.ResumeLayout(false);
            this.GrpAddComment.PerformLayout();
            this.GrpSolvedComments.ResumeLayout(false);
            this.GrpSolvedComments.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewTeams;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamDescription;
        private System.Windows.Forms.Button BtnSelectTeam;
        private System.Windows.Forms.RadioButton RdoBadRankCreate;
        private System.Windows.Forms.RadioButton Rdo2RegularCreate;
        private System.Windows.Forms.RadioButton Rdo3GoodCreation;
        private System.Windows.Forms.RadioButton Rdo4VeryGoodCreation;
        private System.Windows.Forms.RadioButton Rdo5ExcelentCreation;
        private System.Windows.Forms.GroupBox GrpCreateBlackboard;
        private System.Windows.Forms.GroupBox GrpEliminateBlackBoard;
        private System.Windows.Forms.RadioButton Rdo1BadElimination;
        private System.Windows.Forms.RadioButton Rdo5ExcelentElimination;
        private System.Windows.Forms.RadioButton Rdo2RegularElimination;
        private System.Windows.Forms.RadioButton Rdo4VeryGoodElimination;
        private System.Windows.Forms.RadioButton Rdo3GoodElimination;
        private System.Windows.Forms.GroupBox GrpAddElement;
        private System.Windows.Forms.RadioButton Rdo1BadAddElement;
        private System.Windows.Forms.RadioButton Rdo5ExcelentAddElement;
        private System.Windows.Forms.RadioButton Rdo2RegularAddElement;
        private System.Windows.Forms.RadioButton Rdo4VeryGoodAddElement;
        private System.Windows.Forms.RadioButton Rdo3GoodAddElement;
        private System.Windows.Forms.GroupBox GrpAddComment;
        private System.Windows.Forms.RadioButton Rdo1BadAddComment;
        private System.Windows.Forms.RadioButton Rdo5ExcelentAddComment;
        private System.Windows.Forms.RadioButton Rdo2RegularAddComment;
        private System.Windows.Forms.RadioButton Rdo4VeryGoodAddComment;
        private System.Windows.Forms.RadioButton Rdo3GoodAddComment;
        private System.Windows.Forms.GroupBox GrpSolvedComments;
        private System.Windows.Forms.RadioButton Rdo1BadResolved;
        private System.Windows.Forms.RadioButton Rdo5ExcelentResolved;
        private System.Windows.Forms.RadioButton Rdo2RegularResolved;
        private System.Windows.Forms.RadioButton Rdo4VeryGoodResolved;
        private System.Windows.Forms.RadioButton RdoGoodResolved;
        private System.Windows.Forms.Button BtnRankResolve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblUserSelected;
        private System.Windows.Forms.Button BtnResetRank;
        private System.Windows.Forms.Label label5;
    }
}