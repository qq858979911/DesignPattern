﻿using System;

namespace DesignPattern.SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlHelper sqlHelper = new SqlHelper();
            //string insertSql = "insert into [Users](Name,Age) values('ww',13);";
            //int res = sqlHelper.ExecuteNonQuery(insertSql);
            //Console.WriteLine($"插入{res}记录");

            string selectSql = "select count(*) from [Users];";
            object count = sqlHelper.ExecuteScalar(selectSql);
            Console.WriteLine($"共有{count}记录");
        }
    }
}
