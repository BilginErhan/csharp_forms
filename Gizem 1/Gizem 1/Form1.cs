using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gizem_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Deneme", "Benzetim Zamanı");
            dataGridView1.Columns.Add("Deneme", "RS");
            dataGridView1.Columns.Add("Deneme", "Yangın Benzetim Zamanı");
            dataGridView1.Columns.Add("Deneme", "Yangın Durumu");
            dataGridView1.Columns.Add("Deneme", "RS");
            dataGridView1.Columns.Add("Deneme", "Yangın Çıktıktan Sonra İhbar Süresi");
            dataGridView1.Columns.Add("Deneme", "RS");
            dataGridView1.Columns.Add("Deneme", "Ne Kadar Alana Yayıldı");
            dataGridView1.Columns.Add("Deneme", "İşleme Alınan İtfaiye Aracı Sayısı");
            dataGridView1.Columns.Add("Deneme", "İşleme Alınan Helikopter Sayısı");
            dataGridView1.Columns.Add("Deneme", "İşlem Bekleyen İtfaiye Aracı Sayısı");
            dataGridView1.Columns.Add("Deneme", "İşlem Bekleyen Helikopter Sayısı");
            dataGridView1.Columns.Add("Deneme", "RS");
            dataGridView1.Columns.Add("Deneme", "İtfaiye Aracının Söndürdüğü Alan");
            dataGridView1.Columns.Add("Deneme", "RS");
            dataGridView1.Columns.Add("Deneme", "İtfaiye Aracının Söndürme Süresi");
            dataGridView1.Columns.Add("Deneme", "RS");
            dataGridView1.Columns.Add("Deneme", "Helikopter Aracının Söndürdüğü Alan");
            dataGridView1.Columns.Add("Deneme", "RS");
            dataGridView1.Columns.Add("Deneme", "Helikopter Aracının Söndürme Süresi");
            dataGridView1.Columns.Add("Deneme", "Toplam Sönen Alan");
            dataGridView1.Columns.Add("Deneme", "Toplam Yangını Söndürme Süresi");
            dataGridView1.Columns.Add("Deneme", "RS");
            dataGridView1.Columns.Add("Deneme", "Söndürülen Bölgenin Enerji Dönüşüm Durumu");
            dataGridView1.Columns.Add("Deneme", "Kurtarılamayıp Tamamen Yanan Bölge");
            dataGridView1.Columns.Add("Deneme", "Toplam Zarar");
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
                MessageBox.Show("Benztim zamanını bir den büyük giriniz", "Hata!!");
            }


            //işlemler

            if (benz > 1)
            {
                double[] rs1 = new double[benz];
                double[] rs2 = new double[benz];
                double[] rs3 = new double[benz];
                double[] rs4 = new double[benz];
                double[] rs5 = new double[benz];
                double[] rs6 = new double[benz];
                double[] rs7 = new double[benz];
                double[] rs8 = new double[benz];

                Random rs = new Random();
                int[] benzetim = new int[benz];
                int[] yangin = new int[benz];
                String[] yanginDurumu = new String[benz];
                int[] ihbarSuresi = new int[benz];
                double[] alan = new double[benz];
                int[] islemeAlinanitfaiye = new int[benz];
                int[] islemeAlianHelikopter = new int[benz];

                int[] bekleyenitfaiye = new int[benz];
                int[] bekleyenHelikopter = new int[benz];

                double[] itfaiyeSondurdugu = new double[benz];
                double[] helikopterinSondurdugu = new double[benz];

                double[] itfaiyeSure = new double[benz];
                double[] helikopterSure = new double[benz];

                double[] toplamSonen = new double[benz];
                double[] toplamSure = new double[benz];

                double[] geriDonusum = new double[benz];
                double[] tamamenYanan = new double[benz];

                double[] toplamZarar = new double[benz];


                for (int i = 0; i < benz; i++)
                {
                    if (i == 0)
                    {
                        double yan = rs.NextDouble();
                        rs1[i] = yan;
                        if (yan <= 0.2599)
                            yangin[i] = 2;
                        if (0.26 <= yan && yan <= 0.4599)
                            yangin[i] = 3;
                        if (0.46 <= yan && yan <= 0.7599)
                            yangin[i] = 4;
                        if (0.76 <= yan && yan <= 0.9099)
                            yangin[i] = 5;
                        if (0.91 <= yan && yan <= 1.00)
                            yangin[i] = 6;
                        benzetim[i] = i + 1;
                    }
                    else
                    {
                        
                        double yan = rs.NextDouble();
                        rs1[i] = yan;
                        if (yan <= 0.2599)
                            yangin[i] = 2;
                        if (0.26 <= yan && yan <= 0.4599)
                            yangin[i] = 3;
                        if (0.46 <= yan && yan <= 0.7599)
                            yangin[i] = 4;
                        if (0.76 <= yan && yan <= 0.9099)
                            yangin[i] = 5;
                        if (0.91 <= yan && yan <= 1.00)
                            yangin[i] = 6;
                        benzetim[i] = i + 1;

                    }
                }
                int[] deneme=new int[benz];
                for (int i = 0; i < benz;i++)
                {
                    deneme[i] = benzetim[i] + yangin[i];
                }
                for (int i = 0; i < benz; i++)
                {
                    if(i+yangin[i]+1<benz)
                        yanginDurumu[i + yangin[i]] = "Yangın Var";
                }
                for (int i = 0; i < benz; i++)
                {
                    if (yanginDurumu[i] != "Yangın Var")
                        yanginDurumu[i] = "Yangın Yok";
                }
                int k=0;
                for (int i = 0; i < benz; i++)
                {
                    if (yanginDurumu[i] == "Yangın Var")
                    {
                        double yan = rs.NextDouble();
                        rs2[i] = yan;
                        if (yan <= 0.1099)
                            ihbarSuresi[i] = 2;
                        if (0.11 <= yan && yan <= 0.2099)
                            ihbarSuresi[i] = 4;
                        if (0.21 <= yan && yan <= 0.3099)
                            ihbarSuresi[i] = 6;
                        if (0.31 <= yan && yan <= 0.4099)
                            ihbarSuresi[i] = 8;
                        if (0.41 <= yan && yan <= 0.5099)
                            ihbarSuresi[i] = 10;
                        if (0.51 <= yan && yan <= 0.6099)
                            ihbarSuresi[i] = 12;
                        if (0.61 <= yan && yan <= 0.7099)
                            ihbarSuresi[i] = 14;
                        if (0.71 <= yan && yan <= 0.8099)
                            ihbarSuresi[i] = 16;
                        if (0.81 <= yan && yan <= 0.9099)
                            ihbarSuresi[i] = 18;
                        if (0.91 <= yan && yan <= 1.00)
                            ihbarSuresi[i] = 20;
                        double yan1 = rs.NextDouble();
                        rs3[i] = yan1;
                        if (ihbarSuresi[i] >= 2 && ihbarSuresi[i] < 8)
                        {
                            alan[i] += 300 + yan1 * 690;
                        }
                        if (ihbarSuresi[i] >= 8 && ihbarSuresi[i] < 14)
                        {
                            alan[i] += 350 + yan1 * 750;
                        }
                        if (ihbarSuresi[i] >= 14 && ihbarSuresi[i] <= 20)
                        {
                            alan[i] += 500 + yan1 * 800;
                        }
                        while(alan[i]>2000)
                        {
                            alan[i] = alan[i] - 200;
                        }
                        
                        double sondur = rs.NextDouble();
                        double son = rs.NextDouble();

                        double sondur1 = rs.NextDouble();
                        double son1 = rs.NextDouble();

                        rs4[i] = sondur;
                        rs5[i] = son;

                        rs6[i] = sondur1;
                        rs7[i] = son1;

                        if (alan[i] >= 300 && alan[i] < 600)
                        {
                            //1 itfaiye
                            
                            islemeAlinanitfaiye[i] += 1;
                            bekleyenitfaiye[i] = 8-islemeAlinanitfaiye[i];
                            bekleyenHelikopter[i] = 6;
                            if (alan[i] > 500)
                            {
                                islemeAlianHelikopter[i] += 1;
                                bekleyenHelikopter[i] =6-bekleyenHelikopter[i];
                                //1 helikopter
                                helikopterinSondurdugu[i] += 230 + sondur1 * 260;
                                helikopterSure[i] += 5 + son1 * 20;
                            }

                            itfaiyeSondurdugu[i] += 110 + sondur * 160;


                            itfaiyeSure[i] += 10 + son * 45;


                        }
                        if (alan[i] >= 600 && alan[i] < 900)
                        {
                            //2 itfaiye // 1 helikopter
                            islemeAlianHelikopter[i] += 1;
                            islemeAlinanitfaiye[i] += 2;

                            bekleyenitfaiye[i] = 8-islemeAlinanitfaiye[i];
                            bekleyenHelikopter[i] = 6-islemeAlianHelikopter[i];

                            itfaiyeSondurdugu[i] += 2 * (110 + sondur * 160);
                            helikopterinSondurdugu[i] += 230 + sondur1 * 260;

                            itfaiyeSure[i] += (10 + son * 45) / 2;
                            helikopterSure[i] += 5 + son1 * 20;
                        }
                        if (alan[i] >= 900 && alan[i] <= 1200)
                        {
                            //3 itfaiye
                            islemeAlinanitfaiye[i] += 3;
                            islemeAlianHelikopter[i] += 1;
                            bekleyenHelikopter[i] = 6-islemeAlianHelikopter[i];
                            bekleyenitfaiye[i] = 8-islemeAlinanitfaiye[i];
                            itfaiyeSondurdugu[i] += 3 * (110 + sondur * 160);
                            helikopterinSondurdugu[i] += 230 + sondur1 * 260;

                            itfaiyeSure[i] += (10 + son * 45) / 3;
                            helikopterSure[i] += 5 + son1 * 20;

                            if (alan[i] > 1000)
                            {
                                //2 helikopter
                                islemeAlianHelikopter[i] += 1;
                                bekleyenHelikopter[i] = 6-islemeAlianHelikopter[i];
                                helikopterinSondurdugu[i] += 2 * (230 + sondur1 * 260);

                                helikopterSure[i] += (5 + son1 * 20) / 2;
                            }

                        }
                        if(alan[i]>1200 && alan[i]<=2000)
                        {
                            islemeAlinanitfaiye[i] += 4;
                            islemeAlianHelikopter[i] += 2;
                            bekleyenHelikopter[i] = 6 - islemeAlianHelikopter[i];
                            bekleyenitfaiye[i] = 8 - islemeAlinanitfaiye[i];
                            itfaiyeSondurdugu[i] += 4 * (110 + sondur * 160);
                            helikopterinSondurdugu[i] += 2*(230 + sondur1 * 260);

                            itfaiyeSure[i] += (10 + son * 45) / 3;
                            helikopterSure[i] += 5 + son1 * 20;

                            if (alan[i] > 1500)
                            {
                                //2 helikopter
                                islemeAlianHelikopter[i] += 1;
                                bekleyenHelikopter[i] = 6 - islemeAlianHelikopter[i];
                                helikopterinSondurdugu[i] += 3 * (230 + sondur1 * 260);

                                helikopterSure[i] += (5 + son1 * 20) / 2;
                            }
                        }
                        if (alan[i] > (itfaiyeSondurdugu[i] + helikopterinSondurdugu[i]))
                            toplamSonen[i] += itfaiyeSondurdugu[i] + helikopterinSondurdugu[i];
                        else
                            toplamSonen[i] = alan[i];
                        toplamSure[i] += itfaiyeSure[i] + helikopterSure[i];


                        double oran = 0;
                        double rs0 = rs.NextDouble();
                        rs8[i] = rs0;
                        if (rs0 <= 0.3099)
                            oran = 10;
                        if (0.31 <= rs0 && rs0 <= 0.6099)
                            oran = 30;
                        if (0.61 <= rs0 && rs0 <= 0.9099)
                            oran = 40;
                        if (0.91 <= rs0 && rs0 <= 1.00)
                            oran = 70;

                        geriDonusum[i] += (toplamSonen[i] * oran) / 100;
                        tamamenYanan[i] += alan[i] - toplamSonen[i];

                        toplamZarar[i] += toplamSonen[i] - geriDonusum[i] + tamamenYanan[i];

                    }
                    else
                    {
                        bekleyenHelikopter[i] = 6;
                        bekleyenitfaiye[i] = 8;
                    }
                    if (yanginDurumu[i] == "Yangın Var")
                    {
                        if (k + 1 < benz)
                        {
                            if (deneme[k] == deneme[k + 1])
                            {
                                i--;
                            }
                        }
                        k++;
                    }
                }
                double toplamz = 0, toplams = 0, toplamk = 0, toplamg = 0;
                for (int j = 0; j < benz; j++)
                {
                    toplamz += toplamZarar[j];
                    toplams += toplamSonen[j];
                    toplamk += tamamenYanan[j];
                    toplamg += geriDonusum[j];
                    dataGridView1.Rows.Add(1);
                    int toplam = dataGridView1.Rows.Count;
                    dataGridView1.Rows[toplam - 2].Cells[0].Value = benzetim[j];
                    dataGridView1.Rows[toplam - 2].Cells[1].Value = rs1[j].ToString("0.##");
                    dataGridView1.Rows[toplam - 2].Cells[2].Value = yangin[j];
                    dataGridView1.Rows[toplam - 2].Cells[3].Value = yanginDurumu[j];
                    dataGridView1.Rows[toplam - 2].Cells[4].Value = rs2[j].ToString("0.##");
                    if (ihbarSuresi[j] > 0)
                        dataGridView1.Rows[toplam - 2].Cells[5].Value = ihbarSuresi[j].ToString("0.##") + "  dk";
                    dataGridView1.Rows[toplam - 2].Cells[6].Value = rs3[j].ToString("0.##");
                    if (alan[j] > 0)
                        dataGridView1.Rows[toplam - 2].Cells[7].Value = alan[j].ToString("0.##") + "  m^2";
                    dataGridView1.Rows[toplam - 2].Cells[8].Value = islemeAlinanitfaiye[j];
                    dataGridView1.Rows[toplam - 2].Cells[9].Value = islemeAlianHelikopter[j];
                    dataGridView1.Rows[toplam - 2].Cells[10].Value = bekleyenitfaiye[j];
                    dataGridView1.Rows[toplam - 2].Cells[11].Value = bekleyenHelikopter[j];
                    dataGridView1.Rows[toplam - 2].Cells[12].Value = rs4[j].ToString("0.##");
                    if (itfaiyeSondurdugu[j] > 0)
                        dataGridView1.Rows[toplam - 2].Cells[13].Value = itfaiyeSondurdugu[j].ToString("0.##") + "  m^2";
                    dataGridView1.Rows[toplam - 2].Cells[14].Value = rs5[j].ToString("0.##");
                    if (itfaiyeSure[j] > 0)
                        dataGridView1.Rows[toplam - 2].Cells[15].Value = itfaiyeSure[j].ToString("0.##") + "  dk";
                    if (helikopterinSondurdugu[j] > 0)
                        dataGridView1.Rows[toplam - 2].Cells[16].Value = rs6[j].ToString("0.##");
                        dataGridView1.Rows[toplam - 2].Cells[17].Value = helikopterinSondurdugu[j].ToString("0.##") + "  m^2";
                        dataGridView1.Rows[toplam - 2].Cells[18].Value = rs7[j].ToString("0.##");
                    if (helikopterSure[j] > 0)
                        dataGridView1.Rows[toplam - 2].Cells[19].Value = helikopterSure[j].ToString("0.##") + "  dk";
                    if (toplamSonen[j] > 0)
                        dataGridView1.Rows[toplam - 2].Cells[20].Value = toplamSonen[j].ToString("0.##") + "  m^2";
                    if (toplamSure[j] > 0)
                        dataGridView1.Rows[toplam - 2].Cells[21].Value = toplamSure[j].ToString("0.##") + "  dk";
                    dataGridView1.Rows[toplam - 2].Cells[22].Value = rs7[j].ToString("0.##");
                    if (geriDonusum[j] > 0)
                        dataGridView1.Rows[toplam - 2].Cells[23].Value = geriDonusum[j].ToString("0.##") + "  m^2";
                    if (tamamenYanan[j] > 0)
                        dataGridView1.Rows[toplam - 2].Cells[24].Value = tamamenYanan[j].ToString("0.##") + "  m^2";
                    if (toplamZarar[j] > 0)
                        dataGridView1.Rows[toplam - 2].Cells[25].Value = toplamZarar[j].ToString("0.##") + "  m^2";
                }
                label8.Text = toplamz.ToString("0.##") + "  m^2";
                label9.Text = toplams.ToString("0.##") + "  m^2";
                label10.Text = toplamk.ToString("0.##") + "  m^2";
                label11.Text = toplamg.ToString("0.##") + "  m^2";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
