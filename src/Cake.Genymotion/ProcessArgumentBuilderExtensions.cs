using Cake.Core;
using Cake.Core.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake.Genymotion
{
    internal static class ProcessArgumentBuilderExtensions
    {
        public static ProcessArgumentBuilder AppendQuotedUnlessNullWhitespaceOrEmpty(this ProcessArgumentBuilder builder, string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return builder;
            }

            return builder.AppendQuoted(text);
        }

        public static ProcessArgumentBuilder AppendUnlessNullWhitespaceOrEmpty(this ProcessArgumentBuilder builder, string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return builder;
            }

            return builder.Append(text);
        }
    }
}