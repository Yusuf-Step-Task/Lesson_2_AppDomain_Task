using System;
using System.IO;
namespace Lesson_2_AppDomain_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool suspend = false;
        bool abort = false;
        private void btnFrom_Click(object sender, EventArgs e)
        {
            OpenFileDialog Choise = new OpenFileDialog();
            if (Choise.ShowDialog() == DialogResult.OK)
            {
                txtFrom.Text = Choise.FileName; //  secim ediler se hemin secimi froma verir 
            }
        }
        //--------------------------------------------------
        private void btnTo_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtTo.Text = dialog.FileName;
            }
        }
        //--------------------------------------------------
        private void btnCopy_Click(object sender, EventArgs e)
        {
            suspend = false;
            abort = false;
            using (FileStream source = new FileStream(txtFrom.Text, FileMode.Open, FileAccess.Read))
            using (FileStream File_Crud = new FileStream(txtTo.Text, FileMode.Create, FileAccess.Write))
            {
                byte[] Hecm = new byte[4096];
                long TotalHecm = source.Length;
                long C_Byte = 0;
                int bytesRead;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;
                progressBar1.Value = 0;
                //----------------------------------------------
                while ((bytesRead = source.Read(Hecm, 0, Hecm.Length)) > 0)
                {
                    Application.DoEvents();
                    if (abort)
                    {
                        break;
                    }   
                    while (suspend)
                    {
                        Application.DoEvents();
                        if (abort)
                        {
                            break;
                        }
                    }
                    if (abort)
                    { 
                        break;
                    }
                    File_Crud.Write(Hecm , 0 , bytesRead);
                    C_Byte += bytesRead;
                    progressBar1.Value = ( int )( C_Byte * 100 / TotalHecm ) ;
                    Thread.Sleep(3000); //  Gercekci olsinda biraz 
                }
            }
            if (abort)
            {
                MessageBox.Show("Copy Abort....");
            }
            else
            {
                MessageBox.Show("Secsesfuly copied <>");
            }
        }
        //--------------------------------------------------
        private void btnSuspend_Click(object sender, EventArgs e)
        {
            suspend = true;
        }
        //--------------------------------------------------
        private void btnResume_Click(object sender, EventArgs e)
        {
            suspend = false;
        }
        //--------------------------------------------------
        private void btnAbort_Click(object sender, EventArgs e)
        {
            abort = true;
            suspend = false;
        }
        //--------------------------------------------------
    }
}
