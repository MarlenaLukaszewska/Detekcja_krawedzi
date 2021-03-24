using EdgeDetectorWinForms.Model;
using System;
using System.Windows.Forms;

namespace EdgeDetectorWinForms.Forms
{
    public partial class FormRadioButton : Form
    {
        private IFilter filter;
        private MainForm form;
        private string path;
        
        public bool bw;

        public FormRadioButton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Przeciążony konstruktor klasy
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="form"></param>
        /// <param name="path"></param>
        public FormRadioButton(IFilter filter, MainForm form,string path)
        {
            this.filter = filter;
            this.form = form;
            this.path = path;
            InitializeComponent();
        }

        #region Event methods
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
        	bw = radioButton1.Checked;
        	if (this.filter != null) form.DrawEdgeImage(filter.DetectEdge(path, radioButton1.Checked));
            this.Dispose();
        }
        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
