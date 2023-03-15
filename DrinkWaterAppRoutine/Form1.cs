using System;
using System.Threading;
using System.Windows.Forms;

namespace DrinkWaterAppRoutine
{
    public partial class DrinkWaterAppRoutine : Form
    {

        public DrinkWaterAppRoutine()
        {
            InitializeComponent();
            timer2.Interval = 1800000;
            timer2.Tick += new EventHandler(timer2_Tick);
            // Adiciona um menu de contexto
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Fechar");
            exitMenuItem.Click += ExitMenuItem_Click;
            notifyIcon1.ShowBalloonTip(10000, "Beba Agua", "Hora de dar um gole na água!", ToolTipIcon.Info);
            contextMenu.Items.Add(exitMenuItem);
            notifyIcon1.ContextMenuStrip = contextMenu;

        }

        private void NotificarBalao()
        {
            notifyIcon1.ShowBalloonTip(10000, "Beba Agua", "Hora de dar um gole na água!", ToolTipIcon.Info);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            NotificarBalao();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            // Fecha o aplicativo
            Application.Exit();
        }
    }
}
