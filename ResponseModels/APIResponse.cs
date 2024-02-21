using System.Net;
using System.Runtime.Serialization;

namespace ScorePromeAPI.ResponseModels
{
    public class APIResponse
    {
        public APIResponse()
        {
            this.ErrorMessages = new List<string>();
        }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }

        [DataMember]
        public bool IsSuccess { get; set; } = true;

        [DataMember]
        public List<string> ErrorMessages { get; set; }

        [DataMember]
        public object Result { get; set; }
    }
}