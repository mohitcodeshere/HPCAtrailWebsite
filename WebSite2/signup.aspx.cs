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

public partial class signup : System.Web.UI.Page
{

    static OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HP\Desktop\new.accdb");
    OleDbDataAdapter ada = new OleDbDataAdapter();
    OleDbCommand cmd = new OleDbCommand();
    //OleDbDataReader dr;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            string command = "insert into Table1 values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "') ";
            OleDbCommand cmd = new OleDbCommand(command, con);
            cmd.ExecuteNonQuery();
            Label1.Text = "Data inserted";
        }
        catch (Exception exp)
        {
        }

        finally
        {
            con.Close();
        }


        //con.Close();

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}

