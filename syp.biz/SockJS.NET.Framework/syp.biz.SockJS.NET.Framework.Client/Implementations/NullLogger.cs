﻿using syp.biz.SockJS.NET.Framework.Common.Interfaces;

namespace syp.biz.SockJS.NET.Framework.Client.Implementations
{
    internal class NullLogger : ILogger
    {
        #region Implementation of ILogger
        public void Debug(string message) { }
        public void Info(string message) { }
        public void Error(string message) { }
        #endregion Implementation of ILogger
    }
}
