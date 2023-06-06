using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Series
{
    public partial class Form1 : Form
    {

        private ISeries series = new Fibonacci();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
           
        {
            this.label1.Text = series.GetNext().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.series.Reset();
            this.label1.Text = "0";
        }

        private void SetStartSeries(object sender, EventArgs e)
        {
            try
            {
                String inputTextStart = this.textBox1.Text;
                    
                if(inputTextStart == null)
                {
                    return;
                }

                int parsedInput = Int32.Parse(inputTextStart);
                this.series.SetStart(parsedInput);
                this.label1.Text = series.GetNext().ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Should provide an integer");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public interface ISeries
    {
        int GetNext(); // devolver el sig. Número en la serie  
        void Reset(); // reiniciar  
        void SetStart(int x); // establece valor de inicio 
    }

    public class Fibonacci : ISeries
    {
        public int currentVal;
        public int indexCurrentVal;

        public Fibonacci()
        {
            this.currentVal = 0;
            this.indexCurrentVal = 0;
        }

        private int explicitFormulaFibo(int index)
        {
            return (int)Math.Round((Math.Pow((1 + Math.Sqrt(5)), index) -
         Math.Pow((1 - Math.Sqrt(5)), index)) / (Math.Pow(2, index) * Math.Sqrt(5)));
        }

        public int GetNext()
        {
            this.indexCurrentVal++;
            this.currentVal = this.explicitFormulaFibo(this.indexCurrentVal);
            return this.currentVal;
        }

        public void Reset()
        {
            this.currentVal = 0;
            this.indexCurrentVal = 0;
        }

        public void SetStart(int x)
        {
            this.indexCurrentVal = x - 1;
        }
    }

    public class Squares : ISeries
    {
        public int currentVal;
        public int indexCurrentVal;

        public Squares()
        {
            this.currentVal = 0;
            this.indexCurrentVal = 0;
        }

        public int GetNext()
        {
            this.indexCurrentVal++;
            this.currentVal = (int)Math.Pow(this.indexCurrentVal, 2);
            return this.currentVal;
        }

        public void Reset()
        {
            this.currentVal = 0;
            this.indexCurrentVal = 0;
        }

        public void SetStart(int x)
        {
            this.indexCurrentVal = x - 1;
        }
    }
}
