using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Scrapping.AllPossibilities.Regex
{
    public static class RegexHelper
    {
        public static List<string> ExtractEmails(string text)
        {
            if (string.IsNullOrEmpty(text)) return null;

            const string matchEmailPattern =
                @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";
            var rx = new System.Text.RegularExpressions.Regex(matchEmailPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            // Find matches.
            var matches = rx.Matches(text);
            // Report the number of matches found.
            return matches.Cast<Match>().Select(x=>x.Value).ToList();

        }
    }
}
