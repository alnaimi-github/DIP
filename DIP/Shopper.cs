
using DIP;

public class Shopper
{
    private readonly ICard _card;
    private readonly INotifier _notifier;

    public Shopper(ICard card, INotifier notifier)
    {
        _card = card;
        _notifier = notifier;
    }

    public void Pay()
    {
        _card.Charge();
        _notifier.Notify();
    }
}