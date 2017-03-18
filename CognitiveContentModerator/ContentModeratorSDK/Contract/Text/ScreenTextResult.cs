using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.CognitiveServices.ContentModerator.Contract.Text
{
    /// <summary>
    /// Result from screening a text, containing details regarding the Match
    /// </summary>
    public class ScreenTextResult : Result
    {
        public string OriginalText;
        public string NormalizedText;
        public string Misrepresentation;
        public string Language;
        public MatchTerm[] Terms;
        public MatchUrl[] Urls;
        public PII PII;
        public string ContentId;
        public bool IsMatch;
        public MatchDetails MatchDetails;

        public override string ToString()
        {
            var result =  String.Format("{0}; OriginalText={1}; NormalizedText={2}; Misrepresentation={3}; Language={4}; ContentId={5}; IsMatch={6}", 
                base.ToString(), OriginalText, NormalizedText, Misrepresentation, Language, ContentId, IsMatch);

            if (Terms != null) result += String.Format("; Terms-Liste ({0} Items)", Terms.Length);
            if (Urls != null) result += String.Format("; Urls-Liste ({0} Items)", Terms.Length);

            return result;
        }
    }
}
