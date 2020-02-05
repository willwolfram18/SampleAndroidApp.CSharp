using System;
using Android.Util;
using Java.Lang;
using SampleAndroidApp.Services.Logging;

namespace SampleAndroidApp.Droid.Services.Logging
{
    public class Logger<TService> : IWriteLog<TService>
        where TService : class
    {
        public Logger()
        {
        }

        private string Tag => typeof(TService).FullName;

        public void Error<T>(T message, System.Exception exception)
        {
            Log.Error(
                Tag,
                Throwable.FromException(exception),
                message?.ToString()
            );
        }

        public void Info<T>(T message)
        {
            Log.Info(
                Tag,
                message?.ToString()
            );
        }

        public void Warn<T>(T message, System.Exception exception)
        {
            Log.Warn(
                Tag,
                Throwable.FromException(exception),
                message?.ToString()
            );
        }
    }
}
