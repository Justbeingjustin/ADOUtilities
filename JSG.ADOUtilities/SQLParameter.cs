using System.Data;

namespace JSG.ADOUtilities
{
    public class SQLParameter
    {
        public string ParamaterName { get; set; }
        public SqlDbType ParameterType { get; set; }
        public string Value { get; set; }
    }
}
