using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_CatchTheButton
    {
    public partial class FormCatch : Form
        {
        public FormCatch()
            {
            InitializeComponent();
            }

        private void buttonCatchMe_MouseEnter(object sender, EventArgs e)
            {
            Random rand = new Random();
            var maxWidth = this.ClientSize.Width - buttonCatchMe.ClientSize.Width;
            var maxHeight = this.ClientSize.Height - buttonCatchMe.ClientSize.Height;
            this.buttonCatchMe.Location = new Point(
                rand.Next(maxWidth), rand.Next(maxHeight));
            }

        private void buttonCatchMe_Click(object sender, EventArgs e)
        {
            ButtonCatched();
        }

        private void ButtonCatched()
        {
            this.labelResult.Text = "Congratulations! You win!";
        }
        }
    }
