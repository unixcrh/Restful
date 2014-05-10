﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Restful.Common.Extensions
{
    public static class DataTableExtensions
    {
        /// <summary>
        /// 将 DataTable 转换成指定类型的对象列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IList<T> ToObjects<T>( this DataTable source )
        {
            IList<T> target = new List<T>();

            foreach( DataRow dr in source.Rows )
            {
                target.Add( dr.ToObject<T>() );
            }

            return target;
        }
    }
}
