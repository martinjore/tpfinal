using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajopracticofinal
{
    class validar
    {
        public static void Numerico(KeyPressEventArgs v)
        {
            if (char.IsDigit(v.KeyChar))
            {
                v.Handled = false;

            }
            else if (char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Ingrese Edad", "Error dato no numerico", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public static void Salario(KeyPressEventArgs v)
        {
            if (char.IsDigit(v.KeyChar))
            {
                v.Handled = false;

            }
            else if (char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (v.KeyChar.ToString().Equals("."))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Ingrese Salario", "Error, no es un dato numerico", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
