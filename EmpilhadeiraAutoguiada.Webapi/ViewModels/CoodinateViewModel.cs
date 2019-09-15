namespace EmpilhadeiraAutoguiada.Webapi.ViewModels
{
    public class CoordinateViewModel
    {
        public int X { get; set; }
        public int Y { get; set; }

        public CoordinateViewModel(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}