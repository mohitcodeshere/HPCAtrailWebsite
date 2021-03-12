using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page
{
    static OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\HP\Desktop\new.accdb");
    OleDbDataAdapter ada = new OleDbDataAdapter();
    OleDbCommand cmd = new OleDbCommand();
    OleDbDataReader dr;


    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string str;
        str = "select * from Table1 where username ='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
        con.Open();
        cmd = new OleDbCommand(str, con);
        dr = cmd.ExecuteReader();
        if (dr.Read() == true)
        {
            //Server.Transfer("homepage.aspx");
            Response.Redirect("~/homepage.aspx");
        }

        else
        {
            Label1.Text = "Email Or Password are Invalid, Please try again !";
        }
        con.Close();

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/signup.aspx");
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
