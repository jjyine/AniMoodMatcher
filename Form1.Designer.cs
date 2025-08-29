namespace AnimeMoodMatcher
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.내역불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로젝트정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rdHappy = new System.Windows.Forms.RadioButton();
            this.rdSad = new System.Windows.Forms.RadioButton();
            this.rdDepressed = new System.Windows.Forms.RadioButton();
            this.rdAngry = new System.Windows.Forms.RadioButton();
            this.rdtired = new System.Windows.Forms.RadioButton();
            this.rdLove = new System.Windows.Forms.RadioButton();
            this.rdFriend = new System.Windows.Forms.RadioButton();
            this.rdAdventure = new System.Windows.Forms.RadioButton();
            this.rdEmotion = new System.Windows.Forms.RadioButton();
            this.rdComedy = new System.Windows.Forms.RadioButton();
            this.rdGrowth = new System.Windows.Forms.RadioButton();
            this.rdDaily = new System.Windows.Forms.RadioButton();
            this.rdChallenge = new System.Windows.Forms.RadioButton();
            this.rdFantasy = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdBrainOFF = new System.Windows.Forms.RadioButton();
            this.rdBrainRelax = new System.Windows.Forms.RadioButton();
            this.rdBrainFocus = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnResult);
            this.groupBox1.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "정보 입력";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnResult.Location = new System.Drawing.Point(20, 330);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(343, 52);
            this.btnResult.TabIndex = 6;
            this.btnResult.Text = "결과보기";
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "가장 듣고싶은 이야기는?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "지금 가장 가까운 감정은?";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbResult);
            this.groupBox2.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(410, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 398);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과보기";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(6, 20);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(366, 372);
            this.tbResult.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.내역불러오기ToolStripMenuItem,
            this.toolStripSeparator1,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 내역불러오기ToolStripMenuItem
            // 
            this.내역불러오기ToolStripMenuItem.Name = "내역불러오기ToolStripMenuItem";
            this.내역불러오기ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.내역불러오기ToolStripMenuItem.Text = "내역 불러오기";
            this.내역불러오기ToolStripMenuItem.Click += new System.EventHandler(this.내역불러오기ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.프로젝트정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 프로젝트정보ToolStripMenuItem
            // 
            this.프로젝트정보ToolStripMenuItem.Name = "프로젝트정보ToolStripMenuItem";
            this.프로젝트정보ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.프로젝트정보ToolStripMenuItem.Text = "프로젝트 정보";
            this.프로젝트정보ToolStripMenuItem.Click += new System.EventHandler(this.프로젝트정보ToolStripMenuItem_Click);
            // 
            // rdHappy
            // 
            this.rdHappy.AutoSize = true;
            this.rdHappy.Location = new System.Drawing.Point(15, 49);
            this.rdHappy.Name = "rdHappy";
            this.rdHappy.Size = new System.Drawing.Size(47, 17);
            this.rdHappy.TabIndex = 10;
            this.rdHappy.TabStop = true;
            this.rdHappy.Text = "기쁨";
            this.rdHappy.UseVisualStyleBackColor = true;
            // 
            // rdSad
            // 
            this.rdSad.AutoSize = true;
            this.rdSad.Location = new System.Drawing.Point(68, 49);
            this.rdSad.Name = "rdSad";
            this.rdSad.Size = new System.Drawing.Size(47, 17);
            this.rdSad.TabIndex = 11;
            this.rdSad.TabStop = true;
            this.rdSad.Text = "슬픔";
            this.rdSad.UseVisualStyleBackColor = true;
            // 
            // rdDepressed
            // 
            this.rdDepressed.AutoSize = true;
            this.rdDepressed.Location = new System.Drawing.Point(121, 49);
            this.rdDepressed.Name = "rdDepressed";
            this.rdDepressed.Size = new System.Drawing.Size(47, 17);
            this.rdDepressed.TabIndex = 12;
            this.rdDepressed.TabStop = true;
            this.rdDepressed.Text = "우울";
            this.rdDepressed.UseVisualStyleBackColor = true;
            // 
            // rdAngry
            // 
            this.rdAngry.AutoSize = true;
            this.rdAngry.Location = new System.Drawing.Point(174, 49);
            this.rdAngry.Name = "rdAngry";
            this.rdAngry.Size = new System.Drawing.Size(47, 17);
            this.rdAngry.TabIndex = 13;
            this.rdAngry.TabStop = true;
            this.rdAngry.Text = "분노";
            this.rdAngry.UseVisualStyleBackColor = true;
            // 
            // rdtired
            // 
            this.rdtired.AutoSize = true;
            this.rdtired.Location = new System.Drawing.Point(227, 49);
            this.rdtired.Name = "rdtired";
            this.rdtired.Size = new System.Drawing.Size(47, 17);
            this.rdtired.TabIndex = 14;
            this.rdtired.TabStop = true;
            this.rdtired.Text = "피로";
            this.rdtired.UseVisualStyleBackColor = true;
            // 
            // rdLove
            // 
            this.rdLove.AutoSize = true;
            this.rdLove.Location = new System.Drawing.Point(15, 58);
            this.rdLove.Name = "rdLove";
            this.rdLove.Size = new System.Drawing.Size(47, 17);
            this.rdLove.TabIndex = 15;
            this.rdLove.TabStop = true;
            this.rdLove.Text = "사랑";
            this.rdLove.UseVisualStyleBackColor = true;
            // 
            // rdFriend
            // 
            this.rdFriend.AutoSize = true;
            this.rdFriend.Location = new System.Drawing.Point(68, 58);
            this.rdFriend.Name = "rdFriend";
            this.rdFriend.Size = new System.Drawing.Size(47, 17);
            this.rdFriend.TabIndex = 16;
            this.rdFriend.TabStop = true;
            this.rdFriend.Text = "우정";
            this.rdFriend.UseVisualStyleBackColor = true;
            // 
            // rdAdventure
            // 
            this.rdAdventure.AutoSize = true;
            this.rdAdventure.Location = new System.Drawing.Point(121, 58);
            this.rdAdventure.Name = "rdAdventure";
            this.rdAdventure.Size = new System.Drawing.Size(47, 17);
            this.rdAdventure.TabIndex = 17;
            this.rdAdventure.TabStop = true;
            this.rdAdventure.Text = "모험";
            this.rdAdventure.UseVisualStyleBackColor = true;
            // 
            // rdEmotion
            // 
            this.rdEmotion.AutoSize = true;
            this.rdEmotion.Location = new System.Drawing.Point(174, 58);
            this.rdEmotion.Name = "rdEmotion";
            this.rdEmotion.Size = new System.Drawing.Size(47, 17);
            this.rdEmotion.TabIndex = 18;
            this.rdEmotion.TabStop = true;
            this.rdEmotion.Text = "감동";
            this.rdEmotion.UseVisualStyleBackColor = true;
            // 
            // rdComedy
            // 
            this.rdComedy.AutoSize = true;
            this.rdComedy.Location = new System.Drawing.Point(227, 58);
            this.rdComedy.Name = "rdComedy";
            this.rdComedy.Size = new System.Drawing.Size(58, 17);
            this.rdComedy.TabIndex = 19;
            this.rdComedy.TabStop = true;
            this.rdComedy.Text = "코미디";
            this.rdComedy.UseVisualStyleBackColor = true;
            // 
            // rdGrowth
            // 
            this.rdGrowth.AutoSize = true;
            this.rdGrowth.Location = new System.Drawing.Point(15, 81);
            this.rdGrowth.Name = "rdGrowth";
            this.rdGrowth.Size = new System.Drawing.Size(47, 17);
            this.rdGrowth.TabIndex = 20;
            this.rdGrowth.TabStop = true;
            this.rdGrowth.Text = "성장";
            this.rdGrowth.UseVisualStyleBackColor = true;
            // 
            // rdDaily
            // 
            this.rdDaily.AutoSize = true;
            this.rdDaily.Location = new System.Drawing.Point(68, 81);
            this.rdDaily.Name = "rdDaily";
            this.rdDaily.Size = new System.Drawing.Size(47, 17);
            this.rdDaily.TabIndex = 21;
            this.rdDaily.TabStop = true;
            this.rdDaily.Text = "일상";
            this.rdDaily.UseVisualStyleBackColor = true;
            // 
            // rdChallenge
            // 
            this.rdChallenge.AutoSize = true;
            this.rdChallenge.Location = new System.Drawing.Point(121, 81);
            this.rdChallenge.Name = "rdChallenge";
            this.rdChallenge.Size = new System.Drawing.Size(47, 17);
            this.rdChallenge.TabIndex = 22;
            this.rdChallenge.TabStop = true;
            this.rdChallenge.Text = "도전";
            this.rdChallenge.UseVisualStyleBackColor = true;
            // 
            // rdFantasy
            // 
            this.rdFantasy.AutoSize = true;
            this.rdFantasy.Location = new System.Drawing.Point(174, 81);
            this.rdFantasy.Name = "rdFantasy";
            this.rdFantasy.Size = new System.Drawing.Size(58, 17);
            this.rdFantasy.TabIndex = 23;
            this.rdFantasy.TabStop = true;
            this.rdFantasy.Text = "판타지";
            this.rdFantasy.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdFantasy);
            this.groupBox4.Controls.Add(this.rdChallenge);
            this.groupBox4.Controls.Add(this.rdDaily);
            this.groupBox4.Controls.Add(this.rdGrowth);
            this.groupBox4.Controls.Add(this.rdComedy);
            this.groupBox4.Controls.Add(this.rdEmotion);
            this.groupBox4.Controls.Add(this.rdAdventure);
            this.groupBox4.Controls.Add(this.rdFriend);
            this.groupBox4.Controls.Add(this.rdLove);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(20, 205);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(343, 119);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdtired);
            this.groupBox5.Controls.Add(this.rdAngry);
            this.groupBox5.Controls.Add(this.rdDepressed);
            this.groupBox5.Controls.Add(this.rdSad);
            this.groupBox5.Controls.Add(this.rdHappy);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(20, 116);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(343, 83);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "뇌 상태를 표현한다면?\r\n";
            // 
            // rdBrainOFF
            // 
            this.rdBrainOFF.AutoSize = true;
            this.rdBrainOFF.Location = new System.Drawing.Point(15, 47);
            this.rdBrainOFF.Name = "rdBrainOFF";
            this.rdBrainOFF.Size = new System.Drawing.Size(47, 17);
            this.rdBrainOFF.TabIndex = 7;
            this.rdBrainOFF.TabStop = true;
            this.rdBrainOFF.Text = "OFF";
            this.rdBrainOFF.UseVisualStyleBackColor = true;
            this.rdBrainOFF.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdBrainRelax
            // 
            this.rdBrainRelax.AutoSize = true;
            this.rdBrainRelax.Location = new System.Drawing.Point(68, 47);
            this.rdBrainRelax.Name = "rdBrainRelax";
            this.rdBrainRelax.Size = new System.Drawing.Size(47, 17);
            this.rdBrainRelax.TabIndex = 8;
            this.rdBrainRelax.TabStop = true;
            this.rdBrainRelax.Text = "편안";
            this.rdBrainRelax.UseVisualStyleBackColor = true;
            // 
            // rdBrainFocus
            // 
            this.rdBrainFocus.AutoSize = true;
            this.rdBrainFocus.Location = new System.Drawing.Point(121, 47);
            this.rdBrainFocus.Name = "rdBrainFocus";
            this.rdBrainFocus.Size = new System.Drawing.Size(47, 17);
            this.rdBrainFocus.TabIndex = 9;
            this.rdBrainFocus.TabStop = true;
            this.rdBrainFocus.Text = "집중";
            this.rdBrainFocus.UseVisualStyleBackColor = true;
            this.rdBrainFocus.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.rdBrainFocus);
            this.groupBox3.Controls.Add(this.rdBrainRelax);
            this.groupBox3.Controls.Add(this.rdBrainOFF);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(20, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 83);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "애니무드 프로젝트";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 내역불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로젝트정보ToolStripMenuItem;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.RadioButton rdtired;
        private System.Windows.Forms.RadioButton rdAngry;
        private System.Windows.Forms.RadioButton rdDepressed;
        private System.Windows.Forms.RadioButton rdSad;
        private System.Windows.Forms.RadioButton rdHappy;
        private System.Windows.Forms.RadioButton rdComedy;
        private System.Windows.Forms.RadioButton rdEmotion;
        private System.Windows.Forms.RadioButton rdAdventure;
        private System.Windows.Forms.RadioButton rdFriend;
        private System.Windows.Forms.RadioButton rdLove;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdFantasy;
        private System.Windows.Forms.RadioButton rdChallenge;
        private System.Windows.Forms.RadioButton rdDaily;
        private System.Windows.Forms.RadioButton rdGrowth;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdBrainFocus;
        private System.Windows.Forms.RadioButton rdBrainRelax;
        private System.Windows.Forms.RadioButton rdBrainOFF;
        private System.Windows.Forms.Label label1;
    }
}

