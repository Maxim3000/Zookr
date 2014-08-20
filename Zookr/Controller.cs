using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Zookr
{
    class Controller
    {        
        private static Controller _instance = null;
        public static Controller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Controller();
                }
                return _instance;
            }

            set { _instance = value; }
        }
        public MainForm MainView { get; set; }

        public Controller()
        {
        }

        public void startSearch()
        {
            ImageSearch imageSearch = new ImageSearch(MainView);
            imageSearch.SourceImagePath = MainView.SourceImagePath;
            imageSearch.SearchDirPath = MainView.SearchDirPath;
            imageSearch.Tolerance = MainView.Tolerance;
            
            imageSearch.search();
        }
    }
}
