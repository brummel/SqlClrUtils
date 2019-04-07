using System;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;

public partial class UserDefinedFunctions
{
    [SqlFunction(DataAccess = DataAccessKind.Read, FillRowMethodName = "FillValues", TableDefinition = "Value NVARCHAR(4000)")]
    public static IEnumerable RegexSplit(string Input, string Pattern)
    {
        return Regex.Split(Input, Pattern);
    }
}
