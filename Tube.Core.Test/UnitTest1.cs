namespace Tube.Core.Test;

public class Tests
{
const int diameter = 23;




    [Test]
    public void CatchTest()
    {
        var actual = Pipe.CheckParameter(diameter);
        Assert.AreEqual(diameter, actual);
    }
}