using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Odbc;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace sWebLoja
{
    public partial class sConsProd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            carregaGrid();
        }

        protected void carregaGrid()
        {

            MySqlConnection myConnectionCorrigeFA01;
            MySqlDataAdapter myDataAdapter;
            DataSet myDataSet;
            string strSQL;

            strSQL = "SELECT codigo as Codigo, Nome as Nome, precounitario as PrecoUnit,quant as Quantidade from produto order by Nome";
            myConnectionCorrigeFA01 = new MySqlConnection("server=172.16.0.32; user id=intranetadmin; password=Intranet@Al34m; database=loja; pooling=false;SslMode = none;");

            myConnectionCorrigeFA01.Open();             
            myDataAdapter = new MySqlDataAdapter(strSQL, myConnectionCorrigeFA01);
                        

            myDataSet = new DataSet();
            myDataAdapter.Fill(myDataSet, "produtos");
            gdItens.DataSource = myDataSet;
            gdItens.DataBind();
            
            myConnectionCorrigeFA01.Close();

        }

    }
}