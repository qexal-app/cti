namespace Qexal.CTI;

static class Program
{
    private static readonly Mutex Mutex = new(true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}");

    [STAThread]
    static void Main()
    {
        if (!Mutex.WaitOne(TimeSpan.Zero, true)) return;
        ApplicationConfiguration.Initialize();
        Application.Run(new Main());
        Mutex.ReleaseMutex();
    }
}