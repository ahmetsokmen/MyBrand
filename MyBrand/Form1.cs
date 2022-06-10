using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyBrand
{
    public partial class Form1 : Form
    {
        public List<string> Chars { get; }
        public List<Label> Words { get; }


        public Form1()
        {
            InitializeComponent();
            List<string> charList = new List<string> { "a", "e", "i", "ö", "ü", "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "r", "s", "t", "v", "w", "y", "z" };

            List<Label> brandList = new List<Label> { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20, label21, label22, label23, label24, label25, label26, label27, label28, label29, label30, label31, label32, label33, label34, label35, label36, label37, label38, label39, label40, label41, label42, label43, label44, label45, label46, label47, label48, label49, label50, label51, label52, label53, label54, label55, label56, label57, label58, label59, label60, label61, label62, label63, label64, label65, label66, label67, label68, label69, label70, label71, label72 };

            this.Chars = charList;
            this.Words = brandList;

        }

        public void CloseIt()
        {
            System.Threading.Thread.Sleep(2000);
            Interaction.AppActivate(
                 System.Diagnostics.Process.GetCurrentProcess().Id);
            SendKeys.SendWait(" ");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn = this.Controls.Find("btnBrand", true)[0] as Button;
            btn.BackColor = Color.FromArgb(255, 212, 56);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(255, 212, 56);
            btn.FlatAppearance.BorderSize = 1;


        }

        public void WriteToFile(string brandName)
        {

            if (!Directory.Exists("C:\\MyBrand"))
            {
                Directory.CreateDirectory("C:\\MyBrand");
            }
            string dosya_yolu = @"C:\MyBrand\MyBrand.txt";



            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            StreamWriter sw = new StreamWriter(fs);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.

            sw.Write(brandName);
            sw.Write("\n");
            //Dosyaya ekleyeceğimiz iki satırlık yazıyı WriteLine() metodu ile yazacağız.
            sw.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
        }

        private void brand_click(object sender, EventArgs e)
        {

            Label clickedLabel = sender as Label;
            string clickedLabelToString = clickedLabel.Text.ToString();

            if (clickedLabel != null && clickedLabelToString != "xxxxx")
            {
                try
                {
                    WriteToFile(clickedLabelToString);
                    (new System.Threading.Thread(CloseIt)).Start();
                    MessageBox.Show(clickedLabelToString + " has been created succesfully ! \nYou can find it in C:\\MyBrand\\MyBrand.txt", " Saved");



                }
                catch (Exception)
                {

                    MessageBox.Show("Error!");
                }
            }
        }



        private void btnBrand_Click(object sender, EventArgs e)
        {

            if (txtPattern.Text == "xxxx")
            {
                foreach (var word in Words)
                {


                    var first = RandomNumberCreator.RandomNumber(0, 23);
                    var second = RandomNumberCreator.RandomNumber(0, 23);
                    var third = RandomNumberCreator.RandomNumber(0, 23);
                    var fourth = RandomNumberCreator.RandomNumber(0, 23);
                   



                    word.Text = Chars[first] + Chars[second] + Chars[third] + Chars[fourth];

                }


            }
            if (txtPattern.Text == "xxxxx")
            {
                foreach (var word in Words)
                {


                    var first = RandomNumberCreator.RandomNumber(0, 23);
                    var second = RandomNumberCreator.RandomNumber(0, 23);
                    var third = RandomNumberCreator.RandomNumber(0, 23);
                    var fourth = RandomNumberCreator.RandomNumber(0, 23);
                    var fifth = RandomNumberCreator.RandomNumber(0, 23);



                    word.Text = Chars[first] + Chars[second] + Chars[third] + Chars[fourth] + Chars[fifth];

                }


            }

            else if (txtPattern.Text == "xxxxxx")
            {
                foreach (var word in Words)
                {
                    var first = RandomNumberCreator.RandomNumber(0, 23);
                    var second = RandomNumberCreator.RandomNumber(0, 23);
                    var third = RandomNumberCreator.RandomNumber(0, 23);
                    var fourth = RandomNumberCreator.RandomNumber(0, 23);
                    var fifth = RandomNumberCreator.RandomNumber(0, 23);
                    var sixth = RandomNumberCreator.RandomNumber(0, 23);




                    word.Text = Chars[first] + Chars[second] + Chars[third] + Chars[fourth] + Chars[fifth] + Chars[sixth];

                }
            }

            else if (txtPattern.Text == "xxxxxxx")
            {
                foreach (var word in Words)
                {
                    var first = RandomNumberCreator.RandomNumber(0, 23);
                    var second = RandomNumberCreator.RandomNumber(0, 23);
                    var third = RandomNumberCreator.RandomNumber(0, 23);
                    var fourth = RandomNumberCreator.RandomNumber(0, 23);
                    var fifth = RandomNumberCreator.RandomNumber(0, 23);
                    var sixth = RandomNumberCreator.RandomNumber(0, 23);
                    var seventh = RandomNumberCreator.RandomNumber(0, 23);





                    word.Text = Chars[first] + Chars[second] + Chars[third] + Chars[fourth] + Chars[fifth] + Chars[sixth] + Chars[seventh];

                }

            }

            else if (txtPattern.Text == "xxxxxxxx")
            {
                foreach (var word in Words)
                {
                    var first = RandomNumberCreator.RandomNumber(0, 23);
                    var second = RandomNumberCreator.RandomNumber(0, 23);
                    var third = RandomNumberCreator.RandomNumber(0, 23);
                    var fourth = RandomNumberCreator.RandomNumber(0, 23);
                    var fifth = RandomNumberCreator.RandomNumber(0, 23);
                    var sixth = RandomNumberCreator.RandomNumber(0, 23);
                    var seventh = RandomNumberCreator.RandomNumber(0, 23);
                    var eighth = RandomNumberCreator.RandomNumber(0, 23);





                    word.Text = Chars[first] + Chars[second] + Chars[third] + Chars[fourth] + Chars[fifth] + Chars[sixth] + Chars[seventh] + Chars[eighth];

                }

            }

            else
            {
                foreach (var word in Words)
                {
                    var notXList = new List<KeyValuePair<int, string>>();

                    var xList = new List<KeyValuePair<int, string>>();

                    for (int i = 0; i < txtPattern.Text.Length; i++)
                    {
                        var character = txtPattern.Text[i].ToString();

                        if (character != "x")
                        {
                            var abc = new KeyValuePair<int, string>(i, character);
                            notXList.Add(abc);
                        }

                        else
                        {
                            var xyz = new KeyValuePair<int, string>(i, character);
                            xList.Add(xyz);
                        }

                        StringBuilder sb = new StringBuilder(txtPattern.Text);

                        foreach (var item in xList)
                        {


                            sb[item.Key] = Convert.ToChar(Chars[RandomNumberCreator.RandomNumber(0, 23)]);


                        }

                        word.Text = sb.ToString();

                    } 
                }
            }

        }



        private void rdb4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb4.Checked)
            {
                txtPattern.MaxLength = 4;

                if (txtPattern.Text.Length != 4)
                {
                    txtPattern.Text = "xxxx";
                    Words.ForEach(x => x.Text = "xxxx");
                }

            }



            return;
        }

        private void rdb5_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb5.Checked)
            {
                txtPattern.MaxLength = 5;

                if (txtPattern.Text.Length != 5)
                {
                    txtPattern.Text = "xxxxx";
                    Words.ForEach(x => x.Text = "xxxxx");
                }

            }



            return;
        }

        private void rdb6_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb6.Checked)
            {
                txtPattern.MaxLength = 6;

                if (txtPattern.Text.Length != 6)
                {
                    txtPattern.Text = "xxxxxx";
                    Words.ForEach(x => x.Text = "xxxxxx");

                }
            }


            return;

        }

        private void rdb7_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb7.Checked)
            {
                txtPattern.MaxLength = 7;

                if (txtPattern.Text.Length != 7)
                {
                    txtPattern.Text = "xxxxxxx";
                    Words.ForEach(x => x.Text = "xxxxxxx");

                }

            }


            return;

        }

        private void rdb8_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb8.Checked)
            {
                txtPattern.MaxLength = 8;

                if (txtPattern.Text.Length != 8)
                {
                    txtPattern.Text = "xxxxxxxx";
                    Words.ForEach(x => x.Text = "xxxxxxxx");

                }

            }


            return;
        }

        private void lblContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All rights of this application reserved by Aventta Agency. For more information, visit our web site via www.aventta.com", "mybrand v2.0.0");
        }
    }
}
