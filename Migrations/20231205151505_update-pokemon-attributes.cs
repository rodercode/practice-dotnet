using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pokeapi.Migrations
{
    /// <inheritdoc />
    public partial class updatepokemonattributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokeTypePokemon_Pokemons_PokemonId",
                table: "PokeTypePokemon");

            migrationBuilder.DropForeignKey(
                name: "FK_PokeTypePokemon_Types_TypeId",
                table: "PokeTypePokemon");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "PokeTypePokemon",
                newName: "TypesId");

            migrationBuilder.RenameColumn(
                name: "PokemonId",
                table: "PokeTypePokemon",
                newName: "PokemonsId");

            migrationBuilder.RenameIndex(
                name: "IX_PokeTypePokemon_TypeId",
                table: "PokeTypePokemon",
                newName: "IX_PokeTypePokemon_TypesId");

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "Pokemons",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "Pokemons",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddForeignKey(
                name: "FK_PokeTypePokemon_Pokemons_PokemonsId",
                table: "PokeTypePokemon",
                column: "PokemonsId",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokeTypePokemon_Types_TypesId",
                table: "PokeTypePokemon",
                column: "TypesId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokeTypePokemon_Pokemons_PokemonsId",
                table: "PokeTypePokemon");

            migrationBuilder.DropForeignKey(
                name: "FK_PokeTypePokemon_Types_TypesId",
                table: "PokeTypePokemon");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Pokemons");

            migrationBuilder.RenameColumn(
                name: "TypesId",
                table: "PokeTypePokemon",
                newName: "TypeId");

            migrationBuilder.RenameColumn(
                name: "PokemonsId",
                table: "PokeTypePokemon",
                newName: "PokemonId");

            migrationBuilder.RenameIndex(
                name: "IX_PokeTypePokemon_TypesId",
                table: "PokeTypePokemon",
                newName: "IX_PokeTypePokemon_TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PokeTypePokemon_Pokemons_PokemonId",
                table: "PokeTypePokemon",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokeTypePokemon_Types_TypeId",
                table: "PokeTypePokemon",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
