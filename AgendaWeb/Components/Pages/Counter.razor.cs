using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace AgendaWeb.Components.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;

            string connectionString = "Server=localhost;Database=AgendaDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True";

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT into Contactos(Nombre, Telefono, Email) values('Desde VS', '6221194659', 'aylins2323@gmail.com')";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.CommandType= CommandType.Text;

            connection.Open();

            cmd.ExecuteNonQuery();

            connection.Close();

            connection.Dispose();
        }
    }
}
