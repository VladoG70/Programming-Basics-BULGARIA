using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_BGNtoEURConverter_GUI
    {
    public partial class FormConverter : Form
        {
        public FormConverter()
            {
            InitializeComponent();
            }

        private void FormConverter_Load(object sender, EventArgs e)
            {
            ConvertCurrency();
            }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
            {
            ConvertCurrency();
            }

        private void numericUpDownAmount_KeyUp(object sender, KeyEventArgs e)
            {
            ConvertCurrency();
            }

        private void ConvertCurrency()
            {
            var ammountBGN = this.numericUpDownAmount.Value;
            var ammountEUR = ammountBGN * 1.95583m;
            this.labelResult.Text = ammountBGN + " BGN = " + Math.Round(ammountEUR, 2) + " EUR";
            }
        }
    }
