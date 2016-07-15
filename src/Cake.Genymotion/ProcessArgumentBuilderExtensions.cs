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

        public static ProcessArgumentBuilder AppendQuotedSecretUnlessNullWhitespaceOrEmpty(this ProcessArgumentBuilder builder, string argument, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return builder;
            }

            return builder.Append(argument).AppendQuotedSecret(value);
        }

        public static ProcessArgumentBuilder AppendQuotedUnlessNullWhitespaceOrEmpty(this ProcessArgumentBuilder builder, string argument, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return builder;
            }

            return builder.Append(argument).AppendQuoted(value);
        }


        public static ProcessArgumentBuilder AppendOnOffIfBooleanHasValue(this ProcessArgumentBuilder builder, string text, bool? boolean)
        {
            if (!boolean.HasValue)
            {
                return builder;
            }

            return builder.Append($"{text} {boolean.Value.ToStringOnOff()}");
        }

        public static ProcessArgumentBuilder AppendQuotedSecretUnlessNullWhitespaceOrEmpty(this ProcessArgumentBuilder builder, string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return builder;
            }

            return builder.AppendQuotedSecret(text);
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