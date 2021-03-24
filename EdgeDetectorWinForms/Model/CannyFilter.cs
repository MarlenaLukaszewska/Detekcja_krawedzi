using AForge.Imaging.Filters;
using System.Drawing;

namespace EdgeDetectorWinForms.Model
{
    /// <summary>
    /// Klasa reprezentująca filtr Canny'ego implementująca interfejs IFilter, jako jedyna klasa korzysta z Aforge
    /// umożliwia również zdefiniowanie wartości właściwości - wielkość maski filtru Gaussa oraz odchylenia standardowego.
    /// </summary>
    public class CannyFilter : IFilter
    {
        public bool CheckColorPallet
        {
            get
            {
                return false;
            }
        }

        private int gaussianSize;
        public int GaussianSize
        {
            get
            {
                return gaussianSize;
            }

            set
            {
                gaussianSize = value;
            }
        }

        private double gaussianstandarddeviation;
        public double GaussianStandardDeviation
        {
            get
            {
                return gaussianstandarddeviation;
            }

            set
            {
                gaussianstandarddeviation = value;
            }
        }

        public CannyFilter()
        {
            CannyEdgeDetector filter = new CannyEdgeDetector();
            this.GaussianStandardDeviation = filter.GaussianSigma;
            this.GaussianSize = filter.GaussianSize;
        }

        public Image DetectEdge(string path, bool grayScale)
        {    
            Image image = Image.FromFile(path);

            Grayscale grayScaleFilter = new Grayscale(0.2125, 0.7154, 0.0721);
            image = grayScaleFilter.Apply((Bitmap)image);

            CannyEdgeDetector filter = new CannyEdgeDetector();
            filter.GaussianSigma = this.GaussianStandardDeviation;
            filter.GaussianSize = this.GaussianSize;
            filter.ApplyInPlace((Bitmap)image);
            return image;
        }
    }
}
