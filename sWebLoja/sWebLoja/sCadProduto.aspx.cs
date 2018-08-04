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
    
    public partial class sCadProduto : System.Web.UI.Page
    {
        
        
        protected void Page_Load(object sender, EventArgs e)
        {            
            txtCodigo.Focus();

        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {

            txtCodigo.Text = "";
            txtCodigo.Enabled = true;
            TxtNome.Text = "";
            TxtNome.Text = "";
            TxtPreco.Text = "";
            TxtQuant.Text = "";
            txtCodigo.Focus();

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {            
            string strSQL;

            if (txtCodigo.Text != "") {

                if (TxtNome.Text == "" )
                {
                    lblAviso.Text = "Nome Produto não informado!!";
                    lblAviso.Visible = true;
                    return; 
                }

                if (TxtPreco.Text == "")
                {
                    lblAviso.Text = "Preço Produto não informado!!";
                    lblAviso.Visible = true;
                    return;
                }

                if (TxtQuant.Text == "")
                {
                    lblAviso.Text = "Quantidade Produto não informado!!";
                    lblAviso.Visible = true;
                    return;
                }
                
                MySqlConnection myConnectionCorrigeFA01;                                 
                MySqlCommand myCommand;                
                MySqlDataReader dsX;

                string sdataInicial = DateTime.Now.ToString();
                sdataInicial = sdataInicial.Substring(1,9);

                myConnectionCorrigeFA01 = new MySqlConnection("server=172.16.0.32; user id=intranetadmin; password=Intranet@Al34m; database=loja; pooling=false;SslMode = none;");
                strSQL = "SELECT * from produto where codigo =  '" +  txtCodigo.Text + "'";

                myConnectionCorrigeFA01.Open();

                 // Pega os valores das data definidas dentro da tabela padrão
                 myCommand = new MySqlCommand(strSQL, myConnectionCorrigeFA01);
                dsX = myCommand.ExecuteReader();  
                
                // Se existir, alterar              
                if (dsX.Read())
                {

                    MySqlCommand myCommand2;                   
                    MySqlConnection myConnectionCorrigeFA08;
                    myConnectionCorrigeFA08 = new MySqlConnection("server=172.16.0.32; user id=intranetadmin; password=Intranet@Al34m; database=loja; pooling=false;SslMode = none;");                    
                     
                    strSQL = "UPDATE produto SET Nome = '" +  TxtNome.Text.ToUpper()  + "', precounitario = " + TxtPreco.Text  + ", dataprod = '" + sdataInicial + "', quant = " + TxtQuant.Text  +  " where codigo = '" +  txtCodigo.Text + "'";
                    

                    try
                    {
                        myConnectionCorrigeFA08.Open();


                        myCommand2 = new MySqlCommand(strSQL, myConnectionCorrigeFA08);
                        myCommand2.ExecuteNonQuery();
                        
                         
                        
                    }
                    catch (Exception ex)
                    {
                        lblAviso.Text = "Erro de Alteração de Dados!!";
                        lblAviso.Visible = true;
                        return;

                    }

                    myConnectionCorrigeFA08.Close();
                    lblAviso.Text = "Alteração realizada com Sucesso!!";
                    lblAviso.Visible = true;
                    return;


                }
                // Se não existir, inserir
                else
                {

                    MySqlConnection myConnectionCorrigeFA09;
                    myConnectionCorrigeFA09 = new MySqlConnection("server=172.16.0.32; user id=intranetadmin; password=Intranet@Al34m; database=loja; pooling=false;SslMode = none;");
                    


                    try
                    {

                        MySqlCommand myCommand3;

                        myConnectionCorrigeFA09.Open();

                        strSQL = "call sp_ins(" + txtCodigo.Text + ",'" + TxtNome.Text.ToUpper() + "'," + TxtPreco.Text + ",'" + sdataInicial + "'," + TxtQuant.Text + ");";
                        myCommand3 = new MySqlCommand(strSQL, myConnectionCorrigeFA09);
                        myCommand3.ExecuteReader();
                                                
                    }

                    catch (Exception ex)
                    {
                        lblAviso.Text = "Erro de Inserção de Dados!!";
                        lblAviso.Visible = true;
                        return;

                    }

                    myConnectionCorrigeFA09.Close();
                    lblAviso.Text = "Inserção realizada com Sucesso!!";
                    lblAviso.Visible = true;
                    return;


                }



                dsX.Close();
                myConnectionCorrigeFA01.Close();
            }


        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtCodigo.Enabled  = true;
            TxtNome.Text = "";
            TxtPreco.Text = "";
            TxtQuant.Text = "";
            lblAviso.Visible = false;
            txtCodigo.Focus();

        }

        protected void btnMenu_Click(object sender, EventArgs e)
        {
            string strSQL;

            if (txtCodigo.Text != "")
            {

                //MySqlConnection myConnectionCorrigeFA02;
                //myConnectionCorrigeFA02 = new MySqlConnection("server=172.16.0.32; user id=intranetadmin; password=Intranet@Al34m; database=loja; pooling=false;");
                MySqlCommand myCommand4;
                MySqlDataReader dsT;
                MySqlConnection myConnectionCorrigeFA03;

                myConnectionCorrigeFA03 = new MySqlConnection("server=172.16.0.32; user id=intranetadmin; password=Intranet@Al34m; database=loja; pooling=false;SslMode = none;");

                myConnectionCorrigeFA03.Open();

                strSQL = "DELETE FROM produto where codigo = '" + txtCodigo.Text + "'";
                
                try
                {
                    myCommand4 = new MySqlCommand(strSQL, myConnectionCorrigeFA03);
                    dsT = myCommand4.ExecuteReader();

                }
                catch
                {
                    lblAviso.Text = "Erro de Exclusão de Dados!!";
                    lblAviso.Visible = true;
                    return;

                }

                myConnectionCorrigeFA03.Close();
            }

        }

        protected void bntPesquisar_Click(object sender, ImageClickEventArgs e)
        {

            string strSQL;

            if (txtCodigo.Text  != "")
            {

                MySqlConnection myConnectionCorrigeFA07;
                MySqlCommand myCommand5;
                MySqlDataReader dsQ;
                string sdataInicial = DateTime.Now.ToString();
                sdataInicial = sdataInicial.Substring(1, 10);

                myConnectionCorrigeFA07 = new MySqlConnection("server=172.16.0.32; user id=intranetadmin; password=Intranet@Al34m; database=loja; pooling=false;SslMode = none;");
                strSQL = "SELECT * from produto where codigo =  '" + txtCodigo.Text + "'";

                myConnectionCorrigeFA07.Open();


                // Pega os valores das data definidas dentro da tabela padrão
                myCommand5 = new MySqlCommand(strSQL, myConnectionCorrigeFA07);
                dsQ = myCommand5.ExecuteReader();

                // Se existir, alterar              
                if (dsQ.Read())
                {
                    TxtNome.Text = dsQ[1].ToString(); 
                    TxtPreco.Text = dsQ[2].ToString();
                    TxtQuant.Text = dsQ[4].ToString();


                }

                dsQ.Close();
                myConnectionCorrigeFA07.Close();


            }

        }

    }
}