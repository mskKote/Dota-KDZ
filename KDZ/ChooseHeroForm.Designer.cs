namespace KDZ
{
    partial class ChooseHeroForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseHeroForm));
            this.HeroDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectHero = new System.Windows.Forms.DataGridViewButtonColumn();
            this.minDmgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moveSpeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseArmorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regenerationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseStrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseAgiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseIntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EXIT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FiltrationTitle = new System.Windows.Forms.Label();
            this.TypeTB = new System.Windows.Forms.TextBox();
            this.RegenerationTB = new System.Windows.Forms.TextBox();
            this.MoveSpeedTB = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.RegenLabel = new System.Windows.Forms.Label();
            this.MoveLabel = new System.Windows.Forms.Label();
            this.HeroTitle = new System.Windows.Forms.Label();
            this.OpponentTitle = new System.Windows.Forms.Label();
            this.OpponentHeroLabel = new System.Windows.Forms.Label();
            this.YourHeroLabel = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HeroDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeroDataGridView
            // 
            this.HeroDataGridView.AllowUserToAddRows = false;
            this.HeroDataGridView.AllowUserToOrderColumns = true;
            this.HeroDataGridView.AutoGenerateColumns = false;
            this.HeroDataGridView.BackgroundColor = System.Drawing.Color.MistyRose;
            this.HeroDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.HeroDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trajan Pro", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HeroDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.HeroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HeroDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectHero,
            this.minDmgDataGridViewTextBoxColumn,
            this.moveSpeedDataGridViewTextBoxColumn,
            this.baseArmorDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.regenerationDataGridViewTextBoxColumn,
            this.baseStrDataGridViewTextBoxColumn,
            this.baseAgiDataGridViewTextBoxColumn,
            this.baseIntDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.HeroDataGridView.DataSource = this.heroBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HeroDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.HeroDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.HeroDataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HeroDataGridView.Location = new System.Drawing.Point(0, 0);
            this.HeroDataGridView.Name = "HeroDataGridView";
            this.HeroDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HeroDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.HeroDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FloralWhite;
            this.HeroDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Trajan Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeroDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HeroDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.HeroDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.HeroDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HeroDataGridView.Size = new System.Drawing.Size(1103, 1080);
            this.HeroDataGridView.TabIndex = 2;
            this.HeroDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HeroDataGridView_CellContentClick);
            this.HeroDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.HeroDataGridView_DataError);
            // 
            // SelectHero
            // 
            this.SelectHero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SelectHero.DataPropertyName = "Name";
            this.SelectHero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectHero.HeaderText = "Take hero";
            this.SelectHero.Name = "SelectHero";
            this.SelectHero.Width = 235;
            // 
            // minDmgDataGridViewTextBoxColumn
            // 
            this.minDmgDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.minDmgDataGridViewTextBoxColumn.DataPropertyName = "MinDmg";
            this.minDmgDataGridViewTextBoxColumn.HeaderText = "MinDmg";
            this.minDmgDataGridViewTextBoxColumn.Name = "minDmgDataGridViewTextBoxColumn";
            this.minDmgDataGridViewTextBoxColumn.Width = 224;
            // 
            // moveSpeedDataGridViewTextBoxColumn
            // 
            this.moveSpeedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.moveSpeedDataGridViewTextBoxColumn.DataPropertyName = "MoveSpeed";
            this.moveSpeedDataGridViewTextBoxColumn.HeaderText = "MoveSpeed";
            this.moveSpeedDataGridViewTextBoxColumn.Name = "moveSpeedDataGridViewTextBoxColumn";
            this.moveSpeedDataGridViewTextBoxColumn.Width = 270;
            // 
            // baseArmorDataGridViewTextBoxColumn
            // 
            this.baseArmorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.baseArmorDataGridViewTextBoxColumn.DataPropertyName = "BaseArmor";
            this.baseArmorDataGridViewTextBoxColumn.HeaderText = "BaseArmor";
            this.baseArmorDataGridViewTextBoxColumn.Name = "baseArmorDataGridViewTextBoxColumn";
            this.baseArmorDataGridViewTextBoxColumn.Width = 270;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 134;
            // 
            // regenerationDataGridViewTextBoxColumn
            // 
            this.regenerationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.regenerationDataGridViewTextBoxColumn.DataPropertyName = "Regeneration";
            this.regenerationDataGridViewTextBoxColumn.HeaderText = "Regeneration";
            this.regenerationDataGridViewTextBoxColumn.Name = "regenerationDataGridViewTextBoxColumn";
            this.regenerationDataGridViewTextBoxColumn.Width = 333;
            // 
            // baseStrDataGridViewTextBoxColumn
            // 
            this.baseStrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.baseStrDataGridViewTextBoxColumn.DataPropertyName = "BaseStr";
            this.baseStrDataGridViewTextBoxColumn.HeaderText = "BaseStr";
            this.baseStrDataGridViewTextBoxColumn.Name = "baseStrDataGridViewTextBoxColumn";
            this.baseStrDataGridViewTextBoxColumn.Width = 200;
            // 
            // baseAgiDataGridViewTextBoxColumn
            // 
            this.baseAgiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.baseAgiDataGridViewTextBoxColumn.DataPropertyName = "BaseAgi";
            this.baseAgiDataGridViewTextBoxColumn.HeaderText = "BaseAgi";
            this.baseAgiDataGridViewTextBoxColumn.Name = "baseAgiDataGridViewTextBoxColumn";
            this.baseAgiDataGridViewTextBoxColumn.Width = 199;
            // 
            // baseIntDataGridViewTextBoxColumn
            // 
            this.baseIntDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.baseIntDataGridViewTextBoxColumn.DataPropertyName = "BaseInt";
            this.baseIntDataGridViewTextBoxColumn.HeaderText = "BaseInt";
            this.baseIntDataGridViewTextBoxColumn.Name = "baseIntDataGridViewTextBoxColumn";
            this.baseIntDataGridViewTextBoxColumn.Width = 201;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 158;
            // 
            // heroBindingSource
            // 
            this.heroBindingSource.DataSource = typeof(GameplayLib.Hero);
            // 
            // EXIT
            // 
            this.EXIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EXIT.BackColor = System.Drawing.Color.Transparent;
            this.EXIT.FlatAppearance.BorderSize = 5;
            this.EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXIT.Font = new System.Drawing.Font("Algerian", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EXIT.Location = new System.Drawing.Point(1684, 0);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(234, 102);
            this.EXIT.TabIndex = 6;
            this.EXIT.Text = "Menu";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            this.EXIT.MouseLeave += new System.EventHandler(this.Btn_Leave);
            this.EXIT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Move);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.FiltrationTitle);
            this.panel1.Controls.Add(this.TypeTB);
            this.panel1.Controls.Add(this.RegenerationTB);
            this.panel1.Controls.Add(this.MoveSpeedTB);
            this.panel1.Controls.Add(this.TypeLabel);
            this.panel1.Controls.Add(this.RegenLabel);
            this.panel1.Controls.Add(this.MoveLabel);
            this.panel1.Location = new System.Drawing.Point(1129, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 443);
            this.panel1.TabIndex = 11;
            // 
            // FiltrationTitle
            // 
            this.FiltrationTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FiltrationTitle.AutoSize = true;
            this.FiltrationTitle.BackColor = System.Drawing.Color.Transparent;
            this.FiltrationTitle.Font = new System.Drawing.Font("Algerian", 70F);
            this.FiltrationTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FiltrationTitle.Location = new System.Drawing.Point(103, -3);
            this.FiltrationTitle.Name = "FiltrationTitle";
            this.FiltrationTitle.Size = new System.Drawing.Size(560, 104);
            this.FiltrationTitle.TabIndex = 15;
            this.FiltrationTitle.Text = "Filtration";
            this.FiltrationTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_Move);
            // 
            // TypeTB
            // 
            this.TypeTB.BackColor = System.Drawing.Color.GhostWhite;
            this.TypeTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TypeTB.Font = new System.Drawing.Font("Trajan Pro", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeTB.Location = new System.Drawing.Point(599, 354);
            this.TypeTB.Name = "TypeTB";
            this.TypeTB.Size = new System.Drawing.Size(180, 81);
            this.TypeTB.TabIndex = 21;
            this.TypeTB.WordWrap = false;
            this.TypeTB.Click += new System.EventHandler(this.TB_Click);
            this.TypeTB.TextChanged += new System.EventHandler(this.Filtration);
            this.TypeTB.MouseLeave += new System.EventHandler(this.TextBox_Leave);
            this.TypeTB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TextBox_Move);
            // 
            // RegenerationTB
            // 
            this.RegenerationTB.BackColor = System.Drawing.Color.GhostWhite;
            this.RegenerationTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegenerationTB.Font = new System.Drawing.Font("Trajan Pro", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegenerationTB.Location = new System.Drawing.Point(599, 230);
            this.RegenerationTB.Name = "RegenerationTB";
            this.RegenerationTB.Size = new System.Drawing.Size(180, 81);
            this.RegenerationTB.TabIndex = 20;
            this.RegenerationTB.WordWrap = false;
            this.RegenerationTB.Click += new System.EventHandler(this.TB_Click);
            this.RegenerationTB.TextChanged += new System.EventHandler(this.Filtration);
            this.RegenerationTB.MouseLeave += new System.EventHandler(this.TextBox_Leave);
            this.RegenerationTB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TextBox_Move);
            // 
            // MoveSpeedTB
            // 
            this.MoveSpeedTB.BackColor = System.Drawing.Color.GhostWhite;
            this.MoveSpeedTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MoveSpeedTB.Font = new System.Drawing.Font("Trajan Pro", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveSpeedTB.Location = new System.Drawing.Point(599, 110);
            this.MoveSpeedTB.Name = "MoveSpeedTB";
            this.MoveSpeedTB.Size = new System.Drawing.Size(180, 81);
            this.MoveSpeedTB.TabIndex = 19;
            this.MoveSpeedTB.WordWrap = false;
            this.MoveSpeedTB.Click += new System.EventHandler(this.TB_Click);
            this.MoveSpeedTB.TextChanged += new System.EventHandler(this.Filtration);
            this.MoveSpeedTB.MouseLeave += new System.EventHandler(this.TextBox_Leave);
            this.MoveSpeedTB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TextBox_Move);
            // 
            // TypeLabel
            // 
            this.TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Trajan Pro", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.ForeColor = System.Drawing.Color.Beige;
            this.TypeLabel.Location = new System.Drawing.Point(-6, 348);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(617, 84);
            this.TypeLabel.TabIndex = 18;
            this.TypeLabel.Text = "Set type          >=";
            this.TypeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_Move);
            // 
            // RegenLabel
            // 
            this.RegenLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegenLabel.AutoSize = true;
            this.RegenLabel.Font = new System.Drawing.Font("Trajan Pro", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegenLabel.ForeColor = System.Drawing.Color.Beige;
            this.RegenLabel.Location = new System.Drawing.Point(-14, 227);
            this.RegenLabel.Name = "RegenLabel";
            this.RegenLabel.Size = new System.Drawing.Size(628, 84);
            this.RegenLabel.TabIndex = 17;
            this.RegenLabel.Text = "Regeneration>=";
            this.RegenLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_Move);
            // 
            // MoveLabel
            // 
            this.MoveLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MoveLabel.AutoSize = true;
            this.MoveLabel.Font = new System.Drawing.Font("Trajan Pro", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveLabel.ForeColor = System.Drawing.Color.Beige;
            this.MoveLabel.Location = new System.Drawing.Point(-6, 107);
            this.MoveLabel.Name = "MoveLabel";
            this.MoveLabel.Size = new System.Drawing.Size(621, 84);
            this.MoveLabel.TabIndex = 16;
            this.MoveLabel.Text = "MoveSpeed     >=";
            this.MoveLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_Move);
            // 
            // HeroTitle
            // 
            this.HeroTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HeroTitle.AutoSize = true;
            this.HeroTitle.BackColor = System.Drawing.Color.Transparent;
            this.HeroTitle.Font = new System.Drawing.Font("Algerian", 70F);
            this.HeroTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HeroTitle.Location = new System.Drawing.Point(1232, 554);
            this.HeroTitle.Name = "HeroTitle";
            this.HeroTitle.Size = new System.Drawing.Size(541, 104);
            this.HeroTitle.TabIndex = 16;
            this.HeroTitle.Text = "Your hero";
            this.HeroTitle.Visible = false;
            // 
            // OpponentTitle
            // 
            this.OpponentTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpponentTitle.AutoSize = true;
            this.OpponentTitle.BackColor = System.Drawing.Color.Transparent;
            this.OpponentTitle.Font = new System.Drawing.Font("Algerian", 70F);
            this.OpponentTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OpponentTitle.Location = new System.Drawing.Point(1119, 731);
            this.OpponentTitle.Name = "OpponentTitle";
            this.OpponentTitle.Size = new System.Drawing.Size(759, 104);
            this.OpponentTitle.TabIndex = 17;
            this.OpponentTitle.Text = "Opponent hero";
            this.OpponentTitle.Visible = false;
            // 
            // OpponentHeroLabel
            // 
            this.OpponentHeroLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpponentHeroLabel.AutoSize = true;
            this.OpponentHeroLabel.BackColor = System.Drawing.Color.Transparent;
            this.OpponentHeroLabel.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.heroBindingSource, "Name", true));
            this.OpponentHeroLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroBindingSource, "Name", true));
            this.OpponentHeroLabel.Font = new System.Drawing.Font("Trajan Pro", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpponentHeroLabel.ForeColor = System.Drawing.Color.Tomato;
            this.OpponentHeroLabel.Location = new System.Drawing.Point(1165, 824);
            this.OpponentHeroLabel.Name = "OpponentHeroLabel";
            this.OpponentHeroLabel.Size = new System.Drawing.Size(638, 85);
            this.OpponentHeroLabel.TabIndex = 19;
            this.OpponentHeroLabel.Text = "Opponent hero";
            this.OpponentHeroLabel.Visible = false;
            // 
            // YourHeroLabel
            // 
            this.YourHeroLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.YourHeroLabel.AutoSize = true;
            this.YourHeroLabel.BackColor = System.Drawing.Color.Transparent;
            this.YourHeroLabel.Font = new System.Drawing.Font("Trajan Pro", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourHeroLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.YourHeroLabel.Location = new System.Drawing.Point(1236, 647);
            this.YourHeroLabel.Name = "YourHeroLabel";
            this.YourHeroLabel.Size = new System.Drawing.Size(449, 85);
            this.YourHeroLabel.TabIndex = 18;
            this.YourHeroLabel.Text = "Your hero";
            this.YourHeroLabel.Visible = false;
            // 
            // StartBtn
            // 
            this.StartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartBtn.BackColor = System.Drawing.Color.Transparent;
            this.StartBtn.Enabled = false;
            this.StartBtn.FlatAppearance.BorderSize = 5;
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtn.Font = new System.Drawing.Font("Algerian", 60.25F);
            this.StartBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StartBtn.Location = new System.Drawing.Point(1109, 944);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(809, 136);
            this.StartBtn.TabIndex = 20;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            this.StartBtn.MouseLeave += new System.EventHandler(this.Btn_Leave);
            this.StartBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Move);
            // 
            // ChooseHeroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.OpponentHeroLabel);
            this.Controls.Add(this.YourHeroLabel);
            this.Controls.Add(this.OpponentTitle);
            this.Controls.Add(this.HeroTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.HeroDataGridView);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseHeroForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.HeroDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView HeroDataGridView;
        private System.Windows.Forms.BindingSource heroBindingSource;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FiltrationTitle;
        private System.Windows.Forms.Label MoveLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label RegenLabel;
        private System.Windows.Forms.TextBox RegenerationTB;
        private System.Windows.Forms.TextBox MoveSpeedTB;
        private System.Windows.Forms.TextBox TypeTB;
        private System.Windows.Forms.Label HeroTitle;
        private System.Windows.Forms.Label OpponentTitle;
        private System.Windows.Forms.Label OpponentHeroLabel;
        private System.Windows.Forms.Label YourHeroLabel;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDamageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn SelectHero;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDmgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moveSpeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseArmorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regenerationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseStrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseAgiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseIntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}