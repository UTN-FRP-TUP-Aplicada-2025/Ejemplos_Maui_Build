


using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Logging;

namespace Ejemplo_Build.PageModels;

public partial class MainPageModel:ObservableObject
{
    readonly ILogger _logger;

    public MainPageModel(ILogger logger)
    {
        _logger = logger;
    }
}
