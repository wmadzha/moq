﻿using System;
using System.ComponentModel;
using Moq.Properties;
using Moq.Sdk;

namespace Moq
{
    /// <summary>
    /// Extension for marking a mock as being set up, meaning 
    /// invocation tracking should be suspended.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static class SetupExtension
    {
        /// <summary>
        /// Marks the mock as being set up, meaning 
        /// invocation tracking should be suspended 
        /// until the returned <see cref="IDisposable"/> 
        /// is disposed.
        /// </summary>
        /// <param name="mock"></param>
        /// <returns></returns>
        public static IDisposable Setup(this object mock)
        {
            var target = mock is IMocked mocked ?
                mocked.Mock : throw new ArgumentException(Resources.TargetNotMocked);

            return new SetupDisposable(target);
        }

        class SetupDisposable : IDisposable
        {
            IMock mock;

            public SetupDisposable(IMock mock)
            {
                this.mock = mock;
                mock.State.TryAdd<bool?>(MockTrackingBehavior.SkipTrackingState, true);
            }

            public void Dispose() => mock.State.TryRemove<bool?>(MockTrackingBehavior.SkipTrackingState, out var _);
        }
    }
}