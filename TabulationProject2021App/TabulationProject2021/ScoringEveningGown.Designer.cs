
namespace TabulationProject2021
{
    partial class ScoringEveningGown
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
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoringEveningGown));
            this.imageTransitionSHS = new System.Windows.Forms.Timer(this.components);
            this.imageTransitionCollege = new System.Windows.Forms.Timer(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.container = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblJudgeNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSubmitVote = new System.Windows.Forms.Button();
            this.numStageAppeal = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numConfidence = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numCatWalk = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numPoise = new System.Windows.Forms.NumericUpDown();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblCandidateID = new System.Windows.Forms.Label();
            this.lblCandidateName = new System.Windows.Forms.Label();
            this.lblCandidateNumber = new System.Windows.Forms.Label();
            this.container.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStageAppeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConfidence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCatWalk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoise)).BeginInit();
            this.SuspendLayout();
            // 
            // imageTransitionSHS
            // 
            this.imageTransitionSHS.Enabled = true;
            this.imageTransitionSHS.Interval = 1000;
            this.imageTransitionSHS.Tick += new System.EventHandler(this.imageTransition_Tick);
            // 
            // imageTransitionCollege
            // 
            this.imageTransitionCollege.Interval = 1000;
            this.imageTransitionCollege.Tick += new System.EventHandler(this.imageTransitionCollege_Tick);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.container;
            this.guna2DragControl1.TransparentWhileDrag = true;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.guna2Transition1.DefaultAnimation = animation1;
            this.guna2Transition1.Interval = 1;
            this.guna2Transition1.TimeStep = 0.03F;
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.container.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("container.BackgroundImage")));
            this.container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.container.Controls.Add(this.panel2);
            this.container.Controls.Add(this.btnClose);
            this.container.Controls.Add(this.lblJudgeNumber);
            this.container.Controls.Add(this.panel1);
            this.container.Controls.Add(this.lblGender);
            this.container.Controls.Add(this.lblCourse);
            this.container.Controls.Add(this.lblCandidateID);
            this.container.Controls.Add(this.lblCandidateName);
            this.container.Controls.Add(this.lblCandidateNumber);
            this.guna2Transition1.SetDecoration(this.container, Guna.UI2.AnimatorNS.DecorationType.None);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1024, 768);
            this.container.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox1);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(41, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 423);
            this.panel2.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 423);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.guna2Transition1.SetDecoration(this.btnClose, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(205)))), ((int)(((byte)(98)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(205)))), ((int)(((byte)(98)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Info;
            this.btnClose.Location = new System.Drawing.Point(973, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 35);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblJudgeNumber
            // 
            this.lblJudgeNumber.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblJudgeNumber, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblJudgeNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudgeNumber.ForeColor = System.Drawing.Color.White;
            this.lblJudgeNumber.Location = new System.Drawing.Point(12, 742);
            this.lblJudgeNumber.Name = "lblJudgeNumber";
            this.lblJudgeNumber.Size = new System.Drawing.Size(47, 17);
            this.lblJudgeNumber.TabIndex = 20;
            this.lblJudgeNumber.Text = "label5";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnSubmitVote);
            this.panel1.Controls.Add(this.numStageAppeal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numConfidence);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numCatWalk);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numPoise);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(544, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 396);
            this.panel1.TabIndex = 17;
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnNext, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(287, 345);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(42, 29);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnPrevious, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(11, 345);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(42, 29);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Visible = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnSubmitVote
            // 
            this.btnSubmitVote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnSubmitVote, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSubmitVote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubmitVote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(205)))), ((int)(((byte)(98)))));
            this.btnSubmitVote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(205)))), ((int)(((byte)(98)))));
            this.btnSubmitVote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitVote.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitVote.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSubmitVote.Location = new System.Drawing.Point(59, 329);
            this.btnSubmitVote.Name = "btnSubmitVote";
            this.btnSubmitVote.Size = new System.Drawing.Size(222, 54);
            this.btnSubmitVote.TabIndex = 9;
            this.btnSubmitVote.Text = "Submit Vote";
            this.btnSubmitVote.UseVisualStyleBackColor = true;
            this.btnSubmitVote.Visible = false;
            this.btnSubmitVote.Click += new System.EventHandler(this.btnSubmitVote_Click);
            // 
            // numStageAppeal
            // 
            this.numStageAppeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(62)))));
            this.numStageAppeal.DecimalPlaces = 1;
            this.guna2Transition1.SetDecoration(this.numStageAppeal, Guna.UI2.AnimatorNS.DecorationType.None);
            this.numStageAppeal.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numStageAppeal.ForeColor = System.Drawing.SystemColors.Info;
            this.numStageAppeal.Location = new System.Drawing.Point(121, 274);
            this.numStageAppeal.Minimum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numStageAppeal.Name = "numStageAppeal";
            this.numStageAppeal.Size = new System.Drawing.Size(128, 44);
            this.numStageAppeal.TabIndex = 8;
            this.numStageAppeal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numStageAppeal.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numStageAppeal.Click += new System.EventHandler(this.Num_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(205)))), ((int)(((byte)(98)))));
            this.label4.Location = new System.Drawing.Point(78, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stage Appeal(20%)";
            this.label4.Visible = false;
            // 
            // numConfidence
            // 
            this.numConfidence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(62)))));
            this.numConfidence.DecimalPlaces = 1;
            this.guna2Transition1.SetDecoration(this.numConfidence, Guna.UI2.AnimatorNS.DecorationType.None);
            this.numConfidence.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numConfidence.ForeColor = System.Drawing.SystemColors.Info;
            this.numConfidence.Location = new System.Drawing.Point(121, 197);
            this.numConfidence.Minimum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numConfidence.Name = "numConfidence";
            this.numConfidence.Size = new System.Drawing.Size(128, 44);
            this.numConfidence.TabIndex = 6;
            this.numConfidence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numConfidence.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numConfidence.Click += new System.EventHandler(this.Num_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(205)))), ((int)(((byte)(98)))));
            this.label3.Location = new System.Drawing.Point(92, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confidence(30%)";
            this.label3.Visible = false;
            // 
            // numCatWalk
            // 
            this.numCatWalk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(62)))));
            this.numCatWalk.DecimalPlaces = 1;
            this.guna2Transition1.SetDecoration(this.numCatWalk, Guna.UI2.AnimatorNS.DecorationType.None);
            this.numCatWalk.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCatWalk.ForeColor = System.Drawing.SystemColors.Info;
            this.numCatWalk.Location = new System.Drawing.Point(121, 121);
            this.numCatWalk.Minimum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numCatWalk.Name = "numCatWalk";
            this.numCatWalk.Size = new System.Drawing.Size(128, 44);
            this.numCatWalk.TabIndex = 4;
            this.numCatWalk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCatWalk.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numCatWalk.Click += new System.EventHandler(this.Num_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(205)))), ((int)(((byte)(98)))));
            this.label2.Location = new System.Drawing.Point(101, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cat Walk(20%)";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(205)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(1, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Poise && Bearing/Projection(30%)";
            this.label1.Visible = false;
            // 
            // numPoise
            // 
            this.numPoise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(62)))));
            this.numPoise.DecimalPlaces = 1;
            this.guna2Transition1.SetDecoration(this.numPoise, Guna.UI2.AnimatorNS.DecorationType.None);
            this.numPoise.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPoise.ForeColor = System.Drawing.SystemColors.Info;
            this.numPoise.Location = new System.Drawing.Point(121, 44);
            this.numPoise.Minimum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numPoise.Name = "numPoise";
            this.numPoise.Size = new System.Drawing.Size(128, 44);
            this.numPoise.TabIndex = 2;
            this.numPoise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPoise.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numPoise.Click += new System.EventHandler(this.Num_Enter);
            // 
            // lblGender
            // 
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lblGender, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblGender.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Yellow;
            this.lblGender.Location = new System.Drawing.Point(540, 711);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(369, 21);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "name";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCourse
            // 
            this.lblCourse.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lblCourse, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblCourse.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.ForeColor = System.Drawing.Color.Yellow;
            this.lblCourse.Location = new System.Drawing.Point(540, 683);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(369, 21);
            this.lblCourse.TabIndex = 13;
            this.lblCourse.Text = "name";
            this.lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCandidateID
            // 
            this.lblCandidateID.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lblCandidateID, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblCandidateID.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(205)))), ((int)(((byte)(98)))));
            this.lblCandidateID.Location = new System.Drawing.Point(544, 203);
            this.lblCandidateID.Name = "lblCandidateID";
            this.lblCandidateID.Size = new System.Drawing.Size(369, 21);
            this.lblCandidateID.TabIndex = 12;
            this.lblCandidateID.Text = "name";
            // 
            // lblCandidateName
            // 
            this.lblCandidateName.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lblCandidateName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblCandidateName.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateName.ForeColor = System.Drawing.Color.Yellow;
            this.lblCandidateName.Location = new System.Drawing.Point(539, 655);
            this.lblCandidateName.Name = "lblCandidateName";
            this.lblCandidateName.Size = new System.Drawing.Size(370, 21);
            this.lblCandidateName.TabIndex = 10;
            this.lblCandidateName.Text = "name";
            this.lblCandidateName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCandidateNumber
            // 
            this.lblCandidateNumber.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lblCandidateNumber, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblCandidateNumber.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateNumber.ForeColor = System.Drawing.Color.Yellow;
            this.lblCandidateNumber.Location = new System.Drawing.Point(540, 627);
            this.lblCandidateNumber.Name = "lblCandidateNumber";
            this.lblCandidateNumber.Size = new System.Drawing.Size(369, 21);
            this.lblCandidateNumber.TabIndex = 11;
            this.lblCandidateNumber.Text = "name";
            this.lblCandidateNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoringEveningGown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.container);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Name = "ScoringEveningGown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoringEveningGown";
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStageAppeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConfidence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCatWalk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Button btnSubmitVote;
        private System.Windows.Forms.NumericUpDown numStageAppeal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numConfidence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCatWalk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPoise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblCandidateID;
        private System.Windows.Forms.Label lblCandidateNumber;
        private System.Windows.Forms.Label lblCandidateName;
        private System.Windows.Forms.Timer imageTransitionSHS;
        private System.Windows.Forms.Timer imageTransitionCollege;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblJudgeNumber;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
    }
}