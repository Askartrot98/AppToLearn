namespace AppToLearn
{
    partial class Form1
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
            btnConfirm = new Button();
            btnRunAway = new Button();
            btnMagic = new Button();
            btnStartBattle = new Button();
            pictureBox1 = new PictureBox();
            DialogueBox = new Label();
            textBox = new TextBox();
            btnSword = new Button();
            btnMagicWand = new Button();
            btnBow = new Button();
            playerStats = new Label();
            enemyStats = new Label();
            label1 = new Label();
            label2 = new Label();
            btnNegate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(356, 621);
            btnConfirm.MaximumSize = new Size(75, 23);
            btnConfirm.MinimumSize = new Size(75, 23);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Continue";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnRunAway
            // 
            btnRunAway.Location = new Point(174, 621);
            btnRunAway.MaximumSize = new Size(75, 23);
            btnRunAway.MinimumSize = new Size(75, 23);
            btnRunAway.Name = "btnRunAway";
            btnRunAway.Size = new Size(75, 23);
            btnRunAway.TabIndex = 4;
            btnRunAway.Text = "Run Away";
            btnRunAway.UseVisualStyleBackColor = true;
            btnRunAway.Click += btnRunAway_Click;
            // 
            // btnMagic
            // 
            btnMagic.Location = new Point(93, 621);
            btnMagic.MaximumSize = new Size(75, 23);
            btnMagic.MinimumSize = new Size(75, 23);
            btnMagic.Name = "btnMagic";
            btnMagic.Size = new Size(75, 23);
            btnMagic.TabIndex = 3;
            btnMagic.Text = "Magic";
            btnMagic.UseVisualStyleBackColor = true;
            btnMagic.Click += btnMagic_Click;
            // 
            // btnStartBattle
            // 
            btnStartBattle.Location = new Point(12, 621);
            btnStartBattle.MaximumSize = new Size(75, 23);
            btnStartBattle.MinimumSize = new Size(75, 23);
            btnStartBattle.Name = "btnStartBattle";
            btnStartBattle.Size = new Size(75, 23);
            btnStartBattle.TabIndex = 5;
            btnStartBattle.Text = "Attack";
            btnStartBattle.UseVisualStyleBackColor = true;
            btnStartBattle.Click += btnStartBattle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(213, 37);
            pictureBox1.MaximumSize = new Size(395, 258);
            pictureBox1.MinimumSize = new Size(395, 258);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 258);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // DialogueBox
            // 
            DialogueBox.BorderStyle = BorderStyle.Fixed3D;
            DialogueBox.Font = new Font("Segoe UI", 15F);
            DialogueBox.Location = new Point(12, 393);
            DialogueBox.MaximumSize = new Size(797, 181);
            DialogueBox.MinimumSize = new Size(797, 181);
            DialogueBox.Name = "DialogueBox";
            DialogueBox.Size = new Size(797, 181);
            DialogueBox.TabIndex = 7;
            DialogueBox.Text = "TEST";
            // 
            // textBox
            // 
            textBox.Location = new Point(321, 593);
            textBox.MaximumSize = new Size(156, 23);
            textBox.MinimumSize = new Size(156, 23);
            textBox.Name = "textBox";
            textBox.Size = new Size(156, 23);
            textBox.TabIndex = 8;
            // 
            // btnSword
            // 
            btnSword.Location = new Point(12, 592);
            btnSword.MaximumSize = new Size(75, 23);
            btnSword.MinimumSize = new Size(75, 23);
            btnSword.Name = "btnSword";
            btnSword.Size = new Size(75, 23);
            btnSword.TabIndex = 11;
            btnSword.UseVisualStyleBackColor = true;
            btnSword.Click += btnSword_Click;
            // 
            // btnMagicWand
            // 
            btnMagicWand.Location = new Point(174, 592);
            btnMagicWand.MaximumSize = new Size(75, 23);
            btnMagicWand.MinimumSize = new Size(75, 23);
            btnMagicWand.Name = "btnMagicWand";
            btnMagicWand.Size = new Size(75, 23);
            btnMagicWand.TabIndex = 10;
            btnMagicWand.UseVisualStyleBackColor = true;
            btnMagicWand.Click += btnMagicWand_Click;
            // 
            // btnBow
            // 
            btnBow.Location = new Point(93, 592);
            btnBow.MaximumSize = new Size(75, 23);
            btnBow.MinimumSize = new Size(75, 23);
            btnBow.Name = "btnBow";
            btnBow.Size = new Size(75, 23);
            btnBow.TabIndex = 9;
            btnBow.UseVisualStyleBackColor = true;
            btnBow.Click += btnBow_Click;
            // 
            // playerStats
            // 
            playerStats.BorderStyle = BorderStyle.FixedSingle;
            playerStats.Font = new Font("Segoe UI", 14F);
            playerStats.Location = new Point(12, 37);
            playerStats.MaximumSize = new Size(195, 258);
            playerStats.MinimumSize = new Size(195, 258);
            playerStats.Name = "playerStats";
            playerStats.Size = new Size(195, 258);
            playerStats.TabIndex = 12;
            // 
            // enemyStats
            // 
            enemyStats.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            enemyStats.BorderStyle = BorderStyle.FixedSingle;
            enemyStats.FlatStyle = FlatStyle.Flat;
            enemyStats.Font = new Font("Segoe UI", 14F);
            enemyStats.Location = new Point(614, 37);
            enemyStats.MaximumSize = new Size(195, 258);
            enemyStats.MinimumSize = new Size(195, 258);
            enemyStats.Name = "enemyStats";
            enemyStats.Size = new Size(195, 258);
            enemyStats.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 305);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 14;
            label1.Text = "Stats";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(683, 305);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 15;
            label2.Text = "Enemy Stats";
            // 
            // btnNegate
            // 
            btnNegate.Location = new Point(402, 622);
            btnNegate.MaximumSize = new Size(75, 23);
            btnNegate.MinimumSize = new Size(75, 23);
            btnNegate.Name = "btnNegate";
            btnNegate.Size = new Size(75, 23);
            btnNegate.TabIndex = 2;
            btnNegate.Text = "No";
            btnNegate.UseVisualStyleBackColor = true;
            btnNegate.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 646);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(enemyStats);
            Controls.Add(playerStats);
            Controls.Add(btnSword);
            Controls.Add(btnMagicWand);
            Controls.Add(btnBow);
            Controls.Add(textBox);
            Controls.Add(DialogueBox);
            Controls.Add(pictureBox1);
            Controls.Add(btnStartBattle);
            Controls.Add(btnRunAway);
            Controls.Add(btnMagic);
            Controls.Add(btnNegate);
            Controls.Add(btnConfirm);
            MaximumSize = new Size(837, 685);
            MinimumSize = new Size(837, 685);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        private Button btnRunAway;
        private Button btnMagic;
        private Button btnStartBattle;
        private PictureBox pictureBox1;
        private Label DialogueBox;
        private TextBox textBox;
        private Button btnSword;
        private Button btnMagicWand;
        private Button btnBow;
        private Label playerStats;
        private Label enemyStats;
        private Label label1;
        private Label label2;
        private Button btnNegate;
    }
}
