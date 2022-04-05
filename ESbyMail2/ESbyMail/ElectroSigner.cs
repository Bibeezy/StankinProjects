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
        private static string hashAlgorithm = "SHA256";
        //public string GetCheckSum(string path)
        //{
        //    using(FileStream fs = File.OpenRead(path))
        //    {
        //        MD5 md5 = new MD5CryptoServiceProvider();
        //        byte[] fileData = new byte[fs.Length];
        //        fs.Read(fileData, 0, (int)fs.Length);
        //        byte[] checkSum = md5.ComputeHash(fileData);
        //        string result = BitConverter.ToString(checkSum).Replace("-", string.Empty);
        //        using (FileStream fs1 = File.Create(path+" S.txt"))
        //        {
        //            StreamWriter sw = new StreamWriter(fs1);
        //            sw.WriteLine(result);
        //            sw.Close();

        //        }
        //            return result;
        //    }
        //}

        public static void GetCheckSum(string pathF)
        {
            string pathD = pathF;
            byte[] documentContent = File.ReadAllBytes(pathF);
            RSA rsa = RSA.Create();
            RSAPKCS1SignatureFormatter rsaFormatter = new RSAPKCS1SignatureFormatter(rsa);
            rsaFormatter.SetHashAlgorithm(hashAlgorithm);
            byte[] hashDocumentContent = SHA256.Create().ComputeHash(documentContent);
            byte[] signContent = rsaFormatter.CreateSignature(hashDocumentContent);
            
            File.WriteAllText(pathD + " key.txt", rsa.ToXmlString(false));
            File.WriteAllBytes(pathD + " sign.txt", signContent);
        }

        public static bool CheckCheckSum(string pathD)
        {
            bool result = false;
            FileInfo finf = new FileInfo(pathD);
            string key = File.ReadAllText(finf.FullName.Replace("enc", "key"));
            byte[] signature = File.ReadAllBytes(finf.FullName.Replace("enc", "sign"));
            
            byte[] DocCont = File.ReadAllBytes(finf.FullName.Replace("enc","dec"));
            RSA rsa = RSA.Create();
            rsa.FromXmlString(key);
            RSAPKCS1SignatureDeformatter rsaDeform = new RSAPKCS1SignatureDeformatter(rsa);
            rsaDeform.SetHashAlgorithm(hashAlgorithm);
            byte[] data = SHA256.Create().ComputeHash(DocCont);
            if (rsaDeform.VerifySignature(data,signature))
            {
                result = true;
            }
              
            

            return result;
        }






    }
}
