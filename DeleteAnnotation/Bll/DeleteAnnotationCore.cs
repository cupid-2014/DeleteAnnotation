using DeleteAnnotation.common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DeleteAnnotation.Bll
{
    class DeleteAnnotationCore
    {
        public string DoWork(string sourcePath, string targetPath, string[] regexArray, string[] fileEndType)
        {
            string resultMsg = "成功";

            try
            {
                // 读取源文件夹
                ReadFiles(sourcePath, targetPath, regexArray, fileEndType);
            }
            catch (Exception ex)
            {
                resultMsg = "失败";
                //throw;
            }

            return resultMsg;
        }

        /// <summary>
        /// 读取文件夹下所有文件
        /// </summary>
        /// <param name="inFiles"></param>
        /// <param name="outFiles"></param>
        /// <param name="regexArray"></param>
        /// <param name="fileEndType"></param>
        /// <returns></returns>
        private void ReadFiles(string inFiles, string outFiles, string[] regexArray, string[] fileEndType)
        {
            DirectoryInfo inFolder = new DirectoryInfo(inFiles);
            if (inFolder == null)
                return;

            FileSystemInfo[] files = inFolder.GetFileSystemInfos();
            for (int f = 0; f < files.Length; f++)
            {
                FileInfo file = files[f] as FileInfo;
                //是文件                
                if (file != null)
                {
                    // 只有特定结尾的才进行删除，不是特定结尾的直接覆盖
                    if (fileEndType.Contains(file.Extension))
                    {
                        bool a = this.DeleteAnnotationFile(file.FullName, outFiles + "\\" + file.Name, regexArray, true);
                    }
                    else
                    { 
                        bool a = this.DeleteAnnotationFile(file.FullName, outFiles + "\\" + file.Name, regexArray, false);
                    }
                }
                else
                {
                    string subOutFile = outFiles + "\\" + files[f].ToString();
                    if (!System.IO.Directory.Exists(subOutFile))
                    {
                        Directory.CreateDirectory(subOutFile + "\\");
                    }

                    ReadFiles(files[f].FullName.ToString(), subOutFile, regexArray, fileEndType);
                }
            }

        }

        /// <summary>
        /// 删除文件中的注释
        /// </summary>
        /// <param name="inFullName"></param>
        /// <param name="outFullName"></param>
        /// <param name="regexArray"></param>
        /// <param name="isDel"></param>
        /// <returns></returns>
        private bool DeleteAnnotationFile(string inFullName, string outFullName, string[] regexArray, bool isDel)
        {
            // 输出文件判断
            if (inFullName != outFullName && File.Exists(outFullName))
            {
                File.Delete(outFullName);
            }
            else if (inFullName != outFullName)
            {
                FileStream fs;
                fs = File.Create(outFullName);
                fs.Close();
            }
            // 输入文件判断
            if (!File.Exists(inFullName))
            {
                return false;
            }

            try
            {
                // 读取
                string FillStr = File.ReadAllText(@inFullName);

                if (isDel)
                {
                    // 替换
                    foreach (var item in regexArray)
                    {
                        FillStr = Regex.Replace(FillStr, @item, "", RegexOptions.IgnoreCase);
                    }
                }
                
                // 写入
                File.WriteAllText(@outFullName, FillStr, Encoding.UTF8);
            }
            catch (Exception  ex)
            {
                throw;
            }

            return true;
        }
    }
}
