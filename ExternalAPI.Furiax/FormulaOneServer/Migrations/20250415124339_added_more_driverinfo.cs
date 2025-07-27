using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormulaOneServer.Migrations
{
    /// <inheritdoc />
    public partial class added_more_driverinfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Drivers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Helmet",
                table: "Drivers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfGPs",
                table: "Drivers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorldChampionships",
                table: "Drivers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Country", "DriverImageLink", "Helmet", "NumberOfGPs", "WorldChampionships" },
                values: new object[] { "Netherlands", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2025Drivers/verstappen", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/verstappen", 213, 4 });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Country", "Helmet", "NumberOfGPs", "WorldChampionships" },
                values: new object[] { "New Zealand", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/lawson", 15, 0 });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Country", "DriverImageLink", "Helmet", "NumberOfGPs", "WorldChampionships" },
                values: new object[] { "Monaco", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2025Drivers/leclerc", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/leclerc", 151, 0 });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Country", "Helmet", "NumberOfGPs", "WorldChampionships" },
                values: new object[] { "United Kingdom", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/hamilton", 360, 7 });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Country", "DriverImageLink", "Helmet", "NumberOfGPs", "WorldChampionships" },
                values: new object[] { "Australia", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2025Drivers/piastri", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/piastri", 50, 0 });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Country", "DriverImageLink", "Helmet", "NumberOfGPs", "WorldChampionships" },
                values: new object[] { "United Kingdom", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2025Drivers/norris", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/norris", 132, 0 });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Country", "DriverImageLink", "Helmet", "NumberOfGPs", "WorldChampionships" },
                values: new object[] { "United Kingdom", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2025Drivers/russell", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/russell", 132, 0 });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Country", "Helmet", "NumberOfGPs", "WorldChampionships" },
                values: new object[] { "Italy", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/antonelli", 4, 0 });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Country", "DriverImageLink", "Helmet", "NumberOfGPs", "WorldChampionships" },
                values: new object[] { "Canada", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2025Drivers/stroll", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/stroll", 170, 0 });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Country", "DriverImageLink", "Helmet", "NumberOfGPs", "WorldChampionships" },
                values: new object[] { "Spain", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2025Drivers/alonso", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/alonso", 407, 2 });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Country", "DriverImageLink", "Helmet", "NumberOfGPs", "WorldChampionships" },
                values: new object[] { "Thailand", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2025Drivers/albon", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/albon", 108, 0 });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Country", "Helmet", "NumberOfGPs", "WorldChampionships" },
                values: new object[] { "Spain", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/sainz", 210, 0 });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Country", "DriverImageLink", "Helmet", "NumberOfGPs", "WorldChampionships" },
                values: new object[] { "France", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2025Drivers/gasly", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/gasly", 157, 0 });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Country", "DriverImageLink", "Helmet", "NumberOfGPs", "WorldChampionships" },
                values: new object[] { "Australia", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/fom-website/drivers/2025Drivers/doohan", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/doohan", 5, 0 });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Country", "Helmet", "NumberOfGPs", "WorldChampionships" },
                values: new object[] { "France", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/ocon", 160, 0 });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Country", "DriverImageLink", "Helmet", "NumberOfGPs", "WorldChampionships" },
                values: new object[] { "United Kingdom", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2025Drivers/bearman", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/bearman", 7, 0 });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Country", "Helmet", "NumberOfGPs", "WorldChampionships" },
                values: new object[] { "Germany", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/hulkenberg", 231, 0 });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Country", "Helmet", "NumberOfGPs", "WorldChampionships" },
                values: new object[] { "Brazil", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/bortoleto", 4, 0 });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Country", "Helmet", "NumberOfGPs", "WorldChampionships" },
                values: new object[] { "France", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/hadjar", 4, 0 });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Country", "DriverImageLink", "Helmet", "NumberOfGPs", "WorldChampionships" },
                values: new object[] { "Japan", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2025Drivers/tsunoda", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/tsunoda", 91, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Helmet",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "NumberOfGPs",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "WorldChampionships",
                table: "Drivers");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DriverImageLink",
                value: "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/verstappen");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DriverImageLink",
                value: "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/leclerc");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DriverImageLink",
                value: "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/piastri");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DriverImageLink",
                value: "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/norris");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DriverImageLink",
                value: "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/russell");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DriverImageLink",
                value: "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2024Drivers/stroll");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DriverImageLink",
                value: "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/alonso");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DriverImageLink",
                value: "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/albon");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 13,
                column: "DriverImageLink",
                value: "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/gasly");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 14,
                column: "DriverImageLink",
                value: "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/fom-website/drivers/2024Drivers/doohan");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 16,
                column: "DriverImageLink",
                value: "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2024Drivers/bearman");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 20,
                column: "DriverImageLink",
                value: "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/tsunoda");
        }
    }
}
