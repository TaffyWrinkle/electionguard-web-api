using System.Collections.Generic;
using ElectionGuard.SDK.Models;

namespace ElectionGuard.WebAPI.Models
{
    public class TallyVotesRequest
    {
        public ElectionGuardConfig electionGuardConfig { get; set; }

        public IDictionary<int, string> TrusteeKeys { get; set; }

        public string EncryptedBallotsFileName { get; set; }
    }
}