using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        struct Student
        {
            public string FirstName;
            public string SecondName;
            public string ThirdName;
            public string Gender;
            public string Faculty;
            public string Course;
            public string Group;

            public string Math;
            public string Chim;
            public string Phus;
            public string Inf;
            public string Hist;

            public string City;
        }
        public Form1()
        {
            InitializeComponent();
        }
        // Домашняя страница(ДС)             
        private void button1_Click(object sender, EventArgs e)                  
        {
            groupBox1.Visible = false;
            Lab1box.Visible = true;
            Home.Visible = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            Lab2box.Visible = true;
            Home.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {             
            groupBox1.Visible = false;
            Lab3box.Visible = true;
            Home.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            Home.Visible = true;
            Lab4box.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ApProgLab.Calc fc2 = new ApProgLab.Calc();
            fc2.ShowDialog();
        }                                                               
        // Домашняя страница(ДС)
        //Возврат на ДС
        private void Home_Click(object sender, EventArgs e)            
        {
            groupBox1.Visible = true;
            Lab1box.Visible = false;
            Lab2box.Visible = false;
            Lab3box.Visible = false;
            Lab4box.Visible = false;
            Home.Visible = false;
        }                                                               
        //Возврат на ДС

        // Lab1
        private void b_TextChanged(object sender, EventArgs e)           
        {
            int b_value;
            bool testb = Int32.TryParse(b.Text,out b_value);
            Lab1N1V.Text = Convert.ToString(Math.Pow(b_value, 3));
            Lab1N1S.Text = Convert.ToString(6 * Math.Pow(b_value, 2));
        }
        private void InputX_TextChanged(object sender, EventArgs e)
        {
            double x_value, a_value;
            bool testx = Double.TryParse(InputX.Text, out x_value);
            bool testa = Double.TryParse(InputA.Text, out a_value);
            double testval = ((Math.Pow(Math.Exp(x_value), a_value) + 2.73 * (Math.Pow(a_value, 3.0) * Math.Pow(x_value, 1.0 / 3.0) + 1.78 * Math.Pow(Math.Abs(x_value), 1.4))) / (Math.Abs(x_value + a_value) + Math.Tan(Math.PI / 2.0 * a_value))) / 10.0;
            Lab1N2F.Text = testval.ToString("N3");
        }
        private void clearLab1_Click(object sender, EventArgs e)           
        {
            b.Clear();
            InputA.Clear();
            InputX.Clear();
            Lab1N1V.Clear();
            Lab1N2F.Clear();
            Lab1N1S.Clear();
        }
        // Lab1

        //Lab2
        private void apply_Click(object sender, EventArgs e)         
        {
            OutputLab2.Clear();
            int[] Lab2Array = InputLab2.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(k => int.Parse(k.Trim())).ToArray();     //Bug

            int L2ALeight = 0, j = Lab2Array.Length, N = Lab2Array.Length;
            if (InputLab2.Text == " " | InputLab2.Text == "")
            {
                MessageBox.Show("Введите массив !!!");

            }
            else
            {

                while (j > 0)                            //Цикл поиска элементов группы. Для того чтобы найти последнюю группу элементов, начинаем с конца

                    if (Lab2Array[--j] > 1)
                        L2ALeight++;
                    else
                         if (L2ALeight < 2)
                        L2ALeight = 0;
                    else
                        break;
                if (L2ALeight <= 0)
                {
                    L2ALeight = 0;
                    for (int i = 0; (Lab2Array[i] > 1) & (i <= N - 1); i++)
                    {
                        L2ALeight++;
                    }
                    for (int i = L2ALeight; i != N; i++)
                        L2ALeight = 0;
                }
                if (L2ALeight > 0)
                {
                    for (int i = j + L2ALeight + 1; i < N; i++)
                        Lab2Array[i - L2ALeight] = Lab2Array[i];
                    for (int i = 0; i < N - L2ALeight; i++)
                    {
                        OutputLab2.Text += Lab2Array[i].ToString() + ' ';
                    }
                }

            }
        }                                                       

        public void InputLab2_TextChanged(object sender, EventArgs e)
        {
            OutputLab2.Clear();
        }

        private void RandInptL2_Click(object sender, EventArgs e)
        {
            int ArrN = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ведите размер массива"));   //Bug;
            Random RND = new Random();
            int[] Lab2Array = new int[ArrN];
            InputLab2.Clear();
            for (int i = 0; i < ArrN; i++)
            {
                Lab2Array[i] = RND.Next(20);
            }

            for (int i = 0; i < ArrN; i++)
            {
                InputLab2.Text += Lab2Array[i].ToString() + ' ';
            }
        }
        //Lab2

        //Lab3
        private void ApplyL3_Click(object sender, EventArgs e)
        {
            string L3Str = Lab3Input.Text.Replace(" ","");
            char[] L3strCharArr = L3Str.ToCharArray();
            Lab3Input.Clear();
            Array.Reverse(L3strCharArr);
            string FinL3txt = new string(L3strCharArr);
            Lab3Output.Text = L3Str;
            if (L3Str == FinL3txt)
            {
                MessageBox.Show("Введённая строка является палиндромом");
            }
            if (L3Str != FinL3txt)
            {
                MessageBox.Show("Введённая строка не является палиндромом");
            }
        }
        //Lab3
        //Lab4
        public void OpenFileL4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "NotePad - Открыть файл";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string[] InfStud = File.ReadAllLines(openFileDialog1.FileName);
                List<Student> students;
                students = new List<Student>();
                for (int i = 0; i < InfStud.Length; i++)
                {

                    students.Add(new Student
                    {
                        FirstName = InfStud[i++],
                        SecondName = InfStud[i++],
                        ThirdName = InfStud[i++],
                        Gender = InfStud[i++],
                        Faculty = InfStud[i++],
                        Course = InfStud[i++],
                        Group = InfStud[i++],

                        Math = InfStud[i++],
                        Phus = InfStud[i++],
                        Inf = InfStud[i++],
                        Hist = InfStud[i++],
                        Chim = InfStud[i++],

                        City = InfStud[i++],
                    });
                }

                int cnt = 1, tempcnt = 0 ;
                string temp;
                string CmnFrstNm="";

                for (int l = 0; l < 12; l++)
                {
                    tempcnt = 0;
                    temp = students[l].FirstName;
                    //Lab4Out.Text += students[l].FirstName + "\n";
                     
                     for  (int k = l + 1; k < 12; k++)
                     { 
                          if (students[l].FirstName == students[k].FirstName & Convert.ToString(students[l].Gender) == "М")
                          {
                              tempcnt++;
                              // string CmnFrstNm = students[l].FirstName;
                          }
                     }
                    if (tempcnt > 0)
                    {
                        //Lab4Out.Text += students[l].FirstName;
                        CmnFrstNm = temp;
                        cnt = tempcnt;
                    }
                }
                Lab4Out.Text += "Самая распространненая фамилия - " + CmnFrstNm;
            }
        }
        //Lab4
    }
}