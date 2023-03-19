using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaseVotaRestaurante.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Atualit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PeopleName",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "RestaurantName",
                table: "Votes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PeopleName",
                table: "Votes",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RestaurantName",
                table: "Votes",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "");
        }
    }
}
