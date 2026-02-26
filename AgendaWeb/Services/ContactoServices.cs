using AgendaWeb.Data.Commands;
using AgendaWeb.Data.DTOS;
using AgendaWeb.Data.DTOS.Contactos;
using AgendaWeb.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace AgendaWeb.Services
{
    public class ContactoServices
    {
        private readonly ContactoCommand _contactoCommand;

        public ContactoServices(ContactoCommand contactoCommand)
        {
            _contactoCommand = contactoCommand;
        }

        public void Insertar(ContactoNuevoDTO contactoNuevoDTO) 
        {
            Contacto contacto = new Contacto();
            contacto.Nombre = contactoNuevoDTO.Nombre;
            contacto.Telefono = contactoNuevoDTO.Telefono;
            contacto.Email = contactoNuevoDTO.Email;

            int registrosAfectados = _contactoCommand.InsertarContacto(contacto);

            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo guardar el Contacto");
            }

        }
    }
}
