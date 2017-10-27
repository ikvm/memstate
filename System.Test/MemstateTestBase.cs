namespace System.Test
{
    using Memstate;
    using Xunit.Abstractions;

    public abstract class MemstateTestBase
    {
        protected readonly Config Config;
        protected readonly ITestOutputHelper Log;

        protected MemstateTestBase(ITestOutputHelper testOutputHelper)
        {
            Log = testOutputHelper;
            Config = new Config();
            Config.LoggerFactory.AddProvider(new TestOutputLoggingProvider(testOutputHelper));
            string streamName = "test-stream-" + Guid.NewGuid();
            Config["StreamName"] = streamName;
        }
    }
}