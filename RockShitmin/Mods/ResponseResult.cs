using System;

namespace Rock.Mods
{
    public enum ResponseResult
    {
        RelationshipChanged = 1,
        MessageReceived,
        MessageDeleted,
        PresenceHeartbeatResponse,
        SubscriptionListUpdated = 9,
        SubscriptionUpdateProfile = 11,
        SubscriptionUpdatePresence,
        SubscriptionUpdateGameSession,
        SubscriptionUpdateRoom,
        ModerationQuitGame = 20,
        ModerationUpdateRequired,
        ModerationKick,
        ModerationKickAttemptFailed,
        GiftPackageReceived = 30,
        ProfileJuniorStatusUpdate = 40,
        RelationshipsInvalid = 50,
        StorefrontBalanceAdd = 60
    }
}
