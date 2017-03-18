using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.CognitiveServices.ContentModerator.Contract.Text
{
    public class Result
    {
        /// <summary>
        /// Status of the result
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Tracking Id
        /// </summary>
        public string TrackingId { get; set; }

        public override string ToString()
        {
            return String.Format("Status: {0}; Tracking-ID={1}", Status, TrackingId);
        }
    }
}
