using AutoMapper;
using FluentAssertions;
using NUnit.Framework;

namespace Automapper12
{
	[TestFixture]
	internal class MappingTests
	{
		[Test]
		public void UpdateDivisionCommandToDivision()
		{
			// arrange
			var config = new MapperConfiguration(cfg => cfg.AddProfile<DivisionMappings>());
			var mapper = config.CreateMapper();
			var division = new Division
			{
				_Created = DateTimeOffset.Parse("2020-01-05 10:45"),
				DateActive = DateTimeOffset.Parse("2020-01-05 14:05"),
				DivisionId = 1,
				DivisionUid = Guid.Parse("DD1C9725-2741-4CD2-B74F-4786F021EF19").ToString().ToString(),
				DivisionName = "Test Division 1",
				ClientId = "ClientId",
				ClientSecret = "Secret",
				ApiUrl = "https://pb.testdivision.test",
				IdentityServerUrl = "https://is.testdivision.test",
				ConcurrentSessions = 5,
				IsActive = true,
				UserCreated = "NUnit"
			};
			var update = new UpdateDivisionCommand
			{
				DivisionId = 1,
				DivisionName = "New name"
			};

			// act
			var result = mapper.Map(update, division);

			// assert
			result.Should().BeEquivalentTo(new Division
			{
				_Created = DateTimeOffset.Parse("2020-01-05 10:45"),
				DateActive = DateTimeOffset.Parse("2020-01-05 14:05"),
				DivisionId = 1,
				DivisionUid = Guid.Parse("DD1C9725-2741-4CD2-B74F-4786F021EF19").ToString(),
				DivisionName = "New name",
				ClientId = "ClientId",
				ClientSecret = "Secret",
				ApiUrl = "https://pb.testdivision.test",
				IdentityServerUrl = "https://is.testdivision.test",
				ConcurrentSessions = 5,
				IsActive = true,
				UserCreated = "NUnit"
			}, options => options.RespectingRuntimeTypes());
		}
	}
}
