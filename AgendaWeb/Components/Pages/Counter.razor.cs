using AgendaWeb.Data.DTOS.Contactos;
using AgendaWeb.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace AgendaWeb.Components.Pages
{
    public partial class Counter
    {
        //Solo en componentes razor el Inject para inyectar servicios
        [Inject] private ContactoServices ContactoServices { get; set; } = default;
        private int currentCount = 0;

        //private void IncrementCount()
        //{
        //    currentCount++;

        //    string connectionString = "Server=localhost;Database=AgendaDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True";

        //    SqlConnection connection = new SqlConnection(connectionString);

        //    string query = "INSERT into Contactos(Nombre, Telefono, Email) values('Desde VS', '6221194659', 'aylins2323@gmail.com')";

        //    SqlCommand cmd = new SqlCommand(query, connection);

        //    cmd.CommandType= CommandType.Text;

        //    connection.Open();

        //    cmd.ExecuteNonQuery();

        //    connection.Close();

        //    connection.Dispose();
        //}
        private void IncrementCount()
        {
           ContactoNuevoDTO contactoNuevoDTO = new ContactoNuevoDTO 
           {
               Nombre= "Desde vs",
               Telefono= "6221194565",
               Email= "majojo23@gmail.com",
           };

            ContactoServices.Insertar(contactoNuevoDTO);
        }
    }
}
