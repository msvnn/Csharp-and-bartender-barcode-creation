using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seagull.BarTender.Print;
using System.IO.Ports;
using System.IO;



//depeloper:Mustafa Savun
//date:07-01-2023


namespace WindowsFormsApp2
{

    public partial class frmFQC : Form
    {
        private string _bmp_path = Application.StartupPath + @"\exp.jpg";
        private string _btw_path = "";
        string _PrinterName = "";
        string connectionString;


        public frmFQC()
        {
            InitializeComponent();



        }



            void PrintBar(bool isPreView = false)
        {
            if (_btw_path.Length < 5)
            {
                fileNametBox.BackColor = Color.Red;
                return;
            }
            using (Engine btEngine = new Engine(true))
            {
                LabelFormatDocument labelFormat = btEngine.Documents.Open(_btw_path);

                try
                {

                    labelFormat.SubStrings.SetSubString("code", num_textBox.Text);
                    //SaveBarcodeToDatabase(num_textBox.Text);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while changing the content " + ex.Message, "Operating Tips");
                }

                if (labelFormat != null)
                {
                    //Generate a thumbnail for it.
                    labelFormat.ExportImageToFile(_bmp_path, ImageType.BMP, Seagull.BarTender.Print.ColorDepth.ColorDepth24bit, new Resolution(407, 407
                        ), OverwriteOptions.Overwrite);

                    System.Drawing.Image image = System.Drawing.Image.FromFile(_bmp_path);
                    Bitmap NmpImage = new Bitmap(image);
                    pictureBox.Image = NmpImage;
                    image.Dispose();
                }
                else
                {
                    MessageBox.Show("generate image error", "Operating Tips");
                }

                if (isPreView) return;

                if (_PrinterName != "")
                {
                    labelFormat.PrintSetup.PrinterName = _PrinterName;
                    labelFormat.Print("BarPrint" + DateTime.Now, 3 * 1000);
                }
                else
                {
                    MessageBox.Show("Please select a printer first", "Operating Tips");
                }
            }
        }
        private void print_btn_Click(object sender, EventArgs e)
        {
            PrintBar();
        }

        private void frmFQC_Load(object sender, EventArgs e)
        {




            Printers printers = new Printers();
            foreach (Printer printer in printers)
            {
                printer_comboBox.Items.Add(printer.PrinterName);
            }

            if (printers.Count > 0)
            {
                // Automatically select the default printer.
                printer_comboBox.SelectedItem = printers.Default.PrinterName;
            }

            // Automatically select the default file btw.
            _btw_path = Application.StartupPath + @"\fqc.btw";
           
            fileNametBox.Text = "fqc.btw";
            fileNametBox.BackColor = Color.LightGreen;
        }

        private void openFilebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//multiple files
            dialog.Title = "Please select the file to burn";
            dialog.Filter = "bwt文件(*.btw)|*.btw";
            dialog.InitialDirectory = Application.StartupPath;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _btw_path = dialog.FileName;
                fileNametBox.Text = dialog.SafeFileName;
                fileNametBox.BackColor = Color.LightGreen;

                pictureBox.Image = null;
                using (Engine btEngine = new Engine(true))
                {
                    LabelFormatDocument labelFormat = btEngine.Documents.Open(_btw_path);

                    if (labelFormat != null)
                    {
                        Seagull.BarTender.Print.Messages m;
                        labelFormat.ExportPrintPreviewToFile(Application.StartupPath, @"\exp.bmp", ImageType.JPEG, Seagull.BarTender.Print.ColorDepth.ColorDepth24bit, new Resolution(300, 300), System.Drawing.Color.White, OverwriteOptions.Overwrite, true, true, out m);
                        labelFormat.ExportImageToFile(_bmp_path, ImageType.JPEG, Seagull.BarTender.Print.ColorDepth.ColorDepth24bit, new Resolution(300, 300), OverwriteOptions.Overwrite);

                        Image image = Image.FromFile(_bmp_path);
                        Bitmap NmpImage = new Bitmap(image);
                        pictureBox.Image = NmpImage;
                        image.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Error generating image", "Operation prompt");
                    }
                }
            }
        }

        private void printer_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _PrinterName = printer_comboBox.Text;
        }

        private void preview_btn_Click(object sender, EventArgs e)
        {
            PrintBar(true);
        }

        private void num_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileNametBox_KeyDown(object sender, KeyEventArgs e)
        {
    
        }

        private void num_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void num_textBox_Enter(object sender, EventArgs e)
        {

        }

        private void num_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter tuşuna basıldığında işlemi tetikle
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // Enter tuşunun formda başka bir yere gitmesini engelle
                e.SuppressKeyPress = true; // Enter tuşunun sesi çıkmasın

                // Barkodu yazdır
                PrintBar();

                // TextBox'ı temizle
                num_textBox.Clear();
                num_textBox.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
