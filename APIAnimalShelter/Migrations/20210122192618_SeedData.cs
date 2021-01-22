using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIAnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "Age", "Breed", "Coloring", "DateAvailable", "Name", "Personality", "Sex" },
                values: new object[,]
                {
                    { 1, 3, "DSH", "Tuxedo", new DateTime(2021, 1, 22, 11, 26, 17, 714, DateTimeKind.Local).AddTicks(6710), "Boots", "Boots is very curious. He plays well with cats and dogs but does not do well around children.", "Male" },
                    { 2, 0, "Bombay", "Black", new DateTime(2021, 1, 22, 11, 26, 17, 744, DateTimeKind.Local).AddTicks(3640), "Snowball", "Snowball is 6 months old and ready for a playmate. She is very funny and acrobatic.", "Female" },
                    { 3, 12, "Persian", "Grey", new DateTime(2021, 1, 22, 11, 26, 17, 744, DateTimeKind.Local).AddTicks(3660), "Agatha", "Agatha is a senior cat looking for her furrever lap. She loves snuggles and head pets", "Female" },
                    { 4, 4, "Siamese/DSH", "Flame Point", new DateTime(2021, 1, 22, 11, 26, 17, 744, DateTimeKind.Local).AddTicks(3670), "Robert", "Robert loves playing tag but can get a little rowdy in his play. Might not do well around children.", "Male" },
                    { 5, 7, "Scottish Fold", "Silver", new DateTime(2021, 1, 22, 11, 26, 17, 744, DateTimeKind.Local).AddTicks(3670), "Squish", "Squish is the best. You all are crazy if you don't try to adopt this cat right now.", "Male" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Breed", "Coloring", "DateAvailable", "Name", "Personality", "Sex" },
                values: new object[,]
                {
                    { 1, 6, "American Pit Bull", "Blue grey, white", new DateTime(2021, 1, 22, 11, 26, 17, 745, DateTimeKind.Local).AddTicks(3080), "Jackson", "Jackson gets easily frustrated and can exhibit this in a variety of ways. He will need positive outlets for his energy and a calm environment.", "Male" },
                    { 2, 2, "Mastiff", "Tan, black", new DateTime(2021, 1, 22, 11, 26, 17, 745, DateTimeKind.Local).AddTicks(4190), "Chickie", "Chickie will flourish in a calm environment and a low-traffic home. She can be worried about new people, new surroundings and touch. She prefers to take things at her own pace.", "Female" },
                    { 3, 3, "Chihuahua/Dachshund", "TriColor", new DateTime(2021, 1, 22, 11, 26, 17, 745, DateTimeKind.Local).AddTicks(4210), "Miss Precious", "Miss Precious has a history of biting a person or another animal. She would do best in an adult only home", "Female" },
                    { 4, 2, "Rottweiler", "Black, Tan", new DateTime(2021, 1, 22, 11, 26, 17, 745, DateTimeKind.Local).AddTicks(4220), "Zeus", "Zeus had a growth mindset and loves to learn. He needs positive outlets for his energy and a calm environment.", "Male" },
                    { 5, 10, "Pointer/American Pit Bull", "White, Tan", new DateTime(2021, 1, 22, 11, 26, 17, 745, DateTimeKind.Local).AddTicks(4220), "Uma", "Although Uma is no longer a puppy, she is still active and enjoys going for daily walks or runs. When she's not out and about, you can find her napping on a dog bed or a couch.", "Female" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 5);
        }
    }
}
