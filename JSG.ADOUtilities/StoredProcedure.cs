using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace JSG.ADOUtilities
{
    //dotnet nuget push JSG.ADOUtilities.1.0.0.nupkg -k oy2cojun7wdfmsn4o3tqri4awpxg5kaevpbk6ent3cteom -s https://api.nuget.org/v3/index.json
    public static class StoredProcedure
    {
        public static DataSet ExecuteStoredProcedure(
            ISQLDataConnection sqlDataConnection,
            string storedProcedureName,
            List<SQLParameter> listOfSQLParameter)
        {
            DataSet ds = new DataSet();

            using (SqlConnection con = new SqlConnection(sqlDataConnection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(storedProcedureName, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    foreach (var parameter in listOfSQLParameter)
                    {

                        if (parameter.Value == null)
                        {
                            cmd.Parameters.Add(parameter.ParamaterName, parameter.ParameterType).Value = DBNull.Value;
                            continue;
                        }
                        cmd.Parameters.Add(parameter.ParamaterName, parameter.ParameterType).Value = parameter.Value;
                    }



                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                }
            }
            return ds;

        }
    }
}
