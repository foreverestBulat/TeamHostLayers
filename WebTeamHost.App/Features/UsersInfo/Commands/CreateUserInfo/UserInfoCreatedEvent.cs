﻿using WebTeamHost.Domain.Common;
using WebTeamHost.Domain.Entities;

namespace WebTeamHost.App.Features.UsersInfo.Commands.CreateUserInfo
{
    public class UserInfoCreatedEvent : BaseEvent
    {
        public UserInfo UserInfo { get; }

        public UserInfoCreatedEvent(UserInfo userInfo)
        {
            UserInfo = userInfo;
        }
    }
}
