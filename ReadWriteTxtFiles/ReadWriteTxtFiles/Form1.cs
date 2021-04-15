using System;
using System.IO;
using System.Windows.Forms;

namespace ReadWriteTxtFiles
{
    public partial class ReadWriteTxtFiles : Form
    {
        public ReadWriteTxtFiles()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddressTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEmployeebin_Click(object sender, EventArgs e)
        {

        }

        private void ReadWriteTxtFiles_Load(object sender, EventArgs e)
        {

        }

        // PATH TO WRITE .TXT FILE
        // WILL WRITE A SEPARATE FILES FOR EACH CREATE
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Create\\" +
                FirstNameTb.Text + " "+ LastNameTb.Text + ".txt");

            sw.WriteLine(label1.Text + " " + FirstNameTb.Text);
            sw.WriteLine(label2.Text + " " + LastNameTb.Text);
            sw.WriteLine(label3.Text + " " + GenderCb.Text);
            sw.WriteLine(label4.Text + " " + AddressTb.Text);
            sw.Close();

            StreamReader sr = new StreamReader(Application.StartupPath + "\\Create\\" +
                FirstNameTb.Text + " " + LastNameTb.Text + ".txt");
            ReadFilesRTB.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
