using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UnitTestTL
{
    class Run
    {
        static void Main_(string[] args)
        {
            //Console.WriteLine("Hello");
            LoadFile loadFile = new LoadFile();

            //string dateTimeString = "2015-05-15T11:12:04.";
            //Console.WriteLine(loadFile.CovertStringToTime(dateTimeString));
            //loadFile.CovertStringToTime(dateTimeString);
            string startDateTimeString = "2015-05-15T11:12:02";
            string EndDateTimeString = "2015-05-15T11:12:06";
            string dateFormat = "yyyy-MM-ddTHH:mm:ss";

            DateTime startDateTime = loadFile.CovertStringToTime(startDateTimeString, dateFormat).AddMinutes(-1);
            DateTime endDateTime = loadFile.CovertStringToTime(EndDateTimeString, dateFormat).AddMinutes(1);
            //Console.WriteLine(startDateTime);
            //Console.WriteLine(endDateTime);

            loadFile.GetFileContent(startDateTime, endDateTime);

        }
    }

    public class LoadFile
    {
        public string logFolder = @"C:\Log_Example";
        public string logFileName = "ACD1.log";

        public void GetFileContent(DateTime startTime, DateTime endTime)
        {
            string logFilePath = Path.Combine(logFolder, logFileName);
            string newLogFilePath = Path.Combine(logFolder, "new_" + logFileName);

            string regex1 = @"^.\w.+timestamp=.(\d*-\d*-\d*T\d).+.loglevel";
            string regex2 = @"(^.\w.+timestamp=.)(\d*-\d*-\d*T\d)(.+.loglevel)";
            string regex3 = @"(\d*-\d*-\d*T\d+:\d+:\d+\.\d+)";
            string regex4 = @"(\d*-\d*-\d*T\d+:\d+:\d+\.)";

            Regex re = new Regex(regex4, RegexOptions.IgnoreCase);

            using (StreamReader sr = new StreamReader(logFilePath))
            {
                if (File.Exists(newLogFilePath))
                {
                    File.Delete(newLogFilePath);
                }

                string lineString;
                string timeStamp;
                while (sr.Peek() > 0)
                {
                    lineString = sr.ReadLine();
                    //Console.WriteLine(lineString);

                    if (re.IsMatch(lineString))
                    {
                        //re.Match(lineString).Groups[0].Value
                        timeStamp = re.Match(lineString).Groups[0].Value;

                        //Console.WriteLine(CovertStringToTime(timeStamp).ToString("yyyyMMdd-HH:mm:ss"));

                        if (CovertStringToTime(timeStamp) >= startTime && CovertStringToTime(timeStamp) <= endTime)
                        {
                            //Console.WriteLine(CovertStringToTime(timeStamp).ToString("yyyy-MM-ddTHH:mm:ss"));
                            using (StreamWriter sw = File.AppendText(newLogFilePath))
                            {
                                sw.WriteLine(lineString);
                            }
                        }
                        //else if (CovertStringToTime(timeStamp) <= endTime)
                        //{
                        //    Console.WriteLine(CovertStringToTime(timeStamp).ToString("yyyyMMdd-HH:mm:ss"));

                        //}

                        //Console.WriteLine(re.Match(lineString).Groups[0].Value);
                        //Console.WriteLine(re.Match(lineString).Groups[1].Value);
                        //Console.WriteLine(re.Match(lineString).Groups[2].Value);
                    }
                }
            }
        }

        public DateTime CovertStringToTime(string dateTimeString, string dateFormat = "")
        {

            if (dateFormat == "")
            {
                dateFormat = "yyyy-MM-ddTHH:mm:ss.";
            }
            DateTime dt;
            bool success = DateTime.TryParseExact(dateTimeString, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt);

            if (success)
            {
                return dt;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        //private string GetMachineByURI(string uriPath)
        //{
        //    string machineName;

        //    Regex configRegex = new Regex(@"^\\\\([\w+\.]+)\\", RegexOptions.IgnoreCase);

        //    if (configRegex.IsMatch(uriPath))
        //    {
        //        machineName = configRegex.Match(PDSAgentDownloadFolder).Groups[1].Value;
        //    }
        //    else
        //    {
        //        throw (new NullReferenceException("Cannot get machine name from URI Path. Please check."));
        //    }
        //    return machineName;
        //}


        //public FileInfo getACDDownloadRelatedLog()
        //{
        //    string pdsAgentLogFolderPath = Path.Combine(Directory.GetParent(PDSAgentConfigPath).FullName, "PDSAgentLogs");
        //    FileInfo acdLog = new FileInfo(Path.Combine(pdsAgentLogFolderPath, "ACD.log"));

        //    DirectoryInfo dir = new DirectoryInfo(pdsAgentLogFolderPath);

        //    Regex commondllConntentRegex = new Regex(@"\<\w.+loglevel=.\b(Info|Debug).+logger=.Advent\.PDS\.Agent\.Common\.dll.+", RegexOptions.IgnoreCase);
        //    Regex serviceExeConntentRegex = new Regex(@"\<\w.+loglevel=.\b(Info|Debug).+logger=.Advent\.PDS\.Agent\.Service\.exe.+", RegexOptions.IgnoreCase);

        //    if (dir.Exists)
        //    {
        //        foreach (FileInfo file in dir.GetFiles())
        //        {
        //            using (StreamReader streamLogFile = new StreamReader(file.FullName))
        //            {
        //                while (streamLogFile.Peek() >= 0)
        //                {
        //                    string str = streamLogFile.ReadLine();
        //                    if (commondllConntentRegex.IsMatch(str) || serviceExeConntentRegex.IsMatch(str))
        //                    {
        //                        using (StreamWriter sw = File.AppendText(acdLog.FullName))
        //                        {
        //                            sw.WriteLine(str);
        //                        }
        //                    }
        //                }
        //            }

        //        }

        //    }

        //    return acdLog;

        //}

    }
}
