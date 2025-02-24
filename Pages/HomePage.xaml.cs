using System.Diagnostics;

namespace MauiNet9.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        hybridWebView.SetInvokeJavaScriptTarget(this);
    }

    private void OnSendMessageButtonClicked(object sender, EventArgs e)
    {
        hybridWebView.SendRawMessage($"Hello from C#!");
    }

    private async void OnHybridWebViewRawMessageReceived(object sender, HybridWebViewRawMessageReceivedEventArgs e)
    {
        await DisplayAlert("Raw Message Received", e.Message, "OK");
    }


    public void DoSyncWork()
    {
        Debug.WriteLine("DoSyncWork");
    }

    public void DoSyncWorkParams(int i, string s)
    {
        Debug.WriteLine($"DoSyncWorkParams: {i}, {s}");
    }

    public string DoSyncWorkReturn()
    {
        Debug.WriteLine("DoSyncWorkReturn");
        return "Hello from C#!";
    }

    public SyncReturn DoSyncWorkParamsReturn(int i, string s)
    {
        Debug.WriteLine($"DoSyncWorkParamReturn: {i}, {s}");
        return new SyncReturn
        {
            Message = "Hello from C#!" + s,
            Value = i
        };
    }

    public class SyncReturn
    {
        public string? Message { get; set; }
        public int Value { get; set; }
    }
}