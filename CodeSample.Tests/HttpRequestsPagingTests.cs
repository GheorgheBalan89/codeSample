using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using NUnit.Framework;
using TreeDemo;

namespace TreeDemo.Tests
{
    public  class HttpRequestsPagingTests
    {
        [Test]
        public void MovieTest1()
        {
            var call = new HttpRequestsPaging().getMovieTitles("spiderman");
            Assert.IsNotNull(call);
        }
    }
}
