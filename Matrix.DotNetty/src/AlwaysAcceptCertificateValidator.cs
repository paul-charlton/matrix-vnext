﻿using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Matrix.DotNetty
{
    public class AlwaysAcceptCertificateValidator : ICertificateValidator
    {
        public bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain,
           SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}
