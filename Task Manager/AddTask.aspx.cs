using Mediqura.DAL;
using Mediqura.Utility;
using Mediqura.Utility.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task_Manager
{
    public partial class AddTask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            string title = txt_title.Value;
            string detail = txt_details.Value;
            string summary = txt_summary.Value;
            
            SqlParameter[] arParms = new SqlParameter[3];

            arParms[0] = new SqlParameter("@title", SqlDbType.VarChar);
            arParms[0].Value = title;

            arParms[1] = new SqlParameter("@details", SqlDbType.VarChar);
            arParms[1].Value = detail;

            arParms[2] = new SqlParameter("@summary", SqlDbType.VarChar);
            arParms[2].Value = summary;
            SqlDataReader sqlReader = null;

            sqlReader = SqlHelper.ExecuteReader(GlobalConstant.ConnectionString, CommandType.StoredProcedure, "Add_task", arParms);
            List<int> lstUser = ORHelper<int>.FromDataReaderToList(sqlReader);
            if (lstUser.Count > 0) {
                string msg = "<div class='alert alert-success'>" +
                            "Succesfully Save!" +
                        "</div>";
                msgbox.InnerHtml = msg;
            }
            //string connectionString = ConfigurationManager.ConnectionStrings["SqlConnectionString11"].ConnectionString;
            //string SqlQuery = "INSERT INTO [dbo].[Task] ([Title],[Details]  ,[Summary])VALUES ('"+title+"' ,'"+detail+"','"+summary+"')";
          
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(SqlQuery, connection);
            //   // command.Parameters.AddWithValue("@tPatSName", "Your-Parm-Value");
            //    connection.Open();
            //    SqlDataReader reader = command.ExecuteReader();
            //    try
            //    {
            //        while (reader.Read())
            //        {
            //            Console.WriteLine(String.Format("{0}, {1}",
            //            reader["Task"], reader["Title"]));// etc
            //        }
            //    }
            //    finally
            //    {
            //        // Always call Close when done reading.
            //        reader.Close();
            //    }
           // }
        }

     
    }
}