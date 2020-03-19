namespace KDZ
{
    partial class DotaForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DotaForm));
            this.heroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UserDataPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelContinue = new System.Windows.Forms.Label();
            this.labelNewGame = new System.Windows.Forms.Label();
            this.DotaTitle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.heroBindingSource)).BeginInit();
            this.UserDataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // heroBindingSource
            // 
            this.heroBindingSource.DataSource = typeof(GameplayLib.Hero);
            // 
            // UserDataPanel
            // 
            this.UserDataPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserDataPanel.BackColor = System.Drawing.Color.Transparent;
            this.UserDataPanel.Controls.Add(this.label1);
            this.UserDataPanel.Controls.Add(this.labelExit);
            this.UserDataPanel.Controls.Add(this.labelContinue);
            this.UserDataPanel.Controls.Add(this.labelNewGame);
            this.UserDataPanel.Controls.Add(this.DotaTitle);
            this.UserDataPanel.Location = new System.Drawing.Point(460, 500);
            this.UserDataPanel.Name = "UserDataPanel";
            this.UserDataPanel.Size = new System.Drawing.Size(557, 948);
            this.UserDataPanel.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Algerian", 60F);
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(121, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 89);
            this.label1.TabIndex = 100504;
            this.label1.Text = "Dota II";
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Cross;
            this.labelExit.Font = new System.Drawing.Font("Algerian", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelExit.Location = new System.Drawing.Point(96, 340);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(336, 59);
            this.labelExit.TabIndex = 3;
            this.labelExit.Text = "End session";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            this.labelExit.MouseLeave += new System.EventHandler(this.Underline_MouseLeave);
            this.labelExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Underline_MouseMove);
            // 
            // labelContinue
            // 
            this.labelContinue.AutoSize = true;
            this.labelContinue.Cursor = System.Windows.Forms.Cursors.Cross;
            this.labelContinue.Enabled = false;
            this.labelContinue.Font = new System.Drawing.Font("Algerian", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContinue.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelContinue.Location = new System.Drawing.Point(135, 254);
            this.labelContinue.Name = "labelContinue";
            this.labelContinue.Size = new System.Drawing.Size(265, 59);
            this.labelContinue.TabIndex = 2;
            this.labelContinue.Text = "Continue";
            this.labelContinue.Click += new System.EventHandler(this.labelContinue_Click);
            this.labelContinue.MouseLeave += new System.EventHandler(this.Underline_MouseLeave);
            this.labelContinue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Underline_MouseMove);
            // 
            // labelNewGame
            // 
            this.labelNewGame.AutoSize = true;
            this.labelNewGame.Cursor = System.Windows.Forms.Cursors.Cross;
            this.labelNewGame.Font = new System.Drawing.Font("Algerian", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewGame.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelNewGame.Location = new System.Drawing.Point(54, 163);
            this.labelNewGame.Name = "labelNewGame";
            this.labelNewGame.Size = new System.Drawing.Size(445, 59);
            this.labelNewGame.TabIndex = 1;
            this.labelNewGame.Text = "New adventure";
            this.labelNewGame.Click += new System.EventHandler(this.labelNewGame_Click);
            this.labelNewGame.MouseLeave += new System.EventHandler(this.Underline_MouseLeave);
            this.labelNewGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Underline_MouseMove);
            // 
            // DotaTitle
            // 
            this.DotaTitle.BackColor = System.Drawing.Color.Transparent;
            this.DotaTitle.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DotaTitle.Enabled = false;
            this.DotaTitle.FlatAppearance.BorderSize = 3;
            this.DotaTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DotaTitle.Font = new System.Drawing.Font("Algerian", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotaTitle.ForeColor = System.Drawing.Color.AliceBlue;
            this.DotaTitle.Location = new System.Drawing.Point(20, 3);
            this.DotaTitle.Name = "DotaTitle";
            this.DotaTitle.Size = new System.Drawing.Size(510, 125);
            this.DotaTitle.TabIndex = 100500;
            this.DotaTitle.Text = "Dota II";
            this.DotaTitle.UseVisualStyleBackColor = false;
            // 
            // DotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1287, 1091);
            this.ControlBox = false;
            this.Controls.Add(this.UserDataPanel);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DotaForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.heroBindingSource)).EndInit();
            this.UserDataPanel.ResumeLayout(false);
            this.UserDataPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource heroBindingSource;
        private System.Windows.Forms.Panel UserDataPanel;
        private System.Windows.Forms.Button DotaTitle;
        private System.Windows.Forms.Label labelNewGame;
        private System.Windows.Forms.Label labelContinue;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label label1;
    }
}

