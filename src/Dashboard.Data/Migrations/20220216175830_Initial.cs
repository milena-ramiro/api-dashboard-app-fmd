using Microsoft.EntityFrameworkCore.Migrations;

namespace Dashboard.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Theme = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Whatsapp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "Description", "Theme", "Title" },
                values: new object[,]
                {
                    { 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "primary", "Frontend" },
                    { 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "danger", "Backend" },
                    { 3, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "warning", "Design" },
                    { 4, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "secondary", "Comercial" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Discord", "Email", "Gender", "Name", "TeamId", "Whatsapp" },
                values: new object[,]
                {
                    { 1, "https://www.google.com.br", "https://www.google.com.br", "male", "Renan - Zica", 1, "https://www.google.com.br" },
                    { 2, "https://www.google.com.br", "https://www.google.com.br", "male", "Vitão", 1, "https://www.google.com.br" },
                    { 3, "https://www.google.com.br", "https://www.google.com.br", "female", "Camila", 1, "https://www.google.com.br" },
                    { 4, "https://www.google.com.br", "https://www.google.com.br", "male", "Barba", 1, "https://www.google.com.br" },
                    { 5, "https://www.google.com.br", "https://www.google.com.br", "female", "Milena", 2, "https://www.google.com.br" },
                    { 6, "https://www.google.com.br", "https://www.google.com.br", "male", "Irineu", 2, "https://www.google.com.br" },
                    { 7, "https://www.google.com.br", "https://www.google.com.br", "male", "Renatox", 3, "https://www.google.com.br" },
                    { 8, "https://www.google.com.br", "https://www.google.com.br", "female", "Raelle", 3, "https://www.google.com.br" },
                    { 9, "https://www.google.com.br", "https://www.google.com.br", "male", "Aaron Roger", 4, "https://www.google.com.br" },
                    { 10, "https://www.google.com.br", "https://www.google.com.br", "female", "Lisa Simpson", 4, "https://www.google.com.br" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_TeamId",
                table: "Employee",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
