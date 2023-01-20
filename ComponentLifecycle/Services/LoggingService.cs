using System.Collections.ObjectModel;

namespace ComponentLifecycle.Services;

public class LoggingService
{
    public ObservableCollection<string> Logs { get; set; } = new();
}
