using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zookr
{
    class ImageSearch
    {
        private MainForm mainView;
        private int resultCounter = 0;
        public string SourceImagePath { get; set; }
        public string SearchDirPath { get; set; }
        public int Tolerance { get; set; }

        public ImageSearch(MainForm mf)
        {
            this.mainView = mf;
        }

        public void search()
        {
            var resultSet = new List<string>();
            var imageFiles = getImageFiles(SearchDirPath);
            ulong sourceHash = Image.FromFile(SourceImagePath).Hash();
            int counter = 0;
            Console.WriteLine("Source hash: " + sourceHash);
            mainView.clearListView();

            foreach (string file in imageFiles)
            {
                if (mainView.backgroundWorker1.CancellationPending)
                {
                    mainView.reportProgress(100);
                    return;
                }
                try
                {
                    var img = Image.FromFile(file);
                    var compareHash = img.Hash();
                    Console.WriteLine("Image: " + file + ", Hash: " + compareHash);
                    if (calcHammingDist(sourceHash, compareHash) <= Tolerance)
                    {
                        mainView.addResult(file);
                    }
                    img.Dispose();
                    mainView.backgroundWorker1.ReportProgress(((counter + 1) * 100) / imageFiles.Count);
                    counter++;
                }
                catch (Exception e)
                {
                }
            }
        }

        private List<string> getImageFiles(string searchDir)
        {
            string pattern = "([^\\s]+(\\.(?i)(jpg|png|gif|bmp))$)";
            var imageFiles = new List<string>();

            foreach (string file in Directory.GetFiles(searchDir))
            {
                if (file != SourceImagePath && Regex.IsMatch(file, pattern))
                {
                    imageFiles.Add(file);
                }
            }
            foreach (string dir in Directory.GetDirectories(searchDir))
            {
                getImageFiles(dir);
            }

            return imageFiles;
        }

        /// <summary>
        /// Calculates the Hamming distance between two values
        /// </summary>
        /// <param name="num1">First value</param>
        /// <param name="num2">Second value</param>
        /// <returns>Hamming distance</returns>
        private int calcHammingDist(ulong num1, ulong num2)
        {
            ulong dif = num1 ^ num2;
            int dist = 0;

            while (dif > 0)
            {
                if ((dif & 0x01) == 1)
                {
                    dist++;
                }
                dif >>= 1;
            }
            return dist;
        }
    }
}
