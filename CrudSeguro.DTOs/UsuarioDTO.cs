using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudSeguro.DTOs
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Telefono { get; set; }
        public string Rol { get; set; } 
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Direccion { get; set; }
        public string CodigoPostal { get; set; }
        public decimal Salario { get; set; }

       
        public string RFC { get; set; }
        public string NSS { get; set; }
        public string ClabeInterbancaria { get; set; }
    }

   
    public static class SesionActual
    {
        public static int IdUsuario { get; set; }
        public static string Email { get; set; }
        public static string NombreCompleto { get; set; }
        public static string Rol { get; set; }

        public static void CerrarSesion()
        {
            IdUsuario = 0;
            Email = null;
            NombreCompleto = null;
            Rol = null;
        }
    }
}
