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
        
    }
}
