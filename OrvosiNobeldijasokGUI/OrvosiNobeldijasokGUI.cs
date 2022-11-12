using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrvosiNobeldijasokGUI
{
    public partial class OrvosiNobeldijasokGUI : Form
    {
        public OrvosiNobeldijasokGUI()
        {
            InitializeComponent();
        }

        private void adatmentbutton_Click(object sender, EventArgs e)
        {

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        
                        MessageBox.Show("Töltsön ki minden mezőt!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {

                        StreamWriter Iro = new StreamWriter("uj_dijazott.txt", false, Encoding.UTF8);
                        Iro.WriteLine($"Év;Név;SzületésHalálozás;OrszágKód\t\n{EvNum.Value};{NevText.Text};{SzHText.Text};{OrszagText.Text}");
                        Iro.Close();
                        EvNum.Refresh();NevText.Clear();SzHText.Clear();OrszagText.Clear();

                    }

                }

            }

        }

        private void NevText_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {

                e.Handled = true;

            }

        }

        private void SzHText_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }

        }

        private void OrszagText_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {

                e.Handled = true;

            }

        }
    }
}
