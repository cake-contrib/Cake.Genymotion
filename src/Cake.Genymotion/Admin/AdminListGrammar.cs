using System;
using System.Collections.Generic;
using Sprache;

namespace Cake.Genymotion.Admin
{
    internal class AdminListGrammar
    {
        private static readonly Parser<string> NewLine = Parse.String(Environment.NewLine).Text();

        private static readonly Parser<string> Seperator =
            from leading in Parse.WhiteSpace.Many().Optional()
            from seperator in Parse.Char('|').Once()
            from tailing in Parse.WhiteSpace.Many().Optional()
            select string.Concat(seperator);

        // Seperator.Parse("   | ").Dump();
        // Seperator.Parse("   |").Dump();
        // Seperator.Parse("|").Dump();
        // Seperator.Parse("| ").Dump();

        private static readonly Parser<string> TableStart =
            Parse.String("--------+-----------------+------------------------------------+---------------").Text();

        private static readonly Parser<string> TableHeader = Parse.AnyChar.Until(TableStart).Text();

        private static readonly Parser<GenymotionSimulatorState> State =
            from leading in Parse.WhiteSpace.Many().Optional()
            from state in Parse.String("Aborted").Return(GenymotionSimulatorState.Aborted)
                .Or(Parse.String("On").Return(GenymotionSimulatorState.On))
                .Or(Parse.String("Off").Return(GenymotionSimulatorState.Off))
            from tailing in Parse.WhiteSpace.Many().Optional()
            select state;

        // State.Parse("  Off").Dump();
        // State.Parse(" Off").Dump();
        // State.Parse(" Off ").Dump();
        // State.Parse("Off ").Dump();
        // State.Parse("Off  ").Dump();

        private static readonly Parser<string> IpAddress =
            from leading in Parse.WhiteSpace.Many().Optional()
            from a in Parse.Digit.Repeat(1, 3).Text()
            from ignore1 in Parse.Char('.')
            from b in Parse.Digit.Repeat(1, 3).Text()
            from ignore2 in Parse.Char('.')
            from c in Parse.Digit.Repeat(1, 3).Text()
            from ignore3 in Parse.Char('.')
            from d in Parse.Digit.Repeat(1, 3).Text()
            from tailing in Parse.WhiteSpace.Many().Optional()
            select $"{a}.{b}.{c}.{d}";

        // IpAddress.Parse("4.2.2.4").Dump();

        private static readonly Parser<string> UUID =
            from leading in Parse.WhiteSpace.Many().Optional()
            from part1 in Parse.LetterOrDigit.Repeat(8).Text()
            from dash1 in Parse.Char('-')
            from part2 in Parse.LetterOrDigit.Repeat(4).Text()
            from dash2 in Parse.Char('-')
            from part3 in Parse.LetterOrDigit.Repeat(4).Text()
            from dash3 in Parse.Char('-')
            from part4 in Parse.LetterOrDigit.Repeat(4).Text()
            from dash4 in Parse.Char('-')
            from part5 in Parse.LetterOrDigit.Repeat(12).Text()
            from tailing in Parse.WhiteSpace.Many().Optional()
            select $"{part1}-{part2}-{part3}-{part4}-{part5}";

        // Guid.Parse("e111eb03-bc51-4189-a6f4-853a1bece527").Dump();

        private static readonly Parser<string> Name =
            from tailing in Parse.WhiteSpace.Many().Optional()
            from name in Parse.AnyChar.Until(NewLine).Text()
            select name;

        // Name.Parse(" Google Nexus 6 - 6.0.0 - API 23 - 1440x2560\r\n").Dump();

        private static readonly Parser<GenymotionListResult> Simulator =
            from state in State
            from ignore1 in Seperator
            from ipAddress in IpAddress
            from ignore2 in Seperator
            from uuid in UUID
            from ignore3 in Seperator
            from name in Name
            select new GenymotionListResult {State = state, IpAddress = ipAddress, UUID = uuid, Name = name};

        // Simulator.Parse("    Aborted |         0.0.0.0 |cba69bf3-1658-4027-80e7-df5c37a35db5| Google Nexus 6 - 6.0.0 - API 23 - 1440x2560" + Environment.NewLine).Dump();
        // Simulator.Parse("    Off |         1.234.121.100 |cba69bf3-1658-4027-80e7-df5c37a35db5| Google Nexus 6 - 6.0.0 - API 23 - 1440x2560" + Environment.NewLine).Dump();
        // Simulator.Parse("    On |         4.2.2.4 |cba69bf3-1658-4027-80e7-df5c37a35db5| Google Nexus 6 - 6.0.0 - API 23 - 1440x2560" + Environment.NewLine).Dump();


        // Qt: Untested Windows version 10.0 detected!
        //  State  |   IP Address    |                UUID                |      Name
        // --------+-----------------+------------------------------------+---------------
        //     Off |         0.0.0.0 |cba69bf3-1658-4027-80e7-df5c37a35db5| Google Nexus 6 - 6.0.0 - API 23 - 1440x2560
        //     Off |         0.0.0.0 |ec69cd47-6574-48b9-908d-e634b6c1727f| Google Nexus 5 - 5.1.0 - API 22 - 1080x1920
        //     Off |         0.0.0.0 |49b23f0a-f628-4b39-9c5b-f5b9ff628281| Google Nexus 5 - 5.0.0 - API 21 - 1080x1920
        //     Off |         0.0.0.0 |9b22de69-a18e-4c9b-9d38-c4e181314360| Google Nexus 4 - 4.4.4 - API 19 - 768x1280
        //     Off |         0.0.0.0 |e111eb03-bc51-4189-a6f4-853a1bece527| Google Nexus 4 - 4.3 - API 18 - 768x1280
        //     Off |         0.0.0.0 |2e0e5e8b-c5dc-4328-990c-c6f0cc6988d8| Google Nexus 4 - 4.2.2 - API 17 - 768x1280
        //     Off |         0.0.0.0 |bf73467f-3bdc-40b9-8e8f-30f7ba7da740| Google Nexus 4 - 4.1.1 - API 16 - 768x1280

        public static readonly Parser<IEnumerable<GenymotionListResult>> Simulators =
            from tailing in TableHeader
            from newline in Parse.String(Environment.NewLine)
            from simulator in Simulator.Many()
            select simulator;
    }
}