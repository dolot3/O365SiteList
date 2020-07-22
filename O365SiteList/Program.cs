using System;
using System.Collections.Generic;

namespace O365SiteList
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Using test data for now...
            List<string> fileLines = GetFileLines(GetTestSiteData());

            SaveToFile(fileLines, "c:\\_work\\tests\\ThreeWill\\SiteData.csv");

        }

        static List<SiteData> GetSiteData(string siteUrl, string userName, string password)
        {
            List<SiteData> theList = new List<SiteData>();

            //TODO:  extract the site data here

           

            return theList;
        }

        public static List<string> GetFileLines(List<SiteData> siteDataList)
        {
            List<string> theList = new List<string>();

            theList.Add("SiteCollectionName, Owner, LastAccessed");
            foreach(SiteData data in siteDataList)
            {
                theList.Add($"{data.SiteCollectionName},{data.Owner},{data.LastAccessed.ToShortDateString()}");
            }

            return theList;
        }

        public static void SaveToFile(List<string> fileLines, string path)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(path))
            {
                foreach(string line in fileLines)
                {
                    writer.WriteLine(line);
                }
            }
        }

        public static void SaveToOneDrive(string path)
        {
            //TODO: Save the file to OneDrive
            //I'll probably need more params passed to this routine, depending upon how saving to OneDrive actually works.

        }

        public static List<SiteData> GetTestSiteData()
        {
            List<SiteData> testList = new List<SiteData>();
            testList.Add(new SiteData { SiteCollectionName = "Collection 1", Owner = "Dave", LastAccessed = new DateTime(2020, 7, 7) });
            testList.Add(new SiteData { SiteCollectionName = "Collection 2", Owner = "Bruce", LastAccessed = DateTime.Now });
            testList.Add(new SiteData { SiteCollectionName = "Collection 3", Owner = "Karen", LastAccessed = DateTime.Now });
            return testList;
        }


    }
}
