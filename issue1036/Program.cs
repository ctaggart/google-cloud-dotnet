// replacing a custom label leads to no more log entries #1036
// https://github.com/GoogleCloudPlatform/google-cloud-dotnet/issues/1036

// based on code from
// https://github.com/GoogleCloudPlatform/google-cloud-dotnet/issues/466

namespace issue1036
{
    class Program
    {
        const string LogId = "issue1036";

        static void Main(string[] args)
        {
            var appender = new Google.Cloud.Logging.Log4Net.GoogleStackdriverAppender();
            appender.ProjectId = "tachyusweb";
            appender.LogId = LogId;
            appender.Layout = new log4net.Layout.PatternLayout { ConversionPattern = "%message" };
            appender.ActivateOptions();

            var hierarchy = (log4net.Repository.Hierarchy.Hierarchy)log4net.LogManager.GetRepository();
            hierarchy.Root.AddAppender(appender);
            hierarchy.Root.Level = log4net.Core.Level.Debug;
            hierarchy.Configured = true;

            var log = log4net.LogManager.GetLogger(LogId);
            log.Info("a");
            log.Info("b");
            log.Info("c");
            appender.AddCustomLabel(new Google.Cloud.Logging.Log4Net.GoogleStackdriverAppender.Label { Key = "batch", Value = "1" });
            log.Info("d");
            log.Info("e");
            log.Info("f");
            appender.AddCustomLabel(new Google.Cloud.Logging.Log4Net.GoogleStackdriverAppender.Label { Key = "batch", Value = "2" });
            log.Info("g");
            log.Info("h");
            log.Info("i");

            appender.Dispose();
        }
    }
}