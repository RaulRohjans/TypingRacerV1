using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TypingRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool correto = true;
        char[] texto;

        int m, s;
        int totalMins;
        int cntPalavras = 0;

        System.Timers.Timer t;

        private void Form1_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s--;
                if (m == 0 && s == 0)
                {
                    t.Stop();
                    lbl_mins.Text = "00:00";
                    lbl_mins.Visible = false;
                    txt_tempo.Visible = true;
                    btn_start.Enabled = true;
                    MessageBox.Show("A sua velocidade media foi: " + Convert.ToString((int) cntPalavras / totalMins), "Parabens!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (s == 0)
                    {
                        s = 60;
                        m--;
                    }

                    if (m > 9 && s > 9)
                        lbl_mins.Text = m.ToString() + ":" + s.ToString();
                    else
                    {
                        if (m > 9 && s <= 9)
                            lbl_mins.Text = m.ToString() + ":" + "0" + s.ToString();
                        else
                        {
                            if (m <= 9 && s > 9)
                                lbl_mins.Text = "0" + m.ToString() + ":" + s.ToString();
                            else
                                lbl_mins.Text = "0" + m.ToString() + ":" + "0" + s.ToString();
                        }
                    }
                }

            }));
        }

        private void RemoverArray()
        {
            for(int i2 = 0; i2 < texto.Length - 1; i2++)
            {
                texto[i2] = texto[i2 + 1];
            }
            texto[texto.Length - 1] = ' ';
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == ' ' && correto == true)
                {
                    if (texto[txt_word.TextLength] == ' ' || texto[txt_word.TextLength] == '\n' || texto[txt_word.TextLength] == '\r')
                    {
                        while (texto[0] == ' ')
                            RemoverArray();
                        while (texto[0] == '\r')
                            RemoverArray();
                        while (texto[0] == '\n')
                            RemoverArray();

                        //Apagar palavra do array mais o espaco                        
                        for (int i = 0; i < txt_word.TextLength; i++)
                        {
                            RemoverArray();
                        }                               
                        
                        while (texto[0] == ' ')
                            RemoverArray();                        
                        while (texto[0] == '\r')
                            RemoverArray();
                        while (texto[0] == '\n')
                            RemoverArray();

                        //Resetar textbox
                        txt_word.Text = "";
                        e.Handled = true;
                        cntPalavras++;

                        //Colocar coisas na textbox outravez
                        txt_text.Text = "";
                        for(int i = 0; i < texto.Length; i++)
                        {
                            txt_text.Text += texto[i];
                        }
                    }
                    else
                    {
                        correto = true;
                        txt_word.BackColor = Color.White;
                    }
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show("Erro:  " + ee);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Int32 CountFileChars(string path)
        {
            Int32 Count = -1;

            using (System.IO.StreamReader sr = new System.IO.StreamReader(path))
            {
                string content = sr.ReadToEnd();
                Count = content.Length;
            }
                return Count;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tempo.Text != "" && (Convert.ToInt32(txt_tempo.Text) > 0 && Convert.ToInt32(txt_tempo.Text) <= 60))
                {
                    int i = 0;
                    string path = "";
                    totalMins = Convert.ToInt32(txt_tempo.Text);
                    cntPalavras = 0;

                    //Carregar coisas para o Array de Chars
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {                        
                        path = openFileDialog.FileName;
                        Int32 qtdChars = CountFileChars(path);
                        if (qtdChars != -1)
                        {
                            texto = new char[qtdChars];

                            StreamReader sr = new StreamReader(path);
                            while (!sr.EndOfStream)
                            {
                                texto[i] += (char)sr.Read();
                                txt_text.Text += texto[i];
                                i++;
                            }
                            sr.Close();                         
                                

                            //Parte dos numeros e horas
                            txt_tempo.Visible = false;
                            lbl_mins.Visible = true;
                            m = Convert.ToInt32(txt_tempo.Text) - 1;
                            s = 60;
                            t.Start();

                            btn_start.Enabled = false;
                        }
                        else
                            MessageBox.Show("Ocorreu um erro na contagem de caracteres do ficheiro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Ocorreu um erro na leitura do ficheiro, por favor tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                    MessageBox.Show("A caixa de texto deve conter um numero em minutos entre 0 e 60!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ee)
            {
                MessageBox.Show("Erro:  " + ee);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
        }

        private void txt_word_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txt_word.Text != "")
                {
                    char[] temp = txt_word.Text.ToCharArray();
                    if (texto[txt_word.TextLength - 1] != temp[txt_word.TextLength - 1])
                    {
                        correto = false;
                        txt_word.BackColor = Color.Red;
                    }
                    else
                    {
                        correto = true;
                        txt_word.BackColor = Color.White;
                    }
                }
                else
                {
                    correto = true;
                    txt_word.BackColor = Color.White;
                }                
            }
            catch(Exception ee)
            {
                MessageBox.Show("Erro: " + ee);
            }
        }

        private void txt_tempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
                e.Handled = true;
        }        
    }
}
