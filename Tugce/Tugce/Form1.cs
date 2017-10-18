using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Deneme", "RS");
            dataGridView1.Columns.Add("Deneme", "Gelişler Arası Süre");
            dataGridView1.Columns.Add("Deneme", "Benzetim Zamanı");
            dataGridView1.Columns.Add("Deneme", "Gelen Talep Çim 1.Kalite 50x20");
            dataGridView1.Columns.Add("Deneme", "Gelen Talep Çim 1.Kalite 60x30");
            dataGridView1.Columns.Add("Deneme", "Gelen Talep Çim 1.Kalite 80x40");
            dataGridView1.Columns.Add("Deneme", "Gelen Talep Çim 2.Kalite 50x20");
            dataGridView1.Columns.Add("Deneme", "Gelen Talep Çim 2.Kalite 50x20");
            dataGridView1.Columns.Add("Deneme", "Gelen Talep Çim 2.Kalite 50x20");
            dataGridView1.Columns.Add("Deneme", "Gelen Talep Çim Suyu 1. Kalite 24 lü ");
            dataGridView1.Columns.Add("Deneme", "Gelen Talep Çim Suyu 1. Kalite 48 li");
            dataGridView1.Columns.Add("Deneme", "Gelen Talep Çim Suyu 2. Kalite 24 lü ");
            dataGridView1.Columns.Add("Deneme", "Gelen Talep Çim Suyu 2. Kalite 48 li");
            dataGridView1.Columns.Add("Deneme", "Yetiştirme Süresi");
            dataGridView1.Columns.Add("Deneme", "Yetiştirme İşlemi Biten");
            dataGridView1.Columns.Add("Deneme", "Yetiştirme İşleminde Bekleyen");
            dataGridView1.Columns.Add("Deneme", "Yetiştirme İşlemi Devam Eden");
            dataGridView1.Columns.Add("Deneme", "Doldurma Süresi");
            dataGridView1.Columns.Add("Deneme", "Doldurma İşlemi Biten");
            dataGridView1.Columns.Add("Deneme", "Doldurma İşleminde Bekleyen");
            dataGridView1.Columns.Add("Deneme", "Doldurma İşlemi Devam Eden");
            dataGridView1.Columns.Add("Deneme", "Kargosu Süresi");
            dataGridView1.Columns.Add("Deneme", "Kargosu Ulaşmış Olan");
            dataGridView1.Columns.Add("Deneme", "Kargoda Bekleyen");
            dataGridView1.Columns.Add("Deneme", "Kargosu Devam Eden");
            dataGridView1.Columns.Add("Deneme", "Maliyet");
            dataGridView1.Columns.Add("Deneme", "Gelir");
            dataGridView1.Columns.Add("Deneme", "İşlemi Biten");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int benz = 0;
            if (textBox1.TextLength > 0)
            {
                benz = Convert.ToInt32(textBox1.Text);
                label2.Text = benz.ToString();
            }
            if (benz < 2)
            {
                MessageBox.Show("Benzetim zamanını bir den büyük giriniz", "Hata!!");
            }


            //işlemler

            if (benz > 1)
            {
                int sa=0;
                Random rs = new Random();
                int[] benzetim = new int[benz];
                double[] bz1 = new double[benz];
                int[] gas = new int[benz];
                int[] gel = new int[benz];


                String[] cim15 = new String[benz];
                String[] cim16 = new String[benz];
                String[] cim18 = new String[benz];
                String[] cim25 = new String[benz];
                String[] cim26 = new String[benz];
                String[] cim28 = new String[benz];

                String[] cimsu24 = new String[benz];
                String[] cimsu48 = new String[benz];

                String[] cimsu24q = new String[benz];
                String[] cimsu48q = new String[benz];

                int[] yetistirmeSure = new int[benz];

                int[] yetistirmeDevam = new int[benz];
                int[] yetistirmeBiten = new int[benz];
                int[] yetirtimeBekleyen = new int[benz];

                int[] doldurmaSuresi = new int[benz];

                int[] doldurmaDevam = new int[benz];
                int[] doldurmaBiten = new int[benz];
                int[] doldurmaBekleyen = new int[benz];

                int[] kargoSuresi = new int[benz];
                int[] kargosuDevam = new int[benz];
                int[] kargosuUlasan = new int[benz];
                int[] kargodaBekleyen = new int[benz];

                int[] maliyet = new int[benz];
                int[] gelir = new int[benz];

                int[] islemiBiten = new int[benz];
                double bz;
                int bez=0;
                for (int i = 0; i < benz;i++ )
                {
                    benzetim[i] = i + 1;
                }
                for (int i = 0; i < benz - 1; i++)
                {
                    bz = rs.NextDouble();
                    if (bz <= 0.4599)
                        bez = 1;
                    if (0.46 <= bz && bz <= 0.7599)
                        bez = 2;
                    if (0.76 <= bz && bz <= 0.9099)
                        bez = 3;
                    if (0.91 <= bz && bz <= 0.9599)
                        bez = 4;
                    if (0.96 <= bz && bz <= 1.00)
                        bez = 5;
                    gas[i] = bez;
                    bz1[i] = bz;
                }
                for (int i = 0; i < benz;i++ )
                {
                    double rs1 = rs.NextDouble();
                    double rs2 = rs.NextDouble();
                    double rs3 = rs.NextDouble();
                    double rs4 = rs.NextDouble();
                    int sure=0;
                    if (rs4 <= 0.2599)
                        sure = 5;
                    if (0.26 <= rs4 && rs4 <= 1.00)
                        sure = 7;
                    if (i == 0)
                    {
                        sa = gas[0];
                        if (rs1 <= 0.3599)
                        {//çim
                            if (rs2 <= 0.8099)
                            {//1.kalite
                                if (rs3 <= 0.4599)
                                {//50x20
                                    cim15[gas[0]] = "Talep Geldi";
                                    yetistirmeSure[gas[0]] = sure;
                                }
                                if (0.46 <= rs3 && rs3 <= 0.8099)
                                {//60x30
                                    cim16[gas[0]] = "Talep Geldi";
                                    yetistirmeSure[gas[0]] = sure;
                                }
                                if (0.81 <= rs3 && rs3 <= 1.00)
                                {//80x40
                                    cim18[gas[0]] = "Talep Geldi";
                                    yetistirmeSure[gas[0]] = sure;
                                }
                            }
                            if (0.81 <= rs2 && rs2 <= 1.00)
                            {//2.kalite
                                if (rs3 <= 0.4599)
                                {//50x20
                                    cim25[gas[0]] = "Talep Geldi";
                                    yetistirmeSure[gas[0]] = sure;
                                }
                                if (0.46 <= rs3 && rs3 <= 0.8099)
                                {//60x30
                                    cim26[gas[0]] = "Talep Geldi";
                                    yetistirmeSure[gas[0]] = sure;
                                }
                                if (0.81 <= rs3 && rs3 <= 1.00)
                                {//80x40
                                    cim28[gas[0]] = "Talep Geldi";
                                    yetistirmeSure[gas[0]] = sure;
                                }
                            }
                        }
                        if (0.36 <= rs1 && rs1 <= 1.00)
                        {//çim suyu 1.kalite
                            if (rs3 <= 0.8099)
                            {
                                if (rs2 <= 0.6099)
                                {//24 lü
                                    cimsu24[gas[0]] = "Talep Geldi";
                                    yetistirmeSure[gas[0]] = sure;
                                }
                                if (0.61 <= rs2 && rs2 <= 1.00)
                                {//48 li
                                    cimsu48[gas[0]] = "Talep Geldi";
                                    yetistirmeSure[gas[0]] = sure;
                                }
                            }
                            else
                            {
                                if (rs2 <= 0.6099)
                                {//24 lü
                                    cimsu24q[gas[0]] = "Talep Geldi";
                                    yetistirmeSure[gas[0]] = sure;
                                }
                                if (0.61 <= rs2 && rs2 <= 1.00)
                                {//48 li
                                    cimsu48q[gas[0]] = "Talep Geldi";
                                    yetistirmeSure[gas[0]] = sure;
                                }
                            }
                        }
                    }
                    else
                    {
                        sa += gas[i];
                        if (sa < benz)
                        {
                            if (rs1 <= 0.3599)
                            {//çim
                                if (rs2 <= 0.8099)
                                {//1.kalite
                                    if (rs3 <= 0.4599)
                                    {//50x20
                                        cim15[sa] = "Talep Geldi";
                                        yetistirmeSure[sa] = sure;
                                    }
                                    if (0.46 <= rs3 && rs3 <= 0.8099)
                                    {//60x30
                                        cim16[sa] = "Talep Geldi";
                                        yetistirmeSure[sa] = sure;
                                    }
                                    if (0.81 <= rs3 && rs3 <= 1.00)
                                    {//80x40
                                        cim18[sa] = "Talep Geldi";
                                        yetistirmeSure[sa] = sure;
                                    }
                                }
                                if (0.81 <= rs2 && rs2 <= 1.00)
                                {//2.kalite
                                    if (rs3 <= 0.4599)
                                    {//50x20
                                        cim25[sa] = "Talep Geldi";
                                        yetistirmeSure[sa] = sure;
                                    }
                                    if (0.46 <= rs3 && rs3 <= 0.8099)
                                    {//60x30
                                        cim26[sa] = "Talep Geldi";
                                        yetistirmeSure[sa] = sure;
                                    }
                                    if (0.81 <= rs3 && rs3 <= 1.00)
                                    {//80x40
                                        cim28[sa] = "Talep Geldi";
                                        yetistirmeSure[sa] = sure;
                                    }
                                }
                            }
                            if (0.36 <= rs1 && rs1 <= 1.00)
                            {//çim suyu
                                if (rs3 <= 0.8099)
                                {//1.kalite
                                    if (rs2 <= 0.6099)
                                    {//24 lü
                                        cimsu24[sa] = "Talep Geldi";
                                        yetistirmeSure[sa] = sure;
                                    }
                                    if (0.61 <= rs2 && rs2 <= 1.00)
                                    {//48 li
                                        cimsu48[sa] = "Talep Geldi";
                                        yetistirmeSure[sa] = sure;
                                    }
                                }
                                else
                                {//2.kalite
                                    if (rs2 <= 0.6099)
                                    {//24 lü
                                        cimsu24q[sa] = "Talep Geldi";
                                        yetistirmeSure[sa] = sure;
                                    }
                                    if (0.61 <= rs2 && rs2 <= 1.00)
                                    {//48 li
                                        cimsu48q[sa] = "Talep Geldi";
                                        yetistirmeSure[sa] = sure;
                                    }
                                }
                            }
                        }
                    }
                }
                int durum = 0;
                for (int i = 0; i < benz;i++ )
                {
                    if (cim15[i] == "Talep Geldi" || cim16[i] == "Talep Geldi" || cim18[i] == "Talep Geldi" || cim25[i] == "Talep Geldi" || cim26[i] == "Talep Geldi" || cim28[i] == "Talep Geldi" || cimsu24[i] == "Talep Geldi" || cimsu48[i] == "Talep Geldi" || cimsu24q[i] == "Talep Geldi" || cimsu48q[i] == "Talep Geldi")
                    {
                        if (durum == 0)
                        {
                            for (int k = i; k < yetistirmeSure[i]+i; k++)
                            {
                                durum = k;
                                yetistirmeDevam[k] = benzetim[i];
                            }
                            if(durum+1<benz)
                                yetistirmeBiten[durum + 1] = benzetim[i];
                            
                        }
                        else
                        {
                            for (int j=0;j<yetistirmeSure[i];j++)
                            {
                                if (durum < benz-1)
                                {
                                    durum++;
                                    yetistirmeDevam[durum] = benzetim[i];
                                }
                            }
                            if(durum+1<benz)
                                yetistirmeBiten[durum + 1] = benzetim[i];
                        }
                    }
                }
                /*int sayac = 0;
                int sayac1=0;
                for (int i = 0; i < benz;i++ )
                {

                    if (cim15[i] == "Talep Geldi" || cim16[i] == "Talep Geldi" || cim18[i] == "Talep Geldi" || cim25[i] == "Talep Geldi" || cim26[i] == "Talep Geldi" || cim28[i] == "Talep Geldi" || cimsu24[i] == "Talep Geldi" || cimsu48[i] == "Talep Geldi")
                    {
                        sayac++;
                        sayac1 = i;
                    }
                    if(sayac>1)
                    {
                        if (yetistirmeBiten[i] == 0)
                        {
                            yetistirmeDevam[i] = sayac1;
                        }
                    }
                }*/
                durum = 0;
                for (int i = 0; i < benz;i++ )
                {
                    if (yetistirmeBiten[i] > 0)
                    {
                        if (cimsu24[yetistirmeBiten[i] - 1] == "Talep Geldi" || cimsu48[yetistirmeBiten[i] - 1] == "Talep Geldi" || cimsu24q[yetistirmeBiten[i] - 1] == "Talep Geldi" || cimsu48q[yetistirmeBiten[i] - 1] == "Talep Geldi")
                        {
                            double doldur = rs.NextDouble();
                            if (doldur <= 0.3599)
                                doldurmaSuresi[i] = 1;
                            if (0.36 <= doldur && doldur <= 1.00)
                                doldurmaSuresi[i] = 2;

                            if (durum == 0)
                            {
                                for (int k = i; k < doldurmaSuresi[i] + i; k++)
                                {
                                    if (k < benz)
                                    {
                                        doldurmaDevam[k] = yetistirmeBiten[i];
                                        durum = k;
                                    }
                                }
                                if (durum + 1 < benz)
                                    doldurmaBiten[durum + 1] = yetistirmeBiten[i];
                            }
                            else
                            {
                                durum = i;
                                for (int j = 0; j < doldurmaSuresi[i]; j++)
                                {
                                    if (durum < benz - 1)
                                    {
                                        durum++;
                                        doldurmaDevam[durum] = yetistirmeBiten[i];
                                    }
                                }
                                if (durum + 1 < benz)
                                    doldurmaBiten[durum + 1] = yetistirmeBiten[i];
                            }
                        }
                    }
                    doldurmaBekleyen[i] = 0;
                }
                for (int i = 0; i < benz;i++)
                {//kargo süresi
                    double kargo = rs.NextDouble();

                    if (yetistirmeBiten[i] > 0 && (cimsu24[yetistirmeBiten[i] - 1] != "Talep Geldi" && cimsu48[yetistirmeBiten[i] - 1] != "Talep Geldi" && cimsu24q[yetistirmeBiten[i] - 1] != "Talep Geldi" && cimsu48q[yetistirmeBiten[i] - 1] != "Talep Geldi"))
                    {
                        if (kargo <= 0.5599)
                            kargoSuresi[i] = 2;
                        else
                            kargoSuresi[i] = 3;
                        kargosuDevam[i] = yetistirmeBiten[i];
                    }
                    else if (doldurmaBiten[i] > 0)
                    {
                        if (kargo <= 0.5599)
                            kargoSuresi[i] = 2;
                        else
                            kargoSuresi[i] = 3;
                        kargosuDevam[i] = doldurmaBiten[i];
                    }
                }//kargo süresi
                for (int i = 0; i < benz;i++)
                {
                    int dur;
                    if(kargoSuresi[i]>0)
                    {
                        dur = kargoSuresi[i];
                        for(int j=1;j<=dur;j++)
                        {
                            if(j+i<benz)
                                kargosuDevam[j + i] = kargosuDevam[i];
                        }
                        if(i+dur<benz)
                        {
                            kargosuUlasan[i + dur] = kargosuDevam[i];
                            islemiBiten[i + dur] = kargosuDevam[i];
                            maliyet[i + dur] = 7;
                        }
                            
                    }
                }
                for (int i = 0; i < benz;i++)
                {
                    if(islemiBiten[i]!=0)
                    {
                        int d = islemiBiten[i];
                        d--;
                        if (cim15[d] == "Talep Geldi")
                            gelir[i] = 20;
                        if (cim16[d] == "Talep Geldi")
                            gelir[i] = 40;
                        if (cim18[d] == "Talep Geldi")
                            gelir[i] = 80;
                        if (cim25[d] == "Talep Geldi")
                            gelir[i] = 15;
                        if (cim26[d] == "Talep Geldi")
                            gelir[i] = 30;
                        if (cim28[d] == "Talep Geldi")
                            gelir[i] = 60;
                        if (cimsu24[d] == "Talep Geldi")
                            gelir[i] = 48;
                        if (cimsu48[d] == "Talep Geldi")
                            gelir[i] = 70;
                        if (cimsu24q[d] == "Talep Geldi")
                            gelir[i] = 32;
                        if (cimsu48q[d] == "Talep Geldi")
                            gelir[i] = 50;
                    }       
                }
                int toplamMa=0,toplamGelir=0;
                double urun=0;
                for (int j = 0; j < benz; j++)
                {
                    toplamGelir += gelir[j];
                    toplamMa += maliyet[j];
                    urun += yetistirmeSure[j];
                    dataGridView1.Rows.Add(1);
                    int toplam = dataGridView1.Rows.Count;
                    dataGridView1.Rows[toplam - 2].Cells[0].Value = bz1[j];
                    dataGridView1.Rows[toplam - 2].Cells[1].Value = gas[j];
                    dataGridView1.Rows[toplam - 2].Cells[2].Value = benzetim[j];
                    dataGridView1.Rows[toplam - 2].Cells[3].Value = cim15[j];
                    dataGridView1.Rows[toplam - 2].Cells[4].Value = cim16[j];
                    dataGridView1.Rows[toplam - 2].Cells[5].Value = cim18[j];
                    dataGridView1.Rows[toplam - 2].Cells[6].Value = cim25[j];
                    dataGridView1.Rows[toplam - 2].Cells[7].Value = cim26[j];
                    dataGridView1.Rows[toplam - 2].Cells[8].Value = cim28[j];
                    dataGridView1.Rows[toplam - 2].Cells[9].Value = cimsu24[j];
                    dataGridView1.Rows[toplam - 2].Cells[10].Value = cimsu48[j];
                    dataGridView1.Rows[toplam - 2].Cells[11].Value = cimsu24q[j];
                    dataGridView1.Rows[toplam - 2].Cells[12].Value = cimsu48q[j];
                    dataGridView1.Rows[toplam - 2].Cells[13].Value = yetistirmeSure[j];
                    if (yetistirmeBiten[j] > 0)
                        dataGridView1.Rows[toplam - 2].Cells[14].Value = yetistirmeBiten[j] + " . Benzetim";
                    if (yetistirmeDevam[j] > 0)
                        dataGridView1.Rows[toplam - 2].Cells[16].Value = yetistirmeDevam[j] + " . Benzetim";
                    dataGridView1.Rows[toplam - 2].Cells[17].Value = doldurmaSuresi[j];
                    if (doldurmaBiten[j] > 0)
                        dataGridView1.Rows[toplam - 2].Cells[18].Value = doldurmaBiten[j] + " . Benzetim";
                    dataGridView1.Rows[toplam - 2].Cells[19].Value = doldurmaBekleyen[j];
                    if (doldurmaDevam[j] > 0)
                        dataGridView1.Rows[toplam - 2].Cells[20].Value = doldurmaDevam[j] + " . Benzetim";
                    if (kargoSuresi[j] > 0)
                        dataGridView1.Rows[toplam - 2].Cells[21].Value = kargoSuresi[j];
                    if(kargosuUlasan[j]>0)
                        dataGridView1.Rows[toplam - 2].Cells[22].Value = kargosuUlasan[j]+" . Benzetim";
                    if (kargosuDevam[j] > 0)
                        dataGridView1.Rows[toplam - 2].Cells[24].Value = kargosuDevam[j] + " . Benzetim";
                    if (maliyet[j] > 0)
                        dataGridView1.Rows[toplam - 2].Cells[25].Value = maliyet[j] + " TL";
                    if(gelir[j]>0)
                        dataGridView1.Rows[toplam - 2].Cells[26].Value = gelir[j] + " TL";
                    if(islemiBiten[j]>0)
                        dataGridView1.Rows[toplam - 2].Cells[27].Value = islemiBiten[j] + " . Benzetim";
                }
                label7.Text = toplamMa.ToString();
                label8.Text = toplamGelir.ToString();
                urun = urun / benz;
                label9.Text = urun.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
