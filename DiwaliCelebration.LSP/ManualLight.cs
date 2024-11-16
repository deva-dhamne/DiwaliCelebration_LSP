namespace DiwaliCelebration.LSP
{
    public class ManualLight : ILight
    {
        public virtual void Illuminate()
        {
            Console.WriteLine("Lighting up manually..");
        }
    }
}
