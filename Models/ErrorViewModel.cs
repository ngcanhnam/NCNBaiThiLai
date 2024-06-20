namespace NCNBaiThiLai.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}

//dotnet aspnet-codegenerator controller -name LophocController -m lophoc -dc LTQLDb --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite