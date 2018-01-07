﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.ObjectModel;
using System.Reflection;
using Stunts;
using System.Runtime.CompilerServices;
using Moq.Tests.Recursive;
using System.Threading;
using Moq.Sdk;

namespace Mocks
{
    public partial class IRecursiveRootMock : IRecursiveRoot, IStunt, IMocked
    {
        readonly BehaviorPipeline pipeline = new BehaviorPipeline();

        [CompilerGenerated]
        ObservableCollection<IStuntBehavior> IStunt.Behaviors => pipeline.Behaviors;

        [CompilerGenerated]
        public IRecursiveBranch Branch => pipeline.Execute<IRecursiveBranch>(new MethodInvocation(this, MethodBase.GetCurrentMethod()));

        [CompilerGenerated]
        public override bool Equals(object obj) => pipeline.Execute<bool>(new MethodInvocation(this, MethodBase.GetCurrentMethod(), obj));
        [CompilerGenerated]
        public override int GetHashCode() => pipeline.Execute<int>(new MethodInvocation(this, MethodBase.GetCurrentMethod()));
        [CompilerGenerated]
        public override string ToString() => pipeline.Execute<string>(new MethodInvocation(this, MethodBase.GetCurrentMethod()));

        #region IMocked
        IMock mock;

        [CompilerGenerated]
        IMock IMocked.Mock => LazyInitializer.EnsureInitialized(ref mock, () => new MockInfo(this));
        #endregion
    }
}