using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Medias.API.Migrations
{
    public partial class MediasV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MediaGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medias",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Thumbnail = table.Column<string>(nullable: true),
                    MediaGroupId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medias_MediaGroups_MediaGroupId",
                        column: x => x.MediaGroupId,
                        principalTable: "MediaGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MediaGroups",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Shield Hero", "Series" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), "Your Name", "Movie" },
                    { new Guid("24810dfc-2d94-4cc7-aab5-cdf98b83f0c9"), "Goblin Slayer", "Series" },
                    { new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), "Fairy Tail", "Series" },
                    { new Guid("d106b8e5-11e8-4f83-9b33-db7e2be73102"), "JoJo's Bizarre Adventure: Golden Wind", "Series" }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "MediaGroupId", "Thumbnail", "Title" },
                values: new object[,]
                {
                    { new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"), "While in the library, college student Naofumi Iwatani finds a fantasy book about \"Four Heroes\"; The Spear, Sword, Bow, and Shield.", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "https://image.tmdb.org/t/p/w320_and_h180_bestv2/3UyyCIoFdWDoHpt4jk6wlWAKaex.jpg", "EP 1 The Shield Hero" },
                    { new Guid("8ae54711-7084-46ff-bf9e-9092d0ab37b8"), "Unable to use a sword, Naofumi searches for a partner, but he can only afford a sickly demi-human slave.", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "https://images.attvideo.com/image/e_qKSpECrgM/raphtalia-kawaii-loli-tate-no-yuusha-no-nariagari-ep-2.jpg", "EP 2 The Slave Girl" },
                    { new Guid("57970c37-a716-4668-ba9d-cabd79948e94"), "Naofumi and Raphtalia become good partners but must prepare themselves to fight an incoming wave.", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "https://dg31sz3gwrwan.cloudfront.net/screen/6983643/1_iphone.jpg", "EP 3 Wave of Catastrophe" },
                    { new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), "A teenage boy and girl embark on a quest to meet each other for the first time after they magically swap bodies.", new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), "https://d2e111jq13me73.cloudfront.net/sites/default/files/styles/review_gallery_carousel_slide_thumbnail/public/screenshots/csm-movie/your-name-ss1.jpg?itok=2vfTpJIX", "Your Name" },
                    { new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "On Priestes first official adventure, she and her party of novices fall victim to murderous goblins.", new Guid("24810dfc-2d94-4cc7-aab5-cdf98b83f0c9"), "https://dg31sz3gwrwan.cloudfront.net/screen/6758282/1_iphone.jpg", "EP 1 The Fate of Particular Adventurers" },
                    { new Guid("b79a54f9-45a2-421b-735e-08d713cec375"), "As Priestess accompanies Goblin Slayer on his intentionally specific quests.", new Guid("24810dfc-2d94-4cc7-aab5-cdf98b83f0c9"), "https://image.tmdb.org/t/p/w320_and_h180_bestv2/e3BKChEdCLFmD1CcnkHWiUSuLTO.jpg", "EP 2 Goblin Slayer" },
                    { new Guid("30189f54-b7d8-4726-cd85-08d713de3475"), "Three adventurers, High Elf Archer, Dwarf Shaman, and Lizardman Priest, request Goblin Slayer's aid to stop a destructive demon lord.", new Guid("24810dfc-2d94-4cc7-aab5-cdf98b83f0c9"), "https://image.tmdb.org/t/p/w320_and_h180_bestv2/xVfJgU9sAFyRPY2gKCkzLjDixsA.jpg", "EP 3 Unexpected Visitors" },
                    { new Guid("493c3228-3444-4a49-9cc0-e8532edc59b2"), "When a phony wizard lures Lucy onto his ship with the promise of getting into the guild, her new friends must bail her out.", new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), "https://d2e111jq13me73.cloudfront.net/sites/default/files/styles/review_gallery_carousel_slide_thumbnail/public/screenshots/csm-tv/fairy-tail-ss5.jpg?itok=wy2HxSkX", "EP 1 The Fairy Tail" },
                    { new Guid("3706ded9-30ca-4b90-971c-924d330edb96"), "DescriptionNatsu and Happy take Lucy to their headquarters to meet the rowdy members of Fairy Tail.", new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), "https://images.attvideo.com/image/bVMH3H84shM/fairy-tail-episode-2-english-dubbed.jpg", "EP 2 Fire Dragon, Monkey, and Bull" },
                    { new Guid("f064bae0-483b-4db9-b06a-c85129803fdb"), "Natsu picks up a job that could pay big, but he needs Lucy to complete his plan.", new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), "https://www.myanime.co/file/cache/5jo46ejjxv0-320x180.jpg", "EP 3 Infiltrate the Everlue Mansion" },
                    { new Guid("8d81a6f1-f933-429a-91fb-7d38cd54b142"), "Koichi Hirose travels to Naples in order to find the possible son of DIO, Haruno Shiobana.", new Guid("d106b8e5-11e8-4f83-9b33-db7e2be73102"), "https://dw9to29mmj727.cloudfront.net/thumbnails/episodes/11029-jojos-bizarre-adventure-season-four-1-320x180.jpg?size=960x540", "EP 1 Golden Wind" },
                    { new Guid("3d0c1d77-26e7-4972-9e8f-cf1055c996f7"), "Bucciarati is looking for the person responsible for critically injuring Leaky Eye Luca.", new Guid("d106b8e5-11e8-4f83-9b33-db7e2be73102"), "https://dw9to29mmj727.cloudfront.net/thumbnails/episodes/11030-jojos-bizarre-adventure-season-four-2-320x180.jpg?size=960x540", "EP 2 Bucciarati Is Coming" },
                    { new Guid("4259cac2-fcf2-4ca2-b311-813bc291c2ce"), "Risotto figures out that Doppio must be a Stand user that the boss trusts in deeply because he’s able to hear the noise from a certain Stand.", new Guid("d106b8e5-11e8-4f83-9b33-db7e2be73102"), "https://i3.wp.com/ytimg.googleusercontent.com/vi/GxmiZ6Fn-dk/mqdefault.jpg", "EP 27 King Crimson vs Metallica" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medias_MediaGroupId",
                table: "Medias",
                column: "MediaGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medias");

            migrationBuilder.DropTable(
                name: "MediaGroups");
        }
    }
}
