using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VargasM_Taller2.Migrations
{
    /// <inheritdoc />
    public partial class MigracionConJugadores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PartidosPerdidos",
                table: "Jugador");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PartidosPerdidos",
                table: "Jugador",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
