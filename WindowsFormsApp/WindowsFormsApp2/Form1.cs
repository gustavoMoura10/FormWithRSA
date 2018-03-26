using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string msg1 = "";
        string msg2 = "";
        string msgcnv1 = "";
        string msgcnv2 = "";
        BigInteger ascII1;
        BigInteger ascII2;
        BigInteger num = 0;
        BigInteger p = 0;
        BigInteger q = 0;
        BigInteger totiente = 0;
        BigInteger inv = 0;
        BigInteger cript = 0;
        BigInteger n = 0;
        BigInteger ev = 0;
        BigInteger desc = 0;
        double[] aloc;
        public Form1()
        {
            InitializeComponent();
        }
        //Função para determinar qual número primo o p será
        public static BigInteger pPrime(BigInteger number)
        {
            BigInteger p = 0;
            bool isPrime = true;
            for (int i = 2; i <= number; i++)
            {
                for (int j = 2; j <= number; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    p = i;
                }
                isPrime = true;
            }
            return p;
        }
       //determinara qual número primo o q será
        public static BigInteger qPrime(BigInteger number)
        {
            BigInteger q = 0;
            bool isPrime = true;
            for (int i = 2; i <= number * 2; i++)
            {
                for (int j = 2; j <= number; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    q = i;
                }
                isPrime = true;
            }
            return q;
        }
        //Aqui ocorrerá a escolha o inverso modular
        public static BigInteger modInverse(BigInteger a, BigInteger n)
        {
            BigInteger i = n, v = 0, d = 1;
            while (a > 0)
            {
                BigInteger t = i / a, x = a;
                a = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }
            v %= n;
            if (v < 0) v = (v + n) % n;
            return v;

        }
        //Aqui ocorrerá a divisão Polinomial dos números
        public static BigInteger divPoly(BigInteger a, BigInteger b, BigInteger c)
        {
            BigInteger resto = 0;
            BigInteger divisor = c;
            BigInteger aux = a;
            BigInteger dividendo = 0;
            BigInteger quociente = 0;
            for (int i = 1; i < b; i++)
            {
                a = a * aux;
                quociente = a / c;
                resto = a % c;
                dividendo = (quociente * divisor) + resto;
                dividendo = dividendo % c;
            }
            return dividendo;
        }
        public static BigInteger totTiente(BigInteger a, BigInteger b)
        {
            BigInteger phy = (a - 1) * (b - 1);
            return phy;
        }
        public static BigInteger multiN(BigInteger a, BigInteger b)
        {
            BigInteger n = 0;
            BigInteger aux = a;
            for (int i = 1; i < b; i++)
            {
                a = aux * b;
            }
            return a;
        }
        public static BigInteger eValue(BigInteger tot)
        {
            BigInteger ef = 0;
            for (int i = 1; i < tot; i++)
            {
                if (tot % i != 0)
                {
                    ef = i;
                    break;
                }
            }
            return ef;
        }
        public static string conversao(string msg)
        {
            string conv = "";
            for(int i=msg.Length-1;i>=0;i--)
            {
                conv = conv + msg[i];
            }
            return conv;
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            msg1 = text1.Text;
            p = pPrime((int)numer.Value);
            q = qPrime((int)numer.Value);
            n = p * q;
            totiente = totTiente(p,q);
            ev = eValue(totiente);
            keye.Text = Convert.ToString(ev);
            keyn.Text = Convert.ToString(n);
            keyp.Text = Convert.ToString(p);
            keyq.Text = Convert.ToString(q);
            inv = modInverse(ev, totiente);
            keyde.Text = Convert.ToString(inv);
            aloc = new double[msg1.Length];
            char[] carac = new char[msg1.Length];
            msgcnv1 = conversao(msg1);
            for (int i = 0; i < msgcnv1.Length; i++)
            {
                ascII1 = (int)msgcnv1[i];
                cript = divPoly(ascII1, ev, n);
                aloc[i] = (double)cript;
                carac[i] = (char)aloc[i];
                text2.Text += Convert.ToString(carac[i]);
            }
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            msg2 = text2.Text;
            char[] carac = new char[msg2.Length];
            string msg3 = "";
            for (int i = 0; i < aloc.Length; i++)
            {
                ascII2 = (int)aloc[i];
                desc = divPoly(ascII2, inv, n);
                carac[i] = (char)desc;
                msg3 += conversao(Convert.ToString(carac[i]));

            }
            text3.Text = conversao(msg3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numer_ValueChanged(object sender, EventArgs e)
        {
            numer.Minimum = 10;
            numer.Maximum = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text1.Text = "";
            text2.Text = "";
            text3.Text = "";

        }

        private void e_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}