﻿using System;
using System.Linq.Expressions;
using Restful.Data.Entity;

namespace Restful.Data.Linq
{
    public interface IUpdateable<T> : IExecuteable
    {
        /// <summary>
        /// 设置更新字段
        /// </summary>
        /// <param name="object"></param>
        /// <returns></returns>
        IUpdateable<T> Set( object @object );

        /// <summary>
        /// 设置过滤条件
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        IUpdateable<T> Where( Expression<Func<T, bool>> func );
    }
}
