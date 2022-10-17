using MVP.Presenters;
using MVP.Views;
using Source.Presenters;

namespace MVP;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        IAddView addView = new AddView();
        new AddPresenter(addView);

        IUpdateView updateView = new UpdateView();
        new UpdatePresenter(updateView);

        IMainView mainView = new MainView();
        new MainPresenter(mainView, addView, updateView);

        Application.Run((Form)mainView);
    }
}
