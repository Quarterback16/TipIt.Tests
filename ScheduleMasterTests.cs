using ScheduleService;
using System;
using Xunit;
using Xunit.Abstractions;

namespace TipIt.Tests
{
	public class ScheduleMasterTests : BaseTests
	{
		private readonly ITestOutputHelper _output;

		public ScheduleMasterTests(
			ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void ScheduleMaster_CanLoadJsonScheduleFile_Ok()
		{
			var leagueCode = "EPL";
			var season = 2021;
			var cut = new ScheduleMaster();
			Assert.True(cut.HasSeason(leagueCode, season));
			var nRounds = cut.Rounds(leagueCode, season);
			Assert.Equal(38, nRounds);
			_output.WriteLine(
				$"League:{leagueCode} has {nRounds} rounds in {season}");
			var nGames = cut.Games(leagueCode, season);
			Assert.Equal(380, nGames);
			_output.WriteLine(
				$"League:{leagueCode} has {nGames} games in {season}");
		}

		[Fact]
		public void ScheduleMaster_CanLoadJsonNFLScheduleFile_Ok()
		{
			var leagueCode = "NFL";
			var season = 2021;
			var cut = new ScheduleMaster();
			Assert.True(cut.HasSeason(leagueCode, season));
			var nRounds = cut.Rounds(leagueCode, season);
			Assert.Equal(18, nRounds);
			_output.WriteLine(
				$"League:{leagueCode} has {nRounds} rounds in {season}");
			var nGames = cut.Games(leagueCode, season);
			Assert.Equal(652, nGames);
			_output.WriteLine(
				$"League:{leagueCode} has {nGames} games in {season}");
		}

		[Fact]
		public void ScheduleMaster_CanDescribeRoundToMarkdown_Ok()
		{
			var cut = new ScheduleMaster();
			var leagueCode = "EPL";
			var season = 2021;
			Assert.True(cut.HasSeason(leagueCode, season));
			var result = cut.GetRound(1, leagueCode, season);
			_output.WriteLine(
				result);
		}

		[Fact]
		public void ScheduleMaster_CanReturnRoundData()
		{
			var cut = new ScheduleMaster();
			var leagueCode = "EPL";
			var season = 2021;
			Assert.True(cut.HasSeason(leagueCode, season));
			var result = cut.GetRoundData(1, leagueCode, season);
			Assert.NotNull(
				result);
		}

		[Fact]
		public void ScheduleMaster_CanReturnRoundDataForParticularDay()
		{
			var leagueCode = "EPL";
			var season = 2021;
			var cut = new ScheduleMaster();
			var result = cut.GetGame(
				"Arsenal",
				new DateTime(2021,08,14),
				leagueCode, 
				season);
			Assert.NotNull(
				result.League);
			_output.WriteLine(
				result.ToString());
		}

		[Fact]
		public void ScheduleMaster_ReturnsNullResultIfNothingOnParticularDay()
		{
			var leagueCode = "EPL";
			var season = 2021;
			var cut = new ScheduleMaster();
			var result = cut.GetGame(
				"Arsenal",
				new DateTime(2021, 08, 16),
				leagueCode,
				season);
			Assert.True(
				result.Round == 0);
			_output.WriteLine(
				result.ToString());
		}

		[Fact]
		public void ScheduleMaster_CanReturnRoundScheduleDataForParticularTeam()
		{
			var cut = new ScheduleMaster();
			var result = cut.GetSchedule(
				"Arsenal",
				"EPL",
				2021);
			Assert.NotNull(
				result);
			foreach (var game in result)
			{
				_output.WriteLine(
					game.ToString());
			}
		}

		[Fact]
		public void ScheduleMaster_CanReturnWhichLeaguesItHas()
		{
			var cut = new ScheduleMaster();
			var result = cut.GetLeagues();
			Assert.NotNull(
				result);
			foreach (var l in result)
			{
				_output.WriteLine(
					l.ToString()) ;
			}
		}

		[Fact]
		public void ScheduleMaster_KnowsWhichTeamArsenalPlaysFirst()
		{
			var team = "Arsenal";
			var league = "EPL";
			var season = 2021;
			var round = 1;
			var cut = new ScheduleMaster();
			var result = cut.GetGame(
				team,
				league,
				season,
				round);
			Assert.NotNull(
				result);
			var opponent = result.OpponentOf("Arsenal");
			Assert.True(
				opponent.Equals("Brentford"));
			_output.WriteLine(
				$"{team} plays {opponent} in round {round} of {league} {season}");
		}

		[Fact]
		public void ScheduleMaster_KnowsWhichTeamArsenalPlays()
		{
			var team = "Arsenal";
			var league = "EPL";
			var season = 2021;
			var cut = new ScheduleMaster();
			var result = cut.GetGame(
				team,
				new DateTime(2021,9,12),
				league,
				season);
			Assert.NotNull(
				result);
			var opponent = result.OpponentOf("Arsenal");
			Assert.True(
				opponent.Equals("Norwich"));
			_output.WriteLine(
				$"{result}");
		}

		[Fact]
		public void ScheduleMaster_KnowsWhichTeamJuvePlays()
		{
			var team = "Juventus";
			var league = "S-A";
			var season = 2021;
			var cut = new ScheduleMaster();
			var result = cut.GetGame(
				team,
				new DateTime(2021, 8, 23),
				league,
				season);
			Assert.NotNull(
				result);
			var opponent = result.OpponentOf("Juventus");
			Assert.True(
				opponent.Equals("Udinese"));
			_output.WriteLine(
				$"{result}");
		}

		[Fact]
		public void ScheduleMaster_KnowsWhichTeamNinersPlays()
		{
			var team = "SF";
			var league = "NFL";
			var season = 2021;
			var cut = new ScheduleMaster();
			var result = cut.GetGame(
				team,
				new DateTime(2021, 9, 13),
				league,
				season);
			Assert.NotNull(
				result);
			var opponent = result.OpponentOf("SF");
			Assert.True(
				opponent.Equals("DL"));
			_output.WriteLine(
				$"{result}");
		}
	}
}
