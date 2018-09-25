using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class MusicStoreDbInitializer
       : System.Data.Entity.DropCreateDatabaseAlways<MusicStoreDB>
    {
        protected override void Seed(MusicStoreDB context)
        {
            context.Artists.Add(new Artist { Name = "Al Di Meola" });
            context.Genres.Add(new Genre { Name = "Jazz" });
            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Rush" },
                Genre = new Genre { Name = "Rock" },
                Price = 9.99m,
                Title = "Caravan"
            });
            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Men At Work" },
                Genre = new Genre { Name = "Rock" },
                Price = 8.99m,
                Title = "The Best Of The Men At Work"
            });
            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Daft Punk" },
                Genre = new Genre { Name = "Jazz" },
                Price = 8.99m,
                Title = "Homework"
            });
            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Martin Roscoe" },
                Genre = new Genre { Name = "Rock" },
                Price = 8.99m,
                Title = "Szymanowski: Piano Works, Vol. 1"
            });


            base.Seed(context);
        }
    }
}