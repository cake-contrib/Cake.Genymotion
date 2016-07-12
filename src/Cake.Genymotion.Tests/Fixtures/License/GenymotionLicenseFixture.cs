using System;
using Cake.Genymotion;

namespace Cake.Genymotion.Tests
{
	internal sealed class GenymotionLicenseFixture : GenymotionFixture<GenymotionSettings>
	{
		protected override void RunTool()
		{
			var tool = new GenymotionTool(FileSystem, Environment, ProcessRunner, Tools);
			tool.Build(Project, Settings);
		}
	}
}