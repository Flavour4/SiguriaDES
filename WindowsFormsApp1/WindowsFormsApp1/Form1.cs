using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using static System.Windows.Forms.LinkLabel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();



        private void EncryptFile(string source, string destination)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            FileStream fsInput = new FileStream(source, FileMode.Open, FileAccess.Read);
            FileStream fsEncrypted = new FileStream(destination, FileMode.Create, FileAccess.Write);

            DES.Key = Encoding.UTF8.GetBytes(txtCelesi.Text);
            DES.IV = Encoding.UTF8.GetBytes("11223344");
            ICryptoTransform desencrypt = DES.CreateEncryptor();
            CryptoStream cryptostream = new CryptoStream(fsEncrypted,
                                desencrypt,
                                CryptoStreamMode.Write);
            
            byte[] bytearrayinput = new byte[fsInput.Length];
            fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Close();
            fsInput.Close();
            fsEncrypted.Close();
        }
        private void DecryptFile(string source, string destination)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();

            DES.Key = Encoding.UTF8.GetBytes(txtCelesi.Text);
            DES.IV = Encoding.UTF8.GetBytes("11223344");

            FileStream fsread = new FileStream(source,
                                           FileMode.Open,
                                           FileAccess.Read);

            ICryptoTransform desdecrypt = DES.CreateDecryptor();
            FileStream fswrite = new FileStream(destination, FileMode.Create, FileAccess.Write);
            CryptoStream cryptostreamDecr = new CryptoStream(fswrite,
                                                         desdecrypt,
                                                         CryptoStreamMode.Write);
            
            byte[] byteinput = new byte[fsread.Length];
            fsread.Read(byteinput, 0, byteinput.Length);

            cryptostreamDecr.Write(byteinput, 0, byteinput.Length);

            fsread.Close();
            fswrite.Close();
        }


        string fajlli = "C:\\Users\\melos\\Desktop\\MyFile.txt";
        private void EncryptFile2des(string source, string destination)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            FileStream fsread = new FileStream(source, FileMode.Open, FileAccess.Read);
            FileStream fswrite = new FileStream(destination, FileMode.Create, FileAccess.Write);
            FileStream fsfajlliwrite = new FileStream(fajlli, FileMode.Create, FileAccess.Write);



            DES.Key = Encoding.UTF8.GetBytes(txtCelesi.Text);
            DES.IV = Encoding.UTF8.GetBytes("11223344");
            DES.Mode = CipherMode.CBC;
            ICryptoTransform desencrypt = DES.CreateEncryptor();
            ICryptoTransform desdecrypt = DES.CreateDecryptor();

            CryptoStream cryptostream = new CryptoStream(fsfajlliwrite,
                                desencrypt,
                                CryptoStreamMode.Write);
            byte[] bytearrayinput = new byte[fsread.Length];

            fsread.Read(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Close();
            fsfajlliwrite.Close();
            FileStream fsfajlliopen = new FileStream(fajlli, FileMode.Open, FileAccess.Read);


            CryptoStream crptstream = new CryptoStream(fswrite, desencrypt, CryptoStreamMode.Write);

            byte[] bytearrayinput1 = new byte[fsfajlliopen.Length];
            fsfajlliopen.Read(bytearrayinput1, 0, bytearrayinput1.Length);
            crptstream.Write(bytearrayinput1, 0, bytearrayinput1.Length);
            crptstream.Close();
            fsread.Close();
            fsfajlliopen.Close();
            fswrite.Close();

        }
        private void DecryptFile2des(string source, string destination)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            FileStream fsread = new FileStream(source, FileMode.Open, FileAccess.Read);
            FileStream fswrite = new FileStream(destination, FileMode.Create, FileAccess.Write);
            FileStream fsfajlliwrite = new FileStream(fajlli, FileMode.Create, FileAccess.Write);

            DES.Key = Encoding.UTF8.GetBytes(txtCelesi.Text);
            DES.IV = Encoding.UTF8.GetBytes("11223344");
            ICryptoTransform desdecrypt = DES.CreateDecryptor();

            CryptoStream cryptostream = new CryptoStream(fsfajlliwrite,
                                desdecrypt,
                                CryptoStreamMode.Write);
            byte[] bytearrayinput = new byte[fsread.Length];

            fsread.Read(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Close();
            fsfajlliwrite.Close();
            FileStream fsfajlliopen = new FileStream(fajlli, FileMode.Open, FileAccess.Read);
            CryptoStream crptstream = new CryptoStream(fswrite, desdecrypt, CryptoStreamMode.Write);


            byte[] bytearrayinput1 = new byte[fsfajlliopen.Length];
            fsfajlliopen.Read(bytearrayinput1, 0, bytearrayinput1.Length);
            crptstream.Write(bytearrayinput1, 0, bytearrayinput1.Length);

            //cryptostream.Flush();
            //crptstream.Flush();
            cryptostream.Close();
            crptstream.Close();
            fsread.Close();
            fswrite.Close();
            fsfajlliopen.Close();
        }




        private void EncryptFile3des(string source, string destination)
        {
            TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
            DES.Key = Encoding.UTF8.GetBytes(txtCelesi.Text);
            DES.IV = Encoding.UTF8.GetBytes("11223344");
            // Create a FileStream object to read in the source file.
            FileStream fsInput = new FileStream(source, FileMode.Open, FileAccess.Read);
            // Create a byte array from the FileStream object by reading in the source file.

            byte[] abytInput = new byte[fsInput.Length];
            fsInput.Read(abytInput, 0, Convert.ToInt32(fsInput.Length));
            

            // Create a FileStream object to write to a temp file.

            FileStream fsCipherText = new FileStream(destination, FileMode.Create, FileAccess.Write);
            fsCipherText.SetLength(0);

            // Create a Crypto Stream that transforms the file stream using the chosen 
            // encryption and writes it to the output FileStream object.
            ICryptoTransform desencrypt = DES.CreateEncryptor();
            CryptoStream csEncrypted = new CryptoStream(fsCipherText, desencrypt,
                CryptoStreamMode.Write);
            csEncrypted.Write(abytInput, 0, abytInput.Length);
            csEncrypted.Close();
            fsInput.Close();
            fsCipherText.Close();

        }
        private void DecryptFile3des(string source, string destination)
        {
            TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();

            DES.Key = Encoding.UTF8.GetBytes(txtCelesi.Text);
            DES.IV = Encoding.UTF8.GetBytes("11223344");

            FileStream fsread = new FileStream(source,
                                           FileMode.Open,
                                           FileAccess.Read);

            ICryptoTransform desdecrypt = DES.CreateDecryptor();
            FileStream fswrite = new FileStream(destination, FileMode.Create, FileAccess.Write);
            CryptoStream cryptostreamDecr = new CryptoStream(fswrite,
                                                         desdecrypt,
                                                         CryptoStreamMode.Write);

 
            byte[] byteinput = new byte[fsread.Length];
            fsread.Read(byteinput, 0, byteinput.Length);
            cryptostreamDecr.Write(byteinput, 0, byteinput.Length);
            fsread.Close();
            fswrite.Close();

        }





        private void Ngarko_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string source = ofd.FileName;
                string path = source.ToString();
                txtFile.Text = path;
            }
        }

        private void btnEnkriptoDES_Click(object sender, EventArgs e)
        {
            string source = ofd.FileName;
            saveFileDialog1.Filter = "Text Format(*.txt)| *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string destination = saveFileDialog1.FileName;
                EncryptFile(source, destination);
            }
        }

        private void btnEnkripto3DES_Click(object sender, EventArgs e)
        {
            string source = ofd.FileName;
            saveFileDialog1.Filter = "Text Format(*.txt)| *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string destination = saveFileDialog1.FileName;
                EncryptFile3des(source, destination);
            }
        }

        private void btnDekripto_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Text Format(*.txt)| *.txt";

                string source = ofd.FileName;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string destination = saveFileDialog1.FileName;
                    DecryptFile(source, destination);
                }

            MessageBox.Show("U Dekriptua me sukses");
        }


        private void btnDekripto3DES_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Text Format(*.txt)| *.txt";
                string source = ofd.FileName;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string destination = saveFileDialog1.FileName;
                    DecryptFile3des(source, destination);
                }
            MessageBox.Show("U Dekriptua me sukses");
        }


        private void btnDekripto2DES_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Text Format(*.txt)| *.txt";
            string source = ofd.FileName;
            string fajlli = "C:\\Users\\melos\\Desktop\\MyFile.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string destination = saveFileDialog1.FileName;
                DecryptFile2des(source, destination);
            }

            MessageBox.Show("U Dekriptua me sukses");
        }

        private void btnEkripto2DES_Click(object sender, EventArgs e)
        {
            string source = ofd.FileName;
            string fajlli = "C:\\Users\\melos\\Desktop\\MyFile.txt";
            saveFileDialog1.Filter = "Text Format(*.txt)| *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string destination = saveFileDialog1.FileName;
                EncryptFile2des(source, destination);
            }
        }
    }
}
