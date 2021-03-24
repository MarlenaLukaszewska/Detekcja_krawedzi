using EdgeDetectorWinForms.Model;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EdgeDetectorWinForms.Forms
{
    
    /// Główna forma programu
  
    public partial class MainForm : Form
    {
    	public string plik;
    	
        public MainForm()
        {
            InitializeComponent();
        }

        
        /// Metoda publiczna wstawiająca obraz z parametry do obiektu pictureBoxEdgeImage
        
        /// <param name="image"></param>
        public void DrawEdgeImage(Image image)
        {
            this.pictureBoxEdgeImage.Image = image;
        }

        /// <summary>
        /// Metoda, która jako parametr przyjmuje obiekt implementujący IFilter. Na początku sprawdzamy czy
        /// obraz został wczytany przy wykorzystaniu innej metody, następnie sprawdzamy właściwość CheckColorPallet.
        /// Jeżeli wartość == true wtedy otwiera się okno z informacją czy konwertować obraz do skali szarości.
        /// Jeżeli nie oznacza to, że mamy do czynienia z filtrem Canny'ego i otwiera się okno z właściwościami maski Gaussa.
        /// </summary>
        /// <param name="edgeFilter"></param>
        private void ShowPropertiesWindow()
        {
        	
        }
        private void ShowPropertiesWindow(IFilter edgeFilter)
        {
            if (!this.CheckOrignalImageExists())
            {
                MessageBox.Show("Nie wczytano oryginalnego obrazu");
                return;
            }

            if (edgeFilter.CheckColorPallet)
            {
                FormRadioButton form = new FormRadioButton(edgeFilter, this, pictureBoxImageOryginal.ImageLocation);
                form.ShowDialog();
            }
            else
            {
                FormGaussianProperties form = new FormGaussianProperties(edgeFilter, this, pictureBoxImageOryginal.ImageLocation);
                form.ShowDialog();
            }

        }

        /// <summary>
        /// Metoda sprawdzająca czy wczytano obraz
        /// </summary>
        /// <returns></returns>
        private bool CheckOrignalImageExists()
        {
            return pictureBoxImageOryginal.Image != null;
        }

        #region Event methods
        private void button2_Click(object sender, EventArgs e)
        {
            this.ShowPropertiesWindow(new PrewittFilter());
        }

        private void buttonSobel_Click(object sender, EventArgs e)
        {
            this.ShowPropertiesWindow(new SobelFilter());
        }

        private void buttonCanny_Click(object sender, EventArgs e)
        {
            this.ShowPropertiesWindow(new CannyFilter());
        }

        private void buttonRoberts_Click(object sender, EventArgs e)
        {
            this.ShowPropertiesWindow(new RobertsFilter());
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            this.ShowPropertiesWindow(new LoGFilter());
        }

        /// <summary>
        /// Metoda uruchamiana w momencie wciśnięcia klawisza wczytaj - wczytujemy obraz, ustawiamy filtry na pliki i 
        /// dodajemy instrukcję try catch z odpowiednim wyjątkiem by nie zawiesić aplikacji w momencie gdy coś z odczytem poszło źle.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png";
            DialogResult result = fileDialog.ShowDialog(); 
            if (result == DialogResult.OK) 
            {              
                try
                {
                    pictureBoxImageOryginal.Image = Image.FromFile(fileDialog.FileName);
                    pictureBoxImageOryginal.ImageLocation = fileDialog.FileName;
                    plik = fileDialog.FileName;
                }
                catch (IOException)
                {
                    MessageBox.Show("Nie udało się otworzyć pliku !");
                }
            }
        }

        /// <summary>
        /// Metoda uruchamiana w momencie zapisywania pliku. Podobnie do tej powyżej.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png";
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    pictureBoxEdgeImage.Image.Save(fileDialog.FileName);
                }
                catch (IOException)
                {
                    MessageBox.Show("Nie udało się zapisać pliku !");
                }
            }
        }

        #endregion
        
        void Button1Click(object sender, EventArgs e)
        {
       		Wait wait = new Wait();
        	FolderBrowserDialog fileDialog = new FolderBrowserDialog();
        	fileDialog.ShowDialog();
        	
            if (fileDialog.SelectedPath != "")
            {
                try
                {
                	FormRadioButton frb = new FormRadioButton();
                	DialogResult result = frb.ShowDialog();
                	
                	if (result != DialogResult.Cancel)
                	{
        				SobelFilter sobel = new SobelFilter();
        				Application.DoEvents();
        				wait.Show();
        				Application.DoEvents();
	        			sobel.DetectEdge(plik, frb.bw).Save(fileDialog.SelectedPath + "\\1.png");
                	}
                	
                	if (result != DialogResult.Cancel)
                	{
        				PrewittFilter prewitt = new PrewittFilter();
        				Application.DoEvents();
	        			prewitt.DetectEdge(plik, frb.bw).Save(fileDialog.SelectedPath + "\\2.png");
                	}
        			
                	wait.Hide();
                	FormGaussianProperties fgp = new FormGaussianProperties();
                	result = fgp.ShowDialog();
                	
                	if (result != DialogResult.Cancel)
                	{
                		CannyFilter canny = new CannyFilter();
                		canny.GaussianStandardDeviation = fgp.gaussianStandardDeviation;
                		canny.GaussianSize = fgp.gaussianSize;
                		Application.DoEvents();
                		wait.Show();
                		Application.DoEvents();
        				canny.DetectEdge(plik, true).Save(fileDialog.SelectedPath + "\\3.png");
                	}
                	
                	wait.Hide();
                    if (result != DialogResult.Cancel)
                    {
                        RobertsFilter roberts = new RobertsFilter();
                        Application.DoEvents();
                        wait.Show();
                        Application.DoEvents();
                        roberts.DetectEdge(plik, frb.bw).Save(fileDialog.SelectedPath + "\\4.png");
                    }
                   
                    if (result != DialogResult.Cancel)
                    {
                        LoGFilter log = new LoGFilter();
                        Application.DoEvents();
                        log.DetectEdge(plik, frb.bw).Save(fileDialog.SelectedPath + "\\5.png");
                    }
                    wait.Hide();
                }
                catch (IOException)
                {
                    MessageBox.Show("Nie udało się zapisać pliku !");
                }
            }        	
        	

        	
        	

        }
        
        void Button2Click(object sender, EventArgs e)
        {
        	pictureBoxImageOryginal.SizeMode = PictureBoxSizeMode.Zoom;
        	pictureBoxImageOryginal.Dock = DockStyle.Fill;
        }
        
        void Button3Click(object sender, EventArgs e)
        {
        	pictureBoxImageOryginal.SizeMode = PictureBoxSizeMode.AutoSize;        	
        	pictureBoxImageOryginal.Dock = DockStyle.None;
        	pictureBoxImageOryginal.Top = 0;
        	pictureBoxImageOryginal.Left = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBoxEdgeImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEdgeImage.Dock = DockStyle.Fill;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBoxEdgeImage.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxEdgeImage.Dock = DockStyle.None;
            pictureBoxEdgeImage.Top = 0;
            pictureBoxEdgeImage.Left = 0;
        }

        private void pictureBoxImageOryginal_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxEdgeImage_Click(object sender, EventArgs e)
        {

        }
    }
}
