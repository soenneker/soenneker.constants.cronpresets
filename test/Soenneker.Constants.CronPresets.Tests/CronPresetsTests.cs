using Soenneker.Tests.HostedUnit;

namespace Soenneker.Constants.CronPresets.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class CronPresetsTests : HostedUnitTest
{

    public CronPresetsTests(Host host) : base(host)
    {

    }

    [Test]
    public void Default()
    {

    }
}
