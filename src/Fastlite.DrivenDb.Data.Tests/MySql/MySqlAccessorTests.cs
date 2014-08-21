﻿using Fastlite.DrivenDb.Data.Tests.Base;
using Fastlite.DrivenDb.Data.Tests.Base.Infrastructure;
using Fastlite.DrivenDb.Data.Tests.MySql.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#if ALL_TESTS

namespace Fastlite.DrivenDb.Data.Tests.MySql
{
   [TestClass]
   public class MySqlAccessorTests : DbAccessorTests
   {
      protected override IDbTestFixture CreateFixture()
      {
         return new MySqlTestFixture();
      }
   }
}

#endif