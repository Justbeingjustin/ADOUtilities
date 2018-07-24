namespace JSG.ADOUtilities
{
    public static class Extensions
    {
        public static string GetConnectionString(this ISQLDataConnection sqlDataConnection)
        {

            if (sqlDataConnection.IsSQLServerAuthentication)
            {
                return "Data Source=" + sqlDataConnection.Server + ";Initial Catalog=" + sqlDataConnection.Database + ";User ID=" + sqlDataConnection.userName + ";Password=" + sqlDataConnection.password + ";";
            }
            return "Data Source=" + sqlDataConnection.Server + ";Initial Catalog=" + sqlDataConnection.Database + ";Integrated Security=True";
        }
    }
}
