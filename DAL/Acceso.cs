using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;


namespace DAL
{
    public class Acceso
    {

        private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionSQL"].ToString());

        public DataSet Leer(string consulta)
        {
            DataSet dataSet = new DataSet();
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta, conexion);
                dataAdapter.Fill(dataSet);
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
                conexion.Close();
            }
            return dataSet;

        }

        public bool Escribir(string consultaSQL)
        {
            conexion.Open();
            SqlTransaction transaction;
            transaction = conexion.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = conexion;
            command.CommandText = consultaSQL;
            command.Transaction = transaction;
            try
            {
                int respuesta = command.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (SqlException ex)
            {
                transaction.Rollback();
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { conexion.Close(); }
        }


        public bool LeerScalar(string consulta)
        {
            conexion.Open();

            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.CommandType = CommandType.Text;
            try
            {
                int Respuesta = Convert.ToInt32(cmd.ExecuteScalar());
                conexion.Close();
                if (Respuesta > 0)
                { return true; }
                else
                { return false; }
            }
            catch (SqlException ex)
            { throw ex; }
        }

        public int RetornarScalar(string consulta)
        {
            conexion.Open();

            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.CommandType = CommandType.Text;
            try
            {
                int Respuesta = Convert.ToInt32(cmd.ExecuteScalar());
                conexion.Close();
                return Respuesta;
            }
            catch (SqlException ex)
            { throw ex; }
        }
    }
}
