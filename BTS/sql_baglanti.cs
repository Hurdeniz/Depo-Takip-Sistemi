using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace BTS
{
    class sql_baglanti
    {

        public SqlConnection baglanti()

        {
            SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");
            bag.Open();
            return bag;





        }
    }
}
