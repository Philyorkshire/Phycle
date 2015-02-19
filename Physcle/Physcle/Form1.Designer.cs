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
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.overview = new System.Windows.Forms.Label();
            this.summary = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.intervalText = new System.Windows.Forms.Label();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.sModeText = new System.Windows.Forms.Label();
            this.sModeLabel = new System.Windows.Forms.Label();
            this.monitorText = new System.Windows.Forms.Label();
            this.monitorLabel = new System.Windows.Forms.Label();
            this.versionText = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.overviewPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.timer3Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer3Text = new System.Windows.Forms.Label();
            this.lower3Label = new System.Windows.Forms.Label();
            this.lower3Text = new System.Windows.Forms.Label();
            this.upper3Label = new System.Windows.Forms.Label();
            this.upper3Text = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer2Label = new System.Windows.Forms.Label();
            this.timer2Text = new System.Windows.Forms.Label();
            this.lower2Label = new System.Windows.Forms.Label();
            this.lower2Text = new System.Windows.Forms.Label();
            this.upper2Label = new System.Windows.Forms.Label();
            this.upper2Text = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1Label = new System.Windows.Forms.Label();
            this.timer1Text = new System.Windows.Forms.Label();
            this.lower1Label = new System.Windows.Forms.Label();
            this.lower1Text = new System.Windows.Forms.Label();
            this.upper1Label = new System.Windows.Forms.Label();
            this.upper1Text = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateText = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightText = new System.Windows.Forms.Label();
            this.V02MaxLabel = new System.Windows.Forms.Label();
            this.V02MaxText = new System.Windows.Forms.Label();
            this.restHrLabel = new System.Windows.Forms.Label();
            this.restHrText = new System.Windows.Forms.Label();
            this.maxHrLabel = new System.Windows.Forms.Label();
            this.maxHrText = new System.Windows.Forms.Label();
            this.activeLabel = new System.Windows.Forms.Label();
            this.activeText = new System.Windows.Forms.Label();
            this.lengthText = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.welcomeMessage = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.summaryPanel = new System.Windows.Forms.Panel();
            this.tPowerText = new System.Windows.Forms.Label();
            this.tPowerLabel = new System.Windows.Forms.Label();
            this.tDistanceLabel = new System.Windows.Forms.Label();
            this.tDistanceText = new System.Windows.Forms.Label();
            this.totals = new System.Windows.Forms.Label();
            this.averages = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.aPressureLabel = new System.Windows.Forms.Label();
            this.aPressureText = new System.Windows.Forms.Label();
            this.aPowerLabel = new System.Windows.Forms.Label();
            this.aPowerText = new System.Windows.Forms.Label();
            this.aCadenceLabel = new System.Windows.Forms.Label();
            this.aCadenceText = new System.Windows.Forms.Label();
            this.aHeartLabel = new System.Windows.Forms.Label();
            this.aHeartText = new System.Windows.Forms.Label();
            this.aAltitudeLabel = new System.Windows.Forms.Label();
            this.aAltitudeText = new System.Windows.Forms.Label();
            this.aSpeedLabel = new System.Windows.Forms.Label();
            this.aSpeedText = new System.Windows.Forms.Label();
            this.saveToJson = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.overviewPanel.SuspendLayout();
            this.summaryPanel.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(955, 24);
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
            this.saveAsToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.loadFileToolStripMenuItem.Text = "Load File";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.jSONToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.jSONToolStripMenuItem.Text = "JSON";
            this.jSONToolStripMenuItem.Click += new System.EventHandler(this.jSONToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
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
            // intervalText
            // 
            this.intervalText.AutoSize = true;
            this.intervalText.BackColor = System.Drawing.Color.Transparent;
            this.intervalText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervalText.ForeColor = System.Drawing.Color.White;
            this.intervalText.Location = new System.Drawing.Point(208, 143);
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
            this.intervalLabel.Location = new System.Drawing.Point(48, 139);
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
            this.sModeText.Location = new System.Drawing.Point(209, 173);
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
            this.sModeLabel.Location = new System.Drawing.Point(46, 168);
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
            this.monitorText.Location = new System.Drawing.Point(209, 201);
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
            this.monitorLabel.Location = new System.Drawing.Point(48, 197);
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
            this.versionText.Location = new System.Drawing.Point(208, 113);
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
            this.versionLabel.Location = new System.Drawing.Point(46, 109);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 20);
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
            this.overviewPanel.Controls.Add(this.label5);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(406, 306);
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
            this.timer3Label.Location = new System.Drawing.Point(436, 377);
            this.timer3Label.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.timer3Label.Name = "timer3Label";
            this.timer3Label.Size = new System.Drawing.Size(55, 21);
            this.timer3Label.TabIndex = 45;
            this.timer3Label.Text = "Timer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(43, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(2);
            this.label5.Size = new System.Drawing.Size(130, 36);
            this.label5.TabIndex = 3;
            this.label5.Text = "Overview";
            // 
            // timer3Text
            // 
            this.timer3Text.AccessibleDescription = "t";
            this.timer3Text.AutoSize = true;
            this.timer3Text.BackColor = System.Drawing.Color.Transparent;
            this.timer3Text.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer3Text.ForeColor = System.Drawing.Color.White;
            this.timer3Text.Location = new System.Drawing.Point(595, 381);
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
            this.lower3Label.Location = new System.Drawing.Point(436, 348);
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
            this.lower3Text.Location = new System.Drawing.Point(595, 352);
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
            this.upper3Label.Location = new System.Drawing.Point(436, 320);
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
            this.upper3Text.Location = new System.Drawing.Point(595, 324);
            this.upper3Text.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.upper3Text.Name = "upper3Text";
            this.upper3Text.Size = new System.Drawing.Size(30, 16);
            this.upper3Text.TabIndex = 42;
            this.upper3Text.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(406, 199);
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
            this.timer2Label.Location = new System.Drawing.Point(436, 270);
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
            this.timer2Text.Location = new System.Drawing.Point(595, 274);
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
            this.lower2Label.Location = new System.Drawing.Point(436, 241);
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
            this.lower2Text.Location = new System.Drawing.Point(595, 245);
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
            this.upper2Label.Location = new System.Drawing.Point(436, 213);
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
            this.upper2Text.Location = new System.Drawing.Point(595, 217);
            this.upper2Text.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.upper2Text.Name = "upper2Text";
            this.upper2Text.Size = new System.Drawing.Size(30, 16);
            this.upper2Text.TabIndex = 35;
            this.upper2Text.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(406, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "#1";
            // 
            // timer1Label
            // 
            this.timer1Label.AccessibleDescription = "t";
            this.timer1Label.AutoSize = true;
            this.timer1Label.BackColor = System.Drawing.Color.Transparent;
            this.timer1Label.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer1Label.ForeColor = System.Drawing.Color.White;
            this.timer1Label.Location = new System.Drawing.Point(436, 166);
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
            this.timer1Text.Location = new System.Drawing.Point(595, 170);
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
            this.lower1Label.Location = new System.Drawing.Point(436, 137);
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
            this.lower1Text.Location = new System.Drawing.Point(595, 141);
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
            this.upper1Label.Location = new System.Drawing.Point(436, 109);
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
            this.upper1Text.Location = new System.Drawing.Point(595, 113);
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
            this.dateLabel.Location = new System.Drawing.Point(48, 357);
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
            this.dateText.Location = new System.Drawing.Point(211, 362);
            this.dateText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(30, 16);
            this.dateText.TabIndex = 20;
            this.dateText.Text = "N/A";
            // 
            // weightLabel
            // 
            this.weightLabel.AccessibleDescription = "t";
            this.weightLabel.AutoSize = true;
            this.weightLabel.BackColor = System.Drawing.Color.Transparent;
            this.weightLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.ForeColor = System.Drawing.Color.White;
            this.weightLabel.Location = new System.Drawing.Point(48, 332);
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
            this.weightText.Location = new System.Drawing.Point(211, 336);
            this.weightText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.weightText.Name = "weightText";
            this.weightText.Size = new System.Drawing.Size(30, 16);
            this.weightText.TabIndex = 18;
            this.weightText.Text = "N/A";
            // 
            // V02MaxLabel
            // 
            this.V02MaxLabel.AccessibleDescription = "t";
            this.V02MaxLabel.AutoSize = true;
            this.V02MaxLabel.BackColor = System.Drawing.Color.Transparent;
            this.V02MaxLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V02MaxLabel.ForeColor = System.Drawing.Color.White;
            this.V02MaxLabel.Location = new System.Drawing.Point(48, 305);
            this.V02MaxLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.V02MaxLabel.Name = "V02MaxLabel";
            this.V02MaxLabel.Size = new System.Drawing.Size(83, 21);
            this.V02MaxLabel.TabIndex = 15;
            this.V02MaxLabel.Text = "VO2 Max";
            // 
            // V02MaxText
            // 
            this.V02MaxText.AccessibleDescription = "t";
            this.V02MaxText.AutoSize = true;
            this.V02MaxText.BackColor = System.Drawing.Color.Transparent;
            this.V02MaxText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V02MaxText.ForeColor = System.Drawing.Color.White;
            this.V02MaxText.Location = new System.Drawing.Point(211, 309);
            this.V02MaxText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.V02MaxText.Name = "V02MaxText";
            this.V02MaxText.Size = new System.Drawing.Size(30, 16);
            this.V02MaxText.TabIndex = 16;
            this.V02MaxText.Text = "N/A";
            // 
            // restHrLabel
            // 
            this.restHrLabel.AccessibleDescription = "t";
            this.restHrLabel.AutoSize = true;
            this.restHrLabel.BackColor = System.Drawing.Color.Transparent;
            this.restHrLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restHrLabel.ForeColor = System.Drawing.Color.White;
            this.restHrLabel.Location = new System.Drawing.Point(48, 278);
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
            this.restHrText.Location = new System.Drawing.Point(211, 282);
            this.restHrText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.restHrText.Name = "restHrText";
            this.restHrText.Size = new System.Drawing.Size(30, 16);
            this.restHrText.TabIndex = 14;
            this.restHrText.Text = "N/A";
            // 
            // maxHrLabel
            // 
            this.maxHrLabel.AccessibleDescription = "t";
            this.maxHrLabel.AutoSize = true;
            this.maxHrLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxHrLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxHrLabel.ForeColor = System.Drawing.Color.White;
            this.maxHrLabel.Location = new System.Drawing.Point(48, 251);
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
            this.maxHrText.Location = new System.Drawing.Point(211, 255);
            this.maxHrText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.maxHrText.Name = "maxHrText";
            this.maxHrText.Size = new System.Drawing.Size(30, 16);
            this.maxHrText.TabIndex = 12;
            this.maxHrText.Text = "N/A";
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.BackColor = System.Drawing.Color.Transparent;
            this.activeLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeLabel.ForeColor = System.Drawing.Color.White;
            this.activeLabel.Location = new System.Drawing.Point(48, 224);
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
            this.activeText.Location = new System.Drawing.Point(210, 228);
            this.activeText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.activeText.Name = "activeText";
            this.activeText.Size = new System.Drawing.Size(30, 16);
            this.activeText.TabIndex = 10;
            this.activeText.Text = "N/A";
            // 
            // lengthText
            // 
            this.lengthText.AutoSize = true;
            this.lengthText.BackColor = System.Drawing.Color.Transparent;
            this.lengthText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthText.ForeColor = System.Drawing.Color.White;
            this.lengthText.Location = new System.Drawing.Point(621, 196);
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
            this.lengthLabel.Location = new System.Drawing.Point(429, 192);
            this.lengthLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(78, 21);
            this.lengthLabel.TabIndex = 23;
            this.lengthLabel.Text = "Duration";
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
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // summaryPanel
            // 
            this.summaryPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.summaryPanel.Controls.Add(this.tPowerText);
            this.summaryPanel.Controls.Add(this.tPowerLabel);
            this.summaryPanel.Controls.Add(this.tDistanceLabel);
            this.summaryPanel.Controls.Add(this.tDistanceText);
            this.summaryPanel.Controls.Add(this.totals);
            this.summaryPanel.Controls.Add(this.averages);
            this.summaryPanel.Controls.Add(this.label6);
            this.summaryPanel.Controls.Add(this.aPressureLabel);
            this.summaryPanel.Controls.Add(this.aPressureText);
            this.summaryPanel.Controls.Add(this.aPowerLabel);
            this.summaryPanel.Controls.Add(this.aPowerText);
            this.summaryPanel.Controls.Add(this.aCadenceLabel);
            this.summaryPanel.Controls.Add(this.aCadenceText);
            this.summaryPanel.Controls.Add(this.aHeartLabel);
            this.summaryPanel.Controls.Add(this.aHeartText);
            this.summaryPanel.Controls.Add(this.aAltitudeLabel);
            this.summaryPanel.Controls.Add(this.aAltitudeText);
            this.summaryPanel.Controls.Add(this.aSpeedLabel);
            this.summaryPanel.Controls.Add(this.aSpeedText);
            this.summaryPanel.Controls.Add(this.lengthText);
            this.summaryPanel.Controls.Add(this.lengthLabel);
            this.summaryPanel.Location = new System.Drawing.Point(188, 558);
            this.summaryPanel.Name = "summaryPanel";
            this.summaryPanel.Size = new System.Drawing.Size(751, 497);
            this.summaryPanel.TabIndex = 48;
            this.summaryPanel.Visible = false;
            // 
            // tPowerText
            // 
            this.tPowerText.AutoSize = true;
            this.tPowerText.BackColor = System.Drawing.Color.Transparent;
            this.tPowerText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPowerText.ForeColor = System.Drawing.Color.White;
            this.tPowerText.Location = new System.Drawing.Point(621, 224);
            this.tPowerText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.tPowerText.Name = "tPowerText";
            this.tPowerText.Size = new System.Drawing.Size(30, 16);
            this.tPowerText.TabIndex = 77;
            this.tPowerText.Text = "N/A";
            // 
            // tPowerLabel
            // 
            this.tPowerLabel.AutoSize = true;
            this.tPowerLabel.BackColor = System.Drawing.Color.Transparent;
            this.tPowerLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPowerLabel.ForeColor = System.Drawing.Color.White;
            this.tPowerLabel.Location = new System.Drawing.Point(429, 219);
            this.tPowerLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.tPowerLabel.Name = "tPowerLabel";
            this.tPowerLabel.Size = new System.Drawing.Size(151, 21);
            this.tPowerLabel.TabIndex = 76;
            this.tPowerLabel.Text = "Power Generated";
            // 
            // tDistanceLabel
            // 
            this.tDistanceLabel.AccessibleDescription = "t";
            this.tDistanceLabel.AutoSize = true;
            this.tDistanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.tDistanceLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDistanceLabel.ForeColor = System.Drawing.Color.White;
            this.tDistanceLabel.Location = new System.Drawing.Point(429, 166);
            this.tDistanceLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.tDistanceLabel.Name = "tDistanceLabel";
            this.tDistanceLabel.Size = new System.Drawing.Size(155, 21);
            this.tDistanceLabel.TabIndex = 74;
            this.tDistanceLabel.Text = "Distance Traveled";
            // 
            // tDistanceText
            // 
            this.tDistanceText.AccessibleDescription = "t";
            this.tDistanceText.AutoSize = true;
            this.tDistanceText.BackColor = System.Drawing.Color.Transparent;
            this.tDistanceText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDistanceText.ForeColor = System.Drawing.Color.White;
            this.tDistanceText.Location = new System.Drawing.Point(621, 171);
            this.tDistanceText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.tDistanceText.Name = "tDistanceText";
            this.tDistanceText.Size = new System.Drawing.Size(30, 16);
            this.tDistanceText.TabIndex = 75;
            this.tDistanceText.Text = "N/A";
            // 
            // totals
            // 
            this.totals.AutoSize = true;
            this.totals.BackColor = System.Drawing.Color.Transparent;
            this.totals.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totals.ForeColor = System.Drawing.Color.White;
            this.totals.Location = new System.Drawing.Point(422, 123);
            this.totals.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.totals.Name = "totals";
            this.totals.Padding = new System.Windows.Forms.Padding(2);
            this.totals.Size = new System.Drawing.Size(74, 29);
            this.totals.TabIndex = 73;
            this.totals.Text = "Totals";
            // 
            // averages
            // 
            this.averages.AutoSize = true;
            this.averages.BackColor = System.Drawing.Color.Transparent;
            this.averages.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averages.ForeColor = System.Drawing.Color.White;
            this.averages.Location = new System.Drawing.Point(53, 123);
            this.averages.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.averages.Name = "averages";
            this.averages.Padding = new System.Windows.Forms.Padding(2);
            this.averages.Size = new System.Drawing.Size(108, 29);
            this.averages.TabIndex = 60;
            this.averages.Text = "Averages";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(2);
            this.label6.Size = new System.Drawing.Size(200, 36);
            this.label6.TabIndex = 48;
            this.label6.Text = "Summary Data";
            // 
            // aPressureLabel
            // 
            this.aPressureLabel.AccessibleDescription = "t";
            this.aPressureLabel.AutoSize = true;
            this.aPressureLabel.BackColor = System.Drawing.Color.Transparent;
            this.aPressureLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPressureLabel.ForeColor = System.Drawing.Color.White;
            this.aPressureLabel.Location = new System.Drawing.Point(54, 292);
            this.aPressureLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.aPressureLabel.Name = "aPressureLabel";
            this.aPressureLabel.Size = new System.Drawing.Size(82, 21);
            this.aPressureLabel.TabIndex = 58;
            this.aPressureLabel.Text = "Pressure";
            // 
            // aPressureText
            // 
            this.aPressureText.AccessibleDescription = "t";
            this.aPressureText.AutoSize = true;
            this.aPressureText.BackColor = System.Drawing.Color.Transparent;
            this.aPressureText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPressureText.ForeColor = System.Drawing.Color.White;
            this.aPressureText.Location = new System.Drawing.Point(216, 299);
            this.aPressureText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.aPressureText.Name = "aPressureText";
            this.aPressureText.Size = new System.Drawing.Size(30, 16);
            this.aPressureText.TabIndex = 59;
            this.aPressureText.Text = "N/A";
            // 
            // aPowerLabel
            // 
            this.aPowerLabel.AccessibleDescription = "t";
            this.aPowerLabel.AutoSize = true;
            this.aPowerLabel.BackColor = System.Drawing.Color.Transparent;
            this.aPowerLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPowerLabel.ForeColor = System.Drawing.Color.White;
            this.aPowerLabel.Location = new System.Drawing.Point(54, 266);
            this.aPowerLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.aPowerLabel.Name = "aPowerLabel";
            this.aPowerLabel.Size = new System.Drawing.Size(61, 21);
            this.aPowerLabel.TabIndex = 56;
            this.aPowerLabel.Text = "Power";
            // 
            // aPowerText
            // 
            this.aPowerText.AccessibleDescription = "t";
            this.aPowerText.AutoSize = true;
            this.aPowerText.BackColor = System.Drawing.Color.Transparent;
            this.aPowerText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPowerText.ForeColor = System.Drawing.Color.White;
            this.aPowerText.Location = new System.Drawing.Point(216, 273);
            this.aPowerText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.aPowerText.Name = "aPowerText";
            this.aPowerText.Size = new System.Drawing.Size(30, 16);
            this.aPowerText.TabIndex = 57;
            this.aPowerText.Text = "N/A";
            // 
            // aCadenceLabel
            // 
            this.aCadenceLabel.AccessibleDescription = "t";
            this.aCadenceLabel.AutoSize = true;
            this.aCadenceLabel.BackColor = System.Drawing.Color.Transparent;
            this.aCadenceLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aCadenceLabel.ForeColor = System.Drawing.Color.White;
            this.aCadenceLabel.Location = new System.Drawing.Point(54, 240);
            this.aCadenceLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.aCadenceLabel.Name = "aCadenceLabel";
            this.aCadenceLabel.Size = new System.Drawing.Size(82, 21);
            this.aCadenceLabel.TabIndex = 54;
            this.aCadenceLabel.Text = "Cadence";
            // 
            // aCadenceText
            // 
            this.aCadenceText.AccessibleDescription = "t";
            this.aCadenceText.AutoSize = true;
            this.aCadenceText.BackColor = System.Drawing.Color.Transparent;
            this.aCadenceText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aCadenceText.ForeColor = System.Drawing.Color.White;
            this.aCadenceText.Location = new System.Drawing.Point(216, 247);
            this.aCadenceText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.aCadenceText.Name = "aCadenceText";
            this.aCadenceText.Size = new System.Drawing.Size(30, 16);
            this.aCadenceText.TabIndex = 55;
            this.aCadenceText.Text = "N/A";
            // 
            // aHeartLabel
            // 
            this.aHeartLabel.AccessibleDescription = "t";
            this.aHeartLabel.AutoSize = true;
            this.aHeartLabel.BackColor = System.Drawing.Color.Transparent;
            this.aHeartLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aHeartLabel.ForeColor = System.Drawing.Color.White;
            this.aHeartLabel.Location = new System.Drawing.Point(54, 216);
            this.aHeartLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.aHeartLabel.Name = "aHeartLabel";
            this.aHeartLabel.Size = new System.Drawing.Size(97, 21);
            this.aHeartLabel.TabIndex = 52;
            this.aHeartLabel.Text = "Heart Rate";
            // 
            // aHeartText
            // 
            this.aHeartText.AccessibleDescription = "t";
            this.aHeartText.AutoSize = true;
            this.aHeartText.BackColor = System.Drawing.Color.Transparent;
            this.aHeartText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aHeartText.ForeColor = System.Drawing.Color.White;
            this.aHeartText.Location = new System.Drawing.Point(216, 221);
            this.aHeartText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.aHeartText.Name = "aHeartText";
            this.aHeartText.Size = new System.Drawing.Size(30, 16);
            this.aHeartText.TabIndex = 53;
            this.aHeartText.Text = "N/A";
            // 
            // aAltitudeLabel
            // 
            this.aAltitudeLabel.AccessibleDescription = "t";
            this.aAltitudeLabel.AutoSize = true;
            this.aAltitudeLabel.BackColor = System.Drawing.Color.Transparent;
            this.aAltitudeLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aAltitudeLabel.ForeColor = System.Drawing.Color.White;
            this.aAltitudeLabel.Location = new System.Drawing.Point(54, 191);
            this.aAltitudeLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.aAltitudeLabel.Name = "aAltitudeLabel";
            this.aAltitudeLabel.Size = new System.Drawing.Size(69, 21);
            this.aAltitudeLabel.TabIndex = 50;
            this.aAltitudeLabel.Text = "Altitude";
            // 
            // aAltitudeText
            // 
            this.aAltitudeText.AccessibleDescription = "t";
            this.aAltitudeText.AutoSize = true;
            this.aAltitudeText.BackColor = System.Drawing.Color.Transparent;
            this.aAltitudeText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aAltitudeText.ForeColor = System.Drawing.Color.White;
            this.aAltitudeText.Location = new System.Drawing.Point(216, 196);
            this.aAltitudeText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.aAltitudeText.Name = "aAltitudeText";
            this.aAltitudeText.Size = new System.Drawing.Size(30, 16);
            this.aAltitudeText.TabIndex = 51;
            this.aAltitudeText.Text = "N/A";
            // 
            // aSpeedLabel
            // 
            this.aSpeedLabel.AccessibleDescription = "t";
            this.aSpeedLabel.AutoSize = true;
            this.aSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.aSpeedLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSpeedLabel.ForeColor = System.Drawing.Color.White;
            this.aSpeedLabel.Location = new System.Drawing.Point(54, 166);
            this.aSpeedLabel.Margin = new System.Windows.Forms.Padding(50, 30, 3, 0);
            this.aSpeedLabel.Name = "aSpeedLabel";
            this.aSpeedLabel.Size = new System.Drawing.Size(62, 21);
            this.aSpeedLabel.TabIndex = 48;
            this.aSpeedLabel.Text = "Speed";
            // 
            // aSpeedText
            // 
            this.aSpeedText.AccessibleDescription = "t";
            this.aSpeedText.AutoSize = true;
            this.aSpeedText.BackColor = System.Drawing.Color.Transparent;
            this.aSpeedText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSpeedText.ForeColor = System.Drawing.Color.White;
            this.aSpeedText.Location = new System.Drawing.Point(216, 171);
            this.aSpeedText.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.aSpeedText.Name = "aSpeedText";
            this.aSpeedText.Size = new System.Drawing.Size(30, 16);
            this.aSpeedText.TabIndex = 49;
            this.aSpeedText.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Physcle.Properties.Resources.Dark_Gray_U769;
            this.ClientSize = new System.Drawing.Size(955, 1082);
            this.Controls.Add(this.summaryPanel);
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
            this.summaryPanel.ResumeLayout(false);
            this.summaryPanel.PerformLayout();
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
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Label aSpeedLabel;
        private System.Windows.Forms.Label aSpeedText;
        private System.Windows.Forms.Label aCadenceLabel;
        private System.Windows.Forms.Label aCadenceText;
        private System.Windows.Forms.Label aHeartLabel;
        private System.Windows.Forms.Label aHeartText;
        private System.Windows.Forms.Label aAltitudeLabel;
        private System.Windows.Forms.Label aAltitudeText;
        private System.Windows.Forms.Label aPressureLabel;
        private System.Windows.Forms.Label aPressureText;
        private System.Windows.Forms.Label aPowerLabel;
        private System.Windows.Forms.Label aPowerText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totals;
        private System.Windows.Forms.Label averages;
        private System.Windows.Forms.Label tDistanceLabel;
        private System.Windows.Forms.Label tDistanceText;
        private System.Windows.Forms.Label tPowerText;
        private System.Windows.Forms.Label tPowerLabel;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveToJson;



    }
}

