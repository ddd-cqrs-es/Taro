﻿using System;

namespace Taro.Events
{
    public interface IEventDispatcher
    {
        void Dispatch(IDomainEvent evnt, EventDispathcingContext context);
    }
}