using System;
using System.Linq;

namespace DeviceFingerprint
{
    public static class StringUtils
    {
        public static string FormatLikeGUID(string input, double splitSize)
        {
            int k = 0;
            var output = input.ToLookup(c => Math.Floor(k++ / splitSize))
                .Select(e => new String(e.ToArray())).ToArray();

            return string.Join("-", output);
        }
    }
}
