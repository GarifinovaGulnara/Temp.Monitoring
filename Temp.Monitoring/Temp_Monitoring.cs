using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temp.Monitoring
{
    public partial class Temp_Monitoring : Form
    {

        int maxCount;
        int minCount;
        public Temp_Monitoring()
        {
            InitializeComponent();
        }

        private void cbVidFish_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVidFish.SelectedItem.ToString() == ("Семга"))
            {
                TempForMax.Text = ("5");
                TempForMin.Text = ("-3");
                TimeForMax.Text = ("20");
                TimeForMin.Text = ("60");
            }
            else if (cbVidFish.SelectedItem.ToString() == ("Замороженный минтай"))
            {
                TempForMax.Text = ("-5");
                TempForMin.Text = (" ");
                TimeForMax.Text = ("20");
                TimeForMin.Text = (" ");
            }
        }

        private void GraficFish()
        {
            maxCount = 0;
            minCount = 0;
            int norma;
            try
            {
                string tem = TempRid.Text;
                string[] temper = tem.Split(',', '.', ';', ' ');
                int[] inttemp = new int[temper.Length];
                for (int i = 0; i < temper.Length; i++)
                {
                    inttemp[i] = Int32.Parse(temper[i]);
                }
                for (int i = 0; i < temper.Length; i++)
                {
                    if (inttemp[i] < 0)
                    {
                        norma = Convert.ToInt32(TempForMin.Text);
                    }
                    else
                    {
                        norma = Convert.ToInt32(TempForMax.Text);
                    }
                    dgvGrafik.Rows.Add();
                    dgvGrafik[0, i].Value = "2";
                    dgvGrafik[1, i].Value = inttemp[i];
                    dgvGrafik[2, i].Value = norma;
                    dgvGrafik[3, i].Value = inttemp[i] - norma;
                    
                }
                for (int i = 0; i < temper.Length; i++)
                {
                    int count = Convert.ToInt32(dgvGrafik[3, i].Value);
                    if (inttemp[i] > 0 && count > 0)
                    {
                        maxCount += 1;
                    }
                    else
                    {
                        continue;
                    }
                    if (inttemp[i] < 0 && count < 0)
                    {
                        minCount += 1;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неверные значения в строке Температура");
            }

        }

        private void Otchet()
        {
            if ((maxCount * 10) > 20)
            {
                textOtchet.Text = "Порог максимально допустимой нормы превышен на" + $"{maxCount * 10} минут";
            }
            if ((minCount * 10) < 60)
            {
                textOtchet.Text = "Порог минимальной  допустимой нормы превышен на" + $"{minCount * 10} минут";
            }
        }

        private void CreateOtchet_Click(object sender, EventArgs e)
        {
            Otchet();
            GraficFish();
            
        }
    }
}
