namespace BudgetSystem
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
            panelTitleBar = new Panel();
            labelTabName = new Label();
            buttonMenu = new FontAwesome.Sharp.IconButton();
            buttonMaximizeWindow = new FontAwesome.Sharp.IconButton();
            buttonMinimizeWindow = new FontAwesome.Sharp.IconButton();
            buttonCloseWindow = new FontAwesome.Sharp.IconButton();
            panelMenu = new Panel();
            buttonExit = new FontAwesome.Sharp.IconButton();
            buttonSettings = new FontAwesome.Sharp.IconButton();
            buttonDashboards = new FontAwesome.Sharp.IconButton();
            buttonAccount = new FontAwesome.Sharp.IconButton();
            buttonHome = new FontAwesome.Sharp.IconButton();
            panelMain = new Panel();
            panelTitleBar.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(33, 34, 44);
            panelTitleBar.Controls.Add(labelTabName);
            panelTitleBar.Controls.Add(buttonMenu);
            panelTitleBar.Controls.Add(buttonMaximizeWindow);
            panelTitleBar.Controls.Add(buttonMinimizeWindow);
            panelTitleBar.Controls.Add(buttonCloseWindow);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Margin = new Padding(3, 2, 3, 2);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Padding = new Padding(0, 4, 4, 0);
            panelTitleBar.Size = new Size(1292, 60);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // labelTabName
            // 
            labelTabName.Dock = DockStyle.Left;
            labelTabName.Font = new Font("Verdana", 12F);
            labelTabName.ForeColor = Color.White;
            labelTabName.Location = new Point(61, 4);
            labelTabName.Name = "labelTabName";
            labelTabName.Size = new Size(219, 56);
            labelTabName.TabIndex = 4;
            labelTabName.Text = "Tela Inicial";
            labelTabName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonMenu
            // 
            buttonMenu.Dock = DockStyle.Left;
            buttonMenu.FlatAppearance.BorderSize = 0;
            buttonMenu.FlatStyle = FlatStyle.Flat;
            buttonMenu.Font = new Font("Segoe UI", 12F);
            buttonMenu.ForeColor = Color.White;
            buttonMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            buttonMenu.IconColor = Color.White;
            buttonMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonMenu.Location = new Point(0, 4);
            buttonMenu.Margin = new Padding(3, 2, 3, 2);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(61, 56);
            buttonMenu.TabIndex = 3;
            buttonMenu.TextAlign = ContentAlignment.MiddleLeft;
            buttonMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMenu.UseVisualStyleBackColor = true;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // buttonMaximizeWindow
            // 
            buttonMaximizeWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMaximizeWindow.BackColor = Color.FromArgb(33, 34, 44);
            buttonMaximizeWindow.FlatAppearance.BorderSize = 0;
            buttonMaximizeWindow.FlatStyle = FlatStyle.Flat;
            buttonMaximizeWindow.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            buttonMaximizeWindow.IconColor = Color.White;
            buttonMaximizeWindow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonMaximizeWindow.IconSize = 16;
            buttonMaximizeWindow.Location = new Point(1187, 4);
            buttonMaximizeWindow.Margin = new Padding(4);
            buttonMaximizeWindow.Name = "buttonMaximizeWindow";
            buttonMaximizeWindow.Size = new Size(50, 25);
            buttonMaximizeWindow.TabIndex = 2;
            buttonMaximizeWindow.UseVisualStyleBackColor = false;
            buttonMaximizeWindow.Click += buttonMaximizeWindow_Click;
            buttonMaximizeWindow.Resize += Form1_Resize;
            // 
            // buttonMinimizeWindow
            // 
            buttonMinimizeWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMinimizeWindow.BackColor = Color.FromArgb(33, 34, 44);
            buttonMinimizeWindow.FlatAppearance.BorderSize = 0;
            buttonMinimizeWindow.FlatStyle = FlatStyle.Flat;
            buttonMinimizeWindow.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            buttonMinimizeWindow.IconColor = Color.White;
            buttonMinimizeWindow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonMinimizeWindow.IconSize = 16;
            buttonMinimizeWindow.Location = new Point(1135, 4);
            buttonMinimizeWindow.Margin = new Padding(4);
            buttonMinimizeWindow.Name = "buttonMinimizeWindow";
            buttonMinimizeWindow.Size = new Size(50, 25);
            buttonMinimizeWindow.TabIndex = 1;
            buttonMinimizeWindow.UseVisualStyleBackColor = false;
            buttonMinimizeWindow.Click += buttonMinimizeWindow_Click;
            buttonMinimizeWindow.Resize += Form1_Resize;
            // 
            // buttonCloseWindow
            // 
            buttonCloseWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCloseWindow.BackColor = Color.FromArgb(33, 34, 44);
            buttonCloseWindow.FlatAppearance.BorderSize = 0;
            buttonCloseWindow.FlatStyle = FlatStyle.Flat;
            buttonCloseWindow.IconChar = FontAwesome.Sharp.IconChar.X;
            buttonCloseWindow.IconColor = Color.White;
            buttonCloseWindow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonCloseWindow.IconSize = 16;
            buttonCloseWindow.Location = new Point(1239, 4);
            buttonCloseWindow.Margin = new Padding(4);
            buttonCloseWindow.Name = "buttonCloseWindow";
            buttonCloseWindow.Size = new Size(50, 25);
            buttonCloseWindow.TabIndex = 0;
            buttonCloseWindow.UseVisualStyleBackColor = false;
            buttonCloseWindow.Click += buttonCloseWindow_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(46, 47, 56);
            panelMenu.Controls.Add(buttonExit);
            panelMenu.Controls.Add(buttonSettings);
            panelMenu.Controls.Add(buttonDashboards);
            panelMenu.Controls.Add(buttonAccount);
            panelMenu.Controls.Add(buttonHome);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 60);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(201, 553);
            panelMenu.TabIndex = 2;
            // 
            // buttonExit
            // 
            buttonExit.Dock = DockStyle.Bottom;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI", 12F);
            buttonExit.ForeColor = Color.White;
            buttonExit.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            buttonExit.IconColor = Color.White;
            buttonExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonExit.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExit.Location = new Point(0, 493);
            buttonExit.Margin = new Padding(3, 2, 3, 2);
            buttonExit.Name = "buttonExit";
            buttonExit.Padding = new Padding(9, 0, 0, 0);
            buttonExit.Size = new Size(201, 60);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Sair";
            buttonExit.TextAlign = ContentAlignment.MiddleLeft;
            buttonExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.Dock = DockStyle.Top;
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Segoe UI", 12F);
            buttonSettings.ForeColor = Color.White;
            buttonSettings.IconChar = FontAwesome.Sharp.IconChar.Gear;
            buttonSettings.IconColor = Color.White;
            buttonSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSettings.Location = new Point(0, 180);
            buttonSettings.Margin = new Padding(3, 2, 3, 2);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Padding = new Padding(9, 0, 0, 0);
            buttonSettings.Size = new Size(201, 60);
            buttonSettings.TabIndex = 4;
            buttonSettings.Text = "Configurações";
            buttonSettings.TextAlign = ContentAlignment.MiddleLeft;
            buttonSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSettings.UseVisualStyleBackColor = true;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonDashboards
            // 
            buttonDashboards.Dock = DockStyle.Top;
            buttonDashboards.FlatAppearance.BorderSize = 0;
            buttonDashboards.FlatStyle = FlatStyle.Flat;
            buttonDashboards.Font = new Font("Segoe UI", 12F);
            buttonDashboards.ForeColor = Color.White;
            buttonDashboards.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            buttonDashboards.IconColor = Color.White;
            buttonDashboards.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonDashboards.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboards.Location = new Point(0, 120);
            buttonDashboards.Margin = new Padding(3, 2, 3, 2);
            buttonDashboards.Name = "buttonDashboards";
            buttonDashboards.Padding = new Padding(9, 0, 0, 0);
            buttonDashboards.Size = new Size(201, 60);
            buttonDashboards.TabIndex = 3;
            buttonDashboards.Text = "Dashboards";
            buttonDashboards.TextAlign = ContentAlignment.MiddleLeft;
            buttonDashboards.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDashboards.UseVisualStyleBackColor = true;
            buttonDashboards.Click += buttonDashboards_Click;
            // 
            // buttonAccount
            // 
            buttonAccount.Dock = DockStyle.Top;
            buttonAccount.FlatAppearance.BorderSize = 0;
            buttonAccount.FlatStyle = FlatStyle.Flat;
            buttonAccount.Font = new Font("Segoe UI", 12F);
            buttonAccount.ForeColor = Color.White;
            buttonAccount.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            buttonAccount.IconColor = Color.White;
            buttonAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonAccount.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAccount.Location = new Point(0, 60);
            buttonAccount.Margin = new Padding(3, 2, 3, 2);
            buttonAccount.Name = "buttonAccount";
            buttonAccount.Padding = new Padding(9, 0, 0, 0);
            buttonAccount.Size = new Size(201, 60);
            buttonAccount.TabIndex = 2;
            buttonAccount.Text = "Conta";
            buttonAccount.TextAlign = ContentAlignment.MiddleLeft;
            buttonAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAccount.UseVisualStyleBackColor = true;
            buttonAccount.Click += buttonAccount_Click;
            // 
            // buttonHome
            // 
            buttonHome.Dock = DockStyle.Top;
            buttonHome.FlatAppearance.BorderSize = 0;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Segoe UI", 12F);
            buttonHome.ForeColor = Color.White;
            buttonHome.IconChar = FontAwesome.Sharp.IconChar.HouseChimney;
            buttonHome.IconColor = Color.White;
            buttonHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(0, 0);
            buttonHome.Margin = new Padding(3, 2, 3, 2);
            buttonHome.Name = "buttonHome";
            buttonHome.Padding = new Padding(9, 0, 0, 0);
            buttonHome.Size = new Size(201, 60);
            buttonHome.TabIndex = 1;
            buttonHome.Text = "Tela incial";
            buttonHome.TextAlign = ContentAlignment.MiddleLeft;
            buttonHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(201, 60);
            panelMain.Margin = new Padding(3, 2, 3, 2);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(0, 0, 0, 8);
            panelMain.Size = new Size(1091, 553);
            panelMain.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1292, 613);
            Controls.Add(panelMain);
            Controls.Add(panelMenu);
            Controls.Add(panelTitleBar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Resize += Form1_Resize;
            panelTitleBar.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton buttonCloseWindow;
        private FontAwesome.Sharp.IconButton buttonMaximizeWindow;
        private FontAwesome.Sharp.IconButton buttonMinimizeWindow;
        private FontAwesome.Sharp.IconButton buttonMenu;
        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton buttonExit;
        private FontAwesome.Sharp.IconButton buttonSettings;
        private FontAwesome.Sharp.IconButton buttonDashboards;
        private FontAwesome.Sharp.IconButton buttonAccount;
        private FontAwesome.Sharp.IconButton buttonHome;
        private Label labelTabName;
        private Panel panelMain;
    }
}
