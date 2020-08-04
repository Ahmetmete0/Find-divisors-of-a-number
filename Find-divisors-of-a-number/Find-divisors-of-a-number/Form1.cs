using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58) 
            {
                e.Handled = false; //Eğer basılan tuş rakam ise textbox'a yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false; //Eğer basılan tuş boşluk ise textbox'a yazdır.
            }

            else //Boşluk veya rakam değil ise ekrana yazdırma ve uyarı çıkar.
            {
                MessageBox.Show("0,Harf veya Negatif Değer Girilmez...");
                e.Handled = true;
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58) 
            {
                e.Handled = false; //Eğer basılan tuş rakam ise textbox'a yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false; //Eğer basılan tuş boşluk ise textbox'a yazdır.
            }

            else //Boşluk veya rakam değil ise ekrana yazdırma ve uyarı çıkar.
            {
                MessageBox.Show("0,Harf veya Negatif Değer Girilmez...");
                e.Handled = true;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {}
        private void textBox2_TextChanged(object sender, EventArgs e)
        {}
      
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1,sayi2;
            
            this.Width = 600; //Butona basıldığı anda formun genişliğini arttırmak için.
            this.Height = 300; //Butona basıldığı anda formun yüksekliğini arttırmak için.

            ListBox ListBox1 = new ListBox(); //Butona basıldığında "ListBox1" i oluşturup ekrana çıkartması için.
            ListBox1.Location = new System.Drawing.Point(225, 50);
            ListBox1.Size = new System.Drawing.Size(100, 125);
            this.Controls.Add(ListBox1);

            ListBox ListBox2 = new ListBox(); //Butona basıldığında "ListBox2" yi oluşturup ekrana çıkartması için.
            ListBox2.Location = new System.Drawing.Point(350, 50);
            ListBox2.Size = new System.Drawing.Size(100, 125);
            this.Controls.Add(ListBox2);

            TextBox yeniTextbox = new TextBox(); // Butona basıldığında yeni bir textbox çıkartmak için.
            yeniTextbox.Location = new System.Drawing.Point(225, 185);
            yeniTextbox.Size = new System.Drawing.Size(100, 125);      
            this.Controls.Add(yeniTextbox);

            TextBox yeniTextbox2 = new TextBox(); // Butona basıldığında yeni bir textbox çıkartmak için.
            yeniTextbox2.Location = new System.Drawing.Point(350, 185);
            yeniTextbox2.Size = new System.Drawing.Size(100, 125);
            this.Controls.Add(yeniTextbox2);

            Label label = new Label(); //Butona basıldığında yeni bir label oluşturmak ve ekrana çıkartmak için.
            label.Text = "X";
            label.Location = new System.Drawing.Point(265, 25);
            label.Size = new System.Drawing.Size(100, 125);
            this.Controls.Add(label);        

            Label label2 = new Label(); //Butona basıldığında yeni bir label oluşturmak ve ekrana çıkartmak için.
            label2.Text = "Y";
            label2.Location = new System.Drawing.Point(390, 25);
            label2.Size = new System.Drawing.Size(100, 125);
            this.Controls.Add(label2);

            Label label3 = new Label(); //Butona basıldığında yeni bir label oluşturmak ve ekrana çıkartmak için.
            label3.Text = "TOPLAMLAR";
            label3.Location = new System.Drawing.Point(140, 190);
            label3.Size = new System.Drawing.Size(100, 125);
            this.Controls.Add(label3);
            
            if (string.IsNullOrEmpty(textBox1.Text)) //Textbox1'in boş bırakılmasını engellemek için.
            {
                MessageBox.Show("Boş Bırakmayınız...");
            }

            else if(string.IsNullOrEmpty(textBox2.Text)) //Textbox2'nin boş bırakılmasını engellemek için.
            {
                MessageBox.Show("Boş Bırakmayınız...");
            }

           else
           {

                ListBox1.Items.Clear(); //Butona tıklandığında eskiden kalan yazıları silerek yenileri için yer ayırır ve aynı sayıların 2 kere yazılmasını önler
                ListBox2.Items.Clear(); //Butona tıklandığında eskiden kalan yazıları silerek yenileri için yer ayırır ve aynı sayıların 2 kere yazılmasını önler
                       
                sayi1 = Convert.ToInt32(textBox1.Text);
                int toplam1 = 0;
                for (int i = 1; i < sayi1; i++)
                {
                    if (sayi1 % i == 0) //Girilen sayının bölenlerini bulur ve sayının tam bölenlerini ListBox1'e yazdırır
                    {
                        ListBox1.Items.Add(i);
                        toplam1 += i;
                        yeniTextbox.Text = Convert.ToString(toplam1);                        
                    }                  
                }

                sayi2 = Convert.ToInt32(textBox2.Text);
                int toplam2 = 0;
                for (int j = 1; j < sayi2; j++) //Girilen sayının bölenlerini bulur ve sayının tam bölenlerini ListBox1'e yazdırır
                {
                    if (sayi2 % j == 0)
                    {
                        ListBox2.Items.Add(j);
                        toplam2 += j;
                        yeniTextbox2.Text = Convert.ToString(toplam2);                     
                    }                    
                }            
           }
        }
            private void button2_Click(object sender, EventArgs e)
            {
                Application.Exit(); //Uygulamadan çıkışı sağlar.
            }         
    }
}
