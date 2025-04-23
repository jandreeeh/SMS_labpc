namespace SMS.App.Views.IViews
{
    public interface ILoginForm
    {
        string Password { get; }
        string UserName { get; }

        event EventHandler LoginEvent;

        void ShowMessage(string message);

        void HideForm();
    }
}