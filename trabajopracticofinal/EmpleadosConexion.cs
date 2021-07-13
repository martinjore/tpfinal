using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace trabajopracticofinal
{
    class EmpleadosConexion : Empleados
    {
        public string conectaBD()
        {
            
            string cadena;
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=DESKTOP-CC5DDUG;Initial Catalog=EMPLEADOS_DB;Integrated Security=True";
            cadena = "Data Source=DESKTOP-CC5DDUG;Initial Catalog=EMPLEADOS_DB;Integrated Security=True";

            conexion.Open();
            return cadena;
           

        }

      

        public List<Empleados> ListarEmpleados()
        {
            try
            {
                List<Empleados> lista = new List<Empleados>();
                SqlConnection conexion = new SqlConnection();
                SqlCommand comando = new SqlCommand();
                SqlDataReader lector;

                //**recibe la cadena de conexion del metodo ConectarBD    
                conexion.ConnectionString = conectaBD();


                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Id, NombreCompleto, DNI, Edad,Casado,Salario from Empleados ";
                comando.Connection = conexion;
                conexion.Open();

                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Empleados aux = new Empleados();
                    aux.Id = lector.GetInt32(0);
                    aux.Nombrecompleto = lector.GetString(1);
                    aux.Dni = lector.GetString(2);
                    aux.Edad = lector.GetInt32(3);
                    aux.Casado = lector.GetBoolean(4);
                    aux.Salario = lector.GetDecimal(5);

                    lista.Add(aux);
                }
                conexion.Close();

                return lista;
            }
            catch(SqlException ex)
            {
                throw new Exception("Hubo un error con la conexion a la DB. Pruebe en un instante" + ex);
            }

        }

       

        public void agregarempleado(Empleados empleado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            conexion.ConnectionString = conectaBD();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "insert into Empleados values (@NombreCompleto,@DNI,@Edad,@Casado,@Salario)";
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@NombreCompleto", empleado.Nombrecompleto);
            comando.Parameters.AddWithValue("@DNI", empleado.Dni);
            comando.Parameters.AddWithValue("@Edad", empleado.Edad);
            comando.Parameters.AddWithValue("@Casado", empleado.Casado);
            comando.Parameters.AddWithValue("@Salario", empleado.Salario);

            conexion.Open();
            comando.ExecuteNonQuery();

            conexion.Close();
        }
        public List<Empleados> BuscarPorNombre(String nombre)
        {
            try
            {

                List<Empleados> lista = new List<Empleados>();

                SqlConnection conexion = new SqlConnection();
                SqlCommand comando = new SqlCommand();
                SqlDataReader lector;


                conexion.ConnectionString = conectaBD();

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select NombreCompleto, DNI, Edad, Casado, Salario from Empleados WHERE NombreCompleto LIKE '%' + @nombre + '%'";
                comando.Connection = conexion;
                comando.Parameters.AddWithValue("@nombre", nombre);
                conexion.Open();


                lector = comando.ExecuteReader();


                while (lector.Read())
                {
                    Empleados aux = new Empleados();



                    aux.Nombrecompleto = lector.GetString(0);
                    aux.Dni= lector.GetString(1);
                    aux.Edad = lector.GetInt32(2);
                    aux.Casado = lector.GetBoolean(3);
                    aux.Salario = lector.GetDecimal(4);

                    lista.Add(aux);
                }

                conexion.Close();


                return lista;

            }
            catch (SqlException)
            {
                throw new Exception("Error conexion a  la base datos");
            }
            catch (Exception)
            {
                throw new Exception("hubo un error fatal contac admin ");
            }


        }

        public DataTable Buscar()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = conectaBD();
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from empleados where Nombrecompleto like '%{0}%'",Nombrecompleto),conexion);
            SqlDataAdapter ad = new SqlDataAdapter();
            DataSet Da = new DataSet();
            ad.Fill(Da,"Empleados");
            return Da.Tables["Empleados"];

        }
        public void eliminarEmpleado(string nombre)
        {
            try
            {
                

                SqlConnection conexion = new SqlConnection();
                SqlCommand comando = new SqlCommand();




                conexion.ConnectionString = conectaBD();
                comando.CommandType = System.Data.CommandType.Text;

                comando.CommandText = "DELETE FROM Empleados WHERE NombreCompleto = @nombre";
                comando.Connection = conexion;
                comando.Parameters.AddWithValue("@nombre", nombre);


                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }

            catch (SqlException)
            {
                throw new Exception("Error conexion con la base datos");
            }
            catch (Exception)
            {
                throw new Exception("hubo un error fatal contactor con admin ");
            }



        }
        //public void EliminarEmpleado()
        //{
        //    SqlConnection conexion = new SqlConnection();
        //    SqlCommand comando = new SqlCommand();
        //    conexion.ConnectionString = conectaBD();
        //    comando.CommandType = System.Data.CommandType.Text;
        //    SqlDataReader leer;
        //    try
        //    {


        //        comando.Connection = conexion;
        //        conexion.Open();
        //        comando.CommandText = "Delete empleados where Id='" + Codigo + "'";
        //        leer = comando.ExecuteReader();
        //        MessageBox.Show("Datos Eliminados");

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("error" + ex);

        //    }
        //    conexion.Close();

        //}
        //public void ModificarEmpleado(DataGridView data,DataGridViewCellEventArgs e)
        //{

            
        //    Form2 frm_modificar = new Form2();
        //    frm_modificar.txtnombrecomp.Text = data.Rows[e.RowIndex].Cells[1].Value.ToString();
        //    frm_modificar.txtdni.Text = data.Rows[e.RowIndex].Cells[2].Value.ToString();
        //    frm_modificar.txtedad.Text = data.Rows[e.RowIndex].Cells[3].Value.ToString();
        //    frm_modificar.cmbcasado.SelectedItem = Boolean.Parse(data.Rows[e.RowIndex].Cells[4].Value.ToString());
        //    frm_modificar.txtsalario.Text = data.Rows[e.RowIndex].Cells[5].Value.ToString();
        //    frm_modificar.btnreg.Visible = false;
        //    frm_modificar.btnmodificar.Visible = true;
        //    frm_modificar.Show();
        //}
        public void modificarEmpleado(int idEmpleado, string textmodif, string textDniModif, int textPruebaEdad, bool Casado, string textSalarioModif)
        {

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();


            ////Conexion con la DB

            conexion.ConnectionString = conectaBD();
            comando.CommandType = System.Data.CommandType.Text;
            conexion.Open();
            comando.CommandText = "UPDATE Empleados SET NombreCompleto = @txtmodif, DNI = @textDniModif, Edad = @textPruebaEdad, Casado = @Casado, Salario = @textSalarioModif WHERE Id = @idEmpleado";
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@NombreCompleto", textmodif);
            comando.Parameters.AddWithValue("@DNI", textDniModif);
            comando.Parameters.AddWithValue("@Edad", textPruebaEdad);
            comando.Parameters.AddWithValue("@Casado", Casado);
            comando.Parameters.AddWithValue("@Salario", Convert.ToDouble(textSalarioModif));
            comando.Parameters.AddWithValue("@nombre", idEmpleado);


            comando.ExecuteNonQuery();
            conexion.Close();





        }


    }
}

