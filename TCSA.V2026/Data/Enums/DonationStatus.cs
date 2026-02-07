namespace TCSA.V2026.Data.Enums;

public enum DonationStatus
{
    Created = 0,     // checkout created
    Succeeded = 1,   // paid
    Failed = 2,      // payment failed
    Canceled = 3     // user canceled checkout
}
