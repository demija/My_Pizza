using System.Data.Entity.Core;
using System.Data.SqlClient;

namespace MyPizza_API.Util
{
    public class ExceptionHandler
    {
        public static string HandleException(EntityException ex)
        {
            SqlException error = ex.InnerException as SqlException;

            switch (error.Number)
            {
                case 2627: return GetConstraintExceptioMessage(error);
            }

            return error.Message + "(" + error.Number + ")";
        }

        private static string GetConstraintExceptioMessage(SqlException error)
        {
            string msg = error.Message;

            int pocetak = msg.IndexOf("'");
            int kraj = msg.IndexOf("'", pocetak + 1);

            if (pocetak > 0 && kraj > 0)
            {
                string nazivOgranicenja = msg.Substring(pocetak + 1, kraj - pocetak - 1);

                msg = nazivOgranicenja;
            }

            return msg;
        }
    }
}