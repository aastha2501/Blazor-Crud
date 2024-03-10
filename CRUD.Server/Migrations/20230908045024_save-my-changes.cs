using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD.Server.Migrations
{
    public partial class savemychanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("10b11b92-1305-4882-9703-f6545725c2cf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3e3ff311-3cff-457f-a8a8-2cc2df894aad"));

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "Title" },
                values: new object[] { new Guid("17bf4474-e75d-422d-b747-152f7f45465a"), "Amish Tripathy", "55b7a860-9f40-47c4-9cbb-f72b808921c8", "The Secret of the Nagas is the second book of Amish Tripathi, second book of Amishverse, and also the second book of Shiva Trilogy. The story takes place in the imaginary land of Meluha and narrates how the inhabitants of that land are saved from their wars by a nomad named Shiva. It begins from where its predecessor, The Immortals of Meluha, left off, with Shiva trying to save Sati from the invading Naga. Later Shiva takes his troop of soldiers and travels far east to the land of Branga, where he wishes to find a clue to reach the Naga people. Shiva also learns that Sati's first child is still alive, as well as her twin sister. His journey ultimately leads him to the Naga capital of Panchavati, where he finds a surprise waiting for him.", "The Secret of the Nagas" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "Title" },
                values: new object[] { new Guid("3bdfeaba-c35d-4ee9-8ec7-04aa0b6a0fd3"), "Amish Tripathy", "55b7a860-9f40-47c4-9cbb-f72b808921c8", "During a trip Janak, the king of Mithila and his wife Sunaina find a child on the road, being protected by a vulture. They adopt the child and name her Sita, for she was found in a furrow. As an adolescent, Sita is sent to the ashram of Rishi Shvetaketu for her studies. There she learns about martial arts and gains knowledge on different subjects. She also makes friendship with a girl Radhika, and her cousin Hanuman, who was a Vayuputra—the tribe left by the previous Mahadev, Lord Rudra. He is also a Naga whose appearance looks like the head of a monkey placed on a human body.", "Sita the Warrior" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("17bf4474-e75d-422d-b747-152f7f45465a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3bdfeaba-c35d-4ee9-8ec7-04aa0b6a0fd3"));

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "Title" },
                values: new object[] { new Guid("10b11b92-1305-4882-9703-f6545725c2cf"), "Amish Tripathy", "55b7a860-9f40-47c4-9cbb-f72b808921c8", "During a trip Janak, the king of Mithila and his wife Sunaina find a child on the road, being protected by a vulture. They adopt the child and name her Sita, for she was found in a furrow. As an adolescent, Sita is sent to the ashram of Rishi Shvetaketu for her studies. There she learns about martial arts and gains knowledge on different subjects. She also makes friendship with a girl Radhika, and her cousin Hanuman, who was a Vayuputra—the tribe left by the previous Mahadev, Lord Rudra. He is also a Naga whose appearance looks like the head of a monkey placed on a human body.", "Sita the Warrior" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "Title" },
                values: new object[] { new Guid("3e3ff311-3cff-457f-a8a8-2cc2df894aad"), "Amish Tripathy", "55b7a860-9f40-47c4-9cbb-f72b808921c8", "The Secret of the Nagas is the second book of Amish Tripathi, second book of Amishverse, and also the second book of Shiva Trilogy. The story takes place in the imaginary land of Meluha and narrates how the inhabitants of that land are saved from their wars by a nomad named Shiva. It begins from where its predecessor, The Immortals of Meluha, left off, with Shiva trying to save Sati from the invading Naga. Later Shiva takes his troop of soldiers and travels far east to the land of Branga, where he wishes to find a clue to reach the Naga people. Shiva also learns that Sati's first child is still alive, as well as her twin sister. His journey ultimately leads him to the Naga capital of Panchavati, where he finds a surprise waiting for him.", "The Secret of the Nagas" });
        }
    }
}
