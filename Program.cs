using System;
using System.IO;

namespace CAF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //This program creates a folder using the current date as the name (format "YYYY-MM-DD")

            DateTime CurrentDate = System.DateTime.Today.Date;
            DateTime DateToUse = CurrentDate;

            Int32 Year = DateToUse.Year;
            Int32 Month = DateToUse.Month;
            Int32 Day = DateToUse.Day;
            string FolderName = string.Format("{0:0000}", Year) + "-" + string.Format("{0:00}", Month) + "-" + string.Format("{0:00}", Day);

            string FolderToCreate = "";

            if (args.Length == 0)
            {
                Directory.CreateDirectory(FolderName);
            }
            else
            {
                if ((args[0] == "/?") | (args[0] == "?"))
                {
                    Console.WriteLine("Create folder using current date (\"YYYY-MM-DD\") as name. Defaults to current folder or specify path on command line.");
                }
                else
                {
                    FolderToCreate = string.Concat(args[0], @"\", FolderName);
                    Directory.CreateDirectory(FolderToCreate);
                }
            }
        }
    }
}