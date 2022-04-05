using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace ESbyMail
{
    public class ElectroSigner
    {
       
        public string result = string.Empty;
        public string GetCheckSum(string path)
        {
            using(FileStream fs = File.OpenRead(path))
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] fileData = new byte[fs.Length];
                fs.Read(fileData, 0, (int)fs.Length);
                byte[] checkSum = md5.ComputeHash(fileData);
                string result = BitConverter.ToString(checkSum).Replace("-", string.Empty);
                using (FileStream fs1 = File.Create(path+" S.txt"))
                {
                    StreamWriter sw = new StreamWriter(fs1);
                    sw.WriteLine(result);
                    sw.Close();

                }
                    return result;
            }
        }

        
        


    }
}
