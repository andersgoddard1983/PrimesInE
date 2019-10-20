using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimesInE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long FirstPrimeInE = firstPrimeInFile("C:\\Users\\agoddard\\Desktop\\e.txt");
            textBox1.Text = FirstPrimeInE.ToString();
            button1.Text = "Here it is!";
        }

        static long firstPrimeInFile(string filePath)
        {
            try
            {
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    string remainder = "";
                    bool isTestStringPrime = false;
                    int attempts = 0;
                    while ((line = sr.ReadLine()) != null || isTestStringPrime == false)
                    {
                        remainder = remainder + line;
                        for (int i = 0; i < line.Length && (remainder == "" || remainder.Length > 10); i++)
                        {
                            string testString = line.Substring(i, 10);
                            isTestStringPrime = isPrime(testString);
                            attempts += 1;
                            remainder = line.Substring(i + 1);
                            if (isTestStringPrime)
                            {
                                return Int64.Parse(testString);
                            }
                        }
                    }
                    return 0;
                }
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        static Boolean isPrime(string testCase)
        {
            long testCaseToLong = Int64.Parse(testCase);
            var limit = Math.Ceiling(Math.Sqrt(testCaseToLong));
            for (int i = 2; i <= limit; ++i)
            {
                if (testCaseToLong % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
