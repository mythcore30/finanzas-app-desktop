using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanzasApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //lblDiaActual.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dgvMovimientos.Rows.Add("1", "3000", "Pago Efectivo", "SUPERAVIT", "22-02-24");
            dgvMovimientos.Rows.Add("1", "3000", "Pago Efectivo", "SUPERAVIT", "22-02-24");
            dgvMovimientos.Rows.Add("1", "3000", "Pago Efectivo", "SUPERAVIT", "22-02-24");
            dgvMovimientos.Rows.Add("1", "3000", "Pago Efectivo", "SUPERAVIT", "22-02-24");
            dgvMovimientos.Rows.Add("1", "3000", "Pago Efectivo", "SUPERAVIT", "22-02-24");   
        }

        private void pnlDashboard_MouseHover(object sender, EventArgs e)
        {
            pnlDashboard.BackColor = Color.White;
            pnlDashboard.Cursor = Cursors.Hand;
        }

        private void pnlDashboard_MouseLeave(object sender, EventArgs e)
        {
            pnlDashboard.BackColor = Color.FromArgb(222, 226, 230);
            pnlDashboard.ForeColor = SystemColors.ControlText;
        }

        private void pnlReportes_MouseHover(object sender, EventArgs e)
        {
            pnlReportes.BackColor = Color.White;
            pnlReportes.Cursor = Cursors.Hand;
        }

        private void pnlReportes_MouseLeave(object sender, EventArgs e)
        {
            pnlReportes.BackColor = Color.FromArgb(222, 226, 230);
            pnlReportes.ForeColor = SystemColors.ControlText;
        }

        private void pnlBalance_MouseHover(object sender, EventArgs e)
        {
            pnlBalance.BackColor = Color.White;
            pnlBalance.Cursor = Cursors.Hand;
        }

        private void pnlBalance_MouseLeave(object sender, EventArgs e)
        {
            pnlBalance.BackColor = Color.FromArgb(222, 226, 230);
            pnlBalance.ForeColor = SystemColors.ControlText;
        }

        private void pnlReportes_Click(object sender, EventArgs e)
        {
            FormReportes formReportes = new FormReportes();
            formReportes.ShowDialog();
        }

        private void pnlBalance_Click(object sender, EventArgs e)
        {
            FormBalance formBalance = new FormBalance();
            formBalance.ShowDialog();
        }

        private void btnNuevoMovimiento_Click(object sender, EventArgs e)
        {
            FormMovimientos formMovimientos = new FormMovimientos();
            formMovimientos.ShowDialog();
        }
    }
}
