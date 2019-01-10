/*
 * Raas.Tests
 *
 * This file was automatically generated for Tango Card, Inc. by APIMATIC v2.0 ( https://apimatic.io ).
 */
using TangoCard.Raas.Http.Client;
using TangoCard.Raas.Http.Request;
using TangoCard.Raas.Http.Response;

namespace TangoCard.Raas.Helpers
{
    public class HttpCallBackEventsHandler
    {
        public HttpRequest Request { get; private set; }

        public HttpResponse Response { get; private set; }

        public void OnBeforeHttpRequestEventHandler(IHttpClient source, HttpRequest request)
        {
            this.Request = request;
        }

        public void OnAfterHttpResponseEventHandler(IHttpClient source, HttpResponse response)
        {
            this.Response = response;
        }
    }
}
