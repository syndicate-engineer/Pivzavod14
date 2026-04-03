using Robust.Shared.Player;

namespace Content.Goobstation.Common.JoinQueue;

public interface IJoinQueueManager
{
    int ActualPlayersCount { get; }
    int PlayerInQueueCount { get; }
    event Action? PlayerJoinQueueUpdated;
    void Initialize();
}

public sealed class PlayerJoinQueueUpdatedEvent : EntityEventArgs
{
    public ICommonSession Session { get; }

    public PlayerJoinQueueUpdatedEvent(ICommonSession session)
    {
        Session = session;
    }
}