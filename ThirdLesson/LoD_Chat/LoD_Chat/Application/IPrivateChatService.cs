﻿using System;

namespace LoD_Chat.Application
{
    public interface IPrivateChatService
    {
        void AddMessage(Guid groupChatId, Guid clientId, Message message);

        void EditMessage(Guid groupChatId, Guid clientId, Message message, string textChanges);

        void DeleteMessage(Guid groupChatId, Guid clientId, Message message);
    }
}
