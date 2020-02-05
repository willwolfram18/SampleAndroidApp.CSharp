using System;
namespace SampleAndroidApp.Services.Logging
{
    public interface IWriteLog<TService> where TService : class
    {
        void Info<T>(T message);

        void Warn<T>(T message, Exception exception);

        void Error<T>(T message, Exception exception);
    }
}
