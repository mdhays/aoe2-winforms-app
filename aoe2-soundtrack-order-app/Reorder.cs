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

            foreach (var file in files)
            {
                string trackName = Path.GetFileName(file);
                //System.IO.File.Move("oldfilename", "newfilename");
            }
        }

    }
}
