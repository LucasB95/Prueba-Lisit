using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Lisit.Models
{
    public class Usuario
    {
        [Key] //para q tome lo q esta abajo como llave
        public int ID { get; set; }

        [Required]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public int Edad { get; set; }
        public int DNI { get; set; }

       



        public Usuario(string nom, string apellido, string mail, int edad, int DNI)
        {
            Nombre = nom;
            Apellido = apellido;
            Mail = mail;
            Edad = edad;
            this.DNI = DNI;
        }
        public Usuario()
        {

        }
    }
}
