using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Data.Linq;

namespace IFTP1.DAL
{
    public abstract class AbstractDAL
    {

        SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=IFTC1;Integrated Security=True;");
        SqlTransaction transaction;
        SqlCommand command;

        public DataSet Leer(string query, Hashtable hdata)
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command = new SqlCommand(query, conn, transaction);
                command.CommandType = CommandType.StoredProcedure;

                if (hdata != null)
                {
                    foreach (string param in hdata.Keys)
                    {
                        command.Parameters.AddWithValue(param, hdata[param]);
                    }
                }

                DataSet dataset = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dataset);

                transaction.Commit();
                conn.Close();

                return dataset;

            }
            catch (SqlException e)
            {
                transaction.Rollback();
                conn.Close();
                return null;
            }
            catch (Exception e)
            {
                transaction.Rollback();
                conn.Close();
                return null;
            }
        }

        public bool Escribir(string query, Hashtable hdata)
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command = new SqlCommand(query, conn, transaction);
                command.CommandType = CommandType.StoredProcedure;

                if (hdata != null)
                {
                    foreach(string param in hdata.Keys)
                    {
                        command.Parameters.AddWithValue(param, hdata[param]);
                    }
                }

                int status = command.ExecuteNonQuery();
                transaction.Commit();
                conn.Close();

                return true;
            }
            catch (SqlException e)
            {
                transaction.Rollback();
                conn.Close();
                return false;
            }
            catch (Exception)
            {
                transaction.Rollback();
                conn.Close();
                return false;
            }
        }
    }
}
