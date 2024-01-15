using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEntrega
{
    public class Usuario
    {
        // Atributos
        private long id;
        private string nombre;
        private string apellido;
        private string nombreUsuario;
        private string contrasenia;
        private string mail;

        // Getters and Setters
        public long Id 
        { 
            get
            { 
                return this.id; 
            } 
            set 
            {
                this.id = value; 
            } 
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set 
            {
                this.nombre = value; 
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public string NombreUsuario
        {
            get
            {
                return this.nombreUsuario;
            }
            set
            {
                this.nombreUsuario = value;
            }
        }

        public string Contrasenia
        {
            get
            { 
                return this.contrasenia;
            }
            set 
            {
                this.contrasenia = value; 
            }
        }

        public string Mail
        {
            get
            {
                return this.mail;
            }
            set
            {
                this.mail = value;
            }
        }

        // Constructores
        public Usuario()
        {

        }

        public Usuario(long id, string nombre, string apellido, string nombreUsuario, string contrasenia, string mail)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreUsuario = nombreUsuario;
            this.contrasenia = contrasenia;
            this.mail = mail;
        }




    }
}
