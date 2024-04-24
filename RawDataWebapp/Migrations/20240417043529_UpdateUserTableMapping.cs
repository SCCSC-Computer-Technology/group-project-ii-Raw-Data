using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RawDataWebapp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserTableMapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Baseball",
                columns: table => new
                {
                    PlayerName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GamesPlayed = table.Column<double>(type: "float", nullable: false),
                    AtBats = table.Column<double>(type: "float", nullable: false),
                    Runs = table.Column<double>(type: "float", nullable: false),
                    Hits = table.Column<double>(type: "float", nullable: false),
                    Doubles = table.Column<double>(type: "float", nullable: false),
                    Triples = table.Column<double>(type: "float", nullable: false),
                    HomeRuns = table.Column<double>(type: "float", nullable: false),
                    RunsBattedIn = table.Column<double>(type: "float", nullable: false),
                    TotalBases = table.Column<double>(type: "float", nullable: false),
                    Walks = table.Column<double>(type: "float", nullable: false),
                    Strikeouts = table.Column<double>(type: "float", nullable: false),
                    StolenBases = table.Column<double>(type: "float", nullable: false),
                    BattingAverage = table.Column<double>(type: "float", nullable: false),
                    OnBasePercentage = table.Column<double>(type: "float", nullable: false),
                    SluggingPercentage = table.Column<double>(type: "float", nullable: false),
                    OPS = table.Column<double>(type: "float", nullable: false),
                    WAR = table.Column<double>(type: "float", nullable: false),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baseball", x => x.PlayerName);
                });

            migrationBuilder.CreateTable(
                name: "NBA",
                columns: table => new
                {
                    PlayerName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GamesPlayed = table.Column<double>(type: "float", nullable: true),
                    GamesStarted = table.Column<double>(type: "float", nullable: true),
                    Minutes = table.Column<double>(type: "float", nullable: true),
                    Points = table.Column<double>(type: "float", nullable: true),
                    OffensiveRebounds = table.Column<double>(type: "float", nullable: true),
                    DefensiveRebounds = table.Column<double>(type: "float", nullable: true),
                    TotalRebounds = table.Column<double>(type: "float", nullable: true),
                    Assist = table.Column<double>(type: "float", nullable: true),
                    Steals = table.Column<double>(type: "float", nullable: true),
                    Blocks = table.Column<double>(type: "float", nullable: true),
                    Turnovers = table.Column<double>(type: "float", nullable: true),
                    PersonalFouls = table.Column<double>(type: "float", nullable: true),
                    AssistToTurnovers = table.Column<double>(type: "float", nullable: true),
                    FieldGoalsMade = table.Column<double>(type: "float", nullable: true),
                    FieldGoalsAttempted = table.Column<double>(type: "float", nullable: true),
                    FieldGoalPercentage = table.Column<double>(type: "float", nullable: true),
                    ThreePointsMade = table.Column<double>(type: "float", nullable: true),
                    ThreePointsAttempted = table.Column<double>(type: "float", nullable: true),
                    ThreePointsPercentage = table.Column<double>(type: "float", nullable: true),
                    FreeThrowsMade = table.Column<double>(type: "float", nullable: true),
                    FreeThrowAttempted = table.Column<double>(type: "float", nullable: true),
                    FreeThrowPercentage = table.Column<double>(type: "float", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NBA", x => x.PlayerName);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "WNBA",
                columns: table => new
                {
                    PlayerName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GamesPlayed = table.Column<double>(type: "float", nullable: true),
                    GamesStarted = table.Column<double>(type: "float", nullable: true),
                    Minutes = table.Column<double>(type: "float", nullable: true),
                    Points = table.Column<double>(type: "float", nullable: true),
                    OffensiveRebounds = table.Column<double>(type: "float", nullable: true),
                    DefensiveRebounds = table.Column<double>(type: "float", nullable: true),
                    TotalRebounds = table.Column<double>(type: "float", nullable: true),
                    Assist = table.Column<double>(type: "float", nullable: true),
                    Steals = table.Column<double>(type: "float", nullable: true),
                    Blocks = table.Column<double>(type: "float", nullable: true),
                    Turnovers = table.Column<double>(type: "float", nullable: true),
                    PersonalFouls = table.Column<double>(type: "float", nullable: true),
                    AssistToTurnovers = table.Column<double>(type: "float", nullable: true),
                    FieldGoalsMade = table.Column<double>(type: "float", nullable: true),
                    FieldGoalsAttempted = table.Column<double>(type: "float", nullable: true),
                    FieldGoalPercentage = table.Column<double>(type: "float", nullable: true),
                    ThreePointsMade = table.Column<double>(type: "float", nullable: true),
                    ThreePointsAttempted = table.Column<double>(type: "float", nullable: true),
                    ThreePointsPercentage = table.Column<double>(type: "float", nullable: true),
                    FreeThrowsMade = table.Column<double>(type: "float", nullable: true),
                    FreeThrowAttempted = table.Column<double>(type: "float", nullable: true),
                    FreeThrowPercentage = table.Column<double>(type: "float", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WNBA", x => x.PlayerName);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Baseball");

            migrationBuilder.DropTable(
                name: "NBA");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WNBA");
        }
    }
}
