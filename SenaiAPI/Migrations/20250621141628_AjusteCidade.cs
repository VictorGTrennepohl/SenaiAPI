using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenaiAPI.Migrations
{
    /// <inheritdoc />
    public partial class AjusteCidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.AlterColumn<int>(
            //    name: "Cidade",
            //    table: "Endereco",
            //    type: "integer",
            //    maxLength: 60,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "character varying(60)",
            //    oldMaxLength: 60);
            migrationBuilder.Sql(@"
            ALTER TABLE ""Endereco""
            ALTER COLUMN ""Cidade"" TYPE integer
            USING ""Cidade""::integer;");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Endereco",
                type: "character varying(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldMaxLength: 60);
        }
    }
}
