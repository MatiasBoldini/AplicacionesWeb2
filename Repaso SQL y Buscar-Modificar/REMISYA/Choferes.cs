using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Data;

namespace REMISYA
{
    public class Choferes
    {
        SqlConnection conector;
        SqlCommand comando;
        string sql;

        private int  chofer;
        public  int Chofer
        {
            get { return chofer; }
            set { chofer = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public Choferes()
        {
            conector = new SqlConnection("Data Source=.;Initial Catalog=RemisYa;Integrated Security=True");
            comando = new SqlCommand();
            sql = "";
        }

        public void Buscar()
        {
            conector.Open();

            sql = "SELECT * FROM Choferes WHERE chofer=@chofer";

            comando.Connection = conector;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sql;

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@chofer", chofer);

            SqlDataReader dr = comando.ExecuteReader();
            if (dr.HasRows == true)
            {
                dr.Read();
                nombre = dr["nombre"].ToString();
            }
            else
            {
                nombre = "";
            }


            conector.Close();


        }

        public void Modificar()
        {
            conector.Open();

            sql = "UPDATE Choferes SET nombre=@nombre WHERE chofer=@chofer";

            comando.Connection = conector;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sql;

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@chofer", chofer);

            comando.ExecuteNonQuery();

            conector.Close();

        }

        public void agregar()
        {
            conector.Open();

            sql = "INSERT INTO Choferes VALUES(@chofer, @nombre)";

            comando.Connection = conector;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sql;

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@chofer", chofer);
            comando.Parameters.AddWithValue("@nombre", nombre);

            comando.ExecuteNonQuery();

            conector.Close();

        }
    }
}