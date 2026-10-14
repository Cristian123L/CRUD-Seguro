using CrudSeguro.DTOs;
using DataBase;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CrudSeguro.DataBase
{
    public class UsuarioDAO
    {
        private const string LlaveAES = "MiLlave2026";

        public UsuarioDTO Login(string email, string passwordEncriptada)
        {
            string query = @"SELECT id_usuario, nombre, primer_apellido, segundo_apellido, email, rol 
                             FROM usuarios 
                             WHERE email = @email AND password = @pass;";

            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pass", passwordEncriptada);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new UsuarioDTO
                        {
                            IdUsuario = reader.GetInt32("id_usuario"),
                            Nombre = reader.GetString("nombre"),
                            PrimerApellido = reader.GetString("primer_apellido"),
                            SegundoApellido = reader.GetString("segundo_apellido"),
                            Email = reader.GetString("email"),
                            Rol = reader.GetString("rol")
                        };
                    }
                }
            }
            return null;
        }

        public bool InsertarUsuario(UsuarioDTO u)
        {
            string query = @"INSERT INTO usuarios (
                                nombre, primer_apellido, segundo_apellido, email, password, 
                                telefono, rol, ciudad, estado, direccion, codigo_postal, salario, 
                                rfc, nss, clabe_interbancaria
                             ) VALUES (
                                @nom, @ape1, @ape2, @email, @pass, 
                                @tel, @rol, @ciudad, @estado, @dir, @cp, @sal, 
                                AES_ENCRYPT(@rfc, @llave), 
                                AES_ENCRYPT(@nss, @llave), 
                                AES_ENCRYPT(@clabe, @llave)
                             );";

            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nom", u.Nombre);
                cmd.Parameters.AddWithValue("@ape1", u.PrimerApellido);
                cmd.Parameters.AddWithValue("@ape2", u.SegundoApellido);
                cmd.Parameters.AddWithValue("@email", u.Email);
                cmd.Parameters.AddWithValue("@pass", u.Password);
                cmd.Parameters.AddWithValue("@tel", u.Telefono);
                cmd.Parameters.AddWithValue("@rol", u.Rol);
                cmd.Parameters.AddWithValue("@ciudad", u.Ciudad);
                cmd.Parameters.AddWithValue("@estado", u.Estado);
                cmd.Parameters.AddWithValue("@dir", u.Direccion);
                cmd.Parameters.AddWithValue("@cp", u.CodigoPostal);
                cmd.Parameters.AddWithValue("@sal", u.Salario);
                cmd.Parameters.AddWithValue("@rfc", u.RFC);
                cmd.Parameters.AddWithValue("@nss", u.NSS);
                cmd.Parameters.AddWithValue("@clabe", u.ClabeInterbancaria);
                cmd.Parameters.AddWithValue("@llave", LlaveAES);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<UsuarioDTO> ObtenerUsuarios()
        {
            List<UsuarioDTO> lista = new List<UsuarioDTO>();
            string query = @"SELECT id_usuario, nombre, primer_apellido, segundo_apellido, email, 
                                    telefono, rol, ciudad, estado, direccion, codigo_postal, salario,
                                    CONVERT(AES_DECRYPT(rfc, @llave) USING utf8mb4) AS rfc_limpio,
                                    CONVERT(AES_DECRYPT(nss, @llave) USING utf8mb4) AS nss_limpio,
                                    CONVERT(AES_DECRYPT(clabe_interbancaria, @llave) USING utf8mb4) AS clabe_limpia
                             FROM usuarios;";

            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@llave", LlaveAES);

                using (MySqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        lista.Add(new UsuarioDTO
                        {
                            IdUsuario = r.GetInt32("id_usuario"),
                            Nombre = r.GetString("nombre"),
                            PrimerApellido = r.GetString("primer_apellido"),
                            SegundoApellido = r.GetString("segundo_apellido"),
                            Email = r.GetString("email"),
                            Telefono = r.GetString("telefono"),
                            Rol = r.GetString("rol"),
                            Ciudad = r.GetString("ciudad"),
                            Estado = r.GetString("estado"),
                            Direccion = r.GetString("direccion"),
                            CodigoPostal = r.GetString("codigo_postal"),
                            Salario = r.GetDecimal("salario"),
                            RFC = r.IsDBNull(r.GetOrdinal("rfc_limpio")) ? "" : r.GetString("rfc_limpio"),
                            NSS = r.IsDBNull(r.GetOrdinal("nss_limpio")) ? "" : r.GetString("nss_limpio"),
                            ClabeInterbancaria = r.IsDBNull(r.GetOrdinal("clabe_limpia")) ? "" : r.GetString("clabe_limpia")
                        });
                    }
                }
            }
            return lista;
        }

        public bool EliminarUsuario(int idUsuario)
        {
            string query = "DELETE FROM usuarios WHERE id_usuario = @id;";
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", idUsuario);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}