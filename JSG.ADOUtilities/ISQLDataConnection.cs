namespace JSG.ADOUtilities
{
    public interface ISQLDataConnection
    {
        bool IsSQLServerAuthentication { get; set; }
        string Server { get; set; }
        string Database { get; set; }
        string userName { get; set; }
        string password { get; set; }
    }
}
