using System;
using System.Collections.Generic;
using System.Text;

namespace CheapFlightsScanner.Infrastructure.Interface
{
    public interface ICodeGrantOAuthService
    {
        string GetAccessToken();

        string RefreshAccessToken();
    }
}
