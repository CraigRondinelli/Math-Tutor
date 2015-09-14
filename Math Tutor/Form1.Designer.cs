namespace Math_Tutor
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
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblProblem = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.radHard = new System.Windows.Forms.RadioButton();
            this.radEasy = new System.Windows.Forms.RadioButton();
            this.radMult = new System.Windows.Forms.RadioButton();
            this.radSub = new System.Windows.Forms.RadioButton();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.problemBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAttempt = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblWrong = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picMarioStand = new System.Windows.Forms.PictureBox();
            this.picCoin = new System.Windows.Forms.PictureBox();
            this.picMarioJump = new System.Windows.Forms.PictureBox();
            this.timerProblem = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.timerJump = new System.Windows.Forms.Timer(this.components);
            this.timerCoin = new System.Windows.Forms.Timer(this.components);
            this.picBullet = new System.Windows.Forms.PictureBox();
            this.timerBullet = new System.Windows.Forms.Timer(this.components);
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.picDead = new System.Windows.Forms.PictureBox();
            this.timerDead = new System.Windows.Forms.Timer(this.components);
            this.timerStandVisible = new System.Windows.Forms.Timer(this.components);
            this.problemBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMarioStand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMarioJump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDead)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.White;
            this.txtAnswer.Font = new System.Drawing.Font("Moire", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(193, 174);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(85, 33);
            this.txtAnswer.TabIndex = 17;
            this.txtAnswer.TextChanged += new System.EventHandler(this.txtAnswer_TextChanged);
            // 
            // lblProblem
            // 
            this.lblProblem.AutoSize = true;
            this.lblProblem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(136)))), ((int)(((byte)(254)))));
            this.lblProblem.Font = new System.Drawing.Font("Moire", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblem.Location = new System.Drawing.Point(7, 172);
            this.lblProblem.Name = "lblProblem";
            this.lblProblem.Size = new System.Drawing.Size(0, 33);
            this.lblProblem.TabIndex = 16;
            this.lblProblem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Font = new System.Drawing.Font("Moire", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(193, 496);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(123, 26);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check Answer";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnNew
            // 
            this.btnNew.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNew.Font = new System.Drawing.Font("Moire", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(7, 496);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(123, 26);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New Problem";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // radHard
            // 
            this.radHard.AutoSize = true;
            this.radHard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(136)))), ((int)(((byte)(254)))));
            this.radHard.Font = new System.Drawing.Font("Moire", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHard.Location = new System.Drawing.Point(11, 81);
            this.radHard.Name = "radHard";
            this.radHard.Size = new System.Drawing.Size(136, 23);
            this.radHard.TabIndex = 13;
            this.radHard.Text = "&Hard (0 - 24)";
            this.radHard.UseVisualStyleBackColor = false;
            // 
            // radEasy
            // 
            this.radEasy.AutoSize = true;
            this.radEasy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(136)))), ((int)(((byte)(254)))));
            this.radEasy.Checked = true;
            this.radEasy.Font = new System.Drawing.Font("Moire", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEasy.Location = new System.Drawing.Point(11, 36);
            this.radEasy.Name = "radEasy";
            this.radEasy.Size = new System.Drawing.Size(134, 23);
            this.radEasy.TabIndex = 12;
            this.radEasy.TabStop = true;
            this.radEasy.Text = "&Easy (0 - 12)";
            this.radEasy.UseVisualStyleBackColor = false;
            // 
            // radMult
            // 
            this.radMult.AutoSize = true;
            this.radMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(136)))), ((int)(((byte)(254)))));
            this.radMult.Font = new System.Drawing.Font("Moire", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMult.Location = new System.Drawing.Point(6, 96);
            this.radMult.Name = "radMult";
            this.radMult.Size = new System.Drawing.Size(141, 23);
            this.radMult.TabIndex = 11;
            this.radMult.Text = "&Multiplication";
            this.radMult.UseVisualStyleBackColor = false;
            // 
            // radSub
            // 
            this.radSub.AutoSize = true;
            this.radSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(136)))), ((int)(((byte)(254)))));
            this.radSub.Font = new System.Drawing.Font("Moire", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSub.Location = new System.Drawing.Point(6, 63);
            this.radSub.Name = "radSub";
            this.radSub.Size = new System.Drawing.Size(129, 23);
            this.radSub.TabIndex = 10;
            this.radSub.Text = "&Subtraction";
            this.radSub.UseVisualStyleBackColor = false;
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(136)))), ((int)(((byte)(254)))));
            this.radAdd.Checked = true;
            this.radAdd.Font = new System.Drawing.Font("Moire", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdd.Location = new System.Drawing.Point(6, 30);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(97, 23);
            this.radAdd.TabIndex = 9;
            this.radAdd.TabStop = true;
            this.radAdd.Text = "&Addition";
            this.radAdd.UseVisualStyleBackColor = false;
            // 
            // problemBox
            // 
            this.problemBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("problemBox.BackgroundImage")));
            this.problemBox.Controls.Add(this.label1);
            this.problemBox.Controls.Add(this.radAdd);
            this.problemBox.Controls.Add(this.radSub);
            this.problemBox.Controls.Add(this.radMult);
            this.problemBox.Location = new System.Drawing.Point(9, 16);
            this.problemBox.Name = "problemBox";
            this.problemBox.Size = new System.Drawing.Size(189, 132);
            this.problemBox.TabIndex = 18;
            this.problemBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(136)))), ((int)(((byte)(254)))));
            this.label1.Font = new System.Drawing.Font("Moire", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Type of Problem";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radEasy);
            this.groupBox1.Controls.Add(this.radHard);
            this.groupBox1.Location = new System.Drawing.Point(229, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 132);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(136)))), ((int)(((byte)(254)))));
            this.label2.Font = new System.Drawing.Font("Moire", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Difficulty";
            // 
            // lblAttempt
            // 
            this.lblAttempt.AutoSize = true;
            this.lblAttempt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(136)))), ((int)(((byte)(254)))));
            this.lblAttempt.Font = new System.Drawing.Font("Moire ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttempt.Location = new System.Drawing.Point(30, 364);
            this.lblAttempt.Name = "lblAttempt";
            this.lblAttempt.Size = new System.Drawing.Size(0, 23);
            this.lblAttempt.TabIndex = 20;
            this.lblAttempt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(136)))), ((int)(((byte)(254)))));
            this.lblCorrect.Font = new System.Drawing.Font("Moire ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.Location = new System.Drawing.Point(30, 257);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(0, 23);
            this.lblCorrect.TabIndex = 21;
            this.lblCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(136)))), ((int)(((byte)(254)))));
            this.lblWrong.Font = new System.Drawing.Font("Moire ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong.Location = new System.Drawing.Point(30, 311);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(0, 23);
            this.lblWrong.TabIndex = 22;
            this.lblWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(136)))), ((int)(((byte)(254)))));
            this.lblPercent.Font = new System.Drawing.Font("Moire ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.Location = new System.Drawing.Point(30, 422);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(0, 23);
            this.lblPercent.TabIndex = 23;
            this.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Moire", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(415, 496);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 26);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Moire", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(645, 496);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 26);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(136)))), ((int)(((byte)(254)))));
            this.label3.Font = new System.Drawing.Font("Moire", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Attemped Problems";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(136)))), ((int)(((byte)(254)))));
            this.label4.Font = new System.Drawing.Font("Moire", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Wrong";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(136)))), ((int)(((byte)(254)))));
            this.label5.Font = new System.Drawing.Font("Moire", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Correct";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(136)))), ((int)(((byte)(254)))));
            this.label6.Font = new System.Drawing.Font("Moire", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Percentage";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Moire", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(855, 496);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 26);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Snow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(989, 536);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // picMarioStand
            // 
            this.picMarioStand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.picMarioStand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMarioStand.BackgroundImage")));
            this.picMarioStand.Image = ((System.Drawing.Image)(resources.GetObject("picMarioStand.Image")));
            this.picMarioStand.Location = new System.Drawing.Point(534, 253);
            this.picMarioStand.Name = "picMarioStand";
            this.picMarioStand.Size = new System.Drawing.Size(69, 71);
            this.picMarioStand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMarioStand.TabIndex = 32;
            this.picMarioStand.TabStop = false;
            // 
            // picCoin
            // 
            this.picCoin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCoin.BackgroundImage")));
            this.picCoin.Image = ((System.Drawing.Image)(resources.GetObject("picCoin.Image")));
            this.picCoin.Location = new System.Drawing.Point(565, 128);
            this.picCoin.Name = "picCoin";
            this.picCoin.Size = new System.Drawing.Size(41, 42);
            this.picCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoin.TabIndex = 33;
            this.picCoin.TabStop = false;
            this.picCoin.Visible = false;
            // 
            // picMarioJump
            // 
            this.picMarioJump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.picMarioJump.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMarioJump.BackgroundImage")));
            this.picMarioJump.Image = ((System.Drawing.Image)(resources.GetObject("picMarioJump.Image")));
            this.picMarioJump.Location = new System.Drawing.Point(534, 250);
            this.picMarioJump.Name = "picMarioJump";
            this.picMarioJump.Size = new System.Drawing.Size(63, 68);
            this.picMarioJump.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMarioJump.TabIndex = 34;
            this.picMarioJump.TabStop = false;
            this.picMarioJump.Visible = false;
            // 
            // timerProblem
            // 
            this.timerProblem.Interval = 1000;
            this.timerProblem.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(136)))), ((int)(((byte)(254)))));
            this.lblTimer.Font = new System.Drawing.Font("Moire", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(861, 5);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(113, 33);
            this.lblTimer.TabIndex = 35;
            this.lblTimer.Text = "00 : 00";
            // 
            // timerJump
            // 
            this.timerJump.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timerCoin
            // 
            this.timerCoin.Tick += new System.EventHandler(this.timerCoin_Tick);
            // 
            // picBullet
            // 
            this.picBullet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBullet.BackgroundImage")));
            this.picBullet.Image = ((System.Drawing.Image)(resources.GetObject("picBullet.Image")));
            this.picBullet.Location = new System.Drawing.Point(987, 242);
            this.picBullet.Name = "picBullet";
            this.picBullet.Size = new System.Drawing.Size(113, 78);
            this.picBullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBullet.TabIndex = 36;
            this.picBullet.TabStop = false;
            // 
            // timerBullet
            // 
            this.timerBullet.Tick += new System.EventHandler(this.timerBullet_Tick);
            // 
            // picTitle
            // 
            this.picTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(136)))), ((int)(((byte)(254)))));
            this.picTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picTitle.Image = ((System.Drawing.Image)(resources.GetObject("picTitle.Image")));
            this.picTitle.Location = new System.Drawing.Point(699, 150);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(315, 250);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitle.TabIndex = 37;
            this.picTitle.TabStop = false;
            this.picTitle.Click += new System.EventHandler(this.picTitle_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(136)))), ((int)(((byte)(254)))));
            this.lblAnswer.Font = new System.Drawing.Font("Moire", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(163, 224);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 25);
            this.lblAnswer.TabIndex = 38;
            // 
            // picDead
            // 
            this.picDead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(136)))), ((int)(((byte)(254)))));
            this.picDead.Image = ((System.Drawing.Image)(resources.GetObject("picDead.Image")));
            this.picDead.Location = new System.Drawing.Point(534, 257);
            this.picDead.Name = "picDead";
            this.picDead.Size = new System.Drawing.Size(67, 60);
            this.picDead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDead.TabIndex = 39;
            this.picDead.TabStop = false;
            this.picDead.Visible = false;
            // 
            // timerDead
            // 
            this.timerDead.Tick += new System.EventHandler(this.timerDead_Tick);
            // 
            // timerStandVisible
            // 
            this.timerStandVisible.Tick += new System.EventHandler(this.timerStandVisible_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnNew;
            this.ClientSize = new System.Drawing.Size(987, 525);
            this.Controls.Add(this.picDead);
            this.Controls.Add(this.picBullet);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.picTitle);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.picMarioJump);
            this.Controls.Add(this.picCoin);
            this.Controls.Add(this.picMarioStand);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblWrong);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblAttempt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.problemBox);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblProblem);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.problemBox.ResumeLayout(false);
            this.problemBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMarioStand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMarioJump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblProblem;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.RadioButton radHard;
        private System.Windows.Forms.RadioButton radEasy;
        private System.Windows.Forms.RadioButton radMult;
        private System.Windows.Forms.RadioButton radSub;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.GroupBox problemBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAttempt;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblWrong;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picMarioStand;
        private System.Windows.Forms.PictureBox picCoin;
        private System.Windows.Forms.PictureBox picMarioJump;
        private System.Windows.Forms.Timer timerProblem;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timerJump;
        private System.Windows.Forms.Timer timerCoin;
        private System.Windows.Forms.PictureBox picBullet;
        private System.Windows.Forms.Timer timerBullet;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.PictureBox picDead;
        private System.Windows.Forms.Timer timerDead;
        private System.Windows.Forms.Timer timerStandVisible;
        
    }
}

