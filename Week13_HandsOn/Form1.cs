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

namespace Week13_HandsOn
{
    public partial class Cars : Form
    {
        #region Initializing Class
        public Cars()
        {
            InitializeComponent();
        }//CarsMethod
        #endregion

        #region Add_Click
        private void add_Click(object sender, EventArgs e)
        {
            WriteFile();
            resetFields();
            MessageBox.Show("Details Added!");
        }//AddClick
        #endregion

        #region Appending the File

        public void resetFields()
        {
            carNo_txt.Clear();
            brand_txt.Clear();
            model_txt.Clear();
            noOfSeats_txt.Clear();
        }//resetFieldMethod

        public void WriteFile()
        {
            //CreatingFile
            FileStream file = new FileStream(@"C:\Users\Harkirat\Desktop\Week13_HandOn\Cars.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter write = new StreamWriter(file);

            #region Storing In Array
            string[] data = new string[4];

            data[0] = carNo_txt.Text;
            data[1] = brand_txt.Text;
            data[2] = model_txt.Text;
            data[3] = noOfSeats_txt.Text;
            #endregion

            #region Writing To File
            write.WriteLine($"Car#: {data[0], -7}");
            write.WriteLine($"Brand: {data[1], -7}");
            write.WriteLine($"Model: {data[2], -7}");
            write.WriteLine($"Number of seats: {data[3], -7}");
            #endregion

            write.Close();
            file.Close();

        }//WriteFile

        #region Saving data to new Class
        public static void ClassStorage()
        {
            
        }//ClassStorageMethod
        #endregion

        #endregion

        #region Exiting Application
        public void Closes()
        {
            Application.Exit();
        }//Close
        #endregion

        #region Cancel Button
        private void cancel_Click(object sender, EventArgs e)
        {
            Closes();
        }//CancelMethod
        #endregion
    }//CarsClass

    class Car
    {
        public int CarNo { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int NumberOfSeats { get; set; }
    }//CarClass
}//Week13_HandOn
