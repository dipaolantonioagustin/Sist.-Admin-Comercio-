using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Conexion
    {
        private SqlConnection conec = new SqlConnection(@"Data Source=DESKTOP-9JLD1SA\SQLEXPRESS;Initial Catalog=Parcial1LUG;Integrated Security=True");

     



        public DataSet Lectura(string consulta)
        {
            DataSet resultado = new DataSet();
            try
            {
                SqlDataAdapter busqueda = new SqlDataAdapter(consulta, conec);

                busqueda.Fill(resultado);


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.conec.Close();
            }


            return resultado;
        }


       
        public bool LecturaEscalar(string consulta)
        {
            conec.Open();

            SqlCommand busqueda = new SqlCommand(consulta, conec);
            busqueda.CommandType = CommandType.Text;
            try
            {
                int resultado = Convert.ToInt32(busqueda.ExecuteScalar());

                if (resultado != 0) return true;
                else return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conec.Close();
            }

        }

        public bool Escribir(string consulta)
        {
            conec.Open();
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = consulta;
                comando.Connection = conec;

                int resultado = comando.ExecuteNonQuery();
                if (resultado > 0) return true;
                else return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conec.Close();
            }




        }


        public bool Transaccion(string consulta1, string consulta2)
        {

            conec.Open();

            SqlTransaction transaccion;

            SqlCommand comando;

            transaccion = conec.BeginTransaction();

            try
            {
                comando = new SqlCommand(consulta1, conec);

                comando.Transaction = transaccion;

                comando.ExecuteNonQuery();


                comando = new SqlCommand(consulta2, conec);

                comando.Transaction = transaccion;

                comando.ExecuteNonQuery();



                transaccion.Commit();

                return true;

            }
            catch (SqlException ex)
            {
                transaccion.Rollback();
                return false;

            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                return false;

            }
            finally
            {
                conec.Close();
            }

        }



    }
}
