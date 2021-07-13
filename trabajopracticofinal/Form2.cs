using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace trabajopracticofinal
{
    public partial class Form2 : Form
    {
        public  int idEmpleado ;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            // para hecer esto deberia tener una tabla estado civil jajaj asi no muestro todos los estados de los personajes insertados
            //DataSet Midataset = new DataSet("DS");
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=DESKTOP-CC5DDUG;Initial Catalog=EMPLEADOS_DB;Integrated Security=True";
            //SqlDataAdapter Adaptar = new SqlDataAdapter("select * from Empleados",con);
            //Adaptar.Fill(Midataset,"Empleados");
            //cmbcasado.DataSource = Midataset.Tables[0];
            //cmbcasado.DisplayMember = "Casado";
            //cmbcasado.ValueMember = "ID";
            //cmbcasado.DropDownStyle = ComboBoxStyle.DropDownList;

            //bool soltero = false;
            //bool casado = true;
            //cmbcasado.Items.Add(casado);
            //cmbcasado.Items.Add(soltero);
            //cmbcasado.SelectedIndex = 0;
            //cmbcasado.DropDownStyle = ComboBoxStyle.DropDownList;

            Dictionary<string, Boolean> valores = new Dictionary<string, Boolean>();
            valores.Add("Casado", true);
            valores.Add("Soltero", false);
            cmbcasado.DataSource = new BindingSource(valores, null);
            cmbcasado.DisplayMember = valores.ToString();
            cmbcasado.ValueMember = "Key";

        }


        private void btnreg_Click(object sender, EventArgs e)
        {

            if (txtnombrecomp.Text != "")
            {
                if (txtdni.Text != "")
                {
                    if (txtedad.Text != "")
                    {
                        if (txtsalario.Text != "")
                        {


                            Empleados nuevo = new Empleados();
                            EmpleadosConexion conexion = new EmpleadosConexion();
                            nuevo.Nombrecompleto = txtnombrecomp.Text;
                            nuevo.Dni = txtdni.Text;
                            nuevo.Edad = int.Parse(txtedad.Text);
                            nuevo.Casado = ((KeyValuePair<string, Boolean>)cmbcasado.SelectedItem).Value;
                            nuevo.Salario = decimal.Parse(txtsalario.Text);

                            conexion.agregarempleado(nuevo);


                            Form1 form = new Form1();
                            form.CargarGrilla();
                            MessageBox.Show("El registro fue agregado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            Dispose();

                        }
                        else MessageBox.Show("Ingrese Salario", "Error campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else MessageBox.Show("Ingrese Edad", "Error campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else MessageBox.Show("Ingrese Dni", "Error campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else MessageBox.Show("Ingrese Nombre y Apellido", "Error campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Numerico(e);
        }

        private void txtsalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Salario(e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }



        private void btnmodificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Form1 formulario = new Form1();
                //if (formulario.dgvempleados.SelectedRows.Count > 0) {
                //***Select row the employe to update**//


                Empleados ModificarEmpleado = new Empleados();
                EmpleadosConexion conexion = new EmpleadosConexion();
                //**update employe/**

                //idEmpleado = formulario.dgvempleados.CurrentRow.Cells["Nombrecompleto"].Value.ToString();


                ModificarEmpleado.Nombrecompleto = txtnombrecomp.Text;
                ModificarEmpleado.Dni = txtdni.Text;
                ModificarEmpleado.Edad = Convert.ToInt16(txtedad.Text);
                ModificarEmpleado.Casado = ((KeyValuePair<string, Boolean>)cmbcasado.SelectedItem).Value;
                ModificarEmpleado.Salario = Decimal.Parse(txtsalario.Text);

                conexion.modificarEmpleado(idEmpleado, txtnombrecomp.Text, txtdni.Text, Convert.ToInt16(txtedad.Text), Convert.ToBoolean(cmbcasado.Text), txtsalario.Text);
                MessageBox.Show("modificado", "Datos Actualizos con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // }
                //else 
                //{
                //    MessageBox.Show("Selecciona una fila para modificar");
                //}||
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar" + ex);

            }
            finally
            {
                Form1 formulario = new Form1();
                formulario.CargarGrilla();
            }


        }
    }
} 

