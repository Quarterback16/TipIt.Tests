using System;

namespace TipIt.Tests
{
    public class BaseTests
    {
        protected dynamic ConvertAflTeam(string teamName)
        {
            if (teamName == "Carlton")
                return "CARL";
            if (teamName == "Essendon")
                return "ESS";
            if (teamName == "Richmond")
                return "RICH";
            if (teamName == "Geelong Cats")
                return "GEEL";
            if (teamName == "Brisbane Lions")
                return "BL";
            if (teamName == "Collingwood")
                return "COLL";
            if (teamName == "West Coast Eagles")
                return "WCE";
            if (teamName == "GWS Giants")
                return "GWS";
            if (teamName == "Western Bulldogs")
                return "WB";
            if (teamName == "Hawthorn")
                return "HAW";
            if (teamName == "Port Adelaide")
                return "PORT";
            if (teamName == "Adelaide Crows")
                return "ADEL";
            if (teamName == "North Melbourne")
                return "NMFC";
            if (teamName == "Fremantle")
                return "FRE";
            if (teamName == "St Kilda")
                return "STK";
            if (teamName == "Sydney Swans")
                return "SYD";
            if (teamName == "Melbourne")
                return "MELB";
            if (teamName == "Gold Coast Suns")
                return "GCFC";
            return teamName;
        }

        protected dynamic ConvertNrlTeam(string teamName)
        {
            if (teamName == "Titans")
                return "TITN";
            if (teamName == "Dragons")
                return "DRAG";
            if (teamName == "Cowboys")
                return "NQLD";
            if (teamName == "Warriors")
                return "NZW";
            if (teamName == "Bulldogs")
                return "BULL";
            if (teamName == "Knights")
                return "NEWC";
            if (teamName == "Panthers")
                return "PENR";
            if (teamName == "Wests Tigers")
                return "WTIG";
            if (teamName == "Broncos")
                return "BRIS";
            if (teamName == "Sharks")
                return "SHRK";
            if (teamName == "Sea Eagles")
                return "MANL";
            if (teamName == "Eels")
                return "PARR";
            if (teamName == "Raiders")
                return "CANB";
            if (teamName == "Rabbitohs")
                return "SSYD";
            if (teamName == "Storm")
                return "MELB";
            if (teamName == "Roosters")
                return "SYDR";
            return teamName;
        }

        protected dynamic ConvertNflTeam(string teamName)
        {
            if (teamName == "San Francisco 49ers")
                return "SF";
            if (teamName == "New Orleans Saints")
                return "NO";
            if (teamName == "Green Bay Packers")
                return "GB";
            if (teamName == "Philadelphia Eagles")
                return "PE";
            if (teamName == "Kansas City Chiefs")
                return "KC";
            if (teamName == "Houston Texans")
                return "HT";
            if (teamName == "Baltimore Ravens")
                return "BR";
            if (teamName == "New England Patriots")
                return "NE";
            if (teamName == "Denver Broncos")
                return "DB";
            if (teamName == "Buffalo Bills")
                return "BB";
            if (teamName == "Tennessee Titans")
                return "TT";
            if (teamName == "Minnesota Vikings")
                return "MV";
            if (teamName == "Las Vegas Raiders")
                return "OR";
            if (teamName == "Seattle Seahawks")
                return "SS";
            if (teamName == "Pittsburgh Steelers")
                return "PS";
            if (teamName == "Dallas Cowboys")
                return "DC";
            if (teamName == "Detroit Lions")
                return "DL";
            if (teamName == "Carolina Panthers")
                return "CP";
            if (teamName == "Los Angeles Rams")
                return "LR";
            if (teamName == "New York Jets")
                return "NJ";
            if (teamName == "Cleveland Browns")
                return "CL";
            if (teamName == "Indianapolis Colts")
                return "IC";
            if (teamName == "Los Angeles Chargers")
                return "LC";
            if (teamName == "New York Giants")
                return "NG"; 
            if (teamName == "Chicago Bears")
                return "CH";
            if (teamName == "Atlanta Falcons")
                return "AF";
            if (teamName == "Miami Dolphins")
                return "MD";
            if (teamName == "Cincinnati Bengals")
                return "CI";
            if (teamName == "Jacksonville Jaguars")
                return "JJ";
            if (teamName == "Washington Redskins")
                return "WR";
            if (teamName == "Tampa Bay Buccaneers")
                return "TB";
            if (teamName == "Arizona Cardinals")
                return "AC";
            return teamName;
        }

        protected string ConvertNflCode(string teamCode)
        {
            if (teamCode == "SF")
                return "San Francisco 49ers";
            if (teamCode == "NO")
                return "New Orleans Saints";
            if (teamCode == "GB")
                return "Green Bay Packers";
            if (teamCode == "PE")
                return "Philadelphia Eagles";
            if (teamCode == "KC")
                return "Kansas City Chiefs";
            if (teamCode == "HT")
                return "Houston Texans";
            if (teamCode == "BR")
                return "Baltimore Ravens";
            if (teamCode == "NE")
                return "New England Patriots";
            if (teamCode == "DB")
                return "Denver Broncos";
            if (teamCode == "BB")
                return "Buffalo Bills";
            if (teamCode == "TT")
                return "Tennessee Titans";
            if (teamCode == "MV")
                return "Minnesota Vikings";
            if (teamCode == "OR")
                return "Las Vegas Raiders";
            if (teamCode == "SS")
                return "Seattle Seahawks";
            if (teamCode == "PS")
                return "Pittsburgh Steelers";
            if (teamCode == "DC")
                return "Dallas Cowboys";
            if (teamCode == "DL")
                return "Detroit Lions";
            if (teamCode == "CP")
                return "Carolina Panthers";
            if (teamCode == "LR")
                return "Los Angeles Rams";
            if (teamCode == "NJ")
                return "New York Jets";
            if (teamCode == "CL")
                return "Cleveland Browns";
            if (teamCode == "IC")
                return "Indianapolis Colts";
            if (teamCode == "LC")
                return "Los Angeles Chargers";
            if (teamCode == "New York Giants")
                return "NG";
            if (teamCode == "CH")
                return "Chicago Bears";
            if (teamCode == "AF")
                return "Atlanta Falcons";
            if (teamCode == "MD")
                return "Miami Dolphins";
            if (teamCode == "CI")
                return "Cincinnati Bengals";
            if (teamCode == "JJ")
                return "Jacksonville Jaguars";
            if (teamCode == "WR")
                return "Washington Redskins";
            if (teamCode == "TB")
                return "Tampa Bay Buccaneers";
            if (teamCode == "AC")
                return "Arizona Cardinals";
            return teamCode;
        }

        protected string ConvertDate(string gameDate)
        {
            var theDate = DateTime.Parse(gameDate);
            return theDate.ToString("yyyy-MM-dd HH:mm");
        }
    }
}
