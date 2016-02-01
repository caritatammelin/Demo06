using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD { Name = "Endless Forms Most Bautiful", Artist = "Nightwish" };

            Song track1 = new Song { Single = "Shudder Before the beautiful", Duration = "6:29"};
        Song track2 = new Song { Single = "Weak Fantasy", Duration = "5:23" };
        Song track3 = new Song { Single = "Elan", Duration = "4:45" };
        Song track4 = new Song { Single = "Yours Is an Empty Hope", Duration = "5:34" };
        Song track5 = new Song { Single = "Our Decades in the Sun", Duration = "6:37" };
        Song track6 = new Song { Single = "My Walden", Duration = "4:38" };
        Song track7 = new Song { Single = "Endless Forms Most Bautiful", Duration = "5:07" };
        Song track8 = new Song { Single = "Edema Ruh", Duration = "5:15" };
            Song track9 = new Song { Single = "Alpenglow", Duration = "4:45" };
            Song track10 = new Song { Single = "The Eyes of Sharbat Gula", Duration = "6:03" };
            Song track11 = new Song { Single = "The Greatest Show on Earth", Duration = "24:00" };

            cd.AddSong(track1);
            cd.AddSong(track2);
            cd.AddSong(track3);
            cd.AddSong(track4);
            cd.AddSong(track5);
            cd.AddSong(track6);
            cd.AddSong(track7);
            cd.AddSong(track8);
            cd.AddSong(track9);
            cd.AddSong(track10);


            Console.WriteLine(cd.ToString());

            
        }
    }
}
