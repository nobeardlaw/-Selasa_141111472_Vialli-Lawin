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
    public partial class Form1 : Form
    {
        public string bgColor
        {
            get
            {
                return this.rtbBackColor;

            }
            set
            {
                richTextBox1.BackColor = Color.FromName(value);
            }
        }
        public string rtbBackColor;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ToggleBold();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ToggleItalic();
        }

        private void tscbFontColor_DrawItem(object sender, DrawItemEventArgs e)
        {
           
            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);

                g.FillRectangle(brush, e.Bounds);
                string s = (string)this.toolStripComboBox3.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 20, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 19, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 25, e.Bounds.Top);
                brush.Dispose();
                tBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }


        
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(toolStripComboBox2.Items.ToString(), (float)toolStripComboBox1.SelectedIndex + 1);
            richTextBox1.Update();
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                
                
            }
            FontStyle currentStyle = richTextBox1.SelectionFont.Style;

            richTextBox1.SelectionFont = new Font(toolStripComboBox2.SelectedItem.ToString(), (float)toolStripComboBox1.SelectedIndex + 1, FontStyle.Regular | currentStyle);
            richTextBox1.Update();
        }

        
        private void changeFont()
        {
            
        }

        private void ToggleBold()
        {
            if (richTextBox1.SelectionFont != null)
            {
                if (richTextBox1.SelectionLength > 0)
                {
                    if (richTextBox1.SelectionFont.Style == FontStyle.Bold)
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, FontStyle.Regular | richTextBox1.SelectionFont.Style);
                    else
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, FontStyle.Bold | richTextBox1.SelectionFont.Style);
                }
                else
                {
                    if (richTextBox1.SelectionFont.Style == FontStyle.Bold)
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, FontStyle.Regular | richTextBox1.SelectionFont.Style);
                    else
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, FontStyle.Bold | richTextBox1.SelectionFont.Style);
                    
                }
            }
        }

        private void ToggleItalic()
        {
            if (richTextBox1.SelectionFont != null)
            {
                if (richTextBox1.SelectionLength > 0)
                {
                    if (richTextBox1.SelectionFont.Style == FontStyle.Italic)
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, FontStyle.Regular | richTextBox1.SelectionFont.Style);
                    else
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, FontStyle.Italic | richTextBox1.SelectionFont.Style);
                }
                else
                {
                    if (richTextBox1.SelectionFont.Style == FontStyle.Italic)
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, FontStyle.Regular | richTextBox1.SelectionFont.Style);
                    else
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, FontStyle.Italic | richTextBox1.SelectionFont.Style);
                }
            }
        }

        private void ToggleUnderline()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                if (richTextBox1.SelectionFont.Style == FontStyle.Underline)
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, FontStyle.Regular | richTextBox1.SelectionFont.Style);
                else
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, FontStyle.Underline | richTextBox1.SelectionFont.Style);
            }

            else
            {
                if (richTextBox1.SelectionFont.Style == FontStyle.Underline)
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, FontStyle.Regular | richTextBox1.SelectionFont.Style);
                else
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, FontStyle.Underline | richTextBox1.SelectionFont.Style);
            }
        }

       
        private void toolStripComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!toolStripComboBox3.Focused) 
            {
                return; 
            } 

            richTextBox1.SelectionColor = Color.FromName(toolStripComboBox3.Text);
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ToggleUnderline();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripComboBox1.SelectedIndex = 11;
            toolStripComboBox2.Text = "Calibri";
            toolStripComboBox3.Text = "Black";
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMyFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMyFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void SaveMyFile()
        {
           
            SaveFileDialog saveFile1 = new SaveFileDialog();

           
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

          
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
               
                richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        public void LoadMyFile()
        {
          
            OpenFileDialog openFile1 = new OpenFileDialog();

            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";

           
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
               
                richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }
        

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            richTextBox1.SelectedText = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             List<string> fonts = new List<string>();
            List<string> fontSize = new List<string>();

            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                fonts.Add(font.Name);
                
            }

            for (int i=1; i<88; i++)
            {
                fontSize.Add(i.ToString());
                
            }
            
            toolStripComboBox2.Items.AddRange(fonts.ToArray());
            toolStripComboBox1.Items.AddRange(fontSize.ToArray());

            

            Color clr = new Color();
            PropertyInfo[] colors = clr.GetType().GetProperties();
            this.toolStripComboBox3.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;

            foreach (PropertyInfo color in colors)
            {
                if (color.PropertyType == typeof(System.Drawing.Color))
                {
                    toolStripComboBox3.Items.Add(color.Name);
                }
            }

            
            toolStripComboBox1.SelectedIndex = 11;
            toolStripComboBox2.Text = "Calibri";
            toolStripComboBox3.Text = "Black";
            
            richTextBox1.Clear();

            this.toolStripComboBox3.ComboBox.DrawItem += new DrawItemEventHandler(tscbFontColor_DrawItem);
            richTextBox1.SelectionFont = new Font(toolStripComboBox2.Items.ToString(), (float)toolStripComboBox1.SelectedIndex + 1);
            richTextBox1.Update();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        }
    }


