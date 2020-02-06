using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ygMerce.Controller
{
    /// <summary>
    /// Summary description for productImgHandler
    /// </summary>
    public class productImgHandler : IHttpHandler
    {
        string strcon = ConfigurationManager.ConnectionStrings["RMSConnectionString"].ToString();
        public void ProcessRequest(HttpContext context)
        {
            string imageid = context.Request.QueryString["ProIMID"];
            SqlConnection connection = new SqlConnection(strcon);
            connection.Open();
            SqlCommand command = new SqlCommand("select Images from product_image1 where MainPic='true' and ProductID='" + imageid + "'", connection);
            SqlDataReader dr = command.ExecuteReader();
            dr.Read();
            context.Response.BinaryWrite((Byte[])dr[0]);
            connection.Close();
            context.Response.End();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}