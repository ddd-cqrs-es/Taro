﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

using Taro.Data;
using Taro.Events;

using BookStore.Domain;
using BookStore.Domain.Events;

namespace BookStore.Events.Handlers
{
    class OnPasswordChanged : HandlesOnCommit<PasswordChangedEvent>
    {
        public override void Handle(PasswordChangedEvent evnt)
        {
            var user = UnitOfWork.Get<User>(evnt.UserId);

            Debug.WriteLine("Send SMS to user " + user.NickName + " to inform that his password has been changed.");
        }
    }
}
