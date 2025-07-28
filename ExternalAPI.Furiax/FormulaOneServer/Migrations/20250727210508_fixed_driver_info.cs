using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormulaOneServer.Migrations
{
    /// <inheritdoc />
    public partial class fixed_driver_info : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Country", "DriverImageLink", "DriverName", "DriverNumber", "Helmet", "NumberOfGPs" },
                values: new object[] { "Japan", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2025Drivers/tsunoda", "Yuki Tsunoda", 22, "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/tsunoda", 91 });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 14,
                column: "DriverImageLink",
                value: "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2025Drivers/doohan");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Country", "DriverImageLink", "DriverName", "DriverNumber", "Helmet", "NumberOfGPs" },
                values: new object[] { "New Zealand", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2025Drivers/lawson", "Liam Lawson", 30, "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/lawson", 15 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Country", "DriverImageLink", "DriverName", "DriverNumber", "Helmet", "NumberOfGPs" },
                values: new object[] { "New Zealand", "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2025Drivers/lawson", "Liam Lawson", 30, "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/lawson", 15 });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 14,
                column: "DriverImageLink",
                value: "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/fom-website/drivers/2025Drivers/doohan");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Country", "DriverImageLink", "DriverName", "DriverNumber", "Helmet", "NumberOfGPs" },
                values: new object[] { "Japan", "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2025Drivers/tsunoda", "Yuki Tsunoda", 22, "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/tsunoda", 91 });
        }
    }
}
