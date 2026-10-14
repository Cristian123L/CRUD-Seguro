using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using CrudSeguro.DataBase;
using CrudSeguro.DTOs;

namespace CrudSeguro.Backend
{
    public class UsuarioService
    {
        private readonly UsuarioDAO _usuarioDAO = new UsuarioDAO();

        // 1. REGISTRAR CON VALIDACIONES ESTRICTAS
        public string RegistrarUsuario(CrudSeguro.DTOs.UsuarioDTO u)
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(u.Nombre) || string.IsNullOrWhiteSpace(u.PrimerApellido) ||
                string.IsNullOrWhiteSpace(u.SegundoApellido) || string.IsNullOrWhiteSpace(u.Email) ||
                string.IsNullOrWhiteSpace(u.Password) || string.IsNullOrWhiteSpace(u.Telefono) ||
                string.IsNullOrWhiteSpace(u.Rol) || string.IsNullOrWhiteSpace(u.Ciudad) ||
                string.IsNullOrWhiteSpace(u.Estado) || string.IsNullOrWhiteSpace(u.Direccion) ||
                string.IsNullOrWhiteSpace(u.CodigoPostal) || string.IsNullOrWhiteSpace(u.RFC) ||
                string.IsNullOrWhiteSpace(u.NSS) || string.IsNullOrWhiteSpace(u.ClabeInterbancaria))
            {
                return "Todos los campos son obligatorios.";
            }

            // Validar longitudes y tipos de datos (Requisito de la práctica)
            if (!Regex.IsMatch(u.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return "El formato del Email no es válido.";

            if (u.Password.Length < 6)
                return "La contraseña debe tener al menos 6 caracteres.";

            if (!Regex.IsMatch(u.Telefono, @"^\d{10}$"))
                return "El teléfono debe contener exactamente 10 dígitos numéricos.";

            if (!Regex.IsMatch(u.CodigoPostal, @"^\d{5}$"))
                return "El Código Postal debe contener 5 dígitos numéricos.";

            if (u.Salario <= 0)
                return "El salario debe ser mayor a 0.";

            if (u.RFC.Length < 12 || u.RFC.Length > 13)
                return "El RFC debe tener entre 12 y 13 caracteres.";

            if (!Regex.IsMatch(u.NSS, @"^\d{11}$"))
                return "El NSS debe contener exactamente 11 dígitos numéricos.";

            if (!Regex.IsMatch(u.ClabeInterbancaria, @"^\d{18}$"))
                return "La CLABE Interbancaria debe contener exactamente 18 dígitos numéricos.";

            // Encriptar contraseña con el método de tu compañero antes de mandarla a BD
            u.Password = AuthService.EncriptarSHA256(u.Password);

            try
            {
                bool exito = _usuarioDAO.InsertarUsuario(u);
                return exito ? "OK" : "No se pudo registrar el usuario.";
            }
            catch (Exception ex)
            {
                return "Error en BD (verifica si el correo ya existe): " + ex.Message;
            }
        }

        // 2. OBTENER LISTA PARA EL GRID (Oculta encriptados si es Empleado)
        public List<UsuarioDTO> ObtenerUsuariosParaGrid()
        {
            List<UsuarioDTO> lista = _usuarioDAO.ObtenerUsuarios();

            // Regla: El empleado NO podrá ver los datos encriptados
            if (SesionActual.Rol != "Administrador")
            {
                foreach (var u in lista)
                {
                    u.RFC = "******** (Cifrado)";
                    u.NSS = "******** (Cifrado)";
                    u.ClabeInterbancaria = "******** (Cifrado)";
                }
            }

            return lista;
        }

        // 3. ELIMINAR USUARIO (Solo Administrador)
        public bool EliminarUsuario(int idUsuario)
        {
            if (SesionActual.Rol != "Administrador")
                return false;

            return _usuarioDAO.EliminarUsuario(idUsuario);
        }
    }
}