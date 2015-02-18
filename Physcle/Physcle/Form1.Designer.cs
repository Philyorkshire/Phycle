namespace Physcle
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.overview = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.summary = new System.Windows.Forms.Label();
            this.intervalText = new System.Windows.Forms.Label();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.sModeText = new System.Windows.Forms.Label();
            this.sModeLabel = new System.Windows.Forms.Label();
            this.monitorText = new System.Windows.Forms.Label();
            this.monitorLabel = new System.Windows.Forms.Label();
            this.versionText = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.overviewPanel = new System.Windows.Forms.Panel();
            this.activeLabel = new System.Windows.Forms.Label();
            this.activeText = new System.Windows.Forms.Label();
            this.welcomeMessage = new System.Windows.Forms.Label();
            this.maxHrLabel = new System.Windows.Forms.Label();
            this.maxHrText = new System.Windows.Forms.Label();
            this.restHrLabel = new System.Windows.Forms.Label();
            this.restHrText = new System.Windows.Forms.Label();
            this.V02MaxLabel = new System.Windows.Forms.Label();
            this.V02MaxText = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightText = new System.Windows.Forms.Label();
            this.timer1Label = new System.Windows.Forms.Label();
            this.timer1Text = new System.Windows.Forms.Label();
            this.lower1Label = new System.Windows.Forms.Label();
            this.lower1Text = new System.Windows.Forms.Label();
            this.upper1Label = new System.Windows.Forms.Label();
            this.upper1Text = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateText = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.startText = new System.Windows.Forms.Label();
            this.lengthText = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer2Label = new System.Windows.Forms.Label();
            this.timer2Text = new System.Windows.Forms.Label();
            this.lower2Label = new System.Windows.Forms.Label();
            this.lower2Text = new System.Windows.Forms.Label();
            this.upper2Label = new System.Windows.Forms.Label();
            this.upper2Text = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timer3Label = new System.Windows.Forms.Label();
            this.timer3Text = new System.Windows.Forms.Label();
            this.lower3Label = new System.Windows.Forms.Label();
            this.lower3Text = new System.Windows.Forms.Label();
            this.upper3Label = new System.Windows.Forms.Label();
            this.upper3Text = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.overviewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(951, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseUp);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadFileToolStripMenuItem.Text = "Load File";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // navigationPanel
            // 
            this.navigationPanel.AutoScroll = true;
            this.navigationPanel.BackColor = System.Drawing.Color.Transparent;
            this.navigationPanel.Controls.Add(this.overview);
            this.navigationPanel.Controls.Add(this.summary);
            this.navigationPanel.Location = new System.Drawing.Point(40, 50);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(126, 516);
            this.navigationPanel.TabIndex = 1;
            // 
            // overview
            // 
            this.overview.AutoSize = true;
            this.overview.BackColor = System.Drawing.Color.Transparent;
            this.overview.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overview.ForeColor = System.Drawing.Color.White;
            this.overview.Location = new System.Drawing.Point(3, 5);
            this.overview.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.overview.Name = "overview";
            this.overview.Padding = new System.Windows.Forms.Padding(2);
            this.overview.Size = new System.Drawing.Size(73, 21);
            this.overview.TabIndex = 0;
            this.overview.Text = "Overview";
            this.overview.Click += new System.EventHandler(this.overview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(928, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.X_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(907, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "-";
            this.label2.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // summary
            // 
            this.summary.AutoSize = true;
            this.summary.BackColor = System.Drawing.Color.Transparent;
            this.summary.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary.ForeColor = System.Drawing.Color.White;
            this.summary.Location = new System.Drawing.Point(3, 31);
            this.summary.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.summary.Name = "summary";
            this.summary.Padding = new System.Windows.Forms.Padding(2);
            this.summary.Size = new System.Drawing.Size(76, 21);
            this.summary.TabIndex = 2;
            this.summary.Text = "Summary";
            this.summary.Click += new System.EventHandler(this.summary_Click);
            // 
            // intervalText
            // 
            this.intervalText.AutoSize = true;
            this.intervalText.BackColor = System.Drawing.Color.Transparent;
            this.intervalText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervalText.ForeColor = System.Drawing.Color.White;
            this.intervalText.Location = new System.Drawing.Point(201, 79);
            this.intervalText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.intervalText.Name = "intervalText";
            this.intervalText.Size = new System.Drawing.Size(30, 16);
            this.intervalText.TabIndex = 8;
            this.intervalText.Text = "N/A";
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.BackColor = System.Drawing.Color.Transparent;
            this.intervalLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervalLabel.ForeColor = System.Drawing.Color.White;
            this.intervalLabel.Location = new System.Drawing.Point(44, 75);
            this.intervalLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(68, 21);
            this.intervalLabel.TabIndex = 7;
            this.intervalLabel.Text = "Interval";
            // 
            // sModeText
            // 
            this.sModeText.AutoSize = true;
            this.sModeText.BackColor = System.Drawing.Color.Transparent;
            this.sModeText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sModeText.ForeColor = System.Drawing.Color.White;
            this.sModeText.Location = new System.Drawing.Point(201, 125);
            this.sModeText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.sModeText.Name = "sModeText";
            this.sModeText.Size = new System.Drawing.Size(30, 16);
            this.sModeText.TabIndex = 6;
            this.sModeText.Text = "N/A";
            // 
            // sModeLabel
            // 
            this.sModeLabel.AutoSize = true;
            this.sModeLabel.BackColor = System.Drawing.Color.Transparent;
            this.sModeLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sModeLabel.ForeColor = System.Drawing.Color.White;
            this.sModeLabel.Location = new System.Drawing.Point(42, 120);
            this.sModeLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.sModeLabel.Name = "sModeLabel";
            this.sModeLabel.Size = new System.Drawing.Size(67, 21);
            this.sModeLabel.TabIndex = 5;
            this.sModeLabel.Text = "SMode";
            // 
            // monitorText
            // 
            this.monitorText.AutoSize = true;
            this.monitorText.BackColor = System.Drawing.Color.Transparent;
            this.monitorText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorText.ForeColor = System.Drawing.Color.White;
            this.monitorText.Location = new System.Drawing.Point(201, 172);
            this.monitorText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.monitorText.Name = "monitorText";
            this.monitorText.Size = new System.Drawing.Size(30, 16);
            this.monitorText.TabIndex = 4;
            this.monitorText.Text = "N/A";
            // 
            // monitorLabel
            // 
            this.monitorLabel.AutoSize = true;
            this.monitorLabel.BackColor = System.Drawing.Color.Transparent;
            this.monitorLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorLabel.ForeColor = System.Drawing.Color.White;
            this.monitorLabel.Location = new System.Drawing.Point(44, 168);
            this.monitorLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.monitorLabel.Name = "monitorLabel";
            this.monitorLabel.Size = new System.Drawing.Size(70, 21);
            this.monitorLabel.TabIndex = 3;
            this.monitorLabel.Text = "Monitor";
            // 
            // versionText
            // 
            this.versionText.AutoSize = true;
            this.versionText.BackColor = System.Drawing.Color.Transparent;
            this.versionText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionText.ForeColor = System.Drawing.Color.White;
            this.versionText.Location = new System.Drawing.Point(201, 32);
            this.versionText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.versionText.Name = "versionText";
            this.versionText.Size = new System.Drawing.Size(30, 16);
            this.versionText.TabIndex = 2;
            this.versionText.Text = "N/A";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.Color.White;
            this.versionLabel.Location = new System.Drawing.Point(42, 27);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(69, 21);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "Version";
            // 
            // overviewPanel
            // 
            this.overviewPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.overviewPanel.Controls.Add(this.label11);
            this.overviewPanel.Controls.Add(this.timer3Label);
            this.overviewPanel.Controls.Add(this.timer3Text);
            this.overviewPanel.Controls.Add(this.lower3Label);
            this.overviewPanel.Controls.Add(this.lower3Text);
            this.overviewPanel.Controls.Add(this.upper3Label);
            this.overviewPanel.Controls.Add(this.upper3Text);
            this.overviewPanel.Controls.Add(this.label4);
            this.overviewPanel.Controls.Add(this.timer2Label);
            this.overviewPanel.Controls.Add(this.timer2Text);
            this.overviewPanel.Controls.Add(this.lower2Label);
            this.overviewPanel.Controls.Add(this.lower2Text);
            this.overviewPanel.Controls.Add(this.upper2Label);
            this.overviewPanel.Controls.Add(this.upper2Text);
            this.overviewPanel.Controls.Add(this.label3);
            this.overviewPanel.Controls.Add(this.timer1Label);
            this.overviewPanel.Controls.Add(this.timer1Text);
            this.overviewPanel.Controls.Add(this.lower1Label);
            this.overviewPanel.Controls.Add(this.lower1Text);
            this.overviewPanel.Controls.Add(this.upper1Label);
            this.overviewPanel.Controls.Add(this.upper1Text);
            this.overviewPanel.Controls.Add(this.dateLabel);
            this.overviewPanel.Controls.Add(this.dateText);
            this.overviewPanel.Controls.Add(this.startLabel);
            this.overviewPanel.Controls.Add(this.startText);
            this.overviewPanel.Controls.Add(this.lengthText);
            this.overviewPanel.Controls.Add(this.lengthLabel);
            this.overviewPanel.Controls.Add(this.weightLabel);
            this.overviewPanel.Controls.Add(this.weightText);
            this.overviewPanel.Controls.Add(this.V02MaxLabel);
            this.overviewPanel.Controls.Add(this.V02MaxText);
            this.overviewPanel.Controls.Add(this.restHrLabel);
            this.overviewPanel.Controls.Add(this.restHrText);
            this.overviewPanel.Controls.Add(this.maxHrLabel);
            this.overviewPanel.Controls.Add(this.maxHrText);
            this.overviewPanel.Controls.Add(this.activeLabel);
            this.overviewPanel.Controls.Add(this.activeText);
            this.overviewPanel.Controls.Add(this.versionLabel);
            this.overviewPanel.Controls.Add(this.versionText);
            this.overviewPanel.Controls.Add(this.intervalLabel);
            this.overviewPanel.Controls.Add(this.monitorLabel);
            this.overviewPanel.Controls.Add(this.intervalText);
            this.overviewPanel.Controls.Add(this.monitorText);
            this.overviewPanel.Controls.Add(this.sModeText);
            this.overviewPanel.Controls.Add(this.sModeLabel);
            this.overviewPanel.Location = new System.Drawing.Point(188, 55);
            this.overviewPanel.Name = "overviewPanel";
            this.overviewPanel.Size = new System.Drawing.Size(751, 497);
            this.overviewPanel.TabIndex = 4;
            this.overviewPanel.Visible = false;
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.BackColor = System.Drawing.Color.Transparent;
            this.activeLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeLabel.ForeColor = System.Drawing.Color.White;
            this.activeLabel.Location = new System.Drawing.Point(42, 218);
            this.activeLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(100, 21);
            this.activeLabel.TabIndex = 9;
            this.activeLabel.Text = "Active Limit";
            // 
            // activeText
            // 
            this.activeText.AutoSize = true;
            this.activeText.BackColor = System.Drawing.Color.Transparent;
            this.activeText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeText.ForeColor = System.Drawing.Color.White;
            this.activeText.Location = new System.Drawing.Point(201, 222);
            this.activeText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.activeText.Name = "activeText";
            this.activeText.Size = new System.Drawing.Size(30, 16);
            this.activeText.TabIndex = 10;
            this.activeText.Text = "N/A";
            // 
            // welcomeMessage
            // 
            this.welcomeMessage.AutoSize = true;
            this.welcomeMessage.BackColor = System.Drawing.Color.Transparent;
            this.welcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMessage.ForeColor = System.Drawing.Color.White;
            this.welcomeMessage.Location = new System.Drawing.Point(430, 251);
            this.welcomeMessage.Name = "welcomeMessage";
            this.welcomeMessage.Size = new System.Drawing.Size(175, 29);
            this.welcomeMessage.TabIndex = 5;
            this.welcomeMessage.Text = "Load data file...";
            this.welcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxHrLabel
            // 
            this.maxHrLabel.AccessibleDescription = "t";
            this.maxHrLabel.AutoSize = true;
            this.maxHrLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxHrLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxHrLabel.ForeColor = System.Drawing.Color.White;
            this.maxHrLabel.Location = new System.Drawing.Point(42, 273);
            this.maxHrLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.maxHrLabel.Name = "maxHrLabel";
            this.maxHrLabel.Size = new System.Drawing.Size(135, 21);
            this.maxHrLabel.TabIndex = 11;
            this.maxHrLabel.Text = "Max Heart Rate";
            // 
            // maxHrText
            // 
            this.maxHrText.AccessibleDescription = "t";
            this.maxHrText.AutoSize = true;
            this.maxHrText.BackColor = System.Drawing.Color.Transparent;
            this.maxHrText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxHrText.ForeColor = System.Drawing.Color.White;
            this.maxHrText.Location = new System.Drawing.Point(201, 277);
            this.maxHrText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.maxHrText.Name = "maxHrText";
            this.maxHrText.Size = new System.Drawing.Size(30, 16);
            this.maxHrText.TabIndex = 12;
            this.maxHrText.Text = "N/A";
            // 
            // restHrLabel
            // 
            this.restHrLabel.AccessibleDescription = "t";
            this.restHrLabel.AutoSize = true;
            this.restHrLabel.BackColor = System.Drawing.Color.Transparent;
            this.restHrLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restHrLabel.ForeColor = System.Drawing.Color.White;
            this.restHrLabel.Location = new System.Drawing.Point(42, 329);
            this.restHrLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.restHrLabel.Name = "restHrLabel";
            this.restHrLabel.Size = new System.Drawing.Size(139, 21);
            this.restHrLabel.TabIndex = 13;
            this.restHrLabel.Text = "Rest Heart Rate";
            // 
            // restHrText
            // 
            this.restHrText.AccessibleDescription = "t";
            this.restHrText.AutoSize = true;
            this.restHrText.BackColor = System.Drawing.Color.Transparent;
            this.restHrText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restHrText.ForeColor = System.Drawing.Color.White;
            this.restHrText.Location = new System.Drawing.Point(201, 333);
            this.restHrText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.restHrText.Name = "restHrText";
            this.restHrText.Size = new System.Drawing.Size(30, 16);
            this.restHrText.TabIndex = 14;
            this.restHrText.Text = "N/A";
            // 
            // V02MaxLabel
            // 
            this.V02MaxLabel.AccessibleDescription = "t";
            this.V02MaxLabel.AutoSize = true;
            this.V02MaxLabel.BackColor = System.Drawing.Color.Transparent;
            this.V02MaxLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V02MaxLabel.ForeColor = System.Drawing.Color.White;
            this.V02MaxLabel.Location = new System.Drawing.Point(42, 384);
            this.V02MaxLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.V02MaxLabel.Name = "V02MaxLabel";
            this.V02MaxLabel.Size = new System.Drawing.Size(79, 21);
            this.V02MaxLabel.TabIndex = 15;
            this.V02MaxLabel.Text = "V02 Max";
            // 
            // V02MaxText
            // 
            this.V02MaxText.AccessibleDescription = "t";
            this.V02MaxText.AutoSize = true;
            this.V02MaxText.BackColor = System.Drawing.Color.Transparent;
            this.V02MaxText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V02MaxText.ForeColor = System.Drawing.Color.White;
            this.V02MaxText.Location = new System.Drawing.Point(201, 388);
            this.V02MaxText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.V02MaxText.Name = "V02MaxText";
            this.V02MaxText.Size = new System.Drawing.Size(30, 16);
            this.V02MaxText.TabIndex = 16;
            this.V02MaxText.Text = "N/A";
            // 
            // weightLabel
            // 
            this.weightLabel.AccessibleDescription = "t";
            this.weightLabel.AutoSize = true;
            this.weightLabel.BackColor = System.Drawing.Color.Transparent;
            this.weightLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.ForeColor = System.Drawing.Color.White;
            this.weightLabel.Location = new System.Drawing.Point(44, 438);
            this.weightLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(66, 21);
            this.weightLabel.TabIndex = 17;
            this.weightLabel.Text = "Weight";
            // 
            // weightText
            // 
            this.weightText.AccessibleDescription = "t";
            this.weightText.AutoSize = true;
            this.weightText.BackColor = System.Drawing.Color.Transparent;
            this.weightText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightText.ForeColor = System.Drawing.Color.White;
            this.weightText.Location = new System.Drawing.Point(203, 442);
            this.weightText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.weightText.Name = "weightText";
            this.weightText.Size = new System.Drawing.Size(30, 16);
            this.weightText.TabIndex = 18;
            this.weightText.Text = "N/A";
            // 
            // timer1Label
            // 
            this.timer1Label.AccessibleDescription = "t";
            this.timer1Label.AutoSize = true;
            this.timer1Label.BackColor = System.Drawing.Color.Transparent;
            this.timer1Label.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer1Label.ForeColor = System.Drawing.Color.White;
            this.timer1Label.Location = new System.Drawing.Point(440, 228);
            this.timer1Label.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.timer1Label.Name = "timer1Label";
            this.timer1Label.Size = new System.Drawing.Size(55, 21);
            this.timer1Label.TabIndex = 31;
            this.timer1Label.Text = "Timer";
            // 
            // timer1Text
            // 
            this.timer1Text.AccessibleDescription = "t";
            this.timer1Text.AutoSize = true;
            this.timer1Text.BackColor = System.Drawing.Color.Transparent;
            this.timer1Text.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer1Text.ForeColor = System.Drawing.Color.White;
            this.timer1Text.Location = new System.Drawing.Point(599, 232);
            this.timer1Text.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.timer1Text.Name = "timer1Text";
            this.timer1Text.Size = new System.Drawing.Size(30, 16);
            this.timer1Text.TabIndex = 32;
            this.timer1Text.Text = "N/A";
            // 
            // lower1Label
            // 
            this.lower1Label.AccessibleDescription = "t";
            this.lower1Label.AutoSize = true;
            this.lower1Label.BackColor = System.Drawing.Color.Transparent;
            this.lower1Label.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lower1Label.ForeColor = System.Drawing.Color.White;
            this.lower1Label.Location = new System.Drawing.Point(440, 199);
            this.lower1Label.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.lower1Label.Name = "lower1Label";
            this.lower1Label.Size = new System.Drawing.Size(59, 21);
            this.lower1Label.TabIndex = 29;
            this.lower1Label.Text = "Lower";
            // 
            // lower1Text
            // 
            this.lower1Text.AccessibleDescription = "t";
            this.lower1Text.AutoSize = true;
            this.lower1Text.BackColor = System.Drawing.Color.Transparent;
            this.lower1Text.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lower1Text.ForeColor = System.Drawing.Color.White;
            this.lower1Text.Location = new System.Drawing.Point(599, 203);
            this.lower1Text.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.lower1Text.Name = "lower1Text";
            this.lower1Text.Size = new System.Drawing.Size(30, 16);
            this.lower1Text.TabIndex = 30;
            this.lower1Text.Text = "N/A";
            // 
            // upper1Label
            // 
            this.upper1Label.AutoSize = true;
            this.upper1Label.BackColor = System.Drawing.Color.Transparent;
            this.upper1Label.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upper1Label.ForeColor = System.Drawing.Color.White;
            this.upper1Label.Location = new System.Drawing.Point(440, 171);
            this.upper1Label.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.upper1Label.Name = "upper1Label";
            this.upper1Label.Size = new System.Drawing.Size(59, 21);
            this.upper1Label.TabIndex = 27;
            this.upper1Label.Text = "Upper";
            // 
            // upper1Text
            // 
            this.upper1Text.AutoSize = true;
            this.upper1Text.BackColor = System.Drawing.Color.Transparent;
            this.upper1Text.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upper1Text.ForeColor = System.Drawing.Color.White;
            this.upper1Text.Location = new System.Drawing.Point(599, 175);
            this.upper1Text.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.upper1Text.Name = "upper1Text";
            this.upper1Text.Size = new System.Drawing.Size(30, 16);
            this.upper1Text.TabIndex = 28;
            this.upper1Text.Text = "N/A";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(406, 26);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(48, 21);
            this.dateLabel.TabIndex = 19;
            this.dateLabel.Text = "Date";
            // 
            // dateText
            // 
            this.dateText.AutoSize = true;
            this.dateText.BackColor = System.Drawing.Color.Transparent;
            this.dateText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateText.ForeColor = System.Drawing.Color.White;
            this.dateText.Location = new System.Drawing.Point(600, 31);
            this.dateText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(30, 16);
            this.dateText.TabIndex = 20;
            this.dateText.Text = "N/A";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.BackColor = System.Drawing.Color.Transparent;
            this.startLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.Color.White;
            this.startLabel.Location = new System.Drawing.Point(408, 70);
            this.startLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(92, 21);
            this.startLabel.TabIndex = 25;
            this.startLabel.Text = "Start Time";
            // 
            // startText
            // 
            this.startText.AutoSize = true;
            this.startText.BackColor = System.Drawing.Color.Transparent;
            this.startText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startText.ForeColor = System.Drawing.Color.White;
            this.startText.Location = new System.Drawing.Point(600, 74);
            this.startText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.startText.Name = "startText";
            this.startText.Size = new System.Drawing.Size(30, 16);
            this.startText.TabIndex = 26;
            this.startText.Text = "N/A";
            // 
            // lengthText
            // 
            this.lengthText.AutoSize = true;
            this.lengthText.BackColor = System.Drawing.Color.Transparent;
            this.lengthText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthText.ForeColor = System.Drawing.Color.White;
            this.lengthText.Location = new System.Drawing.Point(600, 120);
            this.lengthText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.lengthText.Name = "lengthText";
            this.lengthText.Size = new System.Drawing.Size(30, 16);
            this.lengthText.TabIndex = 24;
            this.lengthText.Text = "N/A";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.lengthLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.ForeColor = System.Drawing.Color.White;
            this.lengthLabel.Location = new System.Drawing.Point(406, 115);
            this.lengthLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(78, 21);
            this.lengthLabel.TabIndex = 23;
            this.lengthLabel.Text = "Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(410, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "#1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(410, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "#2";
            // 
            // timer2Label
            // 
            this.timer2Label.AccessibleDescription = "t";
            this.timer2Label.AutoSize = true;
            this.timer2Label.BackColor = System.Drawing.Color.Transparent;
            this.timer2Label.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer2Label.ForeColor = System.Drawing.Color.White;
            this.timer2Label.Location = new System.Drawing.Point(440, 332);
            this.timer2Label.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.timer2Label.Name = "timer2Label";
            this.timer2Label.Size = new System.Drawing.Size(55, 21);
            this.timer2Label.TabIndex = 38;
            this.timer2Label.Text = "Timer";
            // 
            // timer2Text
            // 
            this.timer2Text.AccessibleDescription = "t";
            this.timer2Text.AutoSize = true;
            this.timer2Text.BackColor = System.Drawing.Color.Transparent;
            this.timer2Text.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer2Text.ForeColor = System.Drawing.Color.White;
            this.timer2Text.Location = new System.Drawing.Point(599, 336);
            this.timer2Text.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.timer2Text.Name = "timer2Text";
            this.timer2Text.Size = new System.Drawing.Size(30, 16);
            this.timer2Text.TabIndex = 39;
            this.timer2Text.Text = "N/A";
            // 
            // lower2Label
            // 
            this.lower2Label.AccessibleDescription = "t";
            this.lower2Label.AutoSize = true;
            this.lower2Label.BackColor = System.Drawing.Color.Transparent;
            this.lower2Label.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lower2Label.ForeColor = System.Drawing.Color.White;
            this.lower2Label.Location = new System.Drawing.Point(440, 303);
            this.lower2Label.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.lower2Label.Name = "lower2Label";
            this.lower2Label.Size = new System.Drawing.Size(59, 21);
            this.lower2Label.TabIndex = 36;
            this.lower2Label.Text = "Lower";
            // 
            // lower2Text
            // 
            this.lower2Text.AccessibleDescription = "t";
            this.lower2Text.AutoSize = true;
            this.lower2Text.BackColor = System.Drawing.Color.Transparent;
            this.lower2Text.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lower2Text.ForeColor = System.Drawing.Color.White;
            this.lower2Text.Location = new System.Drawing.Point(599, 307);
            this.lower2Text.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.lower2Text.Name = "lower2Text";
            this.lower2Text.Size = new System.Drawing.Size(30, 16);
            this.lower2Text.TabIndex = 37;
            this.lower2Text.Text = "N/A";
            // 
            // upper2Label
            // 
            this.upper2Label.AutoSize = true;
            this.upper2Label.BackColor = System.Drawing.Color.Transparent;
            this.upper2Label.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upper2Label.ForeColor = System.Drawing.Color.White;
            this.upper2Label.Location = new System.Drawing.Point(440, 275);
            this.upper2Label.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.upper2Label.Name = "upper2Label";
            this.upper2Label.Size = new System.Drawing.Size(59, 21);
            this.upper2Label.TabIndex = 34;
            this.upper2Label.Text = "Upper";
            // 
            // upper2Text
            // 
            this.upper2Text.AutoSize = true;
            this.upper2Text.BackColor = System.Drawing.Color.Transparent;
            this.upper2Text.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upper2Text.ForeColor = System.Drawing.Color.White;
            this.upper2Text.Location = new System.Drawing.Point(599, 279);
            this.upper2Text.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.upper2Text.Name = "upper2Text";
            this.upper2Text.Size = new System.Drawing.Size(30, 16);
            this.upper2Text.TabIndex = 35;
            this.upper2Text.Text = "N/A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(410, 368);
            this.label11.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 16);
            this.label11.TabIndex = 47;
            this.label11.Text = "#3";
            // 
            // timer3Label
            // 
            this.timer3Label.AccessibleDescription = "t";
            this.timer3Label.AutoSize = true;
            this.timer3Label.BackColor = System.Drawing.Color.Transparent;
            this.timer3Label.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer3Label.ForeColor = System.Drawing.Color.White;
            this.timer3Label.Location = new System.Drawing.Point(440, 439);
            this.timer3Label.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.timer3Label.Name = "timer3Label";
            this.timer3Label.Size = new System.Drawing.Size(55, 21);
            this.timer3Label.TabIndex = 45;
            this.timer3Label.Text = "Timer";
            // 
            // timer3Text
            // 
            this.timer3Text.AccessibleDescription = "t";
            this.timer3Text.AutoSize = true;
            this.timer3Text.BackColor = System.Drawing.Color.Transparent;
            this.timer3Text.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer3Text.ForeColor = System.Drawing.Color.White;
            this.timer3Text.Location = new System.Drawing.Point(599, 443);
            this.timer3Text.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.timer3Text.Name = "timer3Text";
            this.timer3Text.Size = new System.Drawing.Size(30, 16);
            this.timer3Text.TabIndex = 46;
            this.timer3Text.Text = "N/A";
            // 
            // lower3Label
            // 
            this.lower3Label.AccessibleDescription = "t";
            this.lower3Label.AutoSize = true;
            this.lower3Label.BackColor = System.Drawing.Color.Transparent;
            this.lower3Label.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lower3Label.ForeColor = System.Drawing.Color.White;
            this.lower3Label.Location = new System.Drawing.Point(440, 410);
            this.lower3Label.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.lower3Label.Name = "lower3Label";
            this.lower3Label.Size = new System.Drawing.Size(59, 21);
            this.lower3Label.TabIndex = 43;
            this.lower3Label.Text = "Lower";
            // 
            // lower3Text
            // 
            this.lower3Text.AccessibleDescription = "t";
            this.lower3Text.AutoSize = true;
            this.lower3Text.BackColor = System.Drawing.Color.Transparent;
            this.lower3Text.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lower3Text.ForeColor = System.Drawing.Color.White;
            this.lower3Text.Location = new System.Drawing.Point(599, 414);
            this.lower3Text.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.lower3Text.Name = "lower3Text";
            this.lower3Text.Size = new System.Drawing.Size(30, 16);
            this.lower3Text.TabIndex = 44;
            this.lower3Text.Text = "N/A";
            // 
            // upper3Label
            // 
            this.upper3Label.AutoSize = true;
            this.upper3Label.BackColor = System.Drawing.Color.Transparent;
            this.upper3Label.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upper3Label.ForeColor = System.Drawing.Color.White;
            this.upper3Label.Location = new System.Drawing.Point(440, 382);
            this.upper3Label.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.upper3Label.Name = "upper3Label";
            this.upper3Label.Size = new System.Drawing.Size(59, 21);
            this.upper3Label.TabIndex = 41;
            this.upper3Label.Text = "Upper";
            // 
            // upper3Text
            // 
            this.upper3Text.AutoSize = true;
            this.upper3Text.BackColor = System.Drawing.Color.Transparent;
            this.upper3Text.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upper3Text.ForeColor = System.Drawing.Color.White;
            this.upper3Text.Location = new System.Drawing.Point(599, 386);
            this.upper3Text.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.upper3Text.Name = "upper3Text";
            this.upper3Text.Size = new System.Drawing.Size(30, 16);
            this.upper3Text.TabIndex = 42;
            this.upper3Text.Text = "N/A";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Physcle.Properties.Resources.Dark_Gray_U769;
            this.ClientSize = new System.Drawing.Size(951, 564);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.overviewPanel);
            this.Controls.Add(this.welcomeMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            this.overviewPanel.ResumeLayout(false);
            this.overviewPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel navigationPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.Label overview;
        private System.Windows.Forms.Label summary;
        private System.Windows.Forms.Label intervalText;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.Label sModeText;
        private System.Windows.Forms.Label sModeLabel;
        private System.Windows.Forms.Label monitorText;
        private System.Windows.Forms.Label monitorLabel;
        private System.Windows.Forms.Label versionText;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Panel overviewPanel;
        private System.Windows.Forms.Label welcomeMessage;
        private System.Windows.Forms.Label activeLabel;
        private System.Windows.Forms.Label activeText;
        private System.Windows.Forms.Label maxHrLabel;
        private System.Windows.Forms.Label maxHrText;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label weightText;
        private System.Windows.Forms.Label V02MaxLabel;
        private System.Windows.Forms.Label V02MaxText;
        private System.Windows.Forms.Label restHrLabel;
        private System.Windows.Forms.Label restHrText;
        private System.Windows.Forms.Label timer1Label;
        private System.Windows.Forms.Label timer1Text;
        private System.Windows.Forms.Label lower1Label;
        private System.Windows.Forms.Label lower1Text;
        private System.Windows.Forms.Label upper1Label;
        private System.Windows.Forms.Label upper1Text;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label dateText;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label startText;
        private System.Windows.Forms.Label lengthText;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label timer2Label;
        private System.Windows.Forms.Label timer2Text;
        private System.Windows.Forms.Label lower2Label;
        private System.Windows.Forms.Label lower2Text;
        private System.Windows.Forms.Label upper2Label;
        private System.Windows.Forms.Label upper2Text;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label timer3Label;
        private System.Windows.Forms.Label timer3Text;
        private System.Windows.Forms.Label lower3Label;
        private System.Windows.Forms.Label lower3Text;
        private System.Windows.Forms.Label upper3Label;
        private System.Windows.Forms.Label upper3Text;
        private System.Windows.Forms.ImageList imageList1;



    }
}

