using ImageProcessor;
using System.Drawing;

namespace EdgeDetectorWinForms.Model
{
    /// <summary>
    /// Klasa reprezentująca filtr Sobela implementująca interfejs IFilter
    /// </summary>
    public class SobelFilter : IFilter
    {
        public bool CheckColorPallet
        {
            get
            {
                return true;
            }
        }

        public Image DetectEdge(string path, bool grayScale)
        {
            ImageFactory imageFactory = new ImageFactory(preserveExifData: true);
            imageFactory.Load(path);
            return imageFactory.DetectEdges(new ImageProcessor.Imaging.Filters.EdgeDetection.SobelEdgeFilter(), grayScale).Image;
        }
    }
}
