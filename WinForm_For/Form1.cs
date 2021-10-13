using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtx.Text = Properties.Settings.Default.x.ToString();
            txty.Text = Properties.Settings.Default.y.ToString();
        }
        public class Logic
        {
            public static int Res(int x, int y)
            {
                int proiz = 0;
                for (int i = 1; i <= y; i++)
                {
                    proiz += x;
                }
                return proiz;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y;
            try
            {
                x = int.Parse(this.txtx.Text);
                txtx.BackColor = Color.White;
            }
            catch (FormatException)
            {
                txtx.BackColor = Color.Red;
                MessageBox.Show("Введено некоректное значение", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                y = int.Parse(this.txty.Text);
                txty.BackColor = Color.White;
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено некоректное значение", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txty.BackColor = Color.Red;
                return;
            }

            Properties.Settings.Default.x = x;
            Properties.Settings.Default.y = y;
            Properties.Settings.Default.Save();

            MessageBox.Show("Произведение равно = " + Logic.Res(x, y));
        }
    }
}
