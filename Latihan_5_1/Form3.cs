using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {   public Form1 form1;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Color clr = new Color();
            PropertyInfo[] colors = clr.GetType().GetProperties();
            this.comboBox1.DrawMode = DrawMode.OwnerDrawFixed;

            foreach (PropertyInfo color in colors)
            {
                if (color.PropertyType == typeof(System.Drawing.Color))
                {
                    comboBox1.Items.Add(color.Name);
                }
            }
            this.comboBox1.DrawItem += new DrawItemEventHandler(tscbFontColor_DrawItem);
        }
        private void tscbFontColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            // a dropdownlist may initially have no item selected, so skip the highlighting:
            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);

                g.FillRectangle(brush, e.Bounds);
                string s = (string)this.comboBox1.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                // Draw a rectangle and fill it with the current color
                // and add the name to the right of the color
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 20, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 19, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 25, e.Bounds.Top);
                brush.Dispose();
                tBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (!comboBox1.Focused)
            {
                return;
            }
            form1.bgColor = comboBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        }
}

    

