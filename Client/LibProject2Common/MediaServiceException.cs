using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibMediaServiceCommon
{
    public class MediaServiceException : Exception
    {
        public MediaServiceException(string msg)
            : base(msg)
        {
        }
        public MediaServiceException(string msg, Exception ex)
            : base(msg, ex)
        {
        }
    }
}
