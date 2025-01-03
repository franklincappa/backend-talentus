using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class APIResponse
    {
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
        public bool Success { get; set; } = true;
        public string Message { get; set; } = "La operación se ha realizado con éxito";
        public List<string> Errors { get; set; }
        public object Data { get; set; }
    }
}
