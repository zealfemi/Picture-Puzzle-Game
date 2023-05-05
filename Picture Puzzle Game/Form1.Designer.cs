namespace Picture_Puzzle_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrTimeElapse = new System.Windows.Forms.Timer(this.components);
            this.gbPuzzleBox = new System.Windows.Forms.GroupBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx8 = new System.Windows.Forms.PictureBox();
            this.pbx9 = new System.Windows.Forms.PictureBox();
            this.lblMovesMade = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTimeElapsed = new MaterialSkin.Controls.MaterialLabel();
            this.lblPaused = new MaterialSkin.Controls.MaterialLabel();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.gbPuzzleBox2 = new System.Windows.Forms.GroupBox();
            this.pbx21 = new System.Windows.Forms.PictureBox();
            this.pbx22 = new System.Windows.Forms.PictureBox();
            this.pbx23 = new System.Windows.Forms.PictureBox();
            this.pbx24 = new System.Windows.Forms.PictureBox();
            this.pbx25 = new System.Windows.Forms.PictureBox();
            this.pbx26 = new System.Windows.Forms.PictureBox();
            this.pbx27 = new System.Windows.Forms.PictureBox();
            this.pbx28 = new System.Windows.Forms.PictureBox();
            this.pbx29 = new System.Windows.Forms.PictureBox();
            this.group2 = new System.Windows.Forms.GroupBox();
            this.gbOriginal2 = new System.Windows.Forms.GroupBox();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.gbOriginal = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblLabel = new System.Windows.Forms.Label();
            this.gbPuzzleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).BeginInit();
            this.gbPuzzleBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx29)).BeginInit();
            this.group2.SuspendLayout();
            this.group1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrTimeElapse
            // 
            this.tmrTimeElapse.Enabled = true;
            this.tmrTimeElapse.Interval = 900;
            this.tmrTimeElapse.Tick += new System.EventHandler(this.UpdateTimeElapsed);
            // 
            // gbPuzzleBox
            // 
            this.gbPuzzleBox.Controls.Add(this.pbx1);
            this.gbPuzzleBox.Controls.Add(this.pbx2);
            this.gbPuzzleBox.Controls.Add(this.pbx3);
            this.gbPuzzleBox.Controls.Add(this.pbx4);
            this.gbPuzzleBox.Controls.Add(this.pbx5);
            this.gbPuzzleBox.Controls.Add(this.pbx6);
            this.gbPuzzleBox.Controls.Add(this.pbx7);
            this.gbPuzzleBox.Controls.Add(this.pbx8);
            this.gbPuzzleBox.Controls.Add(this.pbx9);
            this.gbPuzzleBox.Location = new System.Drawing.Point(6, 7);
            this.gbPuzzleBox.Name = "gbPuzzleBox";
            this.gbPuzzleBox.Size = new System.Drawing.Size(335, 342);
            this.gbPuzzleBox.TabIndex = 6;
            this.gbPuzzleBox.TabStop = false;
            // 
            // pbx1
            // 
            this.pbx1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx1.Location = new System.Drawing.Point(17, 23);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(100, 100);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            this.pbx1.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx2
            // 
            this.pbx2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx2.Location = new System.Drawing.Point(118, 23);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(100, 100);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 0;
            this.pbx2.TabStop = false;
            this.pbx2.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx3
            // 
            this.pbx3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx3.Location = new System.Drawing.Point(219, 23);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(100, 100);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 0;
            this.pbx3.TabStop = false;
            this.pbx3.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx4
            // 
            this.pbx4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx4.Location = new System.Drawing.Point(17, 124);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(100, 100);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx4.TabIndex = 0;
            this.pbx4.TabStop = false;
            this.pbx4.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx5
            // 
            this.pbx5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx5.Location = new System.Drawing.Point(118, 124);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(100, 100);
            this.pbx5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx5.TabIndex = 0;
            this.pbx5.TabStop = false;
            this.pbx5.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx6
            // 
            this.pbx6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx6.Location = new System.Drawing.Point(219, 124);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(100, 100);
            this.pbx6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx6.TabIndex = 0;
            this.pbx6.TabStop = false;
            this.pbx6.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx7
            // 
            this.pbx7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx7.Location = new System.Drawing.Point(17, 225);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(100, 100);
            this.pbx7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx7.TabIndex = 0;
            this.pbx7.TabStop = false;
            this.pbx7.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx8
            // 
            this.pbx8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx8.Location = new System.Drawing.Point(118, 225);
            this.pbx8.Name = "pbx8";
            this.pbx8.Size = new System.Drawing.Size(100, 100);
            this.pbx8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx8.TabIndex = 0;
            this.pbx8.TabStop = false;
            this.pbx8.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx9
            // 
            this.pbx9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx9.Location = new System.Drawing.Point(219, 225);
            this.pbx9.Name = "pbx9";
            this.pbx9.Size = new System.Drawing.Size(100, 100);
            this.pbx9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx9.TabIndex = 0;
            this.pbx9.TabStop = false;
            this.pbx9.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // lblMovesMade
            // 
            this.lblMovesMade.AutoSize = true;
            this.lblMovesMade.Depth = 0;
            this.lblMovesMade.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMovesMade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMovesMade.Location = new System.Drawing.Point(36, 483);
            this.lblMovesMade.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMovesMade.Name = "lblMovesMade";
            this.lblMovesMade.Size = new System.Drawing.Size(99, 19);
            this.lblMovesMade.TabIndex = 10;
            this.lblMovesMade.Text = "Moves Made:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(36, 507);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(47, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Time:";
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Depth = 0;
            this.lblTimeElapsed.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTimeElapsed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTimeElapsed.Location = new System.Drawing.Point(89, 507);
            this.lblTimeElapsed.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(65, 19);
            this.lblTimeElapsed.TabIndex = 12;
            this.lblTimeElapsed.Text = "00:00:00";
            // 
            // lblPaused
            // 
            this.lblPaused.AutoSize = true;
            this.lblPaused.Depth = 0;
            this.lblPaused.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPaused.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPaused.Location = new System.Drawing.Point(234, 495);
            this.lblPaused.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPaused.Name = "lblPaused";
            this.lblPaused.Size = new System.Drawing.Size(66, 19);
            this.lblPaused.TabIndex = 16;
            this.lblPaused.Text = "PAUSED";
            // 
            // btnShuffle
            // 
            this.btnShuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuffle.Location = new System.Drawing.Point(534, 490);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(69, 36);
            this.btnShuffle.TabIndex = 17;
            this.btnShuffle.Text = "SHUFFLE";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnPause
            // 
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Location = new System.Drawing.Point(459, 490);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(69, 36);
            this.btnPause.TabIndex = 18;
            this.btnPause.Text = "PAUSE";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.PauseOrResume);
            // 
            // btnQuit
            // 
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.Location = new System.Drawing.Point(609, 490);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(69, 36);
            this.btnQuit.TabIndex = 19;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // gbPuzzleBox2
            // 
            this.gbPuzzleBox2.Controls.Add(this.pbx21);
            this.gbPuzzleBox2.Controls.Add(this.pbx22);
            this.gbPuzzleBox2.Controls.Add(this.pbx23);
            this.gbPuzzleBox2.Controls.Add(this.pbx24);
            this.gbPuzzleBox2.Controls.Add(this.pbx25);
            this.gbPuzzleBox2.Controls.Add(this.pbx26);
            this.gbPuzzleBox2.Controls.Add(this.pbx27);
            this.gbPuzzleBox2.Controls.Add(this.pbx28);
            this.gbPuzzleBox2.Controls.Add(this.pbx29);
            this.gbPuzzleBox2.Location = new System.Drawing.Point(6, 7);
            this.gbPuzzleBox2.Name = "gbPuzzleBox2";
            this.gbPuzzleBox2.Size = new System.Drawing.Size(335, 342);
            this.gbPuzzleBox2.TabIndex = 7;
            this.gbPuzzleBox2.TabStop = false;
            // 
            // pbx21
            // 
            this.pbx21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx21.Location = new System.Drawing.Point(17, 23);
            this.pbx21.Name = "pbx21";
            this.pbx21.Size = new System.Drawing.Size(100, 100);
            this.pbx21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx21.TabIndex = 0;
            this.pbx21.TabStop = false;
            this.pbx21.Click += new System.EventHandler(this.SwitchPictureBox2);
            // 
            // pbx22
            // 
            this.pbx22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx22.Location = new System.Drawing.Point(118, 23);
            this.pbx22.Name = "pbx22";
            this.pbx22.Size = new System.Drawing.Size(100, 100);
            this.pbx22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx22.TabIndex = 0;
            this.pbx22.TabStop = false;
            this.pbx22.Click += new System.EventHandler(this.SwitchPictureBox2);
            // 
            // pbx23
            // 
            this.pbx23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx23.Location = new System.Drawing.Point(219, 23);
            this.pbx23.Name = "pbx23";
            this.pbx23.Size = new System.Drawing.Size(100, 100);
            this.pbx23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx23.TabIndex = 0;
            this.pbx23.TabStop = false;
            this.pbx23.Click += new System.EventHandler(this.SwitchPictureBox2);
            // 
            // pbx24
            // 
            this.pbx24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx24.Location = new System.Drawing.Point(17, 124);
            this.pbx24.Name = "pbx24";
            this.pbx24.Size = new System.Drawing.Size(100, 100);
            this.pbx24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx24.TabIndex = 0;
            this.pbx24.TabStop = false;
            this.pbx24.Click += new System.EventHandler(this.SwitchPictureBox2);
            // 
            // pbx25
            // 
            this.pbx25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx25.Location = new System.Drawing.Point(118, 124);
            this.pbx25.Name = "pbx25";
            this.pbx25.Size = new System.Drawing.Size(100, 100);
            this.pbx25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx25.TabIndex = 0;
            this.pbx25.TabStop = false;
            this.pbx25.Click += new System.EventHandler(this.SwitchPictureBox2);
            // 
            // pbx26
            // 
            this.pbx26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx26.Location = new System.Drawing.Point(219, 124);
            this.pbx26.Name = "pbx26";
            this.pbx26.Size = new System.Drawing.Size(100, 100);
            this.pbx26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx26.TabIndex = 0;
            this.pbx26.TabStop = false;
            this.pbx26.Click += new System.EventHandler(this.SwitchPictureBox2);
            // 
            // pbx27
            // 
            this.pbx27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx27.Location = new System.Drawing.Point(17, 225);
            this.pbx27.Name = "pbx27";
            this.pbx27.Size = new System.Drawing.Size(100, 100);
            this.pbx27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx27.TabIndex = 0;
            this.pbx27.TabStop = false;
            this.pbx27.Click += new System.EventHandler(this.SwitchPictureBox2);
            // 
            // pbx28
            // 
            this.pbx28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx28.Location = new System.Drawing.Point(118, 225);
            this.pbx28.Name = "pbx28";
            this.pbx28.Size = new System.Drawing.Size(100, 100);
            this.pbx28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx28.TabIndex = 0;
            this.pbx28.TabStop = false;
            this.pbx28.Click += new System.EventHandler(this.SwitchPictureBox2);
            // 
            // pbx29
            // 
            this.pbx29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx29.Location = new System.Drawing.Point(219, 225);
            this.pbx29.Name = "pbx29";
            this.pbx29.Size = new System.Drawing.Size(100, 100);
            this.pbx29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx29.TabIndex = 0;
            this.pbx29.TabStop = false;
            this.pbx29.Click += new System.EventHandler(this.SwitchPictureBox2);
            // 
            // group2
            // 
            this.group2.Controls.Add(this.gbOriginal2);
            this.group2.Controls.Add(this.gbPuzzleBox2);
            this.group2.Location = new System.Drawing.Point(13, 114);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(675, 355);
            this.group2.TabIndex = 20;
            this.group2.TabStop = false;
            // 
            // gbOriginal2
            // 
            this.gbOriginal2.BackgroundImage = global::Picture_Puzzle_Game.Properties.Resources.tiger;
            this.gbOriginal2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbOriginal2.Location = new System.Drawing.Point(366, 30);
            this.gbOriginal2.Name = "gbOriginal2";
            this.gbOriginal2.Size = new System.Drawing.Size(300, 300);
            this.gbOriginal2.TabIndex = 6;
            this.gbOriginal2.TabStop = false;
            // 
            // group1
            // 
            this.group1.Controls.Add(this.gbPuzzleBox);
            this.group1.Controls.Add(this.gbOriginal);
            this.group1.Location = new System.Drawing.Point(13, 114);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(675, 355);
            this.group1.TabIndex = 21;
            this.group1.TabStop = false;
            // 
            // gbOriginal
            // 
            this.gbOriginal.BackgroundImage = global::Picture_Puzzle_Game.Properties.Resources.moriginal;
            this.gbOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbOriginal.Location = new System.Drawing.Point(365, 30);
            this.gbOriginal.Name = "gbOriginal";
            this.gbOriginal.Size = new System.Drawing.Size(300, 300);
            this.gbOriginal.TabIndex = 5;
            this.gbOriginal.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(112, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 31);
            this.label2.TabIndex = 24;
            this.label2.Text = "GAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(112, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "PICTURE PUZZLE";
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Location = new System.Drawing.Point(534, 26);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(69, 36);
            this.btnHelp.TabIndex = 26;
            this.btnHelp.Text = "HELP";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.Location = new System.Drawing.Point(609, 26);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(69, 36);
            this.btnAbout.TabIndex = 25;
            this.btnAbout.Text = "ABOUT";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Picture_Puzzle_Game.Properties.Resources.puzzle;
            this.pictureBox1.Location = new System.Drawing.Point(19, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnRestart
            // 
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Location = new System.Drawing.Point(384, 490);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(69, 36);
            this.btnRestart.TabIndex = 27;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.ForeColor = System.Drawing.Color.Black;
            this.lblLabel.Location = new System.Drawing.Point(311, 87);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(96, 24);
            this.lblLabel.TabIndex = 28;
            this.lblLabel.Text = "LEVEL 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 536);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.lblPaused);
            this.Controls.Add(this.lblTimeElapsed);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.lblMovesMade);
            this.Controls.Add(this.group1);
            this.Controls.Add(this.group2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AskPermissionBeforeQuite);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPuzzleBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).EndInit();
            this.gbPuzzleBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx29)).EndInit();
            this.group2.ResumeLayout(false);
            this.group1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.PictureBox pbx5;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.Timer tmrTimeElapse;
        private System.Windows.Forms.PictureBox pbx8;
        private System.Windows.Forms.GroupBox gbOriginal;
        private System.Windows.Forms.PictureBox pbx9;
        private System.Windows.Forms.GroupBox gbPuzzleBox;
        private MaterialSkin.Controls.MaterialLabel lblMovesMade;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblTimeElapsed;
        private MaterialSkin.Controls.MaterialLabel lblPaused;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.GroupBox gbOriginal2;
        private System.Windows.Forms.PictureBox pbx29;
        private System.Windows.Forms.PictureBox pbx28;
        private System.Windows.Forms.PictureBox pbx27;
        private System.Windows.Forms.PictureBox pbx26;
        private System.Windows.Forms.PictureBox pbx25;
        private System.Windows.Forms.PictureBox pbx24;
        private System.Windows.Forms.PictureBox pbx23;
        private System.Windows.Forms.PictureBox pbx22;
        private System.Windows.Forms.PictureBox pbx21;
        private System.Windows.Forms.GroupBox gbPuzzleBox2;
        private System.Windows.Forms.GroupBox group2;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblLabel;
    }
}

