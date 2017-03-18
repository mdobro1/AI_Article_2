using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.CognitiveServices.ContentModerator.Contract
{
    /// <summary>
    /// Status from a response
    /// </summary>
    public class Status
    {
        /// <summary>
        /// Status code
        /// </summary>
        public string Code;

        /// <summary>
        /// Text describing the response
        /// </summary>
        public string Description;

        /// <summary>
        /// Observed error
        /// </summary>
        public string Exception;

        public override string ToString()
        {
            return String.Format("Code={0}; Description={1}; Exception={2}", Code, Description, Exception);
        }
    }
}
