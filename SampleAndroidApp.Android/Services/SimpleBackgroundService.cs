using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using SampleAndroidApp.Droid.Services.Logging;
using SampleAndroidApp.Services.Logging;

namespace SampleAndroidApp.Droid.Services
{
    [Service]
    public class SimpleBackgroundService : Service
    {
        private readonly IWriteLog<SimpleBackgroundService> _log;

        public SimpleBackgroundService() : this(new Logger<SimpleBackgroundService>())
        {
        }

        public SimpleBackgroundService(IWriteLog<SimpleBackgroundService> log)
        {
            _log = log;
        }

        public override IBinder OnBind(Intent intent)
        {
            return null;
        }

        public override void OnCreate()
        {
            _log.Info($"Called {nameof(OnCreate)}");

            base.OnCreate();
        }

        [return: GeneratedEnum]
        public override StartCommandResult OnStartCommand(Intent intent, [GeneratedEnum] StartCommandFlags flags, int startId)
        {
            _log.Info($"Called {nameof(OnStartCommand)}.");

            return base.OnStartCommand(intent, flags, startId);
        }

        public override void OnDestroy()
        {
            _log.Info($"Called {nameof(OnDestroy)}.");

            base.OnDestroy();
        }

        public override bool StopService(Intent name)
        {
            _log.Info($"Called {nameof(StopService)}.");

            return base.StopService(name);
        }
    }
}
