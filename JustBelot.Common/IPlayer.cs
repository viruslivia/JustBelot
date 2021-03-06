﻿namespace JustBelot.Common
{
    public interface IPlayer
    {
        string Name { get; }

        GameManager Game { set; }

        PlayerPosition Position { set; }

        void AddCard(Card card);

        AnnouncementType AskForAnnouncement();

        Card PlayCard();
    }
}
