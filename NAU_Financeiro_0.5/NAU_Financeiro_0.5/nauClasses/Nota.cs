using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace NAU_Financeiro_0._5.nauClasses
{
    internal class Nota
    {
        string tabela = "TabelaNotas";
        
        // Getter and Setter properties
        // Acts as Data Carrier

        // Prop
        public int Id { get; set; }

        public SqlDateTime Data { get; set; }

        public string Razao { get; set; }

        public string Setor { get; set; }

        public string Valor { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["NAU_Financeiro_0._5.Properties.Settings.NAU_FinanceiroConnectionString"].ConnectionString;


        //SElecting Data from Database
        public DataTable Select()
        {
            ///Step 1: Database Connection
            SqlConnection sqlConnection = new SqlConnection(myconnstrng);
            DataTable dataString = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string sql = "SELECT * FROM TabelaNotas";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                sqlConnection.Open();
                adapter.Fill(dataString);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sqlConnection.Close();
            }
            return dataString;
        }

        
        //Inserting DAta into Database
        public bool Insert(Nota nota)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;
            //STep 1: Connect DAtabase
            if (!(nota.Razao == "" || nota.Setor == ""))
            {
                SqlConnection sqlConnection = new SqlConnection(myconnstrng);
                try
                {

                    //STep 2: Create a SQL Query to insert Data
                    string sql = String.Format("INSERT INTO TabelaNotas (data, razao, setor, valor) VALUES (@data, @razao, @setor, @valor)");

                    //Creating SQL Command using sql and conn
                    SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                    

                    //Create Parameters to add data
                    cmd.Parameters.AddWithValue("@data", nota.Data);
                    cmd.Parameters.AddWithValue("@razao", nota.Razao);
                    cmd.Parameters.AddWithValue("@setor", nota.Setor);
                    cmd.Parameters.AddWithValue("@valor", nota.Valor);
                    

                    //Connection Open Here
                    sqlConnection.Open();
                    int rows = cmd.ExecuteNonQuery();
                    //If the query runs successfully then the value of rows will be greater than zero else its value will be 0
                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                    else
                    {
                        isSuccess = false;
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            return isSuccess;
        }


        //Method to update data in database from our application
        public bool Update(Nota nota)
        {
            //Create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection sqlConnection = new SqlConnection(myconnstrng);
            try
            {
                //SQL to update data in our Database
                string sql = "UPDATE TabelaNotas SET data=@data, razao=@razao, setor=@setor, valor=@valor WHERE id=@id";

                //Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                //Create Parameters to add value
                cmd.Parameters.AddWithValue("@data", nota.Data);
                cmd.Parameters.AddWithValue("@razao", nota.Razao);
                cmd.Parameters.AddWithValue("@setor", nota.Setor);
                cmd.Parameters.AddWithValue("@valor", nota.Valor);
                cmd.Parameters.AddWithValue("@id", nota.Id);
                //Open DAtabase Connection
                sqlConnection.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs sucessfully then the value of rows will be greater than zero else its value will be zero
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sqlConnection.Close();
            }
            return isSuccess;
        }

        //Method to Delete Data from DAtabase
        public bool Delete(Nota nota)
        {
            //Create a default return value and set its value to false
            bool isSuccess = false;
            //Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL To Delte DAta
                string sql = "DELETE FROM TabelaNotas WHERE id=@id";

                //Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", nota.Id);
                //Open Connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query run sucessfully then the value of rows is greater than zero else its value is 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //Close Connection
                conn.Close();
            }
            return isSuccess;
        }


        // Search method
        public Nota Search(int id)
        {
            Nota nota = new Nota();
            //Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL To Delte DAta
                string sql = "SELECT data, razao, setor, valor FROM TabelaNotas WHERE id=@id";

                //Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                //Open Connection
                conn.Open();

                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                // Call Read before accessing data.
                while (sqlDataReader.Read())
                {
                    nota.Id = id;
                    ReadSingleRow((IDataRecord)sqlDataReader, nota);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //Close Connection
                conn.Close();
            }
            return nota;
        }
        private static void ReadSingleRow(IDataRecord dataRecord, Nota nota)
        {
            nota.Data = ((DateTime) dataRecord[0]);
            nota.Razao = ((string) dataRecord[1]);
            nota.Setor = ((string) dataRecord[2]);
            
            nota.Valor = (Convert.ToString(dataRecord[3]));

        }

        public static float ToSingle(double value)
        {
            return (float)value;
        }
    }
}
