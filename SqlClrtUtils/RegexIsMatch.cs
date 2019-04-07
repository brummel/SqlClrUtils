using System;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;

public partial class UserDefinedFunctions
{
    [SqlFunction]
    public static SqlBoolean RegexIsMatch(string Input, string Pattern)
    {
        return Regex.Match(Input, Pattern).Success ? new SqlBoolean(true) : new SqlBoolean(false);
    }
}
