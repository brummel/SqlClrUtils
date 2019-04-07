using System;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;

public partial class UserDefinedFunctions
{
    [SqlFunction]
    public static SqlString RegexGroupValue(string Input, string Pattern, int GroupNumber)
    {

        Match m = Regex.Match(Input, Pattern);
        SqlString value = m.Success ? m.Groups[GroupNumber].Value : null;

        return value;
    }
}
