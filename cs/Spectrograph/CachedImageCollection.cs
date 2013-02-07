using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Spectrograph
{
    class CachedImageCollection : IDisposable
    {
        int maxWidthToStore;
        const int ImageBlockSize = 48;
        List<Bitmap> images = new List<Bitmap>();
        List<Bitmap> imageBlocks = new List<Bitmap>();

        internal CachedImageCollection()
        {
            int screenLeft = int.MaxValue, screenRight = int.MinValue;
            foreach (Screen screen in Screen.AllScreens)
            {
                screenLeft = Math.Min(screenLeft, screen.Bounds.Left);
                screenRight = Math.Max(screenRight, screen.Bounds.Right);
            }
            maxWidthToStore = screenRight - screenLeft;
        }

        internal void Add(Bitmap image)
        {
            images.Add(image);

            if (images.Count >= ImageBlockSize)
            {
                Bitmap block = MergeImages();

                while (imageBlocks.Count * ImageBlockSize >= maxWidthToStore)
                {
                    imageBlocks[0].Dispose();
                    imageBlocks.RemoveAt(0);
                }

                imageBlocks.Add(block);
            }
        }

        private Bitmap MergeImages()
        {
            Bitmap result = new Bitmap(images.Count, images[0].Height, images[0].PixelFormat);
            using (Graphics g = Graphics.FromImage(result))
            {
                for (int i = 0; i < images.Count; i++)
                {
                    const int ChunkSize = 4092;
                    int chunkCount = images[i].Height / ChunkSize;
                    for (int j = 0; j < chunkCount; j++)
                    {
                        g.DrawImage(images[i], new Rectangle(i, ChunkSize * j, 1, ChunkSize),
                            new Rectangle(0, ChunkSize * j, 1, ChunkSize), GraphicsUnit.Pixel);
                    }
                    int rest = images[i].Height - ChunkSize * chunkCount;
                    if (rest > 0)
                    {
                        g.DrawImage(images[i], new Rectangle(i, ChunkSize * chunkCount, 1, rest),
                            new Rectangle(0, ChunkSize * chunkCount, 1, rest), GraphicsUnit.Pixel);
                    }

                    images[i].Dispose();
                }
            }
            images.Clear();
            return result;
        }

        internal IEnumerable<Bitmap> GetImages()
        {
            for (int i = images.Count - 1; i >= 0; i--)
            {
                yield return images[i];
            }
            for (int i = imageBlocks.Count - 1; i >= 0; i--)
            {
                yield return imageBlocks[i];
            }
        }

        internal void Clear()
        {
            for (int i = images.Count - 1; i >= 0; i--)
            {
                images[i].Dispose();
            }
            images.Clear();
            for (int i = imageBlocks.Count - 1; i >= 0; i--)
            {
                imageBlocks[i].Dispose();
            }
            imageBlocks.Clear();
        }

        public void Dispose()
        {
            Clear();
        }
    }
}
