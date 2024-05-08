using BudgetSystem.Tabs;
using System.Runtime.InteropServices;

namespace BudgetSystem
{
    public partial class Form1 : Form
    {

        // Fields 
        private int borderSize = 2;

        // Constructor
        public Form1()
        {
            InitializeComponent();

            // setting border size
            this.Padding = new Padding(borderSize);

            // border color 
            this.BackColor = Color.FromArgb(33, 34, 44);

            this.panelMenu.Width = 0;

            Home home = new Home();
            addUserControl(home);
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0083;
            if (m.Msg == WM_SYSCOMMAND && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }


        // events methods 
        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }


        // private methods
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;

                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;

            }
        }


        // Função para alterar entre as abas
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl);
            userControl.BringToFront();
        }

        // Configuração dos botões

        // Botão X para fechar aplicação
        private void buttonCloseWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Botão para maximizazr aplicação
        private void buttonMaximizeWindow_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }


        // Botão para minimizar aplicação
        private void buttonMinimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        // Configuração do botão do menu
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            if (this.panelMenu.Width > 200)
            {
                this.panelMenu.Width = 0;
                this.buttonMenu.Width = 75;
                this.buttonMenu.ImageAlign = ContentAlignment.MiddleCenter;
                this.buttonMenu.Text = "";
                this.buttonMenu.BackColor = Color.FromArgb(33, 34, 44);
                this.buttonMenu.Padding = new Padding(0, 0, 0, 0);

            }
            else if (this.panelMenu.Width == 0)
            {
                this.panelMenu.Width = 230;
                this.buttonMenu.Width = 230;
                this.buttonMenu.ImageAlign = ContentAlignment.MiddleLeft;
                this.buttonMenu.Text = "Menu";
                this.buttonMenu.BackColor = Color.FromArgb(46, 47, 56);
                this.buttonMenu.Padding = new Padding(10, 0, 0, 0);
                this.labelTabName.Padding = new Padding(10, 0, 0, 0);
            }
        }


        // Botão de sair do menu
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Botão para voltar a tela inicial
        private void buttonHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            addUserControl(home);
            this.labelTabName.Text = "Tela Inicial";
        }


        // Botão para gerenciar a conta
        private void buttonAccount_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            addUserControl(account);
            this.labelTabName.Text = "Conta";
        }


        // Botão para acessar dashboards
        private void buttonDashboards_Click(object sender, EventArgs e)
        {
            Dashboards dashboards = new Dashboards();
            addUserControl(dashboards);
            this.labelTabName.Text = "Dashboards";
        }


        // Botão acessar as configurações
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            addUserControl(settings);
            this.labelTabName.Text = "Configurações";
        }



    }
}
