using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class CD
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public List<Song> Songs { get; }
        public CD()
        {
            Songs = new List<Song>();
        }

    public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public override string ToString()
        {
            string sCD = "CD data:\n -Name: " + Name + " Artist: " + Artist + " Songs:\n";
            foreach (Song song in Songs)
            {
                sCD += song.ToString() + "\n";
            }
            return sCD;
        }

        public void PrintCollection()
        {
            Console.WriteLine("Songs in collection: ");
            foreach (Song song in Songs)
            {
                Console.WriteLine(song.ToString());
            }
        }
    }
}
