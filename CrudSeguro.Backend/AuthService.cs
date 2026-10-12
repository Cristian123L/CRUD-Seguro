using System;
using System.Security.Cryptography;
using System.Text;

namespace CrudSeguro.Backend
{
    public class AuthService
    {
        // Método principal llamado desde UILogin (Frontend)
        public bool IniciarSesion(string usuario, string passwordFrontend)
        {
            // 1. Encriptar la contraseña recibida con SHA-256
            string passwordEncriptada = EncriptarSHA256(passwordFrontend);

            // 2. Aquí llamaremos al proyecto DataBase para verificar si las credenciales 
            // (usuario y passwordEncriptada) coinciden en la base de datos en AZURE.

            return false; // Por defecto retorna falso hasta completar la conexión
        }

        // Método privado para aplicar la encriptación NO reversible (SHA-256)
        private string EncriptarSHA256(string textoPlano)
        {
            // Se instancia el algoritmo SHA256
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convierte la contraseña ingresada a un arreglo de bytes
                byte[] bytes = Encoding.UTF8.GetBytes(textoPlano);

                // Calcula el hash criptográfico
                byte[] hashBytes = sha256.ComputeHash(bytes);

                // Convierte el arreglo de bytes resultante a una cadena hexadecimal
                StringBuilder constructorCadena = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    // "x2" formatea cada byte como una cadena hexadecimal en minúsculas de dos dígitos
                    constructorCadena.Append(hashBytes[i].ToString("x2"));
                }

                return constructorCadena.ToString();
            }
        }
    }
}