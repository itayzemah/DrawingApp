using System;

namespace EntityAndBoundary
{
    public class Response<TRequest>
    {
        public string ResponseType { get; set; }
        public Response()
        {
            ResponseType = this.GetType().Name;
        }
        public TRequest ResponseData { get; set; }
    }

}
