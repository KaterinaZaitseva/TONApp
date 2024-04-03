using Microsoft.AspNetCore.Mvc;

namespace TONWebApp.Infrastructure.Extensions;

public static class ControllerExtensions {
    public static string ToShortName(this ControllerBase instance) {
        return instance.GetType().Name.Replace("Controller", "");
    }

    public static string GetShortName<T>() where T : ControllerBase {
        return nameof(T).Replace("Controller", "");
    }
}
