using System;

namespace HR.LeaveManagement.UI.Services.Base;

public partial interface IClient
{
    public HttpClient HttpClient { get; }

}
