﻿using System;
using Xunit;

namespace Cake.Genymotion.Tests
{
	public class GenymotionLicenseTests
	{
		[Theory]
		[InlineData(true, "upgrade \\"Cake\" -v -y")]
		[InlineData(false, "upgrade \\"Cake\" -y")]
		public void Should_Add_Verbose_Flag_To_Arguments_If_Set(bool verbose, string expected)
		{
			// Given
			var fixture = new GenymotionLicenseFixture();
			fixture.Settings.Verbose = verbose;

			// When
			var result = fixture.Run();

			// Then
			Assert.Equal(expected, result.Args);
		}
	}
}
