﻿using Object;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class Login : DBConnect
    {

        public int login(string id, string pass)
        {
            int kq = 1;
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(id) from [user] where id = '" + id + "' and password = '" + pass + "'", con);
            kq = (int)cmd.ExecuteScalar();
            con.Close();
            return kq;
        }
        public static List<Items> getData()
        {
            con.Open();
            List<Items> l = new List<Items>();
            SqlCommand cmd = new SqlCommand("select * from sanpham", con);
            SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (rd.Read())
            {
                l.Add(new Items(rd["id"].ToString() , rd["name"].ToString(), rd["img"].ToString()));
            }
            rd.Close();
            return l;
        }
    }
}
