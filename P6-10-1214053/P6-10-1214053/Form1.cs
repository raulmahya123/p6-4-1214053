using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P6_10_1214053
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTingkatan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAngka1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAngka2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNama_Leave(object sender, EventArgs e)
        {
            if ((txtNama.Text).All(Char.IsLetter))
            {
                epWarning.SetError(txtNama, "");
                epWrong.SetError(txtNama, "");
                epCorrect.SetError(txtNama, "Betul");

            }
            else
            {
                epWrong.SetError(txtNama, "inputan hanya boleh huruf!");
                epWarning.SetError(txtNama, "");
                epCorrect.SetError(txtNama, "");
            }
        }

        private void txtTingkatan_Leave(object sender, EventArgs e)
        {
            if (txtTingkatan.Text == "")
            {
                epWarning.SetError(txtTingkatan, "Text obx tiadk boleh kosong");
                epWrong.SetError(txtTingkatan, "");
                epCorrect.SetError(txtTingkatan, "");

            }
            else
            {
                if ((txtTingkatan.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtTingkatan, "");
                    epWrong.SetError(txtTingkatan, "");
                    epCorrect.SetError(txtTingkatan, "Betul");
                }

                else
                {
                    epWarning.SetError(txtTingkatan, "Inputan hanya bole satu");
                    epWrong.SetError(txtTingkatan, "");
                    epCorrect.SetError(txtTingkatan, "");
                }


            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epWarning.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "Betul!");
            }
            else
            {
                epWrong.SetError(txtEmail, "Format email salah!\nContoh: a@b.c");
                epWarning.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)

        {
            if ((textBox2.Text).All(Char.IsLower))
            {
                epWarning.SetError(textBox2, "");
                epWrong.SetError(textBox2, "");
                epCorrect.SetError(textBox2, "Betul");

            }
            else
            {
                epWrong.SetError(textBox2, "inputan hanya boleh huruf!");
                epWarning.SetError(textBox2, "");
                epCorrect.SetError(textBox2, "");
            }

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if ((textBox3.Text).All(Char.IsUpper))
            {
                epWarning.SetError(textBox3, "");
                epWrong.SetError(textBox3, "");
                epCorrect.SetError(textBox3, "Betul");

            }
            else
            {
                epWrong.SetError(textBox3, "inputan hanya boleh huruf!");
                epWarning.SetError(textBox3, "");
                epCorrect.SetError(textBox3, "");
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (txtAngka1.Text == "")
            {
                epWarning.SetError(txtAngka1, "Text obx tiadk boleh kosong");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");

            }
            else
            {
                if ((txtTingkatan.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka1, "Betul");
                }

                else
                {
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "Inputan hanya bole satu");
                    epCorrect.SetError(txtAngka1, "");
                }
                if (txtAngka2.Text == "")
                {
                    epWarning.SetError(txtTingkatan, "Inputan hanya bole satu");
                    epWrong.SetError(txtTingkatan, "");
                    epCorrect.SetError(txtTingkatan, "");
                }
            }
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            int Angka1 = int.Parse(txtAngka1.Text);
            int Angka2 = int.Parse(txtAngka2.Text);

            if (txtAngka1.Text == "")
            {
                epWarning.SetError(txtAngka2, "Text obx tiadk boleh kosong");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");

            }
            else
            {
                if ((txtTingkatan.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "Betul");
                }

                else
                {
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "Inputan hanya bole satu");
                    epCorrect.SetError(txtAngka2, "");
                }
                if (Angka1 > Angka2)
                {
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka1, "Betul");

                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "benar");
                }
                else
                {

                    epWarning.SetError(txtAngka1, "wrong");
                    epWrong.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka1, "");

                    epWarning.SetError(txtAngka2, "wrong");
                    epWrong.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "");
                }
            }
        }
    }
 }

