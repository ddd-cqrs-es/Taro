﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taro
{
    public interface IDomainRepository
    {
        T Find<T>(object id) where T : AggregateRoot;

        void Save<T>(T aggregate) where T : AggregateRoot;

        void Delete<T>(T aggregate) where T : AggregateRoot;
    }
}