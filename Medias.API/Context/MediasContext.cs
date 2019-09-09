using Medias.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medias.API.Context
{
    public class MediasContext : DbContext
    {
        public DbSet<Media> Medias { get; set; }
        public DbSet<MediaGroup> MediaGroups { get; set; }

        public MediasContext(DbContextOptions<MediasContext> options)
           : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MediaGroup>().HasData(
               new MediaGroup()
               {
                   Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                   Name = "Shield Hero",
                   Type = "Series"
               },
               new MediaGroup()
               {
                   Id = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                   Name = "Your Name",
                   Type = "Movie"
               },
               new MediaGroup()
               {
                   Id = Guid.Parse("24810dfc-2d94-4cc7-aab5-cdf98b83f0c9"),
                   Name = "Goblin Slayer",
                   Type = "Series"
               },
               new MediaGroup()
               {
                   Id = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                   Name = "Fairy Tail",
                   Type = "Series"
               },
               new MediaGroup()
               {
                   Id = Guid.Parse("d106b8e5-11e8-4f83-9b33-db7e2be73102"),
                   Name = "JoJo's Bizarre Adventure: Golden Wind",
                   Type = "Series"
               }
               );

            modelBuilder.Entity<Media>().HasData(
            new Media()
            {
                Id = Guid.Parse("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                MediaGroupId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                Title = "EP 1 The Shield Hero",
                Thumbnail = "https://image.tmdb.org/t/p/w320_and_h180_bestv2/3UyyCIoFdWDoHpt4jk6wlWAKaex.jpg",
                Description = "While in the library, college student Naofumi Iwatani finds a fantasy book about \"Four Heroes\"; The Spear, Sword, Bow, and Shield."
            },
            new Media()
            {
                Id = Guid.Parse("8ae54711-7084-46ff-bf9e-9092d0ab37b8"),
                MediaGroupId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                Title = "EP 2 The Slave Girl",
                Thumbnail = "https://images.attvideo.com/image/e_qKSpECrgM/raphtalia-kawaii-loli-tate-no-yuusha-no-nariagari-ep-2.jpg",
                Description = "Unable to use a sword, Naofumi searches for a partner, but he can only afford a sickly demi-human slave."
            },
            new Media()
            {
                Id = Guid.Parse("57970c37-a716-4668-ba9d-cabd79948e94"),
                MediaGroupId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                Thumbnail = "https://dg31sz3gwrwan.cloudfront.net/screen/6983643/1_iphone.jpg",
                Title = "EP 3 Wave of Catastrophe",
                Description = "Naofumi and Raphtalia become good partners but must prepare themselves to fight an incoming wave."
            },
            new Media()
            {
                Id = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                MediaGroupId = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                Thumbnail = "https://d2e111jq13me73.cloudfront.net/sites/default/files/styles/review_gallery_carousel_slide_thumbnail/public/screenshots/csm-movie/your-name-ss1.jpg?itok=2vfTpJIX",
                Title = "Your Name",
                Description = "A teenage boy and girl embark on a quest to meet each other for the first time after they magically swap bodies."
            },
            new Media()
            {
                Id = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                MediaGroupId = Guid.Parse("24810dfc-2d94-4cc7-aab5-cdf98b83f0c9"),
                Thumbnail = "https://dg31sz3gwrwan.cloudfront.net/screen/6758282/1_iphone.jpg",
                Title = "EP 1 The Fate of Particular Adventurers",
                Description = "On Priestes first official adventure, she and her party of novices fall victim to murderous goblins."
            },
            new Media()
            {
                Id = Guid.Parse("B79A54F9-45A2-421B-735E-08D713CEC375"),
                MediaGroupId = Guid.Parse("24810dfc-2d94-4cc7-aab5-cdf98b83f0c9"),
                Thumbnail = "https://image.tmdb.org/t/p/w320_and_h180_bestv2/e3BKChEdCLFmD1CcnkHWiUSuLTO.jpg",
                Title = "EP 2 Goblin Slayer",
                Description = "As Priestess accompanies Goblin Slayer on his intentionally specific quests."
            },
            new Media()
            {
                Id = Guid.Parse("30189F54-B7D8-4726-CD85-08D713DE3475"),
                MediaGroupId = Guid.Parse("24810dfc-2d94-4cc7-aab5-cdf98b83f0c9"),
                Thumbnail = "https://image.tmdb.org/t/p/w320_and_h180_bestv2/xVfJgU9sAFyRPY2gKCkzLjDixsA.jpg",
                Title = "EP 3 Unexpected Visitors",
                Description = "Three adventurers, High Elf Archer, Dwarf Shaman, and Lizardman Priest, request Goblin Slayer's aid to stop a destructive demon lord."
            },
            new Media()
            {
                Id = Guid.Parse("493c3228-3444-4a49-9cc0-e8532edc59b2"),
                MediaGroupId = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                Thumbnail = "https://d2e111jq13me73.cloudfront.net/sites/default/files/styles/review_gallery_carousel_slide_thumbnail/public/screenshots/csm-tv/fairy-tail-ss5.jpg?itok=wy2HxSkX",
                Title = "EP 1 The Fairy Tail",
                Description = "When a phony wizard lures Lucy onto his ship with the promise of getting into the guild, her new friends must bail her out."
            },
            new Media()
            {
                Id = Guid.Parse("3706ded9-30ca-4b90-971c-924d330edb96"),
                MediaGroupId = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                Thumbnail = "https://images.attvideo.com/image/bVMH3H84shM/fairy-tail-episode-2-english-dubbed.jpg",
                Title = "EP 2 Fire Dragon, Monkey, and Bull",
                Description = "DescriptionNatsu and Happy take Lucy to their headquarters to meet the rowdy members of Fairy Tail."
            },
            new Media()
            {
                Id = Guid.Parse("f064bae0-483b-4db9-b06a-c85129803fdb"),
                MediaGroupId = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                Thumbnail = "https://www.myanime.co/file/cache/5jo46ejjxv0-320x180.jpg",
                Title = "EP 3 Infiltrate the Everlue Mansion",
                Description = "Natsu picks up a job that could pay big, but he needs Lucy to complete his plan."
            },
            new Media()
            {
                Id = Guid.Parse("8d81a6f1-f933-429a-91fb-7d38cd54b142"),
                MediaGroupId = Guid.Parse("d106b8e5-11e8-4f83-9b33-db7e2be73102"),
                Thumbnail = "https://dw9to29mmj727.cloudfront.net/thumbnails/episodes/11029-jojos-bizarre-adventure-season-four-1-320x180.jpg?size=960x540",
                Title = "EP 1 Golden Wind",
                Description = "Koichi Hirose travels to Naples in order to find the possible son of DIO, Haruno Shiobana."
            },
            new Media()
            {
                Id = Guid.Parse("3d0c1d77-26e7-4972-9e8f-cf1055c996f7"),
                MediaGroupId = Guid.Parse("d106b8e5-11e8-4f83-9b33-db7e2be73102"),
                Thumbnail = "https://dw9to29mmj727.cloudfront.net/thumbnails/episodes/11030-jojos-bizarre-adventure-season-four-2-320x180.jpg?size=960x540",
                Title = "EP 2 Bucciarati Is Coming",
                Description = "Bucciarati is looking for the person responsible for critically injuring Leaky Eye Luca."
            },
            new Media()
            {
                Id = Guid.Parse("4259cac2-fcf2-4ca2-b311-813bc291c2ce"),
                MediaGroupId = Guid.Parse("d106b8e5-11e8-4f83-9b33-db7e2be73102"),
                Thumbnail = "https://i3.wp.com/ytimg.googleusercontent.com/vi/GxmiZ6Fn-dk/mqdefault.jpg",
                Title = "EP 27 King Crimson vs Metallica",
                Description = "Risotto figures out that Doppio must be a Stand user that the boss trusts in deeply because he’s able to hear the noise from a certain Stand."
            }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
