using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace CrudMarlon2.Persistence
{
    class Connection
    {

        string Sql = ConfigurationManager.ConnectionStrings["CrudMarlon2.Properties.Settings.cadastroConnectionString"].ConnectionString;

        public SqlConnection Con;
        public SqlCommand Cmd;
        public SqlDataAdapter Adapt;






        /*Conexão banco*/

        public void OpenCon()
        {
            Con = new SqlConnection(Sql);
            Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandTimeout = 600;
            Con.Open();
        }

        public void OpenConlocal()
        {
            Con = new SqlConnection(Sql);
            Con.Open();
        }

        public void OpenAdpter(string Query)
        {
            Adapt = new SqlDataAdapter(Query, Con);
            Adapt.SelectCommand.CommandTimeout = 600;

        }

        public void CloseCon()
        {
            Con.Close();
        }
    }
}
