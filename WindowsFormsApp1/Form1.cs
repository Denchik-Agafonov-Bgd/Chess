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
using System.Timers;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int marriage = 0;
        Block[] arr_block = new Block[11];


        //-----------------------------------------

        public class Block
        {
            public int time_max;

            public Block(int value)
            {
                time_max = value;
            }
            public int time_curr { get; set; } = 0;
            public bool work { get; set; } = false;
            public int value { get; set; } = 0;
            public int value1 { get; set; } = 0;
            public int value_comp { get; set; } = 0;

        }
        public Form1()
        {
            InitializeComponent();

            label10.Text = "0";
            label11.Text = "0";
            label12.Text = "0";
            label13.Text = "0";
            label14.Text = "0";
            label15.Text = "0";
            label16.Text = "0";
            label17.Text = "0";

            label20.Text = marriage.ToString();

            button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void check_foto(Block[] arr_block, int i)
        {
                arr_block[i].work = false;
                foto(arr_block, i);
        }

        private void process(Block[] arr_block, int i)
        {
            if (arr_block[i].work == true)
            {
                arr_block[i].time_curr++;

                if (arr_block[i].time_curr == arr_block[i].time_max)
                {
                    arr_block[i].value_comp++;
                    arr_block[i].time_curr = 0;
                    switch (i)
                    {
                        case 0:
                            {
                                arr_block[i].value--;
                                arr_block[i + 1].value++;
                                arr_block[i + 1].work = true;
                                foto(arr_block, i + 1);

                                if (arr_block[i].value == 0)
                                {
                                    check_foto(arr_block, i);
                                }
                                break;
                            }

                        case 1:
                            {
                                arr_block[i].value--;

                                arr_block[i + 1].value+=40;
                                arr_block[i + 2].value+=40;
                                arr_block[i + 3].value+=40;

                                arr_block[i + 1].work = true;
                                arr_block[i + 2].work = true;
                                arr_block[i + 3].work = true;

                                foto(arr_block, i + 1);
                                foto(arr_block, i + 2);
                                foto(arr_block, i + 3);

                                if (arr_block[i].value == 0)
                                {
                                    check_foto(arr_block, i);
                                }

                                button2.Enabled = true;
                                break;
                            }

                        case 2:
                            {
                                arr_block[i].value--;
                                arr_block[i].time_max = rnd.Next(8, 12);
                                arr_block[5].value++;
                                arr_block[5].work = true;
                                foto(arr_block, 5);

                                if (arr_block[i].value == 0)
                                {
                                    check_foto(arr_block, i);
                                }
                                break;
                            }
                        case 3:
                            {
                                arr_block[i].value--;
                                arr_block[i].time_max = rnd.Next(13, 17);
                                arr_block[6].value++;
                                arr_block[6].work = true;
                                foto(arr_block, 6);

                                if (arr_block[i].value == 0)
                                {
                                    check_foto(arr_block, i);
                                }
                                break;
                            }
                        case 4:
                            {
                                arr_block[i].value--;
                                arr_block[i].time_max = rnd.Next(8, 12);
                                arr_block[8].value1++;

                                if (arr_block[8].value1 > 0 && arr_block[8].value > 0)
                                {
                                    arr_block[8].work = true;
                                    foto(arr_block, 8);
                                }

                                if (arr_block[i].value == 0)
                                {
                                    check_foto(arr_block, i);
                                }

                                break;
                            }
                        case 5:
                            {
                                arr_block[i].time_max = rnd.Next(8, 12);
                                arr_block[i].value--;
                                arr_block[7].value++;

                                if (arr_block[7].value1 > 0 && arr_block[7].value > 0)
                                {
                                    arr_block[7].work = true;
                                    foto(arr_block, 7);
                                }

                                if (arr_block[i].value == 0)
                                {
                                    check_foto(arr_block, i);
                                }

                                break;
                            }
                        case 6:
                            {
                                arr_block[i].time_max = rnd.Next(13, 17);
                                if (arr_block[i].value_comp == 1)
                                {
                                    int q = 0;
                                    q++;
                                }
                                arr_block[i].value--;
                                arr_block[7].value1++;

                                if (arr_block[7].value1 > 0 && arr_block[7].value > 0)
                                {
                                    arr_block[7].work = true;
                                    foto(arr_block, 7);
                                }



                                if (arr_block[i].value == 0)
                                {
                                    check_foto(arr_block, i);
                                }

                                break;
                            }
                        case 7:
                            {
                                arr_block[i].time_max = rnd.Next(8, 12);
                                arr_block[i].value1--;
                                arr_block[i].value--;
                                arr_block[8].value++;

                                if (arr_block[8].value1 > 0 && arr_block[8].value > 0)
                                {
                                    arr_block[8].work = true;
                                    foto(arr_block, 8);
                                }

                                if (arr_block[i].value == 0 || arr_block[i].value1 == 0)
                                {
                                    check_foto(arr_block, i);
                                }

                                break;
                            }
                        case 8:
                            {
                                if (rnd.Next(1, 100) != 99)
                                {
                                    arr_block[i + 1].value++;
                                    arr_block[i + 1].work = true;
                                    foto(arr_block, i + 1);
                                }
                                else
                                {
                                    marriage++;
                                    label20.Text = marriage.ToString();
                                }

                                arr_block[i].time_max = rnd.Next(13, 17);
                                arr_block[i].value1--;
                                arr_block[i].value--;

                                if (arr_block[i].value == 0 || arr_block[i].value1 == 0)
                                {
                                    check_foto(arr_block, i);
                                }

                                break;
                            }
                        case 9:
                            {
                                arr_block[i].time_max = rnd.Next(4, 6);
                                arr_block[i].value--;

                                arr_block[i + 1].value++;
                                
                                //foto(arr_block, i + 1);

                                if (arr_block[i].value == 0)
                                {
                                    check_foto(arr_block, i);
                                }

                                break;
                            }
                        case 10:
                            {
                                if (arr_block[i].value >= 40)
                                {

                                }


                                break;
                            }
                    }
                }
            }
        }

        private void foto(Block[] arr_block, int i)
        {
            switch (i)
            {
                case 0:
                    {
                        if (arr_block[i].work == true)
                        {
                            pictureBox1.Image = Properties.Resources.подвоз_комп_1;
                        }
                        else
                            pictureBox1.Image = Properties.Resources.подвоз_комп;
                        break;
                    }
                case 1:
                    {
                        if (arr_block[i].work == true)
                        {
                            pictureBox2.Image = Properties.Resources.Сорт_комп_1;
                        }
                        else
                            pictureBox2.Image = Properties.Resources.Сортировка;
                        break;
                    }
                case 2:
                    {
                        if (arr_block[i].work == true)
                        {
                            pictureBox3.Image = Properties.Resources.запаивание_1;
                        }
                        else
                            pictureBox3.Image = Properties.Resources.запаивание;
                        break;
                    }
                case 3:
                    {
                        if (arr_block[i].work == true)
                        {
                            pictureBox4.Image = Properties.Resources.сборка_кора_1;
                        }
                        else
                            pictureBox4.Image = Properties.Resources.Сборка_корп;
                        break;
                    }
                case 4:
                    {
                        if (arr_block[i].work == true)
                        {
                            pictureBox5.Image = Properties.Resources.Обработка_фиг_1;
                        }
                        else
                            pictureBox5.Image = Properties.Resources.Обработка_фиг;
                        break;
                    }
                case 5:
                    {
                        if (arr_block[i].work == true)
                        {
                            pictureBox6.Image = Properties.Resources.Уст_ПО_1;
                        }
                        else
                            pictureBox6.Image = Properties.Resources.Установка_ПО;
                        break;
                    }
                case 6:
                    {
                        if (arr_block[i].work == true)
                        {
                            pictureBox7.Image = Properties.Resources.Обработка_корп_1;
                        }
                        else
                            pictureBox7.Image = Properties.Resources.обработка_корп;
                        break;
                    }
                case 7:
                    {
                        if (arr_block[i].work == true)
                        {
                            pictureBox8.Image = Properties.Resources.установка_верхней_1;
                        }
                        else
                            pictureBox8.Image = Properties.Resources.установка_крышки;
                        break;
                    }
                case 8:
                    {
                        if (arr_block[i].work == true)
                        {
                            pictureBox9.Image = Properties.Resources.тестирование_1;
                        }
                        else
                            pictureBox9.Image = Properties.Resources.Тестирование;
                        break;
                    }
                case 9:
                    {
                        if (arr_block[i].work == true)
                        {
                            pictureBox10.Image = Properties.Resources.Конеч_упак_1;
                        }
                        else
                            pictureBox10.Image = Properties.Resources.Конеч_упаковка_доски;
                        break;
                    }
                case 10:
                    {
                        if (arr_block[i].work == true)
                        {
                            pictureBox11.Image = Properties.Resources.вывоз_1;
                        }
                        else
                            pictureBox11.Image = Properties.Resources.вывоз_на_склад;
                        break;
                    }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int time = 0;
            

            arr_block[0] = new Block(rnd.Next(28, 32));
            arr_block[1] = new Block(rnd.Next(28, 32));
            arr_block[2] = new Block(rnd.Next(8, 12));
            arr_block[3] = new Block(rnd.Next(13, 17));
            arr_block[4] = new Block(rnd.Next(8, 12));
            arr_block[5] = new Block(rnd.Next(8, 12));
            arr_block[6] = new Block(rnd.Next(13, 17));
            arr_block[7] = new Block(rnd.Next(8, 12));
            arr_block[8] = new Block(rnd.Next(13, 17));
            arr_block[9] = new Block(rnd.Next(4, 6));
            arr_block[10] = new Block(rnd.Next(13, 17));

            arr_block[0].value = 1;
            arr_block[0].work = true;
            pictureBox1.Image = Properties.Resources.подвоз_комп_1;

            int days = 0;

            while (true)
            {
                Vremya(time, days);
                for (int i = 0; i < 10; i++)
                {
                    process(arr_block, i);

                    await Task.Delay(1);
                }

                label10.Text = arr_block[2].value_comp.ToString();
                label11.Text = arr_block[3].value_comp.ToString();
                label12.Text = arr_block[4].value_comp.ToString();
                label13.Text = arr_block[5].value_comp.ToString();
                label14.Text = arr_block[6].value_comp.ToString();
                label15.Text = arr_block[7].value_comp.ToString();
                label16.Text = arr_block[8].value_comp.ToString();
                label17.Text = arr_block[9].value_comp.ToString();
                time++;

                if (time == 1440)
                {
                    days++;

                    time = 0;
                }
            }

            pictureBox1.Image = Properties.Resources.подвоз_комп;
            
            pictureBox2.Image = Properties.Resources.Сортировка;
                        
            pictureBox3.Image = Properties.Resources.запаивание;
   
            pictureBox4.Image = Properties.Resources.Сборка_корп;
    
            pictureBox5.Image = Properties.Resources.Обработка_фиг;
    
            pictureBox6.Image = Properties.Resources.Установка_ПО;
    
            pictureBox7.Image = Properties.Resources.обработка_корп;
    
            pictureBox8.Image = Properties.Resources.установка_крышки;
    
            pictureBox9.Image = Properties.Resources.Тестирование;
    
            pictureBox10.Image = Properties.Resources.Конеч_упаковка_доски;
    
            pictureBox11.Image = Properties.Resources.вывоз_1;

            time = 0;
            while(true)
            {
                await Task.Delay(100);

                if(time == arr_block[10].time_max)
                {
                    pictureBox11.Image = Properties.Resources.вывоз_на_склад;
                    break;
                }

                time++;
            }
        }
        private void Vremya(int time, int days)
        {
            int min, hour;
            string noll = "";
            string nol = "";
            min = time % 60;
            hour = time / 60;

            if (min < 10)
                noll = "0";
            if (hour < 10)
                nol = "0";

            string clock_sring = $"{days} суток {nol}{hour}:{noll}{min}";

            label9.Text = clock_sring;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            arr_block[0].value = 1;
            arr_block[0].work = true;
            pictureBox1.Image = Properties.Resources.подвоз_комп_1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources.вывоз_1;

            arr_block[10].work = true;

        }
    }
}
