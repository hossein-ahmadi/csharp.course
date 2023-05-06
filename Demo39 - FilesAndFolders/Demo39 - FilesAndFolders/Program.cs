namespace Demo39___FilesAndFolders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Demo39___FilesAndFolders.Classes.Car();
            car.Model = "BMW";
            car.Color = "Black";

            car.DisplayInformation();
        }
    }
}