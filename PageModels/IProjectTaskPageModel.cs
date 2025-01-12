using CommunityToolkit.Mvvm.Input;
using MauiNet9.Models;

namespace MauiNet9.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}