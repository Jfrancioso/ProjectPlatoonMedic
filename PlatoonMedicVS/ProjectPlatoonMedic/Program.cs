namespace ProjectPlatoonMedicClient
{
    class Program
    {
        //connect the apiurl to localhost to run off local computer, change it once app is deployable
    private const string apiUrl = "https://localhost:54469";
    
        static void Main()
        {
        PlatoonMedicClientApp app = new PlatoonMedicClientApp(apiUrl);
        app.Run();
        }
    }
}
