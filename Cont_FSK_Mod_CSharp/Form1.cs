using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cont_FSK_Mod_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            double[] sin = Generate.Sin(51);

            fskPlot.Plot.Axes.SetLimitsX(0, 50);
            fskPlot.Plot.Axes.SetLimitsY(-1.5, 1.5);

            fskPlot.Plot.Add.Signal(sin);
            fskPlot.Refresh();
        }
    }
}
