using Microsoft.AspNetCore.SignalR.Client;

namespace Qexal.CTI;

public class RetryPolicy : IRetryPolicy
{
    public TimeSpan? NextRetryDelay(RetryContext retryContext)
    {
        return TimeSpan.FromSeconds(5);
    }
}