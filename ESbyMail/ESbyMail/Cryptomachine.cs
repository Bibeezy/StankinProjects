using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Windows;

namespace ESbyMail
{
    class Cryptomachine
    {
        private static byte[] iv = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8 };   // Вектор инициализации
        private static string cryptoKey = "NikiYaniLeetBoyzNikiYaniLeetBoyz";

        public static bool EncryptData(string sourceFile)
        {
            try
            {
                FileInfo file = new FileInfo(sourceFile);
                FileStream inFileStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
                FileStream outFileStream = new FileStream(sourceFile+" enc"+file.Extension, FileMode.Create, FileAccess.Write);
                outFileStream.SetLength(0);
                byte[] bin = new byte[100]; //This is intermediate storage for the encryption.
                long rdlen = 0;  // This is the total number of bytes written.
                long totlen = inFileStream.Length; // This is the total length of the input file.
                int len;   // This is the number of bytes to be written at a time.

                AesManaged AESProvider = new AesManaged();

                AESProvider.Key = ASCIIEncoding.ASCII.GetBytes(cryptoKey);
                AESProvider.IV = iv;
                ICryptoTransform AESEncrypt = AESProvider.CreateEncryptor(AESProvider.Key, AESProvider.IV);
                CryptoStream cryptoStream = new CryptoStream(outFileStream, AESEncrypt, CryptoStreamMode.Write);
                while (rdlen < totlen)
                {
                    len = inFileStream.Read(bin, 0, 100);
                    cryptoStream.Write(bin, 0, len);
                    rdlen = rdlen + len;
                }

                cryptoStream.Close();
                inFileStream.Close();
                outFileStream.Close();
                MessageBox.Show("Gotovo", "Kaif", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }

            catch (Exception e)
            {

                MessageBox.Show(e.ToString(), "Ошибка Шифрования", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool DecryptData(String sourceFile)
        {
            try
            {
                FileInfo file = new FileInfo(sourceFile);
                FileStream inFileStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
                FileStream outFileStream = new FileStream(file.FullName.Replace("enc","dec"), FileMode.Create, FileAccess.Write);
                outFileStream.SetLength(0);
                byte[] bin = new byte[100]; //This is intermediate storage for the encryption.
                long rdlen = 0;  // This is the total number of bytes written.
                long totlen = inFileStream.Length; // This is the total length of the input file.
                int len;   // This is the number of bytes to be written at a time.

                AesManaged AESProvider = new AesManaged();
                AESProvider.Key = ASCIIEncoding.ASCII.GetBytes(cryptoKey);
                //Initialize the initialization vector
                AESProvider.IV = iv;
                ICryptoTransform AESDecrypt = AESProvider.CreateDecryptor(AESProvider.Key, AESProvider.IV);


                CryptoStream cryptoStream = new CryptoStream(outFileStream, AESDecrypt, CryptoStreamMode.Write);
                while (rdlen < totlen)
                {
                    len = inFileStream.Read(bin, 0, 100);
                    cryptoStream.Write(bin, 0, len);
                    rdlen = rdlen + len;
                }
                cryptoStream.Close();
                inFileStream.Close();
                outFileStream.Close();
                return true;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Ошибка Расшифровки",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return false;
            }
        }
    

} 
}

