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
    }
}
