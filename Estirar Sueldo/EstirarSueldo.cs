using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Estirar_Sueldo
{
    public class EstirarSueldo
    {
        //Data Source = (localdb)\server;Initial Catalog = C; Integrated Security = True

        public List<Deuda> Deudas = new List<Deuda>();
        public List<Extracción> Extracciones = new List<Extracción>();
        public List<Ingreso> Ingresos = new List<Ingreso>();
        public List<Deuda> Pagos = new List<Deuda>();
        SqlConnectionStringBuilder stringBuilder;

        public EstirarSueldo()
        {
            try
            {
                stringBuilder = new SqlConnectionStringBuilder
                {
                    DataSource = "(localdb)\\server",
                    InitialCatalog = "Prueba",
                    IntegratedSecurity = true,
                };
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        #region Cargar Datos
        public object CargarDeudas()
        {
            string query = "Select * from Deuda";
            List<object> list = new List<object>();
            using (SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Deuda(reader.GetString(1),reader.GetDecimal(2),reader.GetDateTime(3),reader.GetString(4)));
                }
            }
            return list;
        }

        public object CargarSueldos()
        {
            string query = "Select * from Sueldo";
            List<object> list = new List<object>();
            using (SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (!reader.IsDBNull(3))
                    {
                        list.Add(new { Fecha = reader.GetDateTime(1), Monto = reader.GetDecimal(2), Mes = reader.GetString(3), Motivo = "" });
                    }
                    else
                    {
                        list.Add(new { Fecha = reader.GetDateTime(1), Monto = reader.GetDecimal(2), Mes = "", Motivo = reader.GetString(4) });
                    }
                }
            }
            return list;
        }

        public object CargarPagos()
        {
            string query = "select * from Pago p inner join Deuda d on d.ID_Deuda=p.ID_Deuda";
            List<object> list = new List<object>();
            using (SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new { Descripción = reader.GetString(6) ,Monto = reader.GetDecimal(2), FechadeVencimiento = reader.GetDateTime(8),FechadePago = reader.GetDateTime(3), Comentarios = reader.GetString(4)});
                }
            }
            return list;
        }

        public object CargarExtracciones()
        {
            string query = "Select * from Extracción";
            List<object> list = new List<object>();
            using (SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new { Fecha = reader.GetDateTime(1), Monto = reader.GetDecimal(2), Comentarios = reader.GetString(3) });
                }
            }
            return list;
        }
        #endregion

        #region Insertar Movimientos

        private void CargarDatos(string query)
        {
            using (SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void IngresarSueldo(Sueldo nuevoSueldo)
        {
            string fecha = $"{nuevoSueldo.Fecha.Year}-{nuevoSueldo.Fecha.Month}-{nuevoSueldo.Fecha.Day}";
            string query = "Insert into Sueldo (Fecha, Monto, Mes) values ('" + fecha + "'," + nuevoSueldo.Monto + ",'" + nuevoSueldo.Mes + "')";
            CargarDatos(query);
        }
        #endregion
    }
}
