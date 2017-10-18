using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("Deneme", "Benzetim Zamanı");
            dataGridView1.Columns.Add("Deneme", "Başlangıç Stok Seviyesi Logo Havalı Poşet");
            dataGridView1.Columns.Add("Deneme", "Başlangıç Stok Seviyesi Standart Kutu");
            dataGridView1.Columns.Add("Deneme", "Başlangıç Stok Seviyesi Hava Kanallı Ambalaj");
            dataGridView1.Columns.Add("Deneme", "Başlangıç Stok Seviyesi Havalı Paket");
            dataGridView1.Columns.Add("Deneme", "Başlangıç Stok Seviyesi Hediye Kutu");
            dataGridView1.Columns.Add("Deneme", "Başlangıç Stok Seviyesi Standart Poşet");

            dataGridView1.Columns.Add("Deneme", "İhtiyaç Duyulan Paket Cinsi");
            dataGridView1.Columns.Add("Deneme", "Adet");

            dataGridView1.Columns.Add("Deneme", "Elde Kalan Miktar Logo Havalı Poşet");
            dataGridView1.Columns.Add("Deneme", "Elde Kalan Miktar Standart Kutu");
            dataGridView1.Columns.Add("Deneme", "Elde Kalan Miktar Hava Kanallı Ambalaj");
            dataGridView1.Columns.Add("Deneme", "Elde Kalan Miktar Havalı Paket");
            dataGridView1.Columns.Add("Deneme", "Elde Kalan Miktar Hediye Kutu");
            dataGridView1.Columns.Add("Deneme", "Elde Kalan Miktar Standart Poşet");

            dataGridView1.Columns.Add("Deneme", "Karşılanamayan Adet");


            dataGridView1.Columns.Add("Deneme", "Stok Pozisyonu Logo Havalı Poşet");
            dataGridView1.Columns.Add("Deneme", "Stok Pozisyonu Standart Kutu");
            dataGridView1.Columns.Add("Deneme", "Stok Pozisyonu Hava Kanallı Ambalaj");
            dataGridView1.Columns.Add("Deneme", "Stok Pozisyonu Havalı Paket");
            dataGridView1.Columns.Add("Deneme", "Stok Pozisyonu Hediye Kutu");
            dataGridView1.Columns.Add("Deneme", "Stok Pozisyonu Standart Poşet");


            dataGridView1.Columns.Add("Deneme", "Açılan Sipariş Logo Havalı Poşet");
            dataGridView1.Columns.Add("Deneme", "Açılan Sipariş Standart Kutu");
            dataGridView1.Columns.Add("Deneme", "Açılan Sipariş Hava Kanallı Ambalaj");
            dataGridView1.Columns.Add("Deneme", "Açılan Sipariş Havalı Paket");
            dataGridView1.Columns.Add("Deneme", "Açılan Sipariş Hediye Kutu");
            dataGridView1.Columns.Add("Deneme", "Açılan Sipariş Standart Poşet");

            dataGridView1.Columns.Add("Deneme", "Tedarik Süresi");
            dataGridView1.Columns.Add("Deneme", "Elde Bulundurma Maliyeti");
            dataGridView1.Columns.Add("Deneme", "Ceza Maliyeti");
            dataGridView1.Columns.Add("Deneme", "Sipariş Maliyeti");
            dataGridView1.Columns.Add("Deneme", "Toplam Maliyet");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int benz = 0;
            if (textBox1.TextLength > 0)
            {
                benz = Convert.ToInt32(textBox1.Text);
                label11.Text = benz.ToString();
            }
            if (benz < 2)
            {
                MessageBox.Show("Benztim zamanını bir den büyük giriniz", "Hata!!");
            }


            //işlemler

            if (benz > 1)
            {
                benz++;
                int[] bas_logo_havali       = new int[benz];
                int[] bas_standart_kutu     = new int[benz];
                int[] bas_hava_kanalli      = new int[benz];
                int[] bas_havali_paket      = new int[benz];
                int[] bas_hediye_kutu       = new int[benz];
                int[] bas_standart_poset    = new int[benz];

                int[] elde_logo_havali      = new int[benz];
                int[] elde_standart_kutu    = new int[benz];
                int[] elde_hava_kanalli     = new int[benz];
                int[] elde_havali_paket     = new int[benz];
                int[] elde_hediye_kutu      = new int[benz];
                int[] elde_standart_poset   = new int[benz];

                int[] stok_logo_havali      = new int[benz];
                int[] stok_standart_kutu    = new int[benz];
                int[] stok_hava_kanalli     = new int[benz];
                int[] stok_havali_paket     = new int[benz];
                int[] stok_hediye_kutu      = new int[benz];
                int[] stok_standart_poset   = new int[benz];

                int[] acilan_logo_havali    = new int[benz];
                int[] acilan_standart_kutu  = new int[benz];
                int[] acilan_hava_kanalli   = new int[benz];
                int[] acilan_havali_paket   = new int[benz];
                int[] acilan_hediye_kutu    = new int[benz];
                int[] acilan_standart_poset = new int[benz];

                int[] ihtiyac           = new int[benz];
                int[] talep             = new int[benz];
                int[] karsilanamayan    = new int[benz];
                int[] tedarik           = new int[benz];
                double[] eldeBulundurma = new double[benz];
                int[] cezaMaliyeti      = new int[benz];
                int[] siparisMaliyeti   = new int[benz];
                double[] toplamMaliyet  = new double[benz];
                int[] benzetimZamani    = new int[benz];

                double toplamElde = 0;
                int toplamCeza = 0;
                int toplamSiparis = 0;
                double toplamMa = 0;

                Random rastgele = new Random();
                for (int i = 1; i < benz; i++)
                {


                    double bz = rastgele.NextDouble();
                    benzetimZamani[i] = i;
                    if (bz <= 0.0599)
                        ihtiyac[i] = 1;
                    else if (bz >= 0.06 && bz < 0.21)
                        ihtiyac[i] = 2;
                    else if (bz >= 0.21 && bz < 0.31)
                        ihtiyac[i] = 3;
                    else if (bz >= 0.31 && bz < 0.41)
                        ihtiyac[i] = 4;   //rs değerine karşılık gelen kan grubunun numarası girilir
                    else if (bz >= 0.41 && bz < 0.51)
                        ihtiyac[i] = 5;
                    else if (bz >= 0.51 && bz < 0.56)
                        ihtiyac[i] = 6;
                    else if (bz >= 0.56 && bz < 0.95)
                        ihtiyac[i] = 7;
                    else if (bz >= 0.95 && bz <= 1)
                        ihtiyac[i] = 8;

                    double tbz = rastgele.NextDouble(); //talep miktarı için üretilen rs değeri
                    if (tbz <= 0.1099)
                        talep[i] = 1;
                    else if (tbz >= 0.1100 && tbz <= 0.5099)
                        talep[i] = 2;
                    else if (tbz >= 0.5100 && tbz <= 0.7099)
                        talep[i] = 3;         //ihtiyaç duyulan paket miktarı
                    else if (tbz >= 0.7100 && tbz <= 0.8599)
                        talep[i] = 4;
                    else if (tbz >= 0.8600 && tbz <= 0.9599)
                        talep[i] = 5;
                    else if (tbz >= 0.9600 && tbz <= 1.0000)
                        talep[i] = 6;


                    if (i == 1)  //başlangıç ta paket miktarları belirlenir
                    {
                        bas_logo_havali[1]      = 85;
                        bas_standart_kutu[1]    = 78;
                        bas_hava_kanalli[1]     = 45;
                        bas_havali_paket[1]     = 78;
                        bas_hediye_kutu[1]      = 57;
                        bas_standart_poset[1]   = 92;

                        stok_logo_havali[1]     = 85;
                        stok_standart_kutu[1]   = 78;
                        stok_hava_kanalli[1]    = 45;
                        stok_havali_paket[1]    = 78;
                        stok_hediye_kutu[1]     = 57;
                        stok_standart_poset[1]  = 92;
                    }
                    //-----------------------------

                    if (ihtiyac[i] == 1) //Rulo pakete ihtiyaç var ise 
                                         //(logo havalı poşet ,standart kutu,hava kanallı ambalaj,havalı paket,hediye kutu,standart paket) 
                                        //hangisi fazla ise o seçilir  
                    {                    //stok pozisyonu ayarlanır
                        if (bas_logo_havali[i] >= bas_hava_kanalli[i] && bas_logo_havali[i] >= bas_hediye_kutu[i])
                        {
                            if ((bas_logo_havali[i] - talep[i]) >= 0)
                            {
                                if (i < benz - 1)
                                {
                                    bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + bas_logo_havali[i] - talep[i];
                                    bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + bas_standart_kutu[i];
                                    bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + bas_hava_kanalli[i];
                                    bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + bas_havali_paket[i];
                                    bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + bas_hediye_kutu[i];
                                    bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + bas_standart_poset[i];
                                }
                                karsilanamayan[i] = 0;
                            }
                            else
                            {
                                if (i < benz - 1)
                                {
                                    bas_logo_havali[i + 1] = 0;
                                    bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + bas_standart_kutu[i];
                                    bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + bas_hava_kanalli[i];
                                    bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + bas_havali_paket[i];
                                    bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + bas_hediye_kutu[i];
                                    bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + bas_standart_poset[i];
                                }
                                karsilanamayan[i] = talep[i] - bas_logo_havali[i];
                            }
                            if (i < benz - 1)
                            {
                                elde_logo_havali[i] = bas_logo_havali[i + 1];
                            }
                            if (i == benz - 1)
                            {
                                elde_logo_havali[i] = bas_logo_havali[i] - talep[i];
                            }
                            elde_standart_kutu[i] = bas_standart_kutu[i];
                            elde_hava_kanalli[i] = bas_hava_kanalli[i];
                            elde_havali_paket[i] = bas_havali_paket[i];     //elde kalan miktarlar yazdırılır
                            elde_hediye_kutu[i] = bas_hediye_kutu[i];
                            elde_standart_poset[i] = bas_standart_poset[i];
                            if (i == 1)
                            {
                                stok_logo_havali[i] = bas_logo_havali[i] - talep[i];
                            }
                            else
                            {
                                stok_logo_havali[i] = stok_logo_havali[i - 1] - talep[i] + acilan_logo_havali[i - 1];
                                stok_standart_kutu[i] = stok_standart_kutu[i - 1] + acilan_standart_kutu[i - 1];
                                stok_hava_kanalli[i] = stok_hava_kanalli[i - 1] + acilan_hava_kanalli[i - 1];
                                stok_havali_paket[i] = stok_havali_paket[i - 1] + acilan_havali_paket[i - 1];
                                stok_hediye_kutu[i] = stok_hediye_kutu[i - 1] + acilan_hediye_kutu[i - 1];
                                stok_standart_poset[i] = stok_standart_poset[i - 1] + acilan_standart_poset[i - 1];
                            }
                        }
                        else if (bas_hava_kanalli[i] >= bas_logo_havali[i] && bas_hava_kanalli[i] >= bas_hediye_kutu[i])
                        {
                            if ((bas_hava_kanalli[i] - talep[i]) >= 0)
                            {
                                if (i < benz - 1)
                                {
                                    bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + bas_hava_kanalli[i] - talep[i];
                                    bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + bas_logo_havali[i];
                                    bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + bas_standart_kutu[i];
                                    bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + bas_havali_paket[i];
                                    bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + bas_hediye_kutu[i];
                                    bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + bas_standart_poset[i];
                                }
                                karsilanamayan[i] = 0;
                            }
                            else
                            {
                                if (i < benz - 1)
                                {
                                    bas_hava_kanalli[i + 1] = 0;
                                    bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + bas_logo_havali[i];
                                    bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + bas_standart_kutu[i];
                                    bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + bas_havali_paket[i];
                                    bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + bas_hediye_kutu[i];
                                    bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + bas_standart_poset[i];
                                }
                                karsilanamayan[i] = talep[i] - bas_hava_kanalli[i];
                            }
                            elde_logo_havali[i] = bas_logo_havali[i];
                            elde_standart_kutu[i] = bas_standart_kutu[i];
                            if (i < benz - 1)
                                elde_hava_kanalli[i] = bas_hava_kanalli[i + 1];
                            if (i == benz - 1)
                            {
                                elde_hava_kanalli[i] = bas_hava_kanalli[i] - talep[i];
                            }
                            elde_havali_paket[i] = bas_havali_paket[i];  //elde kalan miktarlar yazdırılır
                            elde_hediye_kutu[i] = bas_hediye_kutu[i];
                            elde_standart_poset[i] = bas_standart_poset[i];

                            if (i == 1)
                                stok_hava_kanalli[i] = bas_hava_kanalli[i] - talep[i];
                            else {
                                stok_logo_havali[i] = stok_logo_havali[i - 1] + acilan_logo_havali[i - 1];
                                stok_standart_kutu[i] = stok_standart_kutu[i - 1] + acilan_standart_kutu[i - 1];
                                stok_hava_kanalli[i] = stok_hava_kanalli[i - 1] - talep[i] + acilan_hava_kanalli[i - 1];
                                stok_havali_paket[i] = stok_havali_paket[i - 1] + acilan_havali_paket[i - 1];
                                stok_hediye_kutu[i] = stok_hediye_kutu[i - 1] + acilan_hediye_kutu[i - 1];
                                stok_standart_poset[i] = stok_standart_poset[i - 1] + acilan_standart_poset[i - 1];
                            }
                        }
                        else if (bas_hediye_kutu[i] >= bas_logo_havali[i] && bas_hediye_kutu[i] >= bas_hava_kanalli[i])
                        {
                            if ((bas_hediye_kutu[i] - talep[i]) >= 0)
                            {
                                if (i < benz - 1)
                                {
                                    bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + bas_hediye_kutu[i] - talep[i];
                                    bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + bas_hava_kanalli[i];
                                    bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + bas_logo_havali[i];
                                    bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + bas_standart_kutu[i];
                                    bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + bas_havali_paket[i];
                                    bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + bas_standart_poset[i];
                                }
                                karsilanamayan[i] = 0;
                            }
                            else
                            {
                                if (i < benz - 1)
                                {
                                    bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + 0;
                                    bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + bas_hava_kanalli[i];
                                    bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + bas_logo_havali[i];
                                    bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + bas_standart_kutu[i];
                                    bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + bas_havali_paket[i];
                                    bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + bas_standart_poset[i];
                                }
                                karsilanamayan[i] = talep[i] - bas_hediye_kutu[i];
                            }
                            elde_logo_havali[i] = bas_logo_havali[i];
                            elde_standart_kutu[i] = bas_standart_kutu[i];
                            elde_hava_kanalli[i] = bas_hava_kanalli[i];
                            elde_havali_paket[i] = bas_havali_paket[i];     //elde kalan miktarlar yazdırılır
                            if (i < benz - 1)
                                elde_hediye_kutu[i] = bas_hediye_kutu[i + 1];
                            if (i == benz - 1)
                            {
                                elde_hediye_kutu[i] = bas_hediye_kutu[i] - talep[i];
                            }
                            elde_standart_poset[i] = bas_standart_poset[i];

                            if (i == 1)
                                stok_hediye_kutu[i] = bas_hediye_kutu[i] - talep[i];
                            else
                            {
                                stok_logo_havali[i] = stok_logo_havali[i - 1] + acilan_logo_havali[i - 1];
                                stok_standart_kutu[i] = stok_standart_kutu[i - 1] + acilan_standart_kutu[i - 1];
                                stok_hava_kanalli[i] = stok_hava_kanalli[i - 1] + acilan_hava_kanalli[i - 1];
                                stok_havali_paket[i] = stok_havali_paket[i - 1] + acilan_havali_paket[i - 1];
                                stok_hediye_kutu[i] = stok_hediye_kutu[i - 1] - talep[i] + acilan_hediye_kutu[i - 1];
                                stok_standart_poset[i] = stok_standart_poset[i - 1] + acilan_standart_poset[i - 1];
                            }
                        }
                    }
                    else if (ihtiyac[i] == 2)
                    {
                        if (bas_standart_kutu[i] >= bas_havali_paket[i] && bas_standart_kutu[i] >= bas_standart_poset[i])
                        {
                            if ((bas_standart_kutu[i] - talep[i]) >= 0)
                            {
                                if (i < benz - 1)
                                {
                                    bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + bas_standart_kutu[i] - talep[i];
                                    bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + bas_hava_kanalli[i];
                                    bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + bas_logo_havali[i];
                                    bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + bas_havali_paket[i];
                                    bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + bas_hediye_kutu[i];
                                    bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + bas_standart_poset[i];
                                }
                                karsilanamayan[i] = 0;
                            }
                            else
                            {
                                if (i < benz - 1)
                                {
                                    bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + 0;
                                    bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + bas_hava_kanalli[i];
                                    bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + bas_logo_havali[i];
                                    bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + bas_havali_paket[i];
                                    bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + bas_hediye_kutu[i];
                                    bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + bas_standart_poset[i];
                                }
                                karsilanamayan[i] = talep[i] - bas_standart_kutu[i];
                            }
                            elde_logo_havali[i] = bas_logo_havali[i];
                            if (i < benz - 1)
                                elde_standart_kutu[i] = bas_standart_kutu[i + 1];
                            if (i == benz - 1)
                            {
                                elde_standart_kutu[i] = bas_standart_kutu[i] - talep[i];
                            }
                            elde_hava_kanalli[i] = bas_hava_kanalli[i];
                            elde_havali_paket[i] = bas_havali_paket[i]; //elde kalan miktarlar yazdırılır
                            elde_hediye_kutu[i] = bas_hediye_kutu[i];
                            elde_standart_poset[i] = bas_standart_poset[i];

                            if (i == 1)
                                stok_standart_kutu[i] = bas_standart_kutu[i] - talep[i];
                            else
                            {
                                stok_logo_havali[i] = stok_logo_havali[i - 1] + acilan_logo_havali[i - 1];
                                stok_standart_kutu[i] = stok_standart_kutu[i - 1] - talep[i] + acilan_standart_kutu[i - 1];
                                stok_hava_kanalli[i] = stok_hava_kanalli[i - 1] + acilan_hava_kanalli[i - 1];
                                stok_havali_paket[i] = stok_havali_paket[i - 1] + acilan_havali_paket[i - 1];
                                stok_hediye_kutu[i] = stok_hediye_kutu[i - 1] + acilan_hediye_kutu[i - 1];
                                stok_standart_poset[i] = stok_standart_poset[i - 1] + acilan_standart_poset[i - 1];
                            }
                        }
                        else if (bas_havali_paket[i] >= bas_standart_kutu[i] && bas_havali_paket[i] >= bas_standart_poset[i])
                        {
                            if ((bas_havali_paket[i] - talep[i]) >= 0)
                            {
                                if (i < benz - 1)
                                {
                                    bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + bas_havali_paket[i] - talep[i];
                                    bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + bas_hava_kanalli[i];
                                    bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + bas_logo_havali[i];
                                    bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + bas_standart_kutu[i];
                                    bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + bas_hediye_kutu[i];
                                    bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + bas_standart_poset[i];
                                }
                                karsilanamayan[i] = 0;
                            }
                            else
                            {
                                if (i < benz - 1)
                                {
                                    bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + 0;
                                    bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + bas_hava_kanalli[i];
                                    bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + bas_logo_havali[i];
                                    bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + bas_standart_kutu[i];
                                    bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + bas_hediye_kutu[i];
                                    bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + bas_standart_poset[i];
                                }
                                karsilanamayan[i] = talep[i] - bas_havali_paket[i];
                            }
                            elde_logo_havali[i] = bas_logo_havali[i];
                            elde_standart_kutu[i] = bas_standart_kutu[i];
                            elde_hava_kanalli[i] = bas_hava_kanalli[i];
                            if (i < benz - 1)
                                elde_havali_paket[i] = bas_havali_paket[i + 1];  //elde kalan miktarlar yazdırılır
                            if (i == benz - 1)
                            {
                                elde_havali_paket[i] = bas_havali_paket[i] - talep[i];
                            }
                            elde_hediye_kutu[i] = bas_hediye_kutu[i];
                            elde_standart_poset[i] = bas_standart_poset[i];

                            if (i == 1)
                                stok_havali_paket[i] = bas_havali_paket[i] - talep[i];
                            else
                            {
                                stok_logo_havali[i] = stok_logo_havali[i - 1] + acilan_logo_havali[i - 1];
                                stok_standart_kutu[i] = stok_standart_kutu[i - 1] + acilan_standart_kutu[i - 1];
                                stok_hava_kanalli[i] = stok_hava_kanalli[i - 1] + acilan_hava_kanalli[i - 1];
                                stok_havali_paket[i] = stok_havali_paket[i - 1] - talep[i] + acilan_havali_paket[i - 1];
                                stok_hediye_kutu[i] = stok_hediye_kutu[i - 1] + acilan_hediye_kutu[i - 1];
                                stok_standart_poset[i] = stok_standart_poset[i - 1] + acilan_standart_poset[i - 1];
                            }
                        }
                        else if (bas_standart_poset[i] >= bas_standart_kutu[i] && bas_standart_poset[i] >= bas_havali_paket[i])
                        {
                            if ((bas_standart_poset[i] - talep[i]) >= 0)
                            {
                                if (i < benz - 1)
                                {
                                    bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + bas_standart_poset[i] - talep[i];
                                    bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + bas_hava_kanalli[i];
                                    bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + bas_logo_havali[i];
                                    bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + bas_standart_kutu[i];
                                    bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + bas_havali_paket[i];
                                    bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + bas_hediye_kutu[i];
                                }
                                karsilanamayan[i] = 0;
                            }
                            else
                            {
                                if (i < benz - 1)
                                {
                                    bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + 0;
                                    bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + bas_hava_kanalli[i];
                                    bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + bas_logo_havali[i];
                                    bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + bas_standart_kutu[i];
                                    bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + bas_havali_paket[i];
                                    bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + bas_hediye_kutu[i];
                                }
                                karsilanamayan[i] = talep[i] - bas_standart_poset[i];
                            }
                            elde_logo_havali[i] = bas_logo_havali[i];
                            elde_standart_kutu[i] = bas_standart_kutu[i];
                            elde_hava_kanalli[i] = bas_hava_kanalli[i];
                            elde_havali_paket[i] = bas_havali_paket[i];     //elde kalan miktarlar yazdırılır
                            elde_hediye_kutu[i] = bas_hediye_kutu[i];

                            if (i < benz - 1)
                                elde_standart_poset[i] = bas_standart_poset[i + 1];
                            if (i == benz - 1)
                            {
                                elde_standart_poset[i] = bas_standart_poset[i] - talep[i];
                            }
                            if (i == 1)
                            {
                                stok_standart_poset[i] = bas_standart_poset[i] - talep[i];
                            }
                            else
                            {
                                stok_logo_havali[i] = stok_logo_havali[i - 1] + acilan_logo_havali[i - 1];
                                stok_standart_kutu[i] = stok_standart_kutu[i - 1] + acilan_standart_kutu[i - 1];
                                stok_hava_kanalli[i] = stok_hava_kanalli[i - 1] + acilan_hava_kanalli[i - 1];
                                stok_havali_paket[i] = stok_havali_paket[i - 1] + acilan_havali_paket[i - 1];
                                stok_hediye_kutu[i] = stok_hediye_kutu[i - 1] + acilan_hediye_kutu[i - 1];
                                stok_standart_poset[i] = stok_standart_poset[i - 1] - talep[i] + acilan_standart_poset[i - 1];
                            }
                        }
                    }
                    else if (ihtiyac[i] == 3)
                    {
                        if ((bas_logo_havali[i] - talep[i]) >= 0)
                        {
                            if (i < benz - 1)
                            {
                                bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + bas_logo_havali[i] - talep[i];
                                bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + bas_hava_kanalli[i];
                                bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + bas_standart_kutu[i];
                                bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + bas_havali_paket[i];
                                bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + bas_hediye_kutu[i];
                                bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + bas_standart_poset[i];
                            }
                            karsilanamayan[i] = 0;
                        }
                        else
                        {
                            if (i < benz - 1)
                            {
                                bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + 0;
                                bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + bas_hava_kanalli[i];
                                bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + bas_standart_kutu[i];
                                bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + bas_havali_paket[i];
                                bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + bas_hediye_kutu[i];
                                bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + bas_standart_poset[i];
                            }
                            karsilanamayan[i] = talep[i] - bas_logo_havali[i];
                        }
                        if (i < benz - 1)
                            elde_logo_havali[i] = bas_logo_havali[i + 1];
                        if (i == benz - 1)
                        {
                            elde_logo_havali[i] = bas_logo_havali[i] - talep[i];
                        }
                        elde_standart_kutu[i] = bas_standart_kutu[i];
                        elde_hava_kanalli[i] = bas_hava_kanalli[i];
                        elde_havali_paket[i] = bas_havali_paket[i];         //elde kalan miktarlar yazdırılır
                        elde_hediye_kutu[i] = bas_hediye_kutu[i];
                        elde_standart_poset[i] = bas_standart_poset[i];

                        if (i == 1)
                            stok_logo_havali[i] = bas_logo_havali[i] - talep[i];
                        else
                        {
                            stok_logo_havali[i] = stok_logo_havali[i - 1] - talep[i] + acilan_logo_havali[i - 1];
                            stok_standart_kutu[i] = stok_standart_kutu[i - 1] + acilan_standart_kutu[i - 1];
                            stok_hava_kanalli[i] = stok_hava_kanalli[i - 1] + acilan_hava_kanalli[i - 1];
                            stok_havali_paket[i] = stok_havali_paket[i - 1] + acilan_havali_paket[i - 1];
                            stok_hediye_kutu[i] = stok_hediye_kutu[i - 1] + acilan_hediye_kutu[i - 1];
                            stok_standart_poset[i] = stok_standart_poset[i - 1] + acilan_standart_poset[i - 1];
                        }
                    }
                    else if (ihtiyac[i] == 4)
                    {
                        if ((bas_standart_kutu[i] - talep[i]) >= 0)
                        {
                            if (i < benz - 1)
                            {
                                bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + bas_standart_kutu[i] - talep[i];
                                bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + bas_hava_kanalli[i];
                                bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + bas_logo_havali[i];
                                bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + bas_havali_paket[i];
                                bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + bas_hediye_kutu[i];
                                bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + bas_standart_poset[i];
                            }
                            karsilanamayan[i] = 0;
                        }
                        else
                        {
                            if (i < benz - 1)
                            {
                                bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + 0;
                                bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + bas_hava_kanalli[i];
                                bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + bas_logo_havali[i];
                                bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + bas_havali_paket[i];
                                bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + bas_hediye_kutu[i];
                                bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + bas_standart_poset[i];
                            }
                            karsilanamayan[i] = talep[i] - bas_standart_kutu[i];
                        }
                        elde_logo_havali[i] = bas_logo_havali[i];
                        if (i < benz - 1)
                            elde_standart_kutu[i] = bas_standart_kutu[i + 1];
                        if (i == benz - 1)
                        {
                            elde_standart_kutu[i] = bas_standart_kutu[i] - talep[i];
                        }
                        elde_hava_kanalli[i] = bas_hava_kanalli[i];
                        elde_havali_paket[i] = bas_havali_paket[i];     //elde kalan miktarlar yazdırılır
                        elde_hediye_kutu[i] = bas_hediye_kutu[i];
                        elde_standart_poset[i] = bas_standart_poset[i];

                        if (i == 1)
                            stok_standart_kutu[i] = bas_standart_kutu[i] - talep[i];
                        else
                        {
                            stok_logo_havali[i] = stok_logo_havali[i - 1] + acilan_logo_havali[i - 1];
                            stok_standart_kutu[i] = stok_standart_kutu[i - 1] - talep[i] + acilan_standart_kutu[i - 1];
                            stok_hava_kanalli[i] = stok_hava_kanalli[i - 1] + acilan_hava_kanalli[i - 1];
                            stok_havali_paket[i] = stok_havali_paket[i - 1] + acilan_havali_paket[i - 1];
                            stok_hediye_kutu[i] = stok_hediye_kutu[i - 1] + acilan_hediye_kutu[i - 1];
                            stok_standart_poset[i] = stok_standart_poset[i - 1] + acilan_standart_poset[i - 1];
                        }
                    }
                    else if (ihtiyac[i] == 5)
                    {
                        if ((bas_hava_kanalli[i] - talep[i]) >= 0)
                        {
                            if (i < benz - 1)
                            {
                                bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + bas_hava_kanalli[i] - talep[i];
                                bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + bas_logo_havali[i];
                                bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + bas_standart_kutu[i];
                                bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + bas_havali_paket[i];
                                bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + bas_hediye_kutu[i];
                                bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + bas_standart_poset[i];
                            }
                            karsilanamayan[i] = 0;
                        }
                        else
                        {
                            if (i < benz - 1)
                            {
                                bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + 0;
                                bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + bas_logo_havali[i];
                                bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + bas_standart_kutu[i];
                                bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + bas_havali_paket[i];
                                bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + bas_hediye_kutu[i];
                                bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + bas_standart_poset[i];
                            }
                            karsilanamayan[i] = talep[i] - bas_hava_kanalli[i];
                        }
                        elde_logo_havali[i] = bas_logo_havali[i];
                        elde_standart_kutu[i] = bas_standart_kutu[i];
                        if (i < benz - 1)
                            elde_hava_kanalli[i] = bas_hava_kanalli[i + 1];
                        if (i == benz - 1)
                        {
                            elde_hava_kanalli[i] = bas_hava_kanalli[i] - talep[i];
                        }
                        elde_havali_paket[i] = bas_havali_paket[i];        //elde kalan miktarlar yazdırılır
                        elde_hediye_kutu[i] = bas_hediye_kutu[i];
                        elde_standart_poset[i] = bas_standart_poset[i];

                        if (i == 1)
                            stok_hava_kanalli[i] += bas_hava_kanalli[i] - talep[i];
                        else
                        {
                            stok_logo_havali[i] = stok_logo_havali[i - 1] + acilan_logo_havali[i - 1];
                            stok_standart_kutu[i] = stok_standart_kutu[i - 1] + acilan_standart_kutu[i - 1];
                            stok_hava_kanalli[i] = stok_hava_kanalli[i - 1] - talep[i] + acilan_hava_kanalli[i - 1];
                            stok_havali_paket[i] = stok_havali_paket[i - 1] + acilan_havali_paket[i - 1];
                            stok_hediye_kutu[i] = stok_hediye_kutu[i - 1] + acilan_hediye_kutu[i - 1];
                            stok_standart_poset[i] = stok_standart_poset[i - 1] + acilan_standart_poset[i - 1];
                        }
                    }
                    else if (ihtiyac[i] == 6)
                    {
                        if ((bas_havali_paket[i] - talep[i]) >= 0)
                        {
                            if (i < benz - 1)
                            {
                                bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + bas_havali_paket[i] - talep[i];
                                bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + bas_hava_kanalli[i];
                                bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + bas_logo_havali[i];
                                bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + bas_standart_kutu[i];
                                bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + bas_hediye_kutu[i];
                                bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + bas_standart_poset[i];
                            }
                            karsilanamayan[i] = 0;
                        }
                        else
                        {
                            if (i < benz - 1)
                            {
                                bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + 0;
                                bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + bas_hava_kanalli[i];
                                bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + bas_logo_havali[i];
                                bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + bas_standart_kutu[i];
                                bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + bas_hediye_kutu[i];
                                bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + bas_standart_poset[i];
                            }
                            karsilanamayan[i] = talep[i] - bas_havali_paket[i];
                        }
                        elde_logo_havali[i] = bas_logo_havali[i];
                        elde_standart_kutu[i] = bas_standart_kutu[i];
                        elde_hava_kanalli[i] = bas_hava_kanalli[i];
                        if (i < benz - 1)
                            elde_havali_paket[i] = bas_havali_paket[i + 1]; //elde kalan miktarlar yazdırılır
                        if (i == benz - 1)
                        {
                            elde_havali_paket[i] = bas_havali_paket[i] - talep[i];
                        }
                        elde_hediye_kutu[i] = bas_hediye_kutu[i];
                        elde_standart_poset[i] = bas_standart_poset[i];


                        if (i == 1)
                            stok_havali_paket[i] = bas_havali_paket[i] - talep[i];
                        else
                        {
                            stok_logo_havali[i] = stok_logo_havali[i - 1] + acilan_logo_havali[i - 1];
                            stok_standart_kutu[i] = stok_standart_kutu[i - 1] + acilan_standart_kutu[i - 1];
                            stok_hava_kanalli[i] = stok_hava_kanalli[i - 1] + acilan_hava_kanalli[i - 1];
                            stok_havali_paket[i] = stok_havali_paket[i - 1] - talep[i] + acilan_havali_paket[i - 1];
                            stok_hediye_kutu[i] = stok_hediye_kutu[i - 1] + acilan_hediye_kutu[i - 1];
                            stok_standart_poset[i] = stok_standart_poset[i - 1] + acilan_standart_poset[i - 1];
                        }
                    }
                    else if (ihtiyac[i] == 7)
                    {
                        if ((bas_hediye_kutu[i] - talep[i]) >= 0)
                        {
                            if (i < benz - 1)
                            {
                                bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + bas_hediye_kutu[i] - talep[i];
                                bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + bas_hava_kanalli[i];
                                bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + bas_logo_havali[i];
                                bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + bas_standart_kutu[i];
                                bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + bas_havali_paket[i];
                                bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + bas_standart_poset[i];
                            }
                            karsilanamayan[i] = 0;
                        }
                        else
                        {
                            if (i < benz - 1)
                            {
                                bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + 0;
                                bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + bas_hava_kanalli[i];
                                bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + bas_logo_havali[i];
                                bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + bas_standart_kutu[i];
                                bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + bas_havali_paket[i];
                                bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + bas_standart_poset[i];
                            }
                            karsilanamayan[i] = talep[i] - bas_hediye_kutu[i];
                        }
                        elde_logo_havali[i] = bas_logo_havali[i];
                        elde_standart_kutu[i] = bas_standart_kutu[i];
                        elde_hava_kanalli[i] = bas_hava_kanalli[i];
                        elde_havali_paket[i] = bas_havali_paket[i];       //elde kalan miktarlar yazdırılır
                        if (i < benz - 1)
                            elde_hediye_kutu[i] = bas_hediye_kutu[i + 1];
                        if (i == benz - 1)
                        {
                            elde_hediye_kutu[i] = bas_hediye_kutu[i] - talep[i];
                        }
                        elde_standart_poset[i] = bas_standart_poset[i];


                        if (i == 1)
                            stok_hediye_kutu[i] = bas_hediye_kutu[i] - talep[i];
                        else
                        {
                            stok_logo_havali[i] = stok_logo_havali[i - 1] + acilan_logo_havali[i - 1];
                            stok_standart_kutu[i] = stok_standart_kutu[i - 1] + acilan_standart_kutu[i - 1];
                            stok_hava_kanalli[i] = stok_hava_kanalli[i - 1] + acilan_hava_kanalli[i - 1];
                            stok_havali_paket[i] = stok_havali_paket[i - 1] + acilan_havali_paket[i - 1];
                            stok_hediye_kutu[i] = stok_hediye_kutu[i - 1] - talep[i] + acilan_hediye_kutu[i - 1];
                            stok_standart_poset[i] = stok_standart_poset[i - 1] + acilan_standart_poset[i - 1];
                        }
                    }
                    else if (ihtiyac[i] == 8)
                    {
                        if ((bas_standart_poset[i] - talep[i]) >= 0)
                        {
                            if (i < benz - 1)
                            {
                                bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + bas_standart_poset[i] - talep[i];
                                bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + bas_hava_kanalli[i];
                                bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + bas_logo_havali[i];
                                bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + bas_standart_kutu[i];
                                bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + bas_havali_paket[i];
                                bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + bas_hediye_kutu[i];
                            }
                            karsilanamayan[i] = 0;
                        }
                        else
                        {
                            if (i < benz - 1)
                            {
                                bas_standart_poset[i + 1] = bas_standart_poset[i + 1] + 0;
                                bas_hava_kanalli[i + 1] = bas_hava_kanalli[i + 1] + bas_hava_kanalli[i];
                                bas_logo_havali[i + 1] = bas_logo_havali[i + 1] + bas_logo_havali[i];
                                bas_standart_kutu[i + 1] = bas_standart_kutu[i + 1] + bas_standart_kutu[i];
                                bas_havali_paket[i + 1] = bas_havali_paket[i + 1] + bas_havali_paket[i];
                                bas_hediye_kutu[i + 1] = bas_hediye_kutu[i + 1] + bas_hediye_kutu[i];
                            }
                            karsilanamayan[i] = talep[i] - bas_standart_poset[i];
                        }
                        elde_logo_havali[i] = bas_logo_havali[i];
                        elde_standart_kutu[i] = bas_standart_kutu[i];
                        elde_hava_kanalli[i] = bas_hava_kanalli[i];
                        elde_havali_paket[i] = bas_havali_paket[i];     //elde kalan miktarlar yazdırılır
                        elde_hediye_kutu[i] = bas_hediye_kutu[i];
                        if (i < benz - 1)
                            elde_standart_poset[i] = bas_standart_poset[i + 1];
                        if (i == benz - 1)
                        {
                            elde_standart_poset[i] = bas_standart_poset[i] - talep[i];
                        }
                        if (i == 1)
                            stok_standart_poset[i] = bas_standart_poset[i] - talep[i];
                        else
                        {
                            stok_logo_havali[i] = stok_logo_havali[i - 1] + acilan_logo_havali[i - 1];
                            stok_standart_kutu[i] = stok_standart_kutu[i - 1] + acilan_standart_kutu[i - 1];
                            stok_hava_kanalli[i] = stok_hava_kanalli[i - 1] + acilan_hava_kanalli[i - 1];
                            stok_havali_paket[i] = stok_havali_paket[i - 1] + acilan_havali_paket[i - 1];
                            stok_hediye_kutu[i] = stok_hediye_kutu[i - 1] + acilan_hediye_kutu[i - 1];
                            stok_standart_poset[i] = stok_standart_poset[i - 1] - talep[i] + acilan_standart_poset[i - 1];
                        }

                    }

                    //Açılan stok kısmı
                    //tedarik süresi

                    int siparis = 0;
                    double ted = rastgele.NextDouble();
                    int teda;

                    if (ted <= 0.2099)
                        teda = 3;
                    else
                        teda = 2;

                    if (stok_logo_havali[i] <= 185 && i < benz - 1)
                    {
                        tedarik[i] = teda;
                        acilan_logo_havali[i] = 150;
                        stok_logo_havali[i + 1] = stok_logo_havali[i] + 150;
                        if (i + teda + 1 < benz - 1)
                            bas_logo_havali[i + teda + 1] = bas_logo_havali[i + teda + 1] + 150;
                        siparis = 150;
                    }
                    if (stok_standart_kutu[i] <= 185 && i < benz - 1)
                    {
                        tedarik[i] = teda;
                        acilan_standart_kutu[i] = 150;
                        stok_standart_kutu[i + 1] = stok_standart_kutu[i] + 150;
                        siparis = 150;
                        if (i + teda + 1 < benz)
                            bas_standart_kutu[i + teda + 1] = bas_standart_kutu[i + teda + 1] + 150;
                    }
                    if (stok_hava_kanalli[i] <= 185 && i < benz - 1)
                    {
                        tedarik[i] = teda;
                        acilan_hava_kanalli[i] = 150;
                        stok_hava_kanalli[i + 1] = stok_hava_kanalli[i] + 150;
                        siparis = 150;
                        if (i + teda + 1 < benz)
                            bas_hava_kanalli[i + teda + 1] = bas_hava_kanalli[i + teda + 1] + 150;
                    }
                    if (stok_havali_paket[i] <= 150 && i < benz - 1)
                    {
                        tedarik[i] = teda;
                        acilan_havali_paket[i] = 100;
                        stok_havali_paket[i + 1] = stok_havali_paket[i] + 100;
                        siparis = 100;
                        if (i + teda + 1 < benz)
                            bas_havali_paket[i + teda + 1] = bas_havali_paket[i + teda + 1] + 100;
                    }
                    if (stok_standart_poset[i] <= 150 && i < benz - 1)
                    {
                        tedarik[i] = teda;
                        acilan_standart_poset[i] = 100;
                        stok_standart_poset[i + 1] = stok_standart_poset[i] + 100;
                        siparis = 100;
                        if (i + teda + 1 < benz)
                            bas_standart_poset[i + teda + 1] = bas_standart_poset[i + teda + 1] + 100;
                    }
                    if (stok_hediye_kutu[i] <= 215 && i < benz - 1)
                    {
                        tedarik[i] = teda;
                        acilan_hediye_kutu[i] = 200;
                        stok_hediye_kutu[i + 1] = stok_hediye_kutu[i] + 200;
                        siparis = 20;
                        if (i + teda + 1 < benz)
                            bas_hediye_kutu[i + teda + 1] = bas_hediye_kutu[i + teda + 1] + 200;
                    }

                    eldeBulundurma[i] = (elde_logo_havali[i] + elde_standart_kutu[i] + elde_hava_kanalli[i] + elde_havali_paket[i] + elde_hediye_kutu[i] + elde_standart_poset[i]) * 0.09;
                    cezaMaliyeti[i] = karsilanamayan[i] * 2;
                    siparisMaliyeti[i] = 2 * siparis;
                    toplamMaliyet[i] = eldeBulundurma[i] + cezaMaliyeti[i] + siparisMaliyeti[i];

                    toplamElde = toplamElde + eldeBulundurma[i];
                    toplamCeza = toplamCeza + cezaMaliyeti[i];
                    toplamSiparis = toplamSiparis + siparisMaliyeti[i];
                    toplamMa = toplamMa + toplamMaliyet[i];



                }//for çıkış
                label6.Text = toplamElde.ToString();
                label7.Text = toplamCeza.ToString();
                label8.Text = toplamSiparis.ToString();
                label9.Text = toplamMa.ToString();
                for (int j = 1; j < benz; j++)
                {
                    dataGridView1.Rows.Add(1);
                    int toplam = dataGridView1.Rows.Count;
                    dataGridView1.Rows[toplam - 2].Cells[0].Value = benzetimZamani[j];

                    dataGridView1.Rows[toplam - 2].Cells[1].Value = bas_logo_havali[j];
                    dataGridView1.Rows[toplam - 2].Cells[2].Value = bas_standart_kutu[j];
                    dataGridView1.Rows[toplam - 2].Cells[3].Value = bas_hava_kanalli[j];
                    dataGridView1.Rows[toplam - 2].Cells[4].Value = bas_havali_paket[j];
                    dataGridView1.Rows[toplam - 2].Cells[5].Value = bas_hediye_kutu[j];
                    dataGridView1.Rows[toplam - 2].Cells[6].Value = bas_standart_poset[j];
                    String paketCinsi = null;
                    if (ihtiyac[j] == 1)
                        paketCinsi = "Rulo Paket";
                    if (ihtiyac[j] == 2)
                        paketCinsi = "Bez Torba";
                    if (ihtiyac[j] == 3)
                        paketCinsi = "Logo Havalı Poşet";
                    if (ihtiyac[j] == 4)
                        paketCinsi = "Standart Kutu";
                    if (ihtiyac[j] == 5)
                        paketCinsi = "Hava Kanallı Ambalaj";
                    if (ihtiyac[j] == 6)
                        paketCinsi = "Havalı Paket";
                    if (ihtiyac[j] == 7)
                        paketCinsi = "Hediye Kutu";
                    if (ihtiyac[j] == 8)
                        paketCinsi = "Standart Poşet";
                    dataGridView1.Rows[toplam - 2].Cells[7].Value = paketCinsi;
                    dataGridView1.Rows[toplam - 2].Cells[8].Value = talep[j];

                    dataGridView1.Rows[toplam - 2].Cells[9].Value = elde_logo_havali[j];
                    dataGridView1.Rows[toplam - 2].Cells[10].Value = elde_standart_kutu[j];
                    dataGridView1.Rows[toplam - 2].Cells[11].Value = elde_hava_kanalli[j];
                    dataGridView1.Rows[toplam - 2].Cells[12].Value = elde_havali_paket[j];
                    dataGridView1.Rows[toplam - 2].Cells[13].Value = elde_hediye_kutu[j];
                    dataGridView1.Rows[toplam - 2].Cells[14].Value = elde_standart_poset[j];

                    dataGridView1.Rows[toplam - 2].Cells[15].Value = karsilanamayan[j];

                    dataGridView1.Rows[toplam - 2].Cells[16].Value = stok_logo_havali[j];
                    dataGridView1.Rows[toplam - 2].Cells[17].Value = stok_standart_kutu[j];
                    dataGridView1.Rows[toplam - 2].Cells[18].Value = stok_hava_kanalli[j];
                    dataGridView1.Rows[toplam - 2].Cells[19].Value = stok_havali_paket[j];
                    dataGridView1.Rows[toplam - 2].Cells[20].Value = stok_hediye_kutu[j];
                    dataGridView1.Rows[toplam - 2].Cells[21].Value = stok_standart_poset[j];

                    dataGridView1.Rows[toplam - 2].Cells[22].Value = acilan_logo_havali[j];
                    dataGridView1.Rows[toplam - 2].Cells[23].Value = acilan_standart_kutu[j];
                    dataGridView1.Rows[toplam - 2].Cells[24].Value = acilan_hava_kanalli[j];
                    dataGridView1.Rows[toplam - 2].Cells[25].Value = acilan_havali_paket[j];
                    dataGridView1.Rows[toplam - 2].Cells[26].Value = acilan_hediye_kutu[j];
                    dataGridView1.Rows[toplam - 2].Cells[27].Value = acilan_standart_poset[j];

                    dataGridView1.Rows[toplam - 2].Cells[28].Value = tedarik[j];

                    dataGridView1.Rows[toplam - 2].Cells[29].Value = eldeBulundurma[j];

                    dataGridView1.Rows[toplam - 2].Cells[30].Value = cezaMaliyeti[j];

                    dataGridView1.Rows[toplam - 2].Cells[31].Value = siparisMaliyeti[j];

                    dataGridView1.Rows[toplam - 2].Cells[32].Value = toplamMaliyet[j];
                }


            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
