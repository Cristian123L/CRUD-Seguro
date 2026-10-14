using System;
using System.Security.Cryptography;
using System.Text;
using CrudSeguro.DataBase;
using CrudSeguro.DTOs;

namespace CrudSeguro.Backend
{
    public class AuthService
    {
        private readonly UsuarioDAO _usuarioDAO = new UsuarioDAO();

        public bool IniciarSesion(string usuario, string passwordFrontend)
        {
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(passwordFrontend))
                return false;

            // 1. Encriptar la contraseña recibida con SHA-256 (código de tu compañero)
            string passwordEncriptada = EncriptarSHA256(passwordFrontend);

            // 2. Verificar en Base de Datos
            UsuarioDTO user = _usuarioDAO.Login(usuario.Trim(), passwordEncriptada);

            if (user != null)
            {
                // Guardar datos en sesión para controlar permisos de Administrador/Empleado
                SesionActual.IdUsuario = user.IdUsuario;
                SesionActual.Email = user.Email;
                SesionActual.NombreCompleto = $"{user.Nombre} {user.PrimerApellido}";
                SesionActual.Rol = user.Rol;
                return true;
            }

            return false;
        }

        public static string EncriptarSHA256(string textoPlano)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(textoPlano);
                byte[] hashBytes = sha256.ComputeHash(bytes);

                StringBuilder constructorCadena = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    constructorCadena.Append(hashBytes[i].ToString("x2"));
                }
                return constructorCadena.ToString();
            }
        }
    }
}