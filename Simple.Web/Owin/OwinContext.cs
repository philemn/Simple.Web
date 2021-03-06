﻿namespace Simple.Web.Owin
{
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.IO;
    using Http;

    internal class OwinContext : IContext
    {
        public OwinContext(IDictionary<string,object> env, IDictionary<string,string[]> requestHeaders, Stream inputStream)
        {
            Variables = env;
            Request = new OwinRequest(env, requestHeaders, inputStream);
            Response = new OwinResponse();
        }

        public IRequest Request { get; private set; }
        public IResponse Response { get; private set; }
        public IDictionary<string, object> Variables { get; private set; }
    }
}