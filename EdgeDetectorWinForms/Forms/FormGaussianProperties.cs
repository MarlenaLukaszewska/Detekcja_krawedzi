using EdgeDetectorWinForms.Model;
using System;
using System.Windows.Forms;

namespace EdgeDetectorWinForms.Forms
{
    public partial class FormGaussianProperties : Form
    {
        private IFilter filter;
        private MainForm form;
        private string path; 
        public double gaussianStandardDeviation;
        public int gaussianSize;

        public FormGaussianProperties()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Przeciążony konstruktor klasy, oprócz przypisania obiektów wyświetlamy domyślne wartości dla filtru Gaussa i odchylenia stand.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="form"></param>
        /// <param name="path"></param>
        public FormGaussianProperties(IFilter filter, MainForm form,string path)
        {
            InitializeComponent();
            this.filter = filter;
            this.form = form;
            this.path = path;
            this.textBoxStandardDeviation.Text = ((CannyFilter)filter).GaussianStandardDeviation.ToString();
            this.numericUpDown1.Value = ((CannyFilter)filter).GaussianSize;         
        }

        #region Event methods
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
        	gaussianStandardDeviation = Double.Parse(this.textBoxStandardDeviation.Text);
        	gaussianSize = Int32.Parse(this.numericUpDown1.Value.ToString());
        
        	if (this.filter != null) 
        	{
            try
            {
                ((CannyFilter)filter).GaussianStandardDeviation = Convert.ToDouble(textBoxStandardDeviation.Text);
                ((CannyFilter)filter).GaussianSize = Convert.ToInt32(numericUpDown1.Value);
                form.DrawEdgeImage(filter.DetectEdge(path, true));
                this.Dispose();
            }
            catch(FormatException)
            {
                MessageBox.Show("Nie prawidłowe formatowanie !");
            }
        	}
        }
        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxStandardDeviation_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
