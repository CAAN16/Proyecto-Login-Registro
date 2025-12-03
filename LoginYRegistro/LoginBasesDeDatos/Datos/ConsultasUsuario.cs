using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginBasesDeDatos.Datos
{
    public class ConsultasUsuario
    {
        private readonly string connectionString = "Server=localhost;Database=login;Uid=root;Pwd=12345;";
        private readonly string queryAgregar = @"INSERT INTO usuarios 
        values(null,@nombre,@apellidos,@usuario,sha1(@password),@correo,@telefono,@fecha_nacimiento);";
        private readonly string queryIniciarSesion= "SELECT * FROM usuarios WHERE usuario=@usuario AND password=sha1(@password)";
        private readonly string queryObtenerTodos= @"SELECT * FROM usuarios";

        public bool AgregarUsuario(Usuario u)
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                
                using (MySqlCommand cmd = new MySqlCommand(queryAgregar, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre",u.nombre);
                    cmd.Parameters.AddWithValue("@apellidos", u.apellidos);
                    cmd.Parameters.AddWithValue("@usuario", u.usuario);
                    cmd.Parameters.AddWithValue("@password", u.password);
                    cmd.Parameters.AddWithValue("@correo", u.correo);
                    cmd.Parameters.AddWithValue("@telefono",u.telefono);
                    cmd.Parameters.AddWithValue("@fecha_nacimiento",u.fechaNacimiento.ToString("yyyy-MM-dd"));
                    try
                    {
                        var filas = cmd.ExecuteNonQuery();

                        if (filas > 0) return true;
                        return false;

                        
                    }
                    catch (MySqlException ex)
                    {

                        if (ex.Number == 1062)
                        {
                            MessageBox.Show("El nombre de usuario ya existe. Por favor, elija otro.");
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar el usuario: " + ex.Message);
                        }
                    }
                }
                return false;
            }
        }
        public Usuario IniciarSesion(string usuario, string password)
        {
            Usuario a = new Usuario();
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    MySqlCommand cmd = new MySqlCommand(queryIniciarSesion, conexion);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            
                            while (reader.Read())
                            {
                                a.id = reader.GetInt32("id_usuario");
                                a.nombre = reader.GetString("nombre");
                                a.apellidos = reader.GetString("apellidos");
                                a.usuario = reader.GetString("usuario");
                                a.password = reader.GetString("password");
                                
                                a.fechaNacimiento = reader.GetDateTime("fecha_nacimiento");
                            }
                                return a;
                        }
                        else
                        {
                            return a;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
                return a;


            }
        }

        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            List<Usuario> listaUsuarios= new List<Usuario>();
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();

                using (MySqlCommand cmd = new MySqlCommand(queryObtenerTodos, conexion))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText= queryObtenerTodos;

                    DataTable resultado;
                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    using (DataTable table = new DataTable())
                    {
                        table.Load(lector);
                        resultado = table;

                    }
                    if(resultado.Rows.Count==0) return new List<Usuario>();
                    
                    foreach (DataRow fila in resultado.Rows)
                    {
                        Usuario a = new Usuario();
                        a.id = Convert.ToInt32(fila["id_usuario"]);
                        a.nombre = fila["nombre"].ToString();
                        a.apellidos = fila["apellidos"].ToString();
                        a.usuario = fila["usuario"].ToString();
                        a.correo = fila["correo"].ToString();
                        a.password = fila["password"].ToString();
                        a.telefono = fila["telefono"].ToString();
                        a.fechaNacimiento = Convert.ToDateTime(fila["fecha_nacimiento"]);
                        listaUsuarios.Add(a);
                    }

                    
                }
            }
            return listaUsuarios;


        }
    }
}
