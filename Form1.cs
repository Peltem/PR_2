﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PZ_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Zach.Controls[0].Enabled = false;
            Zach.Controls[0].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sem_TextChanged(object sender, EventArgs e)
        {
         
            
        }
         public class Sessia
            {
                private int _semestr;
                private int _zacheti;
                private int _ekzameni;
                private int _zachet;
                public int Semestr
                {
                    get { return _semestr; }
                    set
                    {
                        if (1 < value && value < 8) { _semestr = value; Console.WriteLine(_semestr.ToString()); } else { Console.WriteLine("Не кринжуй"); }
                    }
                }
                public int Zacheti
                {
                    get { return _zacheti; }
                    set
                    {

                        if (Semestr != 0 && (Semestr == 3 || Semestr == 7))
                        {
                            _zacheti = 3;
                        }
                        else if (Semestr != 0 && (Semestr == 5 || Semestr == 6))
                        {
                            _zacheti = 4;
                        }
                        else { _zacheti = 5; }
                    }
                }
                public int Ekzameni
                {
                    get { return _ekzameni; }
                    set
                    {
                        if (value <= 4)
                        {
                            _ekzameni = value; Console.WriteLine("Кол-во Экзамен = {0}", _ekzameni.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Максимум 4 экзамена");
                        }
                    }
                }
                public int Zachet
                {
                    get { return _zachet; }
                    set
                    {
                        if (value >= _zacheti)
                        {
                            _zachet = value;
                            Console.WriteLine("Зачетено");
                        }
                        else
                        {
                            _zachet = value;
                            Console.WriteLine("Не зачтено");
                        }

                    }

                }
                public void Show()
                {
                    List<string> list = new List<string>();
                    list.Add(Semestr.ToString());
                    list.Add(Zacheti.ToString());
                    list.Add(Ekzameni.ToString());
                    list.Add(Zachet.ToString());
                    Console.WriteLine("Семестр = " + list[0] + " " + "Зачеты = " + list[1] + " " + "Экзамены = " + list[2] + " " + "Сданные зачеты = " + list[3]);
                    foreach (string v in list)
                    { Console.WriteLine(v); }


                }
            }
            public class Letnaia : Sessia
            {
                private string _ocenka;
                public string Ocenka
                {
                    get { return _ocenka; }
                    set
                    {
                        if (value == "Да" || value == "да" || value == "ДА")
                        {
                            Console.WriteLine("з/т");
                        }
                        else if (value == "Нет" || value == "нет" || value == "НЕТ" || value == "НЕт" || value == "НеТ")
                        {
                            Console.WriteLine("н/зт");
                        }
                        else { Console.WriteLine("н/ат"); }


                    }
                }

            }

        private void Sem_ValueChanged(object sender, EventArgs e)
        {
            if(Sem.Value < 1 || Sem.Value > 8)
            {
                MessageBox.Show("Не кринжуй");
            }
            if(Sem.Value == 3 || Sem.Value == 7)
            {
                Zach.Value = 3;
            }
            else if(Sem.Value == 5 || Sem.Value == 6)
            {
                Zach.Value = 4;
            }
            else
            {
                Zach.Value = 5;
            }
        }

        private void Sdan_ValueChanged(object sender, EventArgs e)
        {
            if(Sdan.Value >= Zach.Value)
            {
                Zacht.Text = "Зачтено";
            }

            else
            {
                Zacht.Text = "Не зачет";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

