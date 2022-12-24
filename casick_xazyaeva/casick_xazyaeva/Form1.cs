using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace virtual_casino_1
{
    public partial class Form1 : Form
    {
        public Random rnd = new Random();
        PictureBox pictureBox = new PictureBox();
        //Timer time = new Timer();
        public int[] slot = new int[15];
        public int count, rand1, rand2, numbers, j = 0;
        public string slot_text, money_str, bid_str, gain_str, count_str;
        public double money = 50000, winning, gain, bid = 10;
        public bool Timer_bool = true;
        public bool Timer_Auto_bool = true;



        private void timer18_Tick(object sender, EventArgs e)
        {
            timer18.Stop();

            gain_str = Convert.ToString(gain);
            gainLabel.Text = gain_str;
            gain = 0;

            money_str = Convert.ToString(money);
            label_balance.Text = money_str;
            
        }
        private void timer17_Tick(object sender, EventArgs e)
        {
            timer17.Stop();
            Timer_Auto_bool = true;

        }

        private void timer16_Tick(object sender, EventArgs e)
        {
            timer16.Stop();
            Timer_bool = true;
            Timer_Auto_bool = true;
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            if (slot[14] == 1)
            {
                timer1.Start();
                pictureBox15.Image = casick_xazyaeva.Properties.Resources.chto_qwertov;
            }
            else if (slot[14] == 2)
            {
                timer1.Start();
                pictureBox15.Image = casick_xazyaeva.Properties.Resources.plohoi_pots;
            }
            else if (slot[14] == 3)
            {
                timer1.Start();
                pictureBox15.Image = casick_xazyaeva.Properties.Resources.Sanechka_snimaesh;
            }
            else if (slot[14] == 4)
            {
                timer1.Start();
                pictureBox15.Image = casick_xazyaeva.Properties.Resources.buxoi_exile;
            }
            else if (slot[14] == 5)
            {
                timer1.Start();
                pictureBox15.Image = casick_xazyaeva.Properties.Resources.paradeevich;
            }
            else if (slot[14] == 6)
            {
                timer1.Start();
                pictureBox15.Image = casick_xazyaeva.Properties.Resources.koresh;
            }

            timer15.Stop();
            timer16.Start();
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            if (slot[13] == 1)
            {
                timer1.Start();
                pictureBox14.Image = casick_xazyaeva.Properties.Resources.chto_qwertov;
            }
            else if (slot[13] == 2)
            {
                timer1.Start();
                pictureBox14.Image = casick_xazyaeva.Properties.Resources.plohoi_pots;
            }
            else if (slot[13] == 3)
            {
                timer1.Start();
                pictureBox14.Image = casick_xazyaeva.Properties.Resources.Sanechka_snimaesh;
            }
            else if (slot[13] == 4)
            {
                timer1.Start();
                pictureBox14.Image = casick_xazyaeva.Properties.Resources.buxoi_exile;
            }
            else if (slot[13] == 5)
            {
                timer1.Start();
                pictureBox14.Image = casick_xazyaeva.Properties.Resources.paradeevich;
            }
            else if (slot[13] == 6)
            {
                timer1.Start();
                pictureBox14.Image = casick_xazyaeva.Properties.Resources.koresh;
            }

            timer14.Stop();
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            if (slot[12] == 1)
            {
                timer2.Start();
                pictureBox13.Image = casick_xazyaeva.Properties.Resources.chto_qwertov;
            }
            else if (slot[12] == 2)
            {
                timer2.Start();
                pictureBox13.Image = casick_xazyaeva.Properties.Resources.plohoi_pots;
            }
            else if (slot[12] == 3)
            {
                timer2.Start();
                pictureBox13.Image = casick_xazyaeva.Properties.Resources.Sanechka_snimaesh;
            }
            else if (slot[12] == 4)
            {
                timer2.Start();
                pictureBox13.Image = casick_xazyaeva.Properties.Resources.buxoi_exile;
            }
            else if (slot[12] == 5)
            {
                timer2.Start();
                pictureBox13.Image = casick_xazyaeva.Properties.Resources.paradeevich;
            }
            else if (slot[12] == 6)
            {
                timer2.Start();
                pictureBox13.Image = casick_xazyaeva.Properties.Resources.koresh;
            }
            timer13.Stop();
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            if (slot[11] == 1)
            {
                pictureBox12.Image = casick_xazyaeva.Properties.Resources.chto_qwertov;
            }
            else if (slot[11] == 2)
            {
                pictureBox12.Image = casick_xazyaeva.Properties.Resources.plohoi_pots;
            }
            else if (slot[11] == 3)
            {
                pictureBox12.Image = casick_xazyaeva.Properties.Resources.Sanechka_snimaesh;
            }
            else if (slot[11] == 4)
            {
                pictureBox12.Image = casick_xazyaeva.Properties.Resources.buxoi_exile;
            }
            else if (slot[11] == 5)
            {
                pictureBox12.Image = casick_xazyaeva.Properties.Resources.paradeevich;
            }
            else if (slot[11] == 6)
            {
                pictureBox12.Image = casick_xazyaeva.Properties.Resources.koresh;
            }

            timer12.Stop();
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            if (slot[10] == 1)
            {
                pictureBox11.Image = casick_xazyaeva.Properties.Resources.chto_qwertov;
            }
            else if (slot[10] == 2)
            {
                pictureBox11.Image = casick_xazyaeva.Properties.Resources.plohoi_pots;
            }
            else if (slot[10] == 3)
            {
                pictureBox11.Image = casick_xazyaeva.Properties.Resources.Sanechka_snimaesh;
            }
            else if (slot[10] == 4)
            {
                pictureBox11.Image = casick_xazyaeva.Properties.Resources.buxoi_exile;
            }
            else if (slot[10] == 5)
            {
                pictureBox11.Image = casick_xazyaeva.Properties.Resources.paradeevich;
            }
            else if (slot[10] == 6)
            {
                pictureBox11.Image = casick_xazyaeva.Properties.Resources.koresh;
            }

            timer11.Stop();
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            if (slot[9] == 1)
            {
                pictureBox10.Image = casick_xazyaeva.Properties.Resources.chto_qwertov;
            }
            else if (slot[9] == 2)
            {
                pictureBox10.Image = casick_xazyaeva.Properties.Resources.plohoi_pots;
            }
            else if (slot[9] == 3)
            {
                pictureBox10.Image = casick_xazyaeva.Properties.Resources.Sanechka_snimaesh;
            }
            else if (slot[9] == 4)
            {
                pictureBox10.Image = casick_xazyaeva.Properties.Resources.buxoi_exile;
            }
            else if (slot[9] == 5)
            {
                pictureBox10.Image = casick_xazyaeva.Properties.Resources.paradeevich;
            }
            else if (slot[9] == 6)
            {
                pictureBox10.Image = casick_xazyaeva.Properties.Resources.koresh;
            }

            timer10.Stop();
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (slot[8] == 1)
            {
                pictureBox9.Image = casick_xazyaeva.Properties.Resources.chto_qwertov;
            }
            else if (slot[8] == 2)
            {
                pictureBox9.Image = casick_xazyaeva.Properties.Resources.plohoi_pots;
            }
            else if (slot[8] == 3)
            {
                pictureBox9.Image = casick_xazyaeva.Properties.Resources.Sanechka_snimaesh;
            }
            else if (slot[8] == 4)
            {
                pictureBox9.Image = casick_xazyaeva.Properties.Resources.buxoi_exile;
            }
            else if (slot[8] == 5)
            {
                pictureBox9.Image = casick_xazyaeva.Properties.Resources.paradeevich;
            }
            else if (slot[8] == 6)
            {
                pictureBox9.Image = casick_xazyaeva.Properties.Resources.koresh;
            }

            timer9.Stop();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (slot[7] == 1)
            {
                pictureBox8.Image = casick_xazyaeva.Properties.Resources.chto_qwertov;
            }
            else if (slot[7] == 2)
            {
                pictureBox8.Image = casick_xazyaeva.Properties.Resources.plohoi_pots;
            }
            else if (slot[7] == 3)
            {
                pictureBox8.Image = casick_xazyaeva.Properties.Resources.Sanechka_snimaesh;
            }
            else if (slot[7] == 4)
            {
                pictureBox8.Image = casick_xazyaeva.Properties.Resources.buxoi_exile;
            }
            else if (slot[7] == 5)
            {
                pictureBox8.Image = casick_xazyaeva.Properties.Resources.paradeevich;
            }
            else if (slot[7] == 6)
            {
                pictureBox8.Image = casick_xazyaeva.Properties.Resources.koresh;
            }

            timer8.Stop();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (slot[6] == 1)
            {
                pictureBox7.Image = casick_xazyaeva.Properties.Resources.chto_qwertov;
            }
            else if (slot[6] == 2)
            {
                pictureBox7.Image = casick_xazyaeva.Properties.Resources.plohoi_pots;
            }
            else if (slot[6] == 3)
            {
                pictureBox7.Image = casick_xazyaeva.Properties.Resources.Sanechka_snimaesh;
            }
            else if (slot[6] == 4)
            {
                pictureBox7.Image = casick_xazyaeva.Properties.Resources.buxoi_exile;
            }
            else if (slot[6] == 5)
            {
                pictureBox7.Image = casick_xazyaeva.Properties.Resources.paradeevich;
            }
            else if (slot[6] == 6)
            {
                pictureBox7.Image = casick_xazyaeva.Properties.Resources.koresh;
            }

            timer7.Stop();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (slot[5] == 1)
            {
                pictureBox6.Image = casick_xazyaeva.Properties.Resources.chto_qwertov;
            }
            else if (slot[5] == 2)
            {
                pictureBox6.Image = casick_xazyaeva.Properties.Resources.plohoi_pots;
            }
            else if (slot[5] == 3)
            {
                pictureBox6.Image = casick_xazyaeva.Properties.Resources.Sanechka_snimaesh;
            }
            else if (slot[5] == 4)
            {
                pictureBox6.Image = casick_xazyaeva.Properties.Resources.buxoi_exile;
            }
            else if (slot[5] == 5)
            {
                pictureBox6.Image = casick_xazyaeva.Properties.Resources.paradeevich;
            }
            else if (slot[5] == 6)
            {
                pictureBox6.Image = casick_xazyaeva.Properties.Resources.koresh;
            }

            timer6.Stop();
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            if (slot[4] == 1)
            {
                pictureBox5.Image = casick_xazyaeva.Properties.Resources.chto_qwertov;
            }
            else if (slot[4] == 2)
            {
                pictureBox5.Image = casick_xazyaeva.Properties.Resources.plohoi_pots;
            }
            else if (slot[4] == 3)
            {
                pictureBox5.Image = casick_xazyaeva.Properties.Resources.Sanechka_snimaesh;
            }
            else if (slot[4] == 4)
            {
                pictureBox5.Image = casick_xazyaeva.Properties.Resources.buxoi_exile;
            }
            else if (slot[4] == 5)
            {
                pictureBox5.Image = casick_xazyaeva.Properties.Resources.paradeevich;
            }
            else if (slot[4] == 6)
            {
                pictureBox5.Image = casick_xazyaeva.Properties.Resources.koresh;
            }

            timer5.Stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (slot[3] == 1)
            {
                pictureBox4.Image = casick_xazyaeva.Properties.Resources.chto_qwertov;
            }
            else if (slot[3] == 2)
            {
                pictureBox4.Image = casick_xazyaeva.Properties.Resources.plohoi_pots;
            }
            else if (slot[3] == 3)
            {
                pictureBox4.Image = casick_xazyaeva.Properties.Resources.Sanechka_snimaesh;
            }
            else if (slot[3] == 4)
            {
                pictureBox4.Image = casick_xazyaeva.Properties.Resources.buxoi_exile;
            }
            else if (slot[3] == 5)
            {
                pictureBox4.Image = casick_xazyaeva.Properties.Resources.paradeevich;
            }
            else if (slot[3] == 6)
            {
                pictureBox4.Image = casick_xazyaeva.Properties.Resources.koresh;
            }

            timer4.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (slot[2] == 1)
            {
                pictureBox3.Image = casick_xazyaeva.Properties.Resources.chto_qwertov;
            }
            else if (slot[2] == 2)
            {
                pictureBox3.Image = casick_xazyaeva.Properties.Resources.plohoi_pots;
            }
            else if (slot[2] == 3)
            {
                pictureBox3.Image = casick_xazyaeva.Properties.Resources.Sanechka_snimaesh;
            }
            else if (slot[2] == 4)
            {
                pictureBox3.Image = casick_xazyaeva.Properties.Resources.buxoi_exile;
            }
            else if (slot[2] == 5)
            {
                pictureBox3.Image = casick_xazyaeva.Properties.Resources.paradeevich;
            }
            else if (slot[2] == 6)
            {
                pictureBox3.Image = casick_xazyaeva.Properties.Resources.koresh;
            }

            timer3.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (slot[1] == 1)
            {
                pictureBox2.Image = casick_xazyaeva.Properties.Resources.chto_qwertov;
            }
            else if (slot[1] == 2)
            {
                pictureBox2.Image = casick_xazyaeva.Properties.Resources.plohoi_pots;
            }
            else if (slot[1] == 3)
            {
                pictureBox2.Image = casick_xazyaeva.Properties.Resources.Sanechka_snimaesh;
            }
            else if (slot[1] == 4)
            {
                pictureBox2.Image = casick_xazyaeva.Properties.Resources.buxoi_exile;
            }
            else if (slot[1] == 5)
            {
                pictureBox2.Image = casick_xazyaeva.Properties.Resources.paradeevich;
            }
            else if (slot[1] == 6)
            {
                pictureBox2.Image = casick_xazyaeva.Properties.Resources.koresh;
            }

            timer2.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (slot[0] == 1)
            {
                pictureBox1.Image = casick_xazyaeva.Properties.Resources.chto_qwertov;
            }
            else if (slot[0] == 2)
            {
                pictureBox1.Image = casick_xazyaeva.Properties.Resources.plohoi_pots;
            }
            else if (slot[0] == 3)
            {
                pictureBox1.Image = casick_xazyaeva.Properties.Resources.Sanechka_snimaesh;
            }
            else if (slot[0] == 4)
            {
                pictureBox1.Image = casick_xazyaeva.Properties.Resources.buxoi_exile;
            }
            else if (slot[0] == 5)
            {
                pictureBox1.Image = casick_xazyaeva.Properties.Resources.paradeevich;
            }
            else if (slot[0] == 6)
            {
                pictureBox1.Image = casick_xazyaeva.Properties.Resources.koresh;
            }

            timer1.Stop();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();

            //bid_str = bidBox.Text;
            //bid_str = Convert.ToString(bid);
            //bid = Convert.ToInt32(bid_str);
            //bid_str = Convert.ToString(bid);

            money_str = Convert.ToString(money);
            label_balance.Text = money_str;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bid_str = bidBox.Text;
            bool bid_bool = Double.TryParse(bid_str, out bid);
            if (bid_bool && money >= bid && bid >= 3)
            {
                if (Timer_bool)
                {
                    label_check.Text = null;

                    money = money - bid;
                    money_str = Convert.ToString(money);
                    label_balance.Text = money_str;

                    gain_str = Convert.ToString(gain);
                    gainLabel.Text = gain_str;

                    for (int i = 0; i < slot.Length; i++)
                    {
                        slot[i] = rnd.Next(1, 7);
                        slot_text = Convert.ToString(slot[i]);

                        rand1 = rnd.Next(1, 101);
                        if(rand1 <= 4)
                        {
                            if((slot[0] == 1 || slot[2] == 1) && (i == 1 || i == 3)) 
                            {
                                rand1 = rnd.Next(1, 3);
                            }
                            else if ((slot[5] == 1 || slot[7] == 1) && (i == 5 || i == 8))
                            {
                                rand1 = rnd.Next(1, 3);
                            }
                            else if ((slot[10] == 1 || slot[12] == 1) && (i == 10 || i == 13))
                            {
                                rand1 = rnd.Next(1, 3);
                            }
                            else
                            rand1 = rnd.Next(1, 4);
                        }
                        else if(rand1 <= 6)
                        {
                            if ((slot[0] == 2 || slot[2] == 2) && (i == 1 || i == 3))
                            {
                                rand1 = rnd.Next(2, 4);
                            }
                            else if ((slot[5] == 2 || slot[7] == 2) && (i == 5 || i == 8))
                            {
                                rand1 = rnd.Next(2, 4);
                            }
                            else if ((slot[10] == 2 || slot[12] == 2) && (i == 10 || i == 13))
                            {
                                rand1 = rnd.Next(2, 4);
                            }
                            else
                            rand1 = rnd.Next(2, 5);
                        }
                        else if( rand1 <= 10)
                        {
                            if (slot[0] == slot[1] && i == 2)
                            {

                            }
                            if ((slot[0] == 3 || slot[2] == 3) && (i == 1 || i == 3))
                            {
                                rand1 = rnd.Next(3, 5);
                            }
                            else if ((slot[5] == 3 || slot[7] == 3) && (i == 5 || i == 8))
                            {
                                rand1 = rnd.Next(3, 5);
                            }
                            else if ((slot[10] == 3 || slot[12] == 3) && (i == 10 || i == 13))
                            {
                                rand1 = rnd.Next(3, 5);
                            }
                            else
                            slot[i] = rnd.Next(2, 6);
                        }
                        else if(rand1 <= 15)
                        {
                            slot[i] = rnd.Next(4, 7);
                        }
                        else if(rand1 <= 25)
                        {
                            slot[i] = rnd.Next(3, 7);
                        }
                        else
                        {
                            slot[i] = rnd.Next(2, 7);
                        }

                    }
                    Timer_bool = false;
                    for (int i = 0; i < slot.Length; i++)
                    {

                        switch (i)
                        {
                            case 0:
                                timer1.Start();
                                timer16.Start();
                                break;
                            case 5:
                                timer6.Start();
                                break;
                            case 10:
                                timer11.Start();
                                break;
                        }
                    }
                    for (int i = 0; i < slot.Length; i++)
                    {
                        switch (i)
                        {
                            case 1:
                                timer12.Start();
                                break;
                            case 6:
                                timer7.Start();
                                break;
                            case 11:
                                timer2.Start();
                                break;
                        }
                    }
                    for (int i = 0; i < slot.Length; i++)
                    {
                        switch (i)
                        {
                            case 2:
                                timer3.Start();
                                break;
                            case 7:
                                timer8.Start();
                                break;
                            case 12:
                                timer13.Start();
                                break;
                        }
                    }
                    for (int i = 0; i < slot.Length; i++)
                    {
                        switch (i)
                        {
                            case 3:
                                timer14.Start();
                                break;
                            case 8:
                                timer9.Start();
                                break;
                            case 13:
                                timer4.Start();
                                break;
                        }
                    }
                    for (int i = 0; i < slot.Length; i++)
                    {
                        switch (i)
                        {
                            case 4:
                                timer5.Start();
                                break;
                            case 9:
                                timer10.Start();
                                break;
                            case 14:
                                timer15.Start();
                                break;
                        }
                    }




                    // 1
                    if (slot[0] == 1 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4]))
                    {
                        winning = bid * 120;
                        gain += winning;
                    }
                    else if ((slot[0] == 1 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3])) || (slot[1] == 1 && (slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4])))
                    {
                        winning = bid * 25;
                        gain += winning;
                    }
                    else if ((slot[0] == 1 && (slot[0] == slot[1] && slot[1] == slot[2])) || (slot[2] == 1 && (slot[2] == slot[3] && slot[3] == slot[4])))
                    {
                        winning = bid * 10;
                        gain += winning;
                    }


                    if (slot[5] == 1 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9]))
                    {
                        winning = bid * 120;
                        gain += winning;
                    }
                    else if ((slot[5] == 1 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8])) || (slot[6] == 1 && (slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9])))
                    {
                        winning = bid * 25;
                        gain += winning;
                    }
                    else if ((slot[5] == 1 && (slot[5] == slot[6] && slot[6] == slot[7])) || (slot[7] == 1 && (slot[7] == slot[8] && slot[8] == slot[9])))
                    {
                        winning = bid * 10;
                        gain += winning;
                    }


                    if (slot[10] == 1 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14]))
                    {
                        winning = bid * 120;
                        gain += winning;
                    }
                    else if ((slot[10] == 1 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13])) || (slot[11] == 1 && (slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14])))
                    {
                        winning = bid * 25;
                        gain += winning;
                    }
                    else if ((slot[10] == 1 && (slot[10] == slot[11] && slot[11] == slot[12])) || (slot[12] == 1 && (slot[12] == slot[13] && slot[13] == slot[14])))
                    {
                        winning = bid * 10;
                        gain += winning;
                    }



                    // 2
                    if (slot[0] == 2 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4]))
                    {
                        winning = bid * 50;
                        gain += winning;
                    }
                    else if ((slot[0] == 2 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3])) || (slot[1] == 2 && (slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4])))
                    {
                        winning = bid * 15;
                        gain += winning;
                    }
                    else if ((slot[0] == 2 && (slot[0] == slot[1] && slot[1] == slot[2])) || (slot[2] == 2 && (slot[2] == slot[3] && slot[3] == slot[4])))
                    {
                        winning = bid * 6;
                        gain += winning;
                    }


                    if (slot[5] == 2 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9]))
                    {
                        winning = bid * 50;
                        gain += winning;
                    }
                    else if ((slot[5] == 2 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8])) || (slot[6] == 2 && (slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9])))
                    {
                        winning = bid * 15;
                        gain += winning;
                    }
                    else if ((slot[5] == 2 && (slot[5] == slot[6] && slot[6] == slot[7])) || (slot[7] == 2 && (slot[7] == slot[8] && slot[8] == slot[9])))
                    {
                        winning = bid * 6;
                        gain += winning;
                    }


                    if (slot[10] == 2 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14]))
                    {
                        winning = bid * 50;
                        gain += winning;
                    }
                    else if ((slot[10] == 2 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13])) || (slot[11] == 2 && (slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14])))
                    {
                        winning = bid * 15;
                        gain += winning;
                    }
                    else if ((slot[10] == 2 && (slot[10] == slot[11] && slot[11] == slot[12])) || (slot[12] == 2 && (slot[12] == slot[13] && slot[13] == slot[14])))
                    {
                        winning = bid * 6;
                        gain += winning;
                    }



                    // 3
                    if (slot[0] == 3 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4]))
                    {
                        winning = bid * 25;
                        gain += winning;
                    }
                    else if ((slot[0] == 3 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3])) || (slot[1] == 3 && (slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4])))
                    {
                        winning = bid * 6;
                        gain += winning;
                    }
                    else if ((slot[0] == 3 && (slot[0] == slot[1] && slot[1] == slot[2])) || (slot[2] == 3 && (slot[2] == slot[3] && slot[3] == slot[4])))
                    {
                        winning = bid * 3;
                        gain += winning;
                    }


                    if (slot[5] == 3 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9]))
                    {
                        winning = bid * 25;
                        gain += winning;
                    }
                    else if ((slot[5] == 3 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8])) || (slot[6] == 3 && (slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9])))
                    {
                        winning = bid * 6;
                        gain += winning;
                    }
                    else if ((slot[5] == 3 && (slot[5] == slot[6] && slot[6] == slot[7])) || (slot[7] == 3 && (slot[7] == slot[8] && slot[8] == slot[9])))
                    {
                        winning = bid * 3;
                        gain += winning;
                    }


                    if (slot[10] == 3 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14]))
                    {
                        winning = bid * 25;
                        gain += winning;
                    }
                    else if ((slot[10] == 3 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13])) || (slot[11] == 3 && (slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14])))
                    {
                        winning = bid * 6;
                        gain += winning;
                    }
                    else if ((slot[10] == 3 && (slot[10] == slot[11] && slot[11] == slot[12])) || (slot[12] == 3 && (slot[12] == slot[13] && slot[13] == slot[14])))
                    {
                        winning = bid * 3;
                        gain += winning;
                    }



                    // 4
                    if (slot[0] == 4 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4]))
                    {
                        winning = bid * 15;
                        gain += winning;
                    }
                    else if ((slot[0] == 4 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3])) || (slot[1] == 4 && (slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4])))
                    {
                        winning = bid * 3;
                        gain += winning;
                    }
                    else if ((slot[0] == 4 && (slot[0] == slot[1] && slot[1] == slot[2])) || (slot[2] == 4 && (slot[2] == slot[3] && slot[3] == slot[4])))
                    {
                        winning = bid * 1.5;
                        gain += winning;
                    }


                    if (slot[5] == 4 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9]))
                    {
                        winning = bid * 15;
                        gain += winning;
                    }
                    else if ((slot[5] == 4 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8])) || (slot[6] == 4 && (slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9])))
                    {
                        winning = bid * 3;
                        gain += winning;
                    }
                    else if ((slot[5] == 4 && (slot[5] == slot[6] && slot[6] == slot[7])) || (slot[7] == 4 && (slot[7] == slot[8] && slot[8] == slot[9])))
                    {
                        winning = bid * 1.5;
                        gain += winning;
                    }


                    if (slot[10] == 4 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14]))
                    {
                        winning = bid * 15;
                        gain += winning;
                    }
                    else if ((slot[10] == 4 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13])) || (slot[11] == 4 && (slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14])))
                    {
                        winning = bid * 3;
                        gain += winning;
                    }
                    else if ((slot[10] == 4 && (slot[10] == slot[11] && slot[11] == slot[12])) || (slot[12] == 4 && (slot[12] == slot[13] && slot[13] == slot[14])))
                    {
                        winning = bid * 1.5;
                        gain += winning;
                    }



                    // 5
                    if (slot[0] == 5 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4]))
                    {
                        winning = bid * 5;
                        gain += winning;
                    }
                    else if ((slot[0] == 5 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3])) || (slot[1] == 5 && (slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4])))
                    {
                        winning = bid * 2;
                        gain += winning;
                    }
                    else if ((slot[0] == 5 && (slot[0] == slot[1] && slot[1] == slot[2])) || (slot[2] == 5 && (slot[2] == slot[3] && slot[3] == slot[4])))
                    {
                        winning = bid * 1;
                        gain += winning;
                    }


                    if (slot[5] == 5 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9]))
                    {
                        winning = bid * 5;
                        gain += winning;
                    }
                    else if ((slot[5] == 5 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8])) || (slot[6] == 5 && (slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9])))
                    {
                        winning = bid * 2;
                        gain += winning;
                    }
                    else if ((slot[5] == 5 && (slot[5] == slot[6] && slot[6] == slot[7])) || (slot[7] == 5 && (slot[7] == slot[8] && slot[8] == slot[9])))
                    {
                        winning = bid * 1;
                        gain += winning;
                    }


                    if (slot[10] == 5 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14]))
                    {
                        winning = bid * 5;
                        gain += winning;
                    }
                    else if ((slot[10] == 5 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13])) || (slot[11] == 5 && (slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14])))
                    {
                        winning = bid * 2;
                        gain += winning;
                    }
                    else if ((slot[10] == 5 && (slot[10] == slot[11] && slot[11] == slot[12])) || (slot[12] == 5 && (slot[12] == slot[13] && slot[13] == slot[14])))
                    {
                        winning = bid * 1;
                        gain += winning;
                    }



                    // 6
                    if (slot[0] == 6 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4]))
                    {
                        winning = bid * 2.5;
                        gain += winning;
                    }
                    else if ((slot[0] == 6 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3])) || (slot[1] == 6 && (slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4])))
                    {
                        winning = bid * 1;
                        gain += winning;
                    }
                    else if ((slot[0] == 6 && (slot[0] == slot[1] && slot[1] == slot[2])) || (slot[2] == 6 && (slot[2] == slot[3] && slot[3] == slot[4])))
                    {
                        winning = bid * 0.5;
                        gain += winning;
                    }


                    if (slot[5] == 6 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9]))
                    {
                        winning = bid * 2.5;
                        gain += winning;
                    }
                    else if ((slot[5] == 6 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8])) || (slot[6] == 6 && (slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9])))
                    {
                        gain = bid * 1;
                        gain += winning;
                    }
                    else if ((slot[5] == 6 && (slot[5] == slot[6] && slot[6] == slot[7])) || (slot[7] == 6 && (slot[7] == slot[8] && slot[8] == slot[9])))
                    {
                        winning = bid * 0.5;
                        gain += winning;
                    }


                    if (slot[10] == 6 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14]))
                    {
                        winning = bid * 2.5;
                        gain += winning;
                    }
                    if ((slot[10] == 6 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13])) || (slot[11] == 6 && (slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14])))
                    {
                        winning = bid * 1;
                        gain += winning;
                    }
                    if ((slot[10] == 6 && (slot[10] == slot[11] && slot[11] == slot[12])) || (slot[12] == 6 && (slot[12] == slot[13] && slot[13] == slot[14])))
                    {
                        winning = bid * 0.5;
                        gain += winning;
                    }
                    timer18.Start();
                    money += gain;
                    
                }
            }
            else if (money < bid)
            {
                label_check.Text = "Пополните баланс!";
            }
            else if (bid < 3 && bid_bool)
            {
                label_check.Text = "Минимальная ставка 3!";
            }
            else
            {
                label_check.Text = "Введите ставку!";
            }
        }
        private void button_Auto_Click(object sender, EventArgs e)
        {
            count_str = textBox_auto.Text;
            bool count_bool = int.TryParse(count_str, out count);
            if (count_bool)
            {
                
                bid_str = bidBox.Text;
                bool bid_bool = Double.TryParse(bid_str, out bid);
                if (bid_bool && money >= bid * count && bid >= 3)
                {
                    if (Timer_bool)
                    {
                        money = money - (bid * count);
                        for (int j = 0; j < count; j++)
                        {
                            
                                label_check.Text = null;

                                //money -= bid;
                                money_str = Convert.ToString(money);
                                label_balance.Text = money_str;
                                for (int i = 0; i < slot.Length; i++)
                                {
                                    slot[i] = rnd.Next(1, 7);
                                    slot_text = Convert.ToString(slot[i]);


                                }
                                Timer_bool = false;
                                Timer_Auto_bool = false;
                                for (int u = 0; u < slot.Length; u++)
                                {
                                    switch (u)
                                    {
                                        case 0:
                                            timer1.Start();
                                            break;
                                        case 5:
                                            timer6.Start();
                                            break;
                                        case 10:
                                            timer11.Start();
                                            break;
                                    }
                                }
                                for (int u = 0; u < slot.Length; u++)
                                {
                                    switch (u)
                                    {
                                        case 1:
                                            timer2.Start();
                                            break;
                                        case 6:
                                            timer7.Start();
                                            break;
                                        case 11:
                                            timer12.Start();
                                            break;
                                    }
                                }
                                for (int u = 0; u < slot.Length; u++)
                                {
                                    switch (u)
                                    {
                                        case 2:
                                            timer3.Start();
                                            break;
                                        case 7:
                                            timer8.Start();
                                            break;
                                        case 12:
                                            timer13.Start();
                                            break;
                                    }
                                }
                                for (int u = 0; u < slot.Length; u++)
                                {


                                    switch (u)
                                    {
                                        case 3:
                                            timer4.Start();
                                            break;
                                        case 8:
                                            timer9.Start();
                                            break;
                                        case 13:
                                            timer14.Start();
                                            break;
                                    }
                                }
                                for (int u = 0; u < slot.Length; u++)
                                {
                                    switch (u)
                                    {
                                        case 4:
                                            timer5.Start();
                                            break;
                                        case 9:
                                            timer10.Start();
                                            break;
                                        case 14:
                                            timer15.Start();
                                            timer16.Start();
                                            break;
                                    }
                                }

                                // 1
                                if (slot[0] == 1 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4]))
                                {
                                    winning = bid * 120;
                                    gain += winning;
                                }
                                else if ((slot[0] == 1 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3])) || (slot[1] == 1 && (slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4])))
                                {
                                    winning = bid * 25;
                                    gain += winning;
                                }
                                else if ((slot[0] == 1 && (slot[0] == slot[1] && slot[1] == slot[2])) || (slot[2] == 1 && (slot[2] == slot[3] && slot[3] == slot[4])))
                                {
                                    winning = bid * 10;
                                    gain += winning;
                                }


                                if (slot[5] == 1 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9]))
                                {
                                    winning = bid * 120;
                                    gain += winning;
                                }
                                else if ((slot[5] == 1 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8])) || (slot[6] == 1 && (slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9])))
                                {
                                    winning = bid * 25;
                                    gain += winning;
                                }
                                else if ((slot[5] == 1 && (slot[5] == slot[6] && slot[6] == slot[7])) || (slot[7] == 1 && (slot[7] == slot[8] && slot[8] == slot[9])))
                                {
                                    winning = bid * 10;
                                    gain += winning;
                                }


                                if (slot[10] == 1 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14]))
                                {
                                    winning = bid * 120;
                                    gain += winning;
                                }
                                else if ((slot[10] == 1 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13])) || (slot[11] == 1 && (slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14])))
                                {
                                    winning = bid * 25;
                                    gain += winning;
                                }
                                else if ((slot[10] == 1 && (slot[10] == slot[11] && slot[11] == slot[12])) || (slot[12] == 1 && (slot[12] == slot[13] && slot[13] == slot[14])))
                                {
                                    winning = bid * 10;
                                    gain += winning;
                                }



                                // 2
                                if (slot[0] == 2 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4]))
                                {
                                    winning = bid * 50;
                                    gain += winning;
                                }
                                else if ((slot[0] == 2 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3])) || (slot[1] == 2 && (slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4])))
                                {
                                    winning = bid * 15;
                                    gain += winning;
                                }
                                else if ((slot[0] == 2 && (slot[0] == slot[1] && slot[1] == slot[2])) || (slot[2] == 2 && (slot[2] == slot[3] && slot[3] == slot[4])))
                                {
                                    winning = bid * 6;
                                    gain += winning;
                                }


                                if (slot[5] == 2 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9]))
                                {
                                    winning = bid * 50;
                                    gain += winning;
                                }
                                else if ((slot[5] == 2 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8])) || (slot[6] == 2 && (slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9])))
                                {
                                    winning = bid * 15;
                                    gain += winning;
                                }
                                else if ((slot[5] == 2 && (slot[5] == slot[6] && slot[6] == slot[7])) || (slot[7] == 2 && (slot[7] == slot[8] && slot[8] == slot[9])))
                                {
                                    winning = bid * 6;
                                    gain += winning;
                                }


                                if (slot[10] == 2 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14]))
                                {
                                    winning = bid * 50;
                                    gain += winning;
                                }
                                else if ((slot[10] == 2 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13])) || (slot[11] == 2 && (slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14])))
                                {
                                    winning = bid * 15;
                                    gain += winning;
                                }
                                else if ((slot[10] == 2 && (slot[10] == slot[11] && slot[11] == slot[12])) || (slot[12] == 2 && (slot[12] == slot[13] && slot[13] == slot[14])))
                                {
                                    winning = bid * 6;
                                    gain += winning;
                                }



                                // 3
                                if (slot[0] == 3 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4]))
                                {
                                    winning = bid * 25;
                                    gain += winning;
                                }
                                else if ((slot[0] == 3 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3])) || (slot[1] == 3 && (slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4])))
                                {
                                    winning = bid * 6;
                                    gain += winning;
                                }
                                else if ((slot[0] == 3 && (slot[0] == slot[1] && slot[1] == slot[2])) || (slot[2] == 3 && (slot[2] == slot[3] && slot[3] == slot[4])))
                                {
                                    winning = bid * 3;
                                    gain += winning;
                                }


                                if (slot[5] == 3 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9]))
                                {
                                    winning = bid * 25;
                                    gain += winning;
                                }
                                else if ((slot[5] == 3 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8])) || (slot[6] == 3 && (slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9])))
                                {
                                    winning = bid * 6;
                                    gain += winning;
                                }
                                else if ((slot[5] == 3 && (slot[5] == slot[6] && slot[6] == slot[7])) || (slot[7] == 3 && (slot[7] == slot[8] && slot[8] == slot[9])))
                                {
                                    winning = bid * 3;
                                    gain += winning;
                                }


                                if (slot[10] == 3 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14]))
                                {
                                    winning = bid * 25;
                                    gain += winning;
                                }
                                else if ((slot[10] == 3 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13])) || (slot[11] == 3 && (slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14])))
                                {
                                    winning = bid * 6;
                                    gain += winning;
                                }
                                else if ((slot[10] == 3 && (slot[10] == slot[11] && slot[11] == slot[12])) || (slot[12] == 3 && (slot[12] == slot[13] && slot[13] == slot[14])))
                                {
                                    winning = bid * 3;
                                    gain += winning;
                                }



                                // 4
                                if (slot[0] == 4 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4]))
                                {
                                    winning = bid * 15;
                                    gain += winning;
                                }
                                else if ((slot[0] == 4 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3])) || (slot[1] == 4 && (slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4])))
                                {
                                    winning = bid * 3;
                                    gain += winning;
                                }
                                else if ((slot[0] == 4 && (slot[0] == slot[1] && slot[1] == slot[2])) || (slot[2] == 4 && (slot[2] == slot[3] && slot[3] == slot[4])))
                                {
                                    winning = bid * 1.5;
                                    gain += winning;
                                }


                                if (slot[5] == 4 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9]))
                                {
                                    winning = bid * 15;
                                    gain += winning;
                                }
                                else if ((slot[5] == 4 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8])) || (slot[6] == 4 && (slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9])))
                                {
                                    winning = bid * 3;
                                    gain += winning;
                                }
                                else if ((slot[5] == 4 && (slot[5] == slot[6] && slot[6] == slot[7])) || (slot[7] == 4 && (slot[7] == slot[8] && slot[8] == slot[9])))
                                {
                                    winning = bid * 1.5;
                                    gain += winning;
                                }


                                if (slot[10] == 4 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14]))
                                {
                                    winning = bid * 15;
                                    gain += winning;
                                }
                                else if ((slot[10] == 4 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13])) || (slot[11] == 4 && (slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14])))
                                {
                                    winning = bid * 3;
                                    gain += winning;
                                }
                                else if ((slot[10] == 4 && (slot[10] == slot[11] && slot[11] == slot[12])) || (slot[12] == 4 && (slot[12] == slot[13] && slot[13] == slot[14])))
                                {
                                    winning = bid * 1.5;
                                    gain += winning;
                                }



                                // 5
                                if (slot[0] == 5 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4]))
                                {
                                    winning = bid * 5;
                                    gain += winning;
                                }
                                else if ((slot[0] == 5 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3])) || (slot[1] == 5 && (slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4])))
                                {
                                    winning = bid * 2;
                                    gain += winning;
                                }
                                else if ((slot[0] == 5 && (slot[0] == slot[1] && slot[1] == slot[2])) || (slot[2] == 5 && (slot[2] == slot[3] && slot[3] == slot[4])))
                                {
                                    winning = bid * 1;
                                    gain += winning;
                                }


                                if (slot[5] == 5 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9]))
                                {
                                    winning = bid * 5;
                                    gain += winning;
                                }
                                else if ((slot[5] == 5 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8])) || (slot[6] == 5 && (slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9])))
                                {
                                    winning = bid * 2;
                                    gain += winning;
                                }
                                else if ((slot[5] == 5 && (slot[5] == slot[6] && slot[6] == slot[7])) || (slot[7] == 5 && (slot[7] == slot[8] && slot[8] == slot[9])))
                                {
                                    winning = bid * 1;
                                    gain += winning;
                                }


                                if (slot[10] == 5 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14]))
                                {
                                    winning = bid * 5;
                                    gain += winning;
                                }
                                else if ((slot[10] == 5 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13])) || (slot[11] == 5 && (slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14])))
                                {
                                    winning = bid * 2;
                                    gain += winning;
                                }
                                else if ((slot[10] == 5 && (slot[10] == slot[11] && slot[11] == slot[12])) || (slot[12] == 5 && (slot[12] == slot[13] && slot[13] == slot[14])))
                                {
                                    winning = bid * 1;
                                    gain += winning;
                                }



                                // 6
                                if (slot[0] == 6 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4]))
                                {
                                    winning = bid * 2.5;
                                    gain += winning;
                                }
                                else if ((slot[0] == 6 && (slot[0] == slot[1] && slot[1] == slot[2] && slot[2] == slot[3])) || (slot[1] == 6 && (slot[1] == slot[2] && slot[2] == slot[3] && slot[3] == slot[4])))
                                {
                                    winning = bid * 1;
                                    gain += winning;
                                }
                                else if ((slot[0] == 6 && (slot[0] == slot[1] && slot[1] == slot[2])) || (slot[2] == 6 && (slot[2] == slot[3] && slot[3] == slot[4])))
                                {
                                    winning = bid * 0.5;
                                    gain += winning;
                                }


                                if (slot[5] == 6 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9]))
                                {
                                    winning = bid * 2.5;
                                    gain += winning;
                                }
                                else if ((slot[5] == 6 && (slot[5] == slot[6] && slot[6] == slot[7] && slot[7] == slot[8])) || (slot[6] == 6 && (slot[6] == slot[7] && slot[7] == slot[8] && slot[8] == slot[9])))
                                {
                                    gain = bid * 1;
                                    gain += winning;
                                }
                                else if ((slot[5] == 6 && (slot[5] == slot[6] && slot[6] == slot[7])) || (slot[7] == 6 && (slot[7] == slot[8] && slot[8] == slot[9])))
                                {
                                    winning = bid * 0.5;
                                    gain += winning;
                                }


                                if (slot[10] == 6 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14]))
                                {
                                    winning = bid * 2.5;
                                    gain += winning;
                                }
                                if ((slot[10] == 6 && (slot[10] == slot[11] && slot[11] == slot[12] && slot[12] == slot[13])) || (slot[11] == 6 && (slot[11] == slot[12] && slot[12] == slot[13] && slot[13] == slot[14])))
                                {
                                    winning = bid * 1;
                                    gain += winning;
                                }
                                if ((slot[10] == 6 && (slot[10] == slot[11] && slot[11] == slot[12])) || (slot[12] == 6 && (slot[12] == slot[13] && slot[13] == slot[14])))
                                {
                                    winning = bid * 0.5;
                                    gain += winning;
                                }
                                //System.Threading.Timer(2000);

                                //money += gain;
                                gain_str = Convert.ToString(gain);
                                gainLabel.Text = gain_str;
                                //gain = 0;
                            }
                        }
                        money += gain;
                        money_str = Convert.ToString(money);
                        label_balance.Text = money_str;

                        gain = 0;
                    }
                else if (money < bid * count)
                {
                    label_check.Text = "Top up your balance!";
                }
                else if (bid < 3 && bid_bool)
                {
                    label_check.Text = "Minimum bet 3!";
                }
                else
                {
                    label_check.Text = "Enter your rate!";
                }
            }
            else
            {
                label_check.Text = "Fill in the field!";
            }
        }
    }
}
