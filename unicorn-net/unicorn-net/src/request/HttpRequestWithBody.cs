﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

using unicorn_net.http;
using unicorn_net.request;
using unicorn_net.request.body;

namespace unicorn_net.request
{
    public class HttpRequestWithBody : HttpRequest
    {
        public Body Body { get; private set; }

        // Should add overload that takes URL object
        public HttpRequestWithBody(HttpMethod method, string url) : base(method, url)
        {
        }
    }
}
