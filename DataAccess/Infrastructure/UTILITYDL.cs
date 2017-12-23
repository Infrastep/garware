using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Configuration;
using System.ComponentModel;
using System.Diagnostics;


namespace DataAccess.Infrastructure
{
   public class UTILITYDL
    {
        private static bool checkFileExist(string filename)
        {
            bool exist = false;

            string saveFile = HttpContext.Current.Server.MapPath(filename);
            if (!File.Exists(saveFile))
            {
                exist = false;
            }
            else
            { exist = true; }
            return exist;
        }

        public static string GetImage(string path,string text,int id=0)
        {

            string savepath = HttpContext.Current.Server.MapPath("/uploads/"  + id + "/" + path);

            //string savepath = "http://newdemo.infronthrs.com/UploadFiles/Images/" + saveToLocation + "/" + lstfile.FilesNameoriginal.Trim();
            string imageLocation = "/uploads/"+ id + "/" + path;
            try
            {
                if (!checkFileExist(imageLocation))
                {
                    WebClient webClient = new WebClient();
                    string dwlpath = System.Configuration.ConfigurationManager.AppSettings["ImgPathUrl"];
                    if (id!=0)
                    {
                        dwlpath = dwlpath + "/" + id + "/";
                    }
                    webClient.DownloadFile(dwlpath + imageLocation, savepath);
                    //savepath = HttpContext.Current.Server.MapPath("\\UploadFiles\\Images\\" + saveToLocation + "\\" + lstfile.FilesNameoriginal.Trim());
                    // savepath = "http://newdemo.infronthrs.com/UploadFiles/Images/" + saveToLocation + "\\" + lstfile.FilesNameoriginal.Trim();
                }
                //else
                //{ imageLocation = "/uploads/avatar.jpg"; }
            }
            catch(Exception ee)
            {
                if (text == "user")
                {
                    imageLocation = "/uploads/avatar.png";
                }
                else if (text == "client")
                { imageLocation = "/uploads/cruise.jpg"; }
            }
            return imageLocation;
        }


        public static void WriteToLog(Exception excep, bool alwaysLogToFile)
        {
            try
            {
                if (alwaysLogToFile)
                {
                    //WriteToTextLog(excep);

                }

                dynamic log = string.Concat(excep.ToString(),  excep.StackTrace);
                EventLog.WriteEntry("Shipsuit", log, EventLogEntryType.Warning);

            }
            catch (Exception ex)
            {
                //** most likely reason to end up here is insufficient rights to create a event log source, merging in the file
                //   EventLog.reg in the resources folder should fix this, otherwise create it manually
               // WriteToTextLog(ex);
            }
        }




        //private static string _logFile;
        //private static void WriteToTextLog(Exception exec)
        //{
        //    try
        //    {

        //        if (string.IsNullOrEmpty(_logFile))
        //        {
        //            string logPath = ConfigurationManager.AppSettings["LogFileLocation"];
        //            if (string.IsNullOrEmpty(logPath))
        //            {
        //                logPath = Path.GetTempPath;
        //            }

        //            if (!Directory.Exists(logPath))
        //            {
        //                Directory.CreateDirectory(logPath);
        //            }

        //            _logFile = Path.Combine(logPath, string.Concat("Shipsuit", ".log"));

        //        }

        //        using (StreamWriter sw = new StreamWriter(_logFile, true))
        //        {
        //            sw.WriteLine(System.DateTime.Now.ToString("G").PadLeft(20, '-').PadRight(160, '-'));
        //            sw.WriteLine();
        //            sw.WriteLine(exec.Message);
        //            sw.WriteLine();
        //            sw.WriteLine(exec.StackTrace);
        //            sw.WriteLine(string.Empty.PadRight(160, '-'));

        //            sw.Close();
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        //** nothing we can do about it so ignore
        //    }
        //}




    }
}
