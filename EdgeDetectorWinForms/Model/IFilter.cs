using System.Drawing;

namespace EdgeDetectorWinForms.Model
{
    /// <summary>
    /// Interfejs implementujący właściwość,która umożliwia sprawdzenie czy możemy wybrać paletę kolorów oraz metodę detekcji krawędzi
    /// </summary>
    public interface IFilter
    {
        bool CheckColorPallet { get; }
        Image DetectEdge(string path, bool grayScale);
    }
}
