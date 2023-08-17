
namespace TabulationProject2021
{
    partial class ScoringFinalQA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoringFinalQA));
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblCandidateName = new System.Windows.Forms.Label();
            this.lblCandidateNumber = new System.Windows.Forms.Label();
            this.lblJudgeNumber = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSubmitVote = new System.Windows.Forms.Button();
            this.numConfidence = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numIntelligence = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCandidateID = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.imageTransitionCollege = new System.Windows.Forms.Timer(this.components);
            this.imageTransitionSHS = new System.Windows.Forms.Timer(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.panel1.SuspendLayout();
            this.container.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numConfidence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntelligence)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.container);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 768);
            this.panel1.TabIndex = 0;
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.container.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("container.BackgroundImage")));
            this.container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.container.Controls.Add(this.panel3);
            this.container.Controls.Add(this.lblGender);
            this.container.Controls.Add(this.lblCourse);
            this.container.Controls.Add(this.lblCandidateName);
            this.container.Controls.Add(this.lblCandidateNumber);
            this.container.Controls.Add(this.lblJudgeNumber);
            this.container.Controls.Add(this.btnClose);
            this.container.Controls.Add(this.panel2);
            this.container.Controls.Add(this.lblCandidateID);
            this.guna2Transition1.SetDecoration(this.container, Guna.UI2.AnimatorNS.DecorationType.None);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1024, 768);
            this.container.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox1);
            this.guna2Transition1.SetDecoration(this.panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(41, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 423);
            this.panel3.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 423);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblGender
            // 
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lblGender, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblGender.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Yellow;
            this.lblGender.Location = new System.Drawing.Point(541, 711);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(369, 21);
            this.lblGender.TabIndex = 27;
            this.lblGender.Text = "name";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCourse
            // 
            this.lblCourse.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lblCourse, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblCourse.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.ForeColor = System.Drawing.Color.Yellow;
            this.lblCourse.Location = new System.Drawing.Point(541, 683);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(369, 21);
            this.lblCourse.TabIndex = 26;
            this.lblCourse.Text = "name";
            this.lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCandidateName
            // 
            this.lblCandidateName.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lblCandidateName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblCandidateName.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateName.ForeColor = System.Drawing.Color.Yellow;
            this.lblCandidateName.Location = new System.Drawing.Point(540, 655);
            this.lblCandidateName.Name = "lblCandidateName";
            this.lblCandidateName.Size = new System.Drawing.Size(370, 21);
            this.lblCandidateName.TabIndex = 24;
            this.lblCandidateName.Text = "name";
            this.lblCandidateName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCandidateNumber
            // 
            this.lblCandidateNumber.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lblCandidateNumber, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblCandidateNumber.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateNumber.ForeColor = System.Drawing.Color.Yellow;
            this.lblCandidateNumber.Location = new System.Drawing.Point(541, 627);
            this.lblCandidateNumber.Name = "lblCandidateNumber";
            this.lblCandidateNumber.Size = new System.Drawing.Size(369, 21);
            this.lblCandidateNumber.TabIndex = 25;
            this.lblCandidateNumber.Text = "name";
            this.lblCandidateNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblJudgeNumber.TabIndex = 23;
            this.lblJudgeNumber.Text = "label5";
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
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Controls.Add(this.btnSubmitVote);
            this.panel2.Controls.Add(this.numConfidence);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.numIntelligence);
            this.panel2.Controls.Add(this.label1);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(534, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 373);
            this.panel2.TabIndex = 17;
            // 
            // btnNext
            // 
            this.guna2Transition1.SetDecoration(this.btnNext, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(309, 297);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(42, 39);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.guna2Transition1.SetDecoration(this.btnPrevious, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(32, 300);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(43, 39);
            this.btnPrevious.TabIndex = 12;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Visible = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnSubmitVote
            // 
            this.btnSubmitVote.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmitVote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Transition1.SetDecoration(this.btnSubmitVote, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSubmitVote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubmitVote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(205)))), ((int)(((byte)(98)))));
            this.btnSubmitVote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(205)))), ((int)(((byte)(98)))));
            this.btnSubmitVote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitVote.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitVote.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSubmitVote.Location = new System.Drawing.Point(81, 295);
            this.btnSubmitVote.Name = "btnSubmitVote";
            this.btnSubmitVote.Size = new System.Drawing.Size(222, 45);
            this.btnSubmitVote.TabIndex = 9;
            this.btnSubmitVote.Text = "Submit Vote";
            this.btnSubmitVote.UseVisualStyleBackColor = false;
            this.btnSubmitVote.Visible = false;
            this.btnSubmitVote.Click += new System.EventHandler(this.btnSubmitVote_Click);
            // 
            // numConfidence
            // 
            this.numConfidence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(62)))));
            this.numConfidence.DecimalPlaces = 1;
            this.guna2Transition1.SetDecoration(this.numConfidence, Guna.UI2.AnimatorNS.DecorationType.None);
            this.numConfidence.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F);
            this.numConfidence.ForeColor = System.Drawing.SystemColors.Info;
            this.numConfidence.Location = new System.Drawing.Point(128, 216);
            this.numConfidence.Minimum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numConfidence.Name = "numConfidence";
            this.numConfidence.Size = new System.Drawing.Size(128, 44);
            this.numConfidence.TabIndex = 4;
            this.numConfidence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numConfidence.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numConfidence.Click += new System.EventHandler(this.Num_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(205)))), ((int)(((byte)(98)))));
            this.label2.Location = new System.Drawing.Point(53, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confidence(50%)";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numIntelligence
            // 
            this.numIntelligence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(62)))));
            this.numIntelligence.DecimalPlaces = 1;
            this.guna2Transition1.SetDecoration(this.numIntelligence, Guna.UI2.AnimatorNS.DecorationType.None);
            this.numIntelligence.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F);
            this.numIntelligence.ForeColor = System.Drawing.SystemColors.Info;
            this.numIntelligence.Location = new System.Drawing.Point(128, 122);
            this.numIntelligence.Minimum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numIntelligence.Name = "numIntelligence";
            this.numIntelligence.Size = new System.Drawing.Size(128, 44);
            this.numIntelligence.TabIndex = 2;
            this.numIntelligence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numIntelligence.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numIntelligence.Click += new System.EventHandler(this.Num_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(205)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(46, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Intelligence(50%)";
            this.label1.Visible = false;
            // 
            // lblCandidateID
            // 
            this.lblCandidateID.AutoSize = true;
            this.lblCandidateID.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lblCandidateID, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblCandidateID.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblCandidateID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(205)))), ((int)(((byte)(98)))));
            this.lblCandidateID.Location = new System.Drawing.Point(530, 227);
            this.lblCandidateID.Name = "lblCandidateID";
            this.lblCandidateID.Size = new System.Drawing.Size(50, 21);
            this.lblCandidateID.TabIndex = 12;
            this.lblCandidateID.Text = "name";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.container;
            this.guna2DragControl1.TransparentWhileDrag = true;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // imageTransitionCollege
            // 
            this.imageTransitionCollege.Interval = 1000;
            this.imageTransitionCollege.Tick += new System.EventHandler(this.imageTransitionCollege_Tick);
            // 
            // imageTransitionSHS
            // 
            this.imageTransitionSHS.Enabled = true;
            this.imageTransitionSHS.Interval = 1000;
            this.imageTransitionSHS.Tick += new System.EventHandler(this.imageTransitionSHS_Tick);
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
            // ScoringFinalQA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Name = "ScoringFinalQA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoringFinalQA";
            this.panel1.ResumeLayout(false);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numConfidence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntelligence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Label lblCandidateID;
        private System.Windows.Forms.Button btnSubmitVote;
        private System.Windows.Forms.NumericUpDown numConfidence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numIntelligence;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Timer imageTransitionCollege;
        private System.Windows.Forms.Timer imageTransitionSHS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblJudgeNumber;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblCandidateName;
        private System.Windows.Forms.Label lblCandidateNumber;
        private System.Windows.Forms.Panel panel3;
    }
}