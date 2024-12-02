using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruNo)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            buttonA.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonA.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            buttonB.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonB.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            buttonC.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonC.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            buttonD.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonD.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            buttonE.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonE.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            buttonF.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonF.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            buttonG.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonG.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            buttonH.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonH.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 9:
                        if (textBox1.Text == "ısparta")
                        {
                            buttonI.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonI.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 10:
                        if (textBox1.Text == "içel")
                        {
                            buttonIi.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonIi.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            buttonJ.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonJ.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            buttonK.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonK.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruNo++;
            this.Text = soruNo.ToString();

            if (soruNo == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                buttonA.BackColor = Color.Yellow;
            }

            if (soruNo == 2)
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü Marmara ilimiz?";
                buttonB.BackColor = Color.Yellow;
            }

            if (soruNo == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                buttonC.BackColor = Color.Yellow;
            }

            if (soruNo == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                buttonD.BackColor = Color.Yellow;
            }

            if (soruNo == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı?";
                buttonE.BackColor = Color.Yellow;
            }

            if (soruNo == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                buttonF.BackColor = Color.Yellow;
            }

            if (soruNo == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                buttonG.BackColor = Color.Yellow;
            }

            if (soruNo == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirince bakıştığı nesne?";
                buttonH.BackColor = Color.Yellow;
            }

            if (soruNo == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz?";
                buttonI.BackColor = Color.Yellow;
            }

            if (soruNo == 10)
            {
                richTextBox1.Text = "Mersinin diğer ismi?";
                buttonIi.BackColor = Color.Yellow;
            }

            if (soruNo == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk?";
                buttonJ.BackColor = Color.Yellow;
            }

            if (soruNo == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi?";
                buttonK.BackColor = Color.Yellow;
            }

            if (soruNo == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali?";
                buttonL.BackColor = Color.Yellow;
            }

            if (soruNo == 14)
            {
                richTextBox1.Text = "Yılın üçüncü ayı?";
                buttonM.BackColor = Color.Yellow;
            }

            if (soruNo == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti?";
                buttonN.BackColor = Color.Yellow;
            }

            if (soruNo == 16)
            {
                richTextBox1.Text = "Halk şairi?";
                buttonO.BackColor = Color.Yellow;
            }

            if (soruNo == 17)
            {
                richTextBox1.Text = "Çocukların pek sevmediği pirinç, havuç gibi sebzelerle yapılan yemek?";
                buttonP.BackColor = Color.Yellow;

            }

            if (soruNo == 18)
            {
                richTextBox1.Text = "11 ayın sultanı?";
                buttonR.BackColor = Color.Yellow;
            }

            if (soruNo == 19)
            {
                richTextBox1.Text = "İngilizcede yılan?";
                buttonS.BackColor = Color.Yellow;
            }

            if (soruNo == 20)
            {
                richTextBox1.Text = "Türkiyenin megastarı";
                buttonT.BackColor = Color.Yellow;
            }

            if (soruNo == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?";
                buttonU.BackColor = Color.Yellow;
            }

            if (soruNo == 22)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
                buttonV.BackColor = Color.Yellow;
            }

            if (soruNo == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
                buttonY.BackColor = Color.Yellow;
            }

            if (soruNo == 24)
            {
                richTextBox1.Text = "Ege bölgesinin en çok ağacı bulunan meyvesi?";
                buttonZ.BackColor = Color.Yellow;
            }


        }
    }
}
