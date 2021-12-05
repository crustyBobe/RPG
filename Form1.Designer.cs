
namespace FinalProject
{
    partial class RPG
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPG));
            this.attackBox = new System.Windows.Forms.CheckBox();
            this.defendBox = new System.Windows.Forms.CheckBox();
            this.specialBox = new System.Windows.Forms.CheckBox();
            this.backPanel = new System.Windows.Forms.Panel();
            this.banditBox = new System.Windows.Forms.CheckBox();
            this.actionButton = new System.Windows.Forms.Button();
            this.banditThreeBox = new System.Windows.Forms.CheckBox();
            this.banditTwoBox = new System.Windows.Forms.CheckBox();
            this.dragonBox = new System.Windows.Forms.CheckBox();
            this.warriorBox = new System.Windows.Forms.CheckBox();
            this.mageBox = new System.Windows.Forms.CheckBox();
            this.trollThreeBox = new System.Windows.Forms.CheckBox();
            this.trollBox = new System.Windows.Forms.CheckBox();
            this.clericBox = new System.Windows.Forms.CheckBox();
            this.trollTwoBox = new System.Windows.Forms.CheckBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.banditPicture = new System.Windows.Forms.PictureBox();
            this.dragonPicture = new System.Windows.Forms.PictureBox();
            this.trollPicture = new System.Windows.Forms.PictureBox();
            this.magePicture = new System.Windows.Forms.PictureBox();
            this.clericPicture = new System.Windows.Forms.PictureBox();
            this.warriorPicture = new System.Windows.Forms.PictureBox();
            this.warriorHealth = new System.Windows.Forms.ProgressBar();
            this.mageHealth = new System.Windows.Forms.ProgressBar();
            this.clericHealth = new System.Windows.Forms.ProgressBar();
            this.banditHealth = new System.Windows.Forms.ProgressBar();
            this.dragonHealth = new System.Windows.Forms.ProgressBar();
            this.trollHealth = new System.Windows.Forms.ProgressBar();
            this.banditTwoPicture = new System.Windows.Forms.PictureBox();
            this.banditTwoHealth = new System.Windows.Forms.ProgressBar();
            this.banditThreePicture = new System.Windows.Forms.PictureBox();
            this.banditThreeHealth = new System.Windows.Forms.ProgressBar();
            this.trollThreePicture = new System.Windows.Forms.PictureBox();
            this.trollThreeHealth = new System.Windows.Forms.ProgressBar();
            this.trollTwoHealth = new System.Windows.Forms.ProgressBar();
            this.trollTwoPicture = new System.Windows.Forms.PictureBox();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banditPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trollPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clericPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warriorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banditTwoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banditThreePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trollThreePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trollTwoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // attackBox
            // 
            this.attackBox.AutoSize = true;
            this.attackBox.Location = new System.Drawing.Point(346, 10);
            this.attackBox.Name = "attackBox";
            this.attackBox.Size = new System.Drawing.Size(60, 19);
            this.attackBox.TabIndex = 0;
            this.attackBox.Text = "Attack";
            this.attackBox.UseVisualStyleBackColor = true;
            this.attackBox.CheckedChanged += new System.EventHandler(this.AttackBox_CheckedChanged);
            // 
            // defendBox
            // 
            this.defendBox.AutoSize = true;
            this.defendBox.Location = new System.Drawing.Point(346, 57);
            this.defendBox.Name = "defendBox";
            this.defendBox.Size = new System.Drawing.Size(64, 19);
            this.defendBox.TabIndex = 1;
            this.defendBox.Text = "Defend";
            this.defendBox.UseVisualStyleBackColor = true;
            this.defendBox.CheckedChanged += new System.EventHandler(this.DefendBox_CheckedChanged);
            // 
            // specialBox
            // 
            this.specialBox.AutoSize = true;
            this.specialBox.Location = new System.Drawing.Point(346, 109);
            this.specialBox.Name = "specialBox";
            this.specialBox.Size = new System.Drawing.Size(63, 19);
            this.specialBox.TabIndex = 2;
            this.specialBox.Text = "Special";
            this.specialBox.UseVisualStyleBackColor = true;
            this.specialBox.CheckedChanged += new System.EventHandler(this.SpecialBox_CheckedChanged);
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.SystemColors.Control;
            this.backPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.backPanel.Controls.Add(this.banditBox);
            this.backPanel.Controls.Add(this.actionButton);
            this.backPanel.Controls.Add(this.banditThreeBox);
            this.backPanel.Controls.Add(this.banditTwoBox);
            this.backPanel.Controls.Add(this.dragonBox);
            this.backPanel.Controls.Add(this.warriorBox);
            this.backPanel.Controls.Add(this.mageBox);
            this.backPanel.Controls.Add(this.trollThreeBox);
            this.backPanel.Controls.Add(this.trollBox);
            this.backPanel.Controls.Add(this.clericBox);
            this.backPanel.Controls.Add(this.trollTwoBox);
            this.backPanel.Controls.Add(this.outputBox);
            this.backPanel.Controls.Add(this.progressBar3);
            this.backPanel.Controls.Add(this.progressBar1);
            this.backPanel.Controls.Add(this.progressBar2);
            this.backPanel.Controls.Add(this.specialBox);
            this.backPanel.Controls.Add(this.defendBox);
            this.backPanel.Controls.Add(this.attackBox);
            this.backPanel.Location = new System.Drawing.Point(-2, 315);
            this.backPanel.Name = "backPanel";
            this.backPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.backPanel.Size = new System.Drawing.Size(888, 136);
            this.backPanel.TabIndex = 7;
            // 
            // banditBox
            // 
            this.banditBox.AutoSize = true;
            this.banditBox.Location = new System.Drawing.Point(425, 10);
            this.banditBox.Name = "banditBox";
            this.banditBox.Size = new System.Drawing.Size(60, 19);
            this.banditBox.TabIndex = 25;
            this.banditBox.Text = "Bandit";
            this.banditBox.UseVisualStyleBackColor = true;
            this.banditBox.CheckedChanged += new System.EventHandler(this.BanditBox_CheckedChanged);
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(519, 6);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(357, 23);
            this.actionButton.TabIndex = 12;
            this.actionButton.Text = "Act";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // banditThreeBox
            // 
            this.banditThreeBox.AutoSize = true;
            this.banditThreeBox.Location = new System.Drawing.Point(425, 109);
            this.banditThreeBox.Name = "banditThreeBox";
            this.banditThreeBox.Size = new System.Drawing.Size(92, 19);
            this.banditThreeBox.TabIndex = 24;
            this.banditThreeBox.Text = "Bandit Three";
            this.banditThreeBox.UseVisualStyleBackColor = true;
            this.banditThreeBox.Visible = false;
            this.banditThreeBox.CheckedChanged += new System.EventHandler(this.BanditThreeBox_CheckedChanged);
            // 
            // banditTwoBox
            // 
            this.banditTwoBox.AutoSize = true;
            this.banditTwoBox.Location = new System.Drawing.Point(425, 57);
            this.banditTwoBox.Name = "banditTwoBox";
            this.banditTwoBox.Size = new System.Drawing.Size(84, 19);
            this.banditTwoBox.TabIndex = 23;
            this.banditTwoBox.Text = "Bandit Two";
            this.banditTwoBox.UseVisualStyleBackColor = true;
            this.banditTwoBox.Visible = false;
            this.banditTwoBox.CheckedChanged += new System.EventHandler(this.BanditTwoBox_CheckedChanged);
            // 
            // dragonBox
            // 
            this.dragonBox.AutoSize = true;
            this.dragonBox.Location = new System.Drawing.Point(425, 109);
            this.dragonBox.Name = "dragonBox";
            this.dragonBox.Size = new System.Drawing.Size(65, 19);
            this.dragonBox.TabIndex = 23;
            this.dragonBox.Text = "Dragon";
            this.dragonBox.UseVisualStyleBackColor = true;
            this.dragonBox.Visible = false;
            this.dragonBox.CheckedChanged += new System.EventHandler(this.DragonBox_CheckedChanged);
            // 
            // warriorBox
            // 
            this.warriorBox.AutoSize = true;
            this.warriorBox.Location = new System.Drawing.Point(10, 10);
            this.warriorBox.Name = "warriorBox";
            this.warriorBox.Size = new System.Drawing.Size(65, 19);
            this.warriorBox.TabIndex = 8;
            this.warriorBox.Text = "Warrior";
            this.warriorBox.UseVisualStyleBackColor = true;
            this.warriorBox.CheckedChanged += new System.EventHandler(this.WarriorBox_CheckedChanged);
            // 
            // mageBox
            // 
            this.mageBox.AutoSize = true;
            this.mageBox.Location = new System.Drawing.Point(10, 57);
            this.mageBox.Name = "mageBox";
            this.mageBox.Size = new System.Drawing.Size(56, 19);
            this.mageBox.TabIndex = 9;
            this.mageBox.Text = "Mage";
            this.mageBox.UseVisualStyleBackColor = true;
            this.mageBox.CheckedChanged += new System.EventHandler(this.MageBox_CheckedChanged);
            // 
            // trollThreeBox
            // 
            this.trollThreeBox.AutoSize = true;
            this.trollThreeBox.Location = new System.Drawing.Point(425, 109);
            this.trollThreeBox.Name = "trollThreeBox";
            this.trollThreeBox.Size = new System.Drawing.Size(80, 19);
            this.trollThreeBox.TabIndex = 26;
            this.trollThreeBox.Text = "Troll Three";
            this.trollThreeBox.UseVisualStyleBackColor = true;
            this.trollThreeBox.Visible = false;
            this.trollThreeBox.CheckedChanged += new System.EventHandler(this.TrollThreeBox_CheckedChanged);
            // 
            // trollBox
            // 
            this.trollBox.AutoSize = true;
            this.trollBox.Location = new System.Drawing.Point(425, 57);
            this.trollBox.Name = "trollBox";
            this.trollBox.Size = new System.Drawing.Size(48, 19);
            this.trollBox.TabIndex = 24;
            this.trollBox.Text = "Troll";
            this.trollBox.UseVisualStyleBackColor = true;
            this.trollBox.Visible = false;
            this.trollBox.CheckedChanged += new System.EventHandler(this.TrollBox_CheckedChanged);
            // 
            // clericBox
            // 
            this.clericBox.AutoSize = true;
            this.clericBox.Location = new System.Drawing.Point(11, 109);
            this.clericBox.Name = "clericBox";
            this.clericBox.Size = new System.Drawing.Size(56, 19);
            this.clericBox.TabIndex = 10;
            this.clericBox.Text = "Cleric";
            this.clericBox.UseVisualStyleBackColor = true;
            this.clericBox.CheckedChanged += new System.EventHandler(this.ClericBox_CheckedChanged);
            // 
            // trollTwoBox
            // 
            this.trollTwoBox.AutoSize = true;
            this.trollTwoBox.Location = new System.Drawing.Point(425, 10);
            this.trollTwoBox.Name = "trollTwoBox";
            this.trollTwoBox.Size = new System.Drawing.Size(72, 19);
            this.trollTwoBox.TabIndex = 25;
            this.trollTwoBox.Text = "Troll Two";
            this.trollTwoBox.UseVisualStyleBackColor = true;
            this.trollTwoBox.Visible = false;
            this.trollTwoBox.CheckedChanged += new System.EventHandler(this.TrollTwoBox_CheckedChanged);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(519, 35);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(353, 99);
            this.outputBox.TabIndex = 11;
            this.outputBox.Text = "";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(81, 105);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(253, 23);
            this.progressBar3.TabIndex = 10;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(81, 53);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(253, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(81, 6);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(253, 23);
            this.progressBar2.TabIndex = 9;
            // 
            // banditPicture
            // 
            this.banditPicture.Image = ((System.Drawing.Image)(resources.GetObject("banditPicture.Image")));
            this.banditPicture.Location = new System.Drawing.Point(594, 26);
            this.banditPicture.Name = "banditPicture";
            this.banditPicture.Size = new System.Drawing.Size(90, 81);
            this.banditPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.banditPicture.TabIndex = 11;
            this.banditPicture.TabStop = false;
            // 
            // dragonPicture
            // 
            this.dragonPicture.Image = ((System.Drawing.Image)(resources.GetObject("dragonPicture.Image")));
            this.dragonPicture.Location = new System.Drawing.Point(657, 144);
            this.dragonPicture.Name = "dragonPicture";
            this.dragonPicture.Size = new System.Drawing.Size(107, 100);
            this.dragonPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dragonPicture.TabIndex = 12;
            this.dragonPicture.TabStop = false;
            this.dragonPicture.Visible = false;
            // 
            // trollPicture
            // 
            this.trollPicture.Image = ((System.Drawing.Image)(resources.GetObject("trollPicture.Image")));
            this.trollPicture.Location = new System.Drawing.Point(770, 100);
            this.trollPicture.Name = "trollPicture";
            this.trollPicture.Size = new System.Drawing.Size(90, 88);
            this.trollPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trollPicture.TabIndex = 13;
            this.trollPicture.TabStop = false;
            this.trollPicture.Visible = false;
            // 
            // magePicture
            // 
            this.magePicture.Image = ((System.Drawing.Image)(resources.GetObject("magePicture.Image")));
            this.magePicture.Location = new System.Drawing.Point(20, 100);
            this.magePicture.Name = "magePicture";
            this.magePicture.Size = new System.Drawing.Size(90, 102);
            this.magePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.magePicture.TabIndex = 16;
            this.magePicture.TabStop = false;
            // 
            // clericPicture
            // 
            this.clericPicture.Image = ((System.Drawing.Image)(resources.GetObject("clericPicture.Image")));
            this.clericPicture.Location = new System.Drawing.Point(160, 209);
            this.clericPicture.Name = "clericPicture";
            this.clericPicture.Size = new System.Drawing.Size(90, 79);
            this.clericPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clericPicture.TabIndex = 15;
            this.clericPicture.TabStop = false;
            // 
            // warriorPicture
            // 
            this.warriorPicture.Image = ((System.Drawing.Image)(resources.GetObject("warriorPicture.Image")));
            this.warriorPicture.Location = new System.Drawing.Point(161, 40);
            this.warriorPicture.Name = "warriorPicture";
            this.warriorPicture.Size = new System.Drawing.Size(90, 97);
            this.warriorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.warriorPicture.TabIndex = 14;
            this.warriorPicture.TabStop = false;
            // 
            // warriorHealth
            // 
            this.warriorHealth.Location = new System.Drawing.Point(161, 24);
            this.warriorHealth.Name = "warriorHealth";
            this.warriorHealth.Size = new System.Drawing.Size(90, 10);
            this.warriorHealth.TabIndex = 17;
            // 
            // mageHealth
            // 
            this.mageHealth.Location = new System.Drawing.Point(20, 84);
            this.mageHealth.Name = "mageHealth";
            this.mageHealth.Size = new System.Drawing.Size(90, 10);
            this.mageHealth.TabIndex = 18;
            // 
            // clericHealth
            // 
            this.clericHealth.Location = new System.Drawing.Point(160, 192);
            this.clericHealth.Name = "clericHealth";
            this.clericHealth.Size = new System.Drawing.Size(90, 10);
            this.clericHealth.TabIndex = 19;
            // 
            // banditHealth
            // 
            this.banditHealth.Location = new System.Drawing.Point(594, 10);
            this.banditHealth.Name = "banditHealth";
            this.banditHealth.Size = new System.Drawing.Size(90, 10);
            this.banditHealth.TabIndex = 20;
            // 
            // dragonHealth
            // 
            this.dragonHealth.Location = new System.Drawing.Point(657, 127);
            this.dragonHealth.Name = "dragonHealth";
            this.dragonHealth.Size = new System.Drawing.Size(107, 11);
            this.dragonHealth.TabIndex = 21;
            this.dragonHealth.Visible = false;
            // 
            // trollHealth
            // 
            this.trollHealth.Location = new System.Drawing.Point(770, 83);
            this.trollHealth.Name = "trollHealth";
            this.trollHealth.Size = new System.Drawing.Size(90, 10);
            this.trollHealth.TabIndex = 22;
            this.trollHealth.Visible = false;
            // 
            // banditTwoPicture
            // 
            this.banditTwoPicture.Image = ((System.Drawing.Image)(resources.GetObject("banditTwoPicture.Image")));
            this.banditTwoPicture.Location = new System.Drawing.Point(770, 127);
            this.banditTwoPicture.Name = "banditTwoPicture";
            this.banditTwoPicture.Size = new System.Drawing.Size(90, 88);
            this.banditTwoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.banditTwoPicture.TabIndex = 27;
            this.banditTwoPicture.TabStop = false;
            this.banditTwoPicture.Visible = false;
            // 
            // banditTwoHealth
            // 
            this.banditTwoHealth.Location = new System.Drawing.Point(770, 111);
            this.banditTwoHealth.Name = "banditTwoHealth";
            this.banditTwoHealth.Size = new System.Drawing.Size(90, 10);
            this.banditTwoHealth.TabIndex = 28;
            this.banditTwoHealth.Visible = false;
            // 
            // banditThreePicture
            // 
            this.banditThreePicture.Image = ((System.Drawing.Image)(resources.GetObject("banditThreePicture.Image")));
            this.banditThreePicture.Location = new System.Drawing.Point(619, 207);
            this.banditThreePicture.Name = "banditThreePicture";
            this.banditThreePicture.Size = new System.Drawing.Size(90, 81);
            this.banditThreePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.banditThreePicture.TabIndex = 29;
            this.banditThreePicture.TabStop = false;
            this.banditThreePicture.Visible = false;
            // 
            // banditThreeHealth
            // 
            this.banditThreeHealth.Location = new System.Drawing.Point(619, 191);
            this.banditThreeHealth.Name = "banditThreeHealth";
            this.banditThreeHealth.Size = new System.Drawing.Size(90, 10);
            this.banditThreeHealth.TabIndex = 30;
            this.banditThreeHealth.Visible = false;
            // 
            // trollThreePicture
            // 
            this.trollThreePicture.Image = ((System.Drawing.Image)(resources.GetObject("trollThreePicture.Image")));
            this.trollThreePicture.Location = new System.Drawing.Point(550, 221);
            this.trollThreePicture.Name = "trollThreePicture";
            this.trollThreePicture.Size = new System.Drawing.Size(90, 88);
            this.trollThreePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trollThreePicture.TabIndex = 31;
            this.trollThreePicture.TabStop = false;
            this.trollThreePicture.Visible = false;
            // 
            // trollThreeHealth
            // 
            this.trollThreeHealth.Location = new System.Drawing.Point(550, 205);
            this.trollThreeHealth.Name = "trollThreeHealth";
            this.trollThreeHealth.Size = new System.Drawing.Size(90, 10);
            this.trollThreeHealth.TabIndex = 32;
            this.trollThreeHealth.Visible = false;
            // 
            // trollTwoHealth
            // 
            this.trollTwoHealth.Location = new System.Drawing.Point(519, 24);
            this.trollTwoHealth.Name = "trollTwoHealth";
            this.trollTwoHealth.Size = new System.Drawing.Size(90, 10);
            this.trollTwoHealth.TabIndex = 33;
            this.trollTwoHealth.Visible = false;
            // 
            // trollTwoPicture
            // 
            this.trollTwoPicture.Image = ((System.Drawing.Image)(resources.GetObject("trollTwoPicture.Image")));
            this.trollTwoPicture.Location = new System.Drawing.Point(519, 40);
            this.trollTwoPicture.Name = "trollTwoPicture";
            this.trollTwoPicture.Size = new System.Drawing.Size(90, 88);
            this.trollTwoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trollTwoPicture.TabIndex = 34;
            this.trollTwoPicture.TabStop = false;
            this.trollTwoPicture.Visible = false;
            // 
            // RPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 451);
            this.Controls.Add(this.banditThreeHealth);
            this.Controls.Add(this.banditThreePicture);
            this.Controls.Add(this.banditHealth);
            this.Controls.Add(this.banditPicture);
            this.Controls.Add(this.trollTwoPicture);
            this.Controls.Add(this.trollTwoHealth);
            this.Controls.Add(this.trollThreeHealth);
            this.Controls.Add(this.trollThreePicture);
            this.Controls.Add(this.banditTwoHealth);
            this.Controls.Add(this.banditTwoPicture);
            this.Controls.Add(this.trollHealth);
            this.Controls.Add(this.dragonHealth);
            this.Controls.Add(this.clericHealth);
            this.Controls.Add(this.mageHealth);
            this.Controls.Add(this.warriorHealth);
            this.Controls.Add(this.magePicture);
            this.Controls.Add(this.clericPicture);
            this.Controls.Add(this.warriorPicture);
            this.Controls.Add(this.trollPicture);
            this.Controls.Add(this.dragonPicture);
            this.Controls.Add(this.backPanel);
            this.Name = "RPG";
            this.Text = "RPG";
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banditPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trollPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clericPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warriorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banditTwoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banditThreePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trollThreePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trollTwoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox attackBox;
        private System.Windows.Forms.CheckBox defendBox;
        private System.Windows.Forms.CheckBox specialBox;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.CheckBox warriorBox;
        private System.Windows.Forms.CheckBox mageBox;
        private System.Windows.Forms.CheckBox clericBox;
        private System.Windows.Forms.PictureBox banditPicture;
        private System.Windows.Forms.PictureBox dragonPicture;
        private System.Windows.Forms.PictureBox trollPicture;
        private System.Windows.Forms.PictureBox magePicture;
        private System.Windows.Forms.PictureBox clericPicture;
        private System.Windows.Forms.PictureBox warriorPicture;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.ProgressBar warriorHealth;
        private System.Windows.Forms.ProgressBar mageHealth;
        private System.Windows.Forms.ProgressBar clericHealth;
        private System.Windows.Forms.ProgressBar banditHealth;
        private System.Windows.Forms.ProgressBar dragonHealth;
        private System.Windows.Forms.ProgressBar trollHealth;
        private System.Windows.Forms.CheckBox dragon;
        private System.Windows.Forms.CheckBox trollBox;
        private System.Windows.Forms.CheckBox banditBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.CheckBox dragonBox;
        private System.Windows.Forms.CheckBox banditTwoBox;
        private System.Windows.Forms.CheckBox banditThreeBox;
        private System.Windows.Forms.CheckBox trollTwoBox;
        private System.Windows.Forms.CheckBox trollThreeBox;
        private System.Windows.Forms.PictureBox banditTwoPicture;
        private System.Windows.Forms.ProgressBar banditTwoHealth;
        private System.Windows.Forms.PictureBox banditThreePicture;
        private System.Windows.Forms.ProgressBar banditThreeHealth;
        private System.Windows.Forms.PictureBox trollThreePicture;
        private System.Windows.Forms.ProgressBar trollThreeHealth;
        private System.Windows.Forms.ProgressBar trollTwoHealth;
        private System.Windows.Forms.PictureBox trollTwoPicture;
    }
}

