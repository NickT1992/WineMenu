using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WineMenu.Models
{
    public class Pub
    {
        SqlConnection con = new SqlConnection();
        List<Pub> pubList = new List<Pub>();

        public int PubId { get; set; }
        public string PubName { get; set; }

        Pub p = null;

        public List<Pub> GetPubs()
        { 
            //Try without extra \ before SQLEXPRESS     
         con.ConnectionString = "Data Source=NICK_WIN8_PC\\SQLEXPRESS;Initial Catalog=DB_WineMenu;Integrated Security=True";
           
             con.Open();
 
            using (con)
            {               
            SqlCommand cmd = new SqlCommand("Select * from Pub", con);          
            SqlDataReader rd = cmd.ExecuteReader();
               
            while (rd.Read())               
            {                   
                    p = new Pub();
                          
                    p.PubId = Convert.ToInt32(rd.GetInt32(0));
                    p.PubName =Convert.ToString(rd.GetSqlValue(1));    
   
                    pubList.Add(p);              
            }
            }
            return pubList;
        }
    }
}