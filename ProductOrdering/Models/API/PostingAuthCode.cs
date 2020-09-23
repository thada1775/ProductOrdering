using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models.API
{
    public class PostingAuthCode
    {
        public string grant_type
        {
            get
            {
                return "authorization_code";
            }
        }
        public string code { get; set; }
        public string redirect_uri { get; set; }
        public string client_id { get; set; }
        public string client_secret { get; set; }
    }
}
