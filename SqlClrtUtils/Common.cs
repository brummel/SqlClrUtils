using System;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;

public partial class UserDefinedFunctions
{
    public static void FillMatches(object Group, out SqlInt32 GroupNumber, out SqlString MatchText)
    {
        RegexMatch rm = (RegexMatch)Group;
        GroupNumber = rm.GroupNumber;
        MatchText = rm.MatchText;
    }

    private class RegexMatch
    {
        public SqlInt32 GroupNumber { get; set; }
        public SqlString MatchText { get; set; }

        public RegexMatch(SqlInt32 group, SqlString match)
        {
            this.GroupNumber = group;
            this.MatchText = match;
        }
    }

    public static void FillValues(object obj, out string value)
    {
        value = obj.ToString();
    }
}
