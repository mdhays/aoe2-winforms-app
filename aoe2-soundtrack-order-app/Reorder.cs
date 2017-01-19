using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace aoe2_soundtrack_order_app
{
    public static class ReOrder
    {
        static List<string> trackList = new List<string>();

        public static void RenameFiles(string pathRef)
        {
            Form1 form1Ref = new Form1();

            var files = Directory.GetFiles(pathRef, "*.mp3");

            //var randomizedFiles = new Random().Shuffle(files);
            var randomizedFiles = Algorithm.Shuffle(files);

            for (int i = 0; i < files.Length; i++)
            {
                string oldTrackName = files[i];
                string newTrackName = randomizedFiles.First().ToString();

                randomizedFiles.Remove(randomizedFiles.First());
                File.Delete(newTrackName);

                //System.IO.File.Move("oldfilename", "newfilename");
                System.IO.File.Move(oldTrackName, newTrackName);
            }
        }

    }
}
