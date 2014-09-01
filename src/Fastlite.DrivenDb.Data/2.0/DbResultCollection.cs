﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Fastlite.DrivenDb.Core._2._0.Framework
{
   public sealed class DbResultCollection<T> : IReadOnlyList<T>
   {
      private readonly IReadOnlyList<T> _results;

      public DbResultCollection(IReadOnlyList<T> results)
      {
         if (results == null)
            throw new ArgumentNullException("results");

         _results = results;
      }

      public T this[int index]
      {
         get { return _results[index]; }
      }

      public int Count
      {
         get { return _results.Count; }
      }

      public IEnumerator<T> GetEnumerator()
      {         
         return _results.GetEnumerator();
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
         return GetEnumerator();
      }
   }
}