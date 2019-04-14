using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _190414_1_OOP_Statik_Metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //StaticMetotClass d = new StaticMetotClass();//static olarak tanımlanmış bir metot ,değişkeni örneklemeye gerek yoktur//programdan önce statici okur ramda herzaman hazırdır
            string[] x = new string[10];
            //int sayi = StaticMetotClass.c;
            //label2.Text = sayi.ToString();
            label2.Text = StaticMetotClass.c.ToString(); //direk çağıralabilir

            for (int i = 0; i < StaticMetotClass.isimListesi().Length; i++)
            {
                listBox1.Items.Add(StaticMetotClass.isimListesi()[i]); //dizi döndüren bir metot bu şekilde çalışır;
            }

            listBox1.Items.Add("**************");

            foreach (var item in StaticMetotClass.isimListesi())
            {
                listBox1.Items.Add(item);
            }
            label3.Text = StaticMetotClass.isimListesi()[3];// dizi döndüren metodun içinde istenilen bir elemanı çağırmak 
        }
    }
}
