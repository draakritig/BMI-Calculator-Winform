using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Web.Script.Serialization;
using System.IO;



namespace BMICalculator
{
    public partial class Form1 : Form
    {
        Dictionary<string, Aakriti_BMIData> dictionary_of_listings = new Dictionary<string, Aakriti_BMIData>();
        public static string SaveResult = "";
        List<Aakriti_BMIData> bmiDataList = Aakriti_BMIData.BMIDataList();
        public Form1()
        {
            // SplashScreen thread
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(2000);
            InitializeComponent();
            gridBmiData.DataSource = bmiDataList;
            t.Abort();
        }
        public void StartForm()
        {
            // Runs the SplashScreen
            Application.Run(new SplashScreen());
        }

        // Utility Function containing operations of BMI Calculator
        private void performCalculation()
        {
            double height = double.Parse(textHeight.Text);
            double weight = double.Parse(textWeight.Text);
            double result = 0;
            if (radioBtnImp.Checked)
            {
                result = (weight * 703) / (height * height);
                textResult.Text = $"{result:f2}";
            }
            else
            {
                result = (weight) / (height * height);
                textResult.Text = $"{result:f2}";
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            performCalculation();
            SaveResult = textResult.Text;
            Form2 resultPage = new Form2();
            resultPage.ShowDialog();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            //Clear all credentials
            textName.Clear();
            textHeight.Text = " ";
            textWeight.Text = " ";
            numAge.Value = 0;
            textResult.Text = " ";
            radioBtnImp.Checked = false;
            radioBtnMet.Checked = false;       
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string result = textResult.Text;
            string age = numAge.Value.ToString();
            Aakriti_BMIData bmiDataList1 = new Aakriti_BMIData(name, age, result);
            bmiDataList.Add(bmiDataList1);
            gridBmiData.DataSource = null;
            gridBmiData.DataSource = bmiDataList;
        }
        private Dictionary<string, Aakriti_BMIData> ReadJson(string filename = "BmiDataBase.json")
        {
            string data = File.ReadAllText(filename);
            List<Aakriti_BMIData> list = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<List<Aakriti_BMIData>>(data);
            return list.ToDictionary(item => item.NAME);
            
        }

    }
}
