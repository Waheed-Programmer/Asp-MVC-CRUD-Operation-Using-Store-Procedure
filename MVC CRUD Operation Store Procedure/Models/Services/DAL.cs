using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_CRUD_Operation_Store_Procedure.Models.Services
{
    public class DAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter sd;
        DataTable dt;

        public List<EmployeModel> GetEmloye()
        {
            cmd = new SqlCommand("sp_view", con);
            cmd.CommandType = CommandType.StoredProcedure;
            sd = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sd.Fill(dt);
            List<EmployeModel> list = new List<EmployeModel>();
            foreach(DataRow dr in dt.Rows)
            {
                list.Add(new EmployeModel
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Name = dr["Name"].ToString(),
                    Eamil = dr["Email"].ToString(),
                    Age = Convert.ToInt32(dr["Age"])
                });
               
            }
            return list;
        }
    }
}