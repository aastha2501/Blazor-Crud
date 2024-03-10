using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD.Server.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { "44db7a33-d170-4c47-bcdc-adb8f1f7c834", "Ethical" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { "55b7a860-9f40-47c4-9cbb-f72b808921c8", "Fiction" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "Title" },
                values: new object[] { new Guid("962f2543-e69f-405f-a639-2e185f07c940"), "Amish Tripathy", "55b7a860-9f40-47c4-9cbb-f72b808921c8", "During a trip Janak, the king of Mithila and his wife Sunaina find a child on the road, being protected by a vulture. They adopt the child and name her Sita, for she was found in a furrow. As an adolescent, Sita is sent to the ashram of Rishi Shvetaketu for her studies. There she learns about martial arts and gains knowledge on different subjects. She also makes friendship with a girl Radhika, and her cousin Hanuman, who was a Vayuputra—the tribe left by the previous Mahadev, Lord Rudra. He is also a Naga whose appearance looks like the head of a monkey placed on a human body.", "Sita the Warrior" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "Title" },
                values: new object[] { new Guid("ed433973-bd89-44a7-9f56-6f4dd4320e22"), "Amish Tripathy", "55b7a860-9f40-47c4-9cbb-f72b808921c8", "The Secret of the Nagas is the second book of Amish Tripathi, second book of Amishverse, and also the second book of Shiva Trilogy. The story takes place in the imaginary land of Meluha and narrates how the inhabitants of that land are saved from their wars by a nomad named Shiva. It begins from where its predecessor, The Immortals of Meluha, left off, with Shiva trying to save Sati from the invading Naga. Later Shiva takes his troop of soldiers and travels far east to the land of Branga, where he wishes to find a clue to reach the Naga people. Shiva also learns that Sati's first child is still alive, as well as her twin sister. His journey ultimately leads him to the Naga capital of Panchavati, where he finds a surprise waiting for him.", "The Secret of the Nagas" });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
