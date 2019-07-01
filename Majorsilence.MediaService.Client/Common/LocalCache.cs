using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;


namespace Majorsilence.MediaService.Client.Common
{
    public class LocalCache
    {

        private static string cacheDirectory = System.IO.Path.Combine(DataDirectory.MajorSilenceMediaServiceLocalAppDataDirectory, "CoverArtCache");

        public static void SaveCacheImage(Image img, long IdMediaInfo)
        {
            if (System.IO.Directory.Exists(cacheDirectory) == false)
            {
                System.IO.Directory.CreateDirectory(cacheDirectory);
            }


            string filename = System.IO.Path.Combine(LocalCache.cacheDirectory, IdMediaInfo.ToString() + ".jpg");

            if (System.IO.File.Exists(filename))
            {
                System.IO.File.Delete(filename);
            }

           
            using(Image tmep = new Bitmap(img)){
                // work around an error where using the image passed in causes an exception
                tmep.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
                tmep.Dispose();
            }
        }

        public static Image GetCachedImage(long IdMediaInfo)
        {
            if (System.IO.Directory.Exists(cacheDirectory) == false)
            {
                System.IO.Directory.CreateDirectory(cacheDirectory);
            }

            string filename = System.IO.Path.Combine(LocalCache.cacheDirectory, IdMediaInfo.ToString() + ".jpg");

            if (System.IO.File.Exists(filename))
            {

                return Image.FromFile(filename);
            }

            return null;
        }

    
    }
}
