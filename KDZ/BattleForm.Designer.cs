namespace KDZ
{
    partial class BattleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleForm));
            this.AttackBtn = new System.Windows.Forms.Button();
            this.DefendBtn = new System.Windows.Forms.Button();
            this.RunBtn = new System.Windows.Forms.Button();
            this.UserHealthProgBar = new System.Windows.Forms.ProgressBar();
            this.EnemyHealthProgBar = new System.Windows.Forms.ProgressBar();
            this.EnemyNameLabel = new System.Windows.Forms.Label();
            this.ChoiceLabelDesc = new System.Windows.Forms.Label();
            this.EnemyChoiceLabel = new System.Windows.Forms.Label();
            this.EXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AttackBtn
            // 
            this.AttackBtn.BackColor = System.Drawing.Color.Transparent;
            this.AttackBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AttackBtn.FlatAppearance.BorderSize = 7;
            this.AttackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttackBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttackBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AttackBtn.Location = new System.Drawing.Point(1223, 665);
            this.AttackBtn.Name = "AttackBtn";
            this.AttackBtn.Size = new System.Drawing.Size(434, 254);
            this.AttackBtn.TabIndex = 8;
            this.AttackBtn.Text = "Attack";
            this.AttackBtn.UseVisualStyleBackColor = false;
            this.AttackBtn.Click += new System.EventHandler(this.Btn_Click);
            this.AttackBtn.MouseLeave += new System.EventHandler(this.Btn_LeaveMove);
            this.AttackBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseMove);
            // 
            // DefendBtn
            // 
            this.DefendBtn.BackColor = System.Drawing.Color.Transparent;
            this.DefendBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DefendBtn.FlatAppearance.BorderSize = 7;
            this.DefendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DefendBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefendBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DefendBtn.Location = new System.Drawing.Point(783, 665);
            this.DefendBtn.Name = "DefendBtn";
            this.DefendBtn.Size = new System.Drawing.Size(434, 254);
            this.DefendBtn.TabIndex = 9;
            this.DefendBtn.Text = "Defend";
            this.DefendBtn.UseVisualStyleBackColor = false;
            this.DefendBtn.Click += new System.EventHandler(this.Btn_Click);
            this.DefendBtn.MouseLeave += new System.EventHandler(this.Btn_LeaveMove);
            this.DefendBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseMove);
            // 
            // RunBtn
            // 
            this.RunBtn.BackColor = System.Drawing.Color.Transparent;
            this.RunBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RunBtn.FlatAppearance.BorderSize = 7;
            this.RunBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RunBtn.Location = new System.Drawing.Point(343, 665);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(434, 254);
            this.RunBtn.TabIndex = 10;
            this.RunBtn.Text = "Run";
            this.RunBtn.UseVisualStyleBackColor = false;
            this.RunBtn.Click += new System.EventHandler(this.Btn_Click);
            this.RunBtn.MouseLeave += new System.EventHandler(this.Btn_LeaveMove);
            this.RunBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseMove);
            // 
            // UserHealthProgBar
            // 
            this.UserHealthProgBar.BackColor = System.Drawing.SystemColors.Control;
            this.UserHealthProgBar.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.UserHealthProgBar.Location = new System.Drawing.Point(343, 938);
            this.UserHealthProgBar.Name = "UserHealthProgBar";
            this.UserHealthProgBar.Size = new System.Drawing.Size(1314, 34);
            this.UserHealthProgBar.TabIndex = 11;
            // 
            // EnemyHealthProgBar
            // 
            this.EnemyHealthProgBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EnemyHealthProgBar.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.EnemyHealthProgBar.Location = new System.Drawing.Point(343, 144);
            this.EnemyHealthProgBar.Name = "EnemyHealthProgBar";
            this.EnemyHealthProgBar.Size = new System.Drawing.Size(1314, 34);
            this.EnemyHealthProgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.EnemyHealthProgBar.TabIndex = 12;
            // 
            // EnemyNameLabel
            // 
            this.EnemyNameLabel.AutoSize = true;
            this.EnemyNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.EnemyNameLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyNameLabel.ForeColor = System.Drawing.Color.Tomato;
            this.EnemyNameLabel.Location = new System.Drawing.Point(688, 15);
            this.EnemyNameLabel.Name = "EnemyNameLabel";
            this.EnemyNameLabel.Size = new System.Drawing.Size(1094, 126);
            this.EnemyNameLabel.TabIndex = 13;
            this.EnemyNameLabel.Text = "Label for enemy name";
            // 
            // ChoiceLabelDesc
            // 
            this.ChoiceLabelDesc.AutoSize = true;
            this.ChoiceLabelDesc.BackColor = System.Drawing.Color.Transparent;
            this.ChoiceLabelDesc.Font = new System.Drawing.Font("Imprint MT Shadow", 75F);
            this.ChoiceLabelDesc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChoiceLabelDesc.Location = new System.Drawing.Point(323, 181);
            this.ChoiceLabelDesc.Name = "ChoiceLabelDesc";
            this.ChoiceLabelDesc.Size = new System.Drawing.Size(678, 118);
            this.ChoiceLabelDesc.TabIndex = 14;
            this.ChoiceLabelDesc.Text = "Enemy choice:";
            // 
            // EnemyChoiceLabel
            // 
            this.EnemyChoiceLabel.AutoSize = true;
            this.EnemyChoiceLabel.BackColor = System.Drawing.Color.Transparent;
            this.EnemyChoiceLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyChoiceLabel.ForeColor = System.Drawing.Color.Tomato;
            this.EnemyChoiceLabel.Location = new System.Drawing.Point(1007, 181);
            this.EnemyChoiceLabel.Name = "EnemyChoiceLabel";
            this.EnemyChoiceLabel.Size = new System.Drawing.Size(125, 118);
            this.EnemyChoiceLabel.TabIndex = 15;
            this.EnemyChoiceLabel.Text = "...";
            // 
            // EXIT
            // 
            this.EXIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EXIT.BackColor = System.Drawing.Color.Transparent;
            this.EXIT.FlatAppearance.BorderSize = 5;
            this.EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXIT.Font = new System.Drawing.Font("Algerian", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EXIT.Location = new System.Drawing.Point(1685, -2);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(234, 102);
            this.EXIT.TabIndex = 7;
            this.EXIT.Text = "Menu";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            this.EXIT.MouseLeave += new System.EventHandler(this.Btn_LeaveMove);
            this.EXIT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseMove);
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.EnemyChoiceLabel);
            this.Controls.Add(this.ChoiceLabelDesc);
            this.Controls.Add(this.EnemyNameLabel);
            this.Controls.Add(this.EnemyHealthProgBar);
            this.Controls.Add(this.UserHealthProgBar);
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.DefendBtn);
            this.Controls.Add(this.AttackBtn);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BattleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AttackBtn;
        private System.Windows.Forms.Button DefendBtn;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.ProgressBar UserHealthProgBar;
        private System.Windows.Forms.ProgressBar EnemyHealthProgBar;
        private System.Windows.Forms.Label EnemyNameLabel;
        private System.Windows.Forms.Label ChoiceLabelDesc;
        private System.Windows.Forms.Label EnemyChoiceLabel;
        private System.Windows.Forms.Button EXIT;
    }
}