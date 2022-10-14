using MVP.Presenters;
using MVP.Views;
using Source.Presenters;

namespace MVP;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
      
        IAddUpdateView addView = new AddUpdateView();
        new AddUpdatePresenter(addView);

        IMainView mainView = new MainView();
        new MainPresenter(mainView, addView);

        Application.Run((Form)mainView);
    }
}
