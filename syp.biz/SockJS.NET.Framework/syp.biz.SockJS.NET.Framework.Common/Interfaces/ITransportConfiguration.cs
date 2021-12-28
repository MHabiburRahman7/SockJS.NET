using syp.biz.SockJS.NET.Framework.Common.DTO;
using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace syp.biz.SockJS.NET.Framework.Common.Interfaces
{
    public interface ITransportConfiguration
    {
        Uri BaseEndpoint { get; }
        ILogger Logger { get; }
        InfoDto Info { get; }
        WebHeaderCollection DefaultRequestHeaders { get; }
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        ICredentials? Credentials { get; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        IWebProxy? Proxy { get; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        X509CertificateCollection? ClientCertificates { get; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        RemoteCertificateValidationCallback? RemoteCertificateValidator { get; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        CookieContainer? Cookies { get; }
        TimeSpan? KeepAliveInterval { get; }
    }
}
