using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetAdoptionProject.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FisrtName",
                table: "Clients",
                newName: "PhoneNumber");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PetType",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Nourishments",
                columns: table => new
                {
                    NourishID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NourishName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nourishments", x => x.NourishID);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    PetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PetType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PetDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.PetID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PetType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnimalID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "Password", "PetType", "PhoneNumber" },
                values: new object[] { "anigilavyan@gmail.com", "Ani", "anianiani", "dog", "2255526852" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "Password", "PetType", "PhoneNumber" },
                values: new object[] { "manushatasunts@gmail.com", "Artyom", "mamamama", "pig", "852565" });

            migrationBuilder.InsertData(
                table: "Nourishments",
                columns: new[] { "NourishID", "Brand", "NourishName", "Price" },
                values: new object[,]
                {
                    { 1, "DogNour", "MommyDoggy", 100 },
                    { 2, "YumDog", "DogSnack", 200 },
                    { 3, "PetYummas", "Yummy", 300 }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetID", "PetDescription", "PetName", "PetType" },
                values: new object[,]
                {
                    { 1, "Healthy", "Rony", "Dog" },
                    { 2, "Healthy", "Boghar", "Dog" },
                    { 3, "Needs medical care", "August", "Dog" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "AnimalID", "Email", "FirstName", "LastName", "Password", "PetName", "PetType", "PhoneNumber", "UserAddress" },
                values: new object[,]
                {
                    { 1, 12, "arminegilavyan04@gmail.com", "Manush", "Atasunts", "Aniartyom", "Lola", "cat", "642574", "Goris" },
                    { 2, 31, "arminegilavya125n04@gmail.com", "Arkadi", "Gilavyan", "lalala", "Boghar", "dog", "7547854", "Goris" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nourishments");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "PetType",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Clients",
                newName: "FisrtName");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 1,
                column: "FisrtName",
                value: "Ani");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 2,
                column: "FisrtName",
                value: "Artyom");
        }
    }
}
