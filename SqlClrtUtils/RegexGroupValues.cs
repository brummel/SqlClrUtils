using System;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;

public partial class UserDefinedFunctions
{
    [SqlFunction(DataAccess = DataAccessKind.Read, FillRowMethodName = "FillMatches", TableDefinition = "GroupNumber INT, MatchText NVARCHAR(4000)")]
    public static IEnumerable RegexGroupValues(string Input, string Pattern)
    {
        List<RegexMatch> GroupCollection = new List<RegexMatch>();

        Match m = Regex.Match(Input, Pattern);
        if (m.Success)
        {
            for (int i = 0; i < m.Groups.Count; i++)
            {
                GroupCollection.Add(new RegexMatch(i, m.Groups[i].Value));
            }
        }

        return GroupCollection;
    }
}
