using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;

namespace BMICalculator
{
    public class Aakriti_BMIData
    { 
         //PROPERTIES
        public string NAME { get; }
        public string BMI { get; }
        public string AGE { get; }

        //CONSTRUCTOR
        public Aakriti_BMIData(string name, string age, string bmi)
        {
            NAME = name;
            AGE = age;
            BMI = bmi; 
        }
        public static List<Aakriti_BMIData> BMIDataList()
        {
            List<Aakriti_BMIData> bmiDataList = new List<Aakriti_BMIData>();
            bmiDataList.Add(new Aakriti_BMIData("Tom Parker", "45", "25.00"));
            bmiDataList.Add(new Aakriti_BMIData("Shanaya Khanna", "20", "19"));
            bmiDataList.Add(new Aakriti_BMIData("Harry Weasley", "56", "22.55"));
            bmiDataList.Add(new Aakriti_BMIData("Ronald Weins", "35", "34.9"));
            bmiDataList.Add(new Aakriti_BMIData("Mary Susan", "28", "27.60"));
            bmiDataList.Add(new Aakriti_BMIData("Ben Mark", "35", "40.15"));
            return bmiDataList;

        }
        public void SaveData(string filename)
        {
            File.ReadAllText(filename);
        }
      
    }
}
