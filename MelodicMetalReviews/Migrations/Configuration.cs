namespace MelodicMetalReviews.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MelodicMetalReviews.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MelodicMetalReviews.Models.AlbumContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MelodicMetalReviews.Models.AlbumContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Bands.AddOrUpdate(
                    new Band
                    {
                        BandID = 1,
                        BandName = "Monuments",
                        Bio = "Transcontinental metallers MONUMENTS have come a long way since starting as a side project of John Browne (guitars; Fellsilent) and Josh Travis (guitars; The Tony Danza Tapdance Extravaganza). From a surprise appearance on BBC Radio 1 to debut full-length, Gnosis, the group immediately found a fanatic audience. Praised for their brainy yet song-oriented approach to heavy music, MONUMENTS bridged the progressive metal gap like few before. On one side they challenged. Gnosis was full of mind-bending, betcha-cant-play-this-type passages. On the other side, fans deeply connected to hook- laden songs like 97% Static and Empty Vessels.",
                        ImagePath = "/Images/Monuments/Monuments.jpg"
                    },
                    new Band
                    {
                        BandID = 2,
                        BandName = "Intervals",
                        Bio = "Intervals was known in the progressive metal world for being one of those rare instrumental bands that wasn't purely focused on technical ability - rather, just catchy riffs and soulful leads by lead guitarist Aaron Marshall designed to replace the role of a vocalist. The band had always been open to taking on a singer, but simply never felt the need to add one. However, there is a certain plateau that can be reached with instrumental music in terms of popularity, and it's unlikely that its appeal will stretch beyond a niche market (bands like Animals As Leaders prove that this is possible, but they are the exception and not the rule). Therefore, when Mike Semesky, former vocalist of Vestascension and The HAARP Machine, joined on bass toward the end of last year, suspicions arose that he would also become the bands' vocalist and help them establish themselves as a more popular band by breaking free of the boundaries imposed on bands playing exclusively instrumental music. These suspicions were confirmed alongside the band's announcement of their fittingly titled debut album, A Voice Within. Hang up any worries about the transformation of the band, because AVW is a smart, catchy album that fuses the guitar focused style of their previous EPs with neatly integrated vocals, with some surprises thrown in along the way.",
                        ImagePath = "/Images/Intervals/Intervals.jpg"
                    }
                );
            context.SaveChanges();
            context.Albums.AddOrUpdate(
                    new Album
                    {
                        AlbumName = "The Amanuensis",
                        ImagePath = "/Images/Monuments/TheAmanuensis.jpg",
                        ReleaseDate = DateTime.Parse("06/23/2014"),
                        Review = "In the beginning, there was silence well, Fellsilent, to be exact. Before the whole djent movement took off in the early 10s, there were two UK bands laying the foundations for the genre: SiKth and Fellsilent. While the former has splintered off into several bands spanning multiple genres that have never really reached the popularity of their mother group, Fellsilens guitarists took their side projects and made them into bands that are arguably far more successful that the one that spawned them. Acle Kahney borrowed the ambience and melodies of his original band and created TesseracT, one of the most discussed modern prog metal acts today. But John Brownes Monuments keeps most of Fellsilents formulas for crushingly heavy riffs; the difference being that Monuments steps up the game in almost every way. The band has gone through many changes since the bitter departure of original vocalists Neema and Greg, but theyve always retained their big dick grooves and unique riff styles. The Amanuensis is no exception to the formula theyve been building up for over four years, and Monuments deliver the goods consistently and satisfyingly.",
                        BandID = 1,
                        Rating = 4.0M
                    },
                    new Album
                    {
                        AlbumName = "A Voice Within",
                        ImagePath = "/Images/Intervals/AVoiceWithin.jpg",
                        ReleaseDate = DateTime.Parse("3/4/2014"),
                        Review = "Intervals was known in the progressive metal world for being one of those rare instrumental bands that wasn't purely focused on technical ability - rather, just catchy riffs and soulful leads by lead guitarist Aaron Marshall designed to replace the role of a vocalist. The band had always been open to taking on a singer, but simply never felt the need to add one. However, there is a certain plateau that can be reached with instrumental music in terms of popularity, and it's unlikely that its appeal will stretch beyond a niche market (bands like Animals As Leaders prove that this is possible, but they are the exception and not the rule). Therefore, when Mike Semesky, former vocalist of Vestascension and The HAARP Machine, joined on bass toward the end of last year, suspicions arose that he would also become the bands' vocalist and help them establish themselves as a more popular band by breaking free of the boundaries imposed on bands playing exclusively instrumental music. These suspicions were confirmed alongside the band's announcement of their fittingly titled debut album, A Voice Within. Hang up any worries about the transformation of the band, because AVW is a smart, catchy album that fuses the guitar focused style of their previous EPs with neatly integrated vocals, with some surprises thrown in along the way.",
                        BandID = 2,
                        Rating = 4.0M
                    }
                );
            context.SaveChanges();

        }
    }
}
