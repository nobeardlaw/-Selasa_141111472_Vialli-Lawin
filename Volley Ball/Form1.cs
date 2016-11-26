using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volley_Ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public const int Modular = 1000000007;

        static bool Valid(int a, int b)
        {
            if (a < 25) return false;
            if (a == 25) return b <= 23;
            return b == (a - 2);
        }

        public static void Swap<T>(ref T left, ref T right)
        {
            T temp;
            temp = left;
            left = right;
            right = temp;
        }

        public static int nCr(int n, int r, int mod)
        {
            if (n < r) Swap(ref n, ref r);
            if (n < 1 || r < 1) return 1;
            var row = new int[r];
            for (var i = 0; i < r; row[i++] = 1) { }

            for (int i = 2; i < r; ++i)
            {
                for (int j = i - 1; j > 0; --j)
                {
                    row[j] = (row[j] + row[j - 1]) % mod;
                }
            }
            --r;
            int sum = row[r];
            for (int i = 0; i < n; ++i)
            {
                for (int j = r; j > 0; --j)
                {
                    row[j] = (row[j] + row[j - 1]) % mod;
                }
                sum = (sum + row[r]) % mod;
            }
            return sum;
        }

        private static int pow(int baseNo, int exponent, int mod)
        {
            if (exponent < 2)
            {
                return (exponent < 1) ? 1 : baseNo;
            }
            long product = pow(baseNo, exponent >> 1, mod);
            product = (product * product) % mod;
            return ((exponent & 1) == 1) ? (int)((product * baseNo) % mod) : (int)(product);
        }

        private void Buttonhasil_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(txt1.Text);
            var b = Convert.ToInt32(txt2.Text);
            int result;

            if (a < b) Swap(ref a, ref b);
            if (!Valid(a, b))
            {
                result = 0;
            }
            else
            {
                if (a > 25)
                {
                    result = nCr(24, 24, Modular);
                    result = (int)((((long)result) * pow(2, b - 24, Modular)) % Modular);
                }
                else
                {
                    result = nCr(a - 1, b, Modular);
                }
            }
            txthasil.Text = result.ToString();
        }
    }
}
