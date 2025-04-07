namespace SMS.App.Views.IViews
{
    public interface IProgramView
    {
        string Description { get; set; }
        int ProgramId { get; set; }
        string ProgramName { get; set; }
        string SearchValue { get; }

        event EventHandler CreateEvent;
        event EventHandler ReadEvent;
        event EventHandler UpdateEvent;
        event EventHandler DeleteEvent;
        event EventHandler GetInfoEvent;

        void GetProgramList(BindingSource bindingSource);

        void SetMessage(string message);
    }
}