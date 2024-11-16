namespace DiwaliCelebration.LSP
{
    public class AutomaticLEDLight : ILight
    {
        public void Illuminate()
        {
            Console.WriteLine("Turning on the LED light!");
        }
    }
}
