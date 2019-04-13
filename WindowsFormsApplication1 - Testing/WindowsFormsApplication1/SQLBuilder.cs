using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HairBeautyNWRC
{
    class SQLBuilder
    {
        SqlDataAdapter da;
        DataSet dsNWRC_HairBeauty = new DataSet();
        SqlCommandBuilder cmdB;
        DataRow dr;
        String connStr, sqlQuery;
        
        public SQLBuilder()
        {
            da = null;
            dsNWRC_HairBeauty = null;
            cmdB = null;
            dr = null;
            connStr = @"Data Source = .; Initial Catalog = NWRC_HairBeauty; Integrated Security = true";
            sqlQuery = null;
        }

        public SQLBuilder(string location, string query, string tableName)
        {
            if(location == "College")
            {
                connStr = @"Data Source = .; Initial Catalog = NWRC_HairBeauty; Integrated Security = true";
            }
            else
            {
                connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = NWRC_HairBeauty; Integrated Security = true";
            }
            da = new SqlDataAdapter(query, connStr);
            cmdB = new SqlCommandBuilder(da);
            da.FillSchema(dsNWRC_HairBeauty, SchemaType.Source, tableName);
            da.Fill(dsNWRC_HairBeauty, tableName);
        }
    }
}
