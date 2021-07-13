using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajopracticofinal
{
    public partial class Form1 : Form
    {
        EmpleadosConexion Emp = new EmpleadosConexion();

        private string idEmpleado = null;
        public int RowIndex
        { 
            get;
            private set; 
        }
        
        public Form1()
        {
            InitializeComponent();
        }
      

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("Esta seguro de eliminar empleado?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //***Select row to delete*//
                if (dgvempleados.SelectedRows.Count > 0)
                {
                   
                    //**Delete  employe/**
                    idEmpleado = dgvempleados.CurrentRow.Cells["NombreCompleto"].Value.ToString();

                    Empleados BorrarEmpleado = new Empleados();
                    EmpleadosConexion conexion = new EmpleadosConexion();
                    conexion.eliminarEmpleado(idEmpleado);
                    MessageBox.Show("Eliminado", "Empleado BORRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                else
                {
                    MessageBox.Show("Seleccione una fila");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Algunos de los datos ingresados son del tipo incorrecto", "Error");
                MessageBox.Show(ex.Message, "error");
            }
            finally
            {
                CargarGrilla();
            }

            //Form2 frm_modificar = new Form2();

            //frm_modificar.btneliminar.Visible = true;
            //frm_modificar.btnmodificar.Visible = false;
            //frm_modificar.btnreg.Visible = false;
            //if (dgvempleados.SelectedRows.Count > 0)
            //{
            //    frm_modificar.Show();

            //    frm_modificar.txtnombrecomp.Text = dgvempleados.CurrentRow.Cells["NombreCompleto"].Value.ToString();
            //    frm_modificar.txtdni.Text = dgvempleados.CurrentRow.Cells["DNI"].Value.ToString();
            //    frm_modificar.txtedad.Text = dgvempleados.CurrentRow.Cells["Edad"].Value.ToString();
            //    frm_modificar.cmbcasado.SelectedItem = Convert.ToBoolean(dgvempleados.CurrentRow.Cells["Casado"].Value);

            //    frm_modificar.txtsalario.Text = dgvempleados.CurrentRow.Cells["Salario"].Value.ToString();




            //}
            //else
            //{
            //    MessageBox.Show("seleccione una fila por favor");
            //}
            //Int32 selectedRowCount =
            //  dgvempleados.Rows.GetRowCount(DataGridViewElementStates.Selected);
            //if (selectedRowCount > 0)
            //{
            //    System.Text.StringBuilder sb = new System.Text.StringBuilder();

            //        sb.Append("Row: ");


            //        frm_modificar.txtnombrecomp.Text = dgvempleados.Rows[dgvempleados.NewRowIndex].Cells["NombreCompleto"].Value.ToString();
            //        frm_modificar.txtdni.Text = dgvempleados.Rows[dgvempleados.NewRowIndex].Cells["DNI"].Value.ToString();
            //        frm_modificar.txtedad.Text = dgvempleados.Rows[dgvempleados.NewRowIndex].Cells["Edad"].Value.ToString();
            //        frm_modificar.cmbcasado.SelectedItem = Boolean.Parse(dgvempleados.Rows[dgvempleados.NewRowIndex].Cells["Casado"].Value.ToString());
            //        frm_modificar.txtsalario.Text = dgvempleados.Rows[dgvempleados.NewRowIndex].Cells["Salario"].Value.ToString();
            //        frm_modificar.btnreg.Visible = false;
            //        frm_modificar.btnmodificar.Visible = true;
            //        frm_modificar.Show();

            //        sb.Append(Environment.NewLine);


            //    sb.Append("Total: " + selectedRowCount.ToString());
            //    MessageBox.Show(sb.ToString(), "Selected Rows");
            //}
            //frm_modificar.txtnombrecomp.Text = dgvempleados.Rows[RowIndex].Cells[1].Value.ToString();
            //frm_modificar.txtdni.Text = dgvempleados.Rows[RowIndex].Cells[2].Value.ToString();
            //frm_modificar.txtedad.Text = dgvempleados.Rows[RowIndex].Cells[3].Value.ToString();
            //frm_modificar.cmbcasado.SelectedItem = Boolean.Parse(dgvempleados.Rows[RowIndex].Cells[4].Value.ToString());
            //frm_modificar.txtsalario.Text = dgvempleados.Rows[RowIndex].Cells[5].Value.ToString();
            //frm_modificar.btnreg.Visible = false;
            //frm_modificar.btnmodificar.Visible = true;
            //frm_modificar.Show();
            //Form2 frm_modificar = new Form2();

            //frm_modificar.txtnombrecomp.Text = dgvempleados.Rows[1].Cells["NombreCompleto"].Value.ToString();
            //frm_modificar.txtdni.Text = dgvempleados.Rows[2].Cells["DNI"].Value.ToString();
            //frm_modificar.txtedad.Text = dgvempleados.Rows[3].Cells["Edad"].Value.ToString();
            //frm_modificar.cmbcasado.SelectedItem = Boolean.Parse(dgvempleados.Rows[4].Cells["Casado"].Value.ToString());
            //frm_modificar.txtsalario.Text = dgvempleados.Rows[5].Cells["Salario"].Value.ToString();
            //frm_modificar.btnreg.Visible = false;
            //frm_modificar.btnmodificar.Visible = true;
            //frm_modificar.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 registrar = new Form2();
            registrar.Show();
           
            registrar.btnreg.Visible = true;
            registrar.btneliminar.Visible = false;

            registrar.btnmodificar.Visible = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            EmpleadosConexion conexion = new EmpleadosConexion();
            dgvempleados.DataSource = conexion.ListarEmpleados();
            
            CargarGrilla();
        }
       public void CargarGrilla()
        {
            try
            {
                EmpleadosConexion conexion = new EmpleadosConexion();
                dgvempleados.DataSource = conexion.ListarEmpleados();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtbuscar.Text != "")
            //    {
            //        dgvempleados.DataSource = Emp.Buscar(txtbuscar.Text);
            //    }
            //    else CargarGrilla();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("error de busqueda"+ex);
            //}

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbuscar.Text != "")
                {
                    string nombre;
                    EmpleadosConexion EmpleadoBuscado = new EmpleadosConexion();
                    nombre = txtbuscar.Text;
                    BuscarxNombre(nombre);

                }
                else CargarGrilla();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("error de busqueda" + ex);
                CargarGrilla();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm_modificar = new Form2();

            frm_modificar.btneliminar.Visible = false;
            frm_modificar.btnmodificar.Visible = true;
            frm_modificar.btnreg.Visible = false;
            if (dgvempleados.SelectedRows.Count > 0)
            {
                frm_modificar.Show();

                frm_modificar. txtnombrecomp.Text = dgvempleados.CurrentRow.Cells["NombreCompleto"].Value.ToString();
                frm_modificar.txtdni.Text = dgvempleados.CurrentRow.Cells["DNI"].Value.ToString();
                frm_modificar.txtedad.Text = dgvempleados.CurrentRow.Cells["Edad"].Value.ToString();
                frm_modificar.cmbcasado.Text = dgvempleados.CurrentRow.Cells["Casado"].Value.ToString();
                
                frm_modificar.txtsalario.Text = dgvempleados.CurrentRow.Cells["Salario"].Value.ToString();




            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }
        private void BuscarxNombre(String nombre)
        {
            try
            {
                EmpleadosConexion aux = new EmpleadosConexion();
                dgvempleados.DataSource = aux.BuscarPorNombre(nombre);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgvempleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //EmpleadosConexion ModificarEmpleado = new EmpleadosConexion();
            //ModificarEmpleado.ModificarEmpleado(dgvempleados, e);

        }

        //private void btnmodificar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        if (dgvempleados.SelectedRows.Count > 0)
        //        {
        //            //***Select row the employe to update**//


        //            Empleados ModificarEmpleado = new Empleados();
        //        EmpleadosConexion conexion = new EmpleadosConexion();
        //        //**update employe/**

        //        idEmpleado = dgvempleados.CurrentRow.Cells["Nombrecompleto"].Value.ToString();


        //        ModificarEmpleado.Nombrecompleto = txtnombrecomp.Text;
        //        ModificarEmpleado.Dni = txtdni.Text;
        //        ModificarEmpleado.Edad = Convert.ToInt16(txtedad.Text);
        //        ModificarEmpleado.Casado = Convert.ToBoolean(cmbcasado.Text);

        //        //ModificarEmpleado.Casado = ((KeyValuePair<string, Boolean>)cmbcasado.SelectedItem).Value;
        //        ModificarEmpleado.Salario = Decimal.Parse(txtsalario.Text);

        //        conexion.modificarEmpleado(idEmpleado, txtnombrecomp.Text, txtdni.Text, Convert.ToInt16(txtedad.Text), Convert.ToBoolean(cmbcasado.Text), txtsalario.Text);
        //        MessageBox.Show("modificado", "Datos Actualizos con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //        else
        //    {
        //        MessageBox.Show("Selecciona una fila para modificar");
        //    }
        //}
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al actualizar" + ex);

        //    }
        //    finally
        //    {

        //        CargarGrilla();
        //    }

        //}
    }
}
