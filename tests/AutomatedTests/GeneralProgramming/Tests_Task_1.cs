using GeneralProgramming.Tasks;
using Xunit;

namespace AutomatedTests;

public class Tests_Task_1
{
    private readonly Task_1 _obj;

    public Tests_Task_1()
    {
        _obj = new Task_1();
    }

    [Fact]
    public void Test1()
    {
        var arr = new int[5, 6]
        {
            { 1, 3, 2, 2, 2, 4 },
            { 3, 3, 3, 2, 4, 4 },
            { 4, 3, 1, 2, 3, 3 },
            { 4, 3, 1, 3, 3, 1 },
            { 4, 3, 3, 3, 1, 1 }
        };

        var rs = _obj.GetLargestArea(arr);

        Assert.Equal(13, rs);
    }

    [Fact]
    public void Test2()
    {
        var arr = new int[7, 7]
        {
            { 1, 3, 2, 2, 2, 4, 9 },
            { 3, 3, 3, 2, 4, 4, 9 },
            { 4, 3, 1, 2, 3, 3, 9 },
            { 4, 3, 1, 3, 3, 1, 9 },
            { 4, 3, 3, 3, 1, 1, 9 },
            { 4, 3, 3, 3, 1, 1, 9 },
            { 4, 3, 3, 3, 1, 1, 9 }
        };

        var rs = _obj.GetLargestArea(arr);

        Assert.Equal(19, rs);
    }
    [Fact]
    public void Test3()
    {
        var arr = new int[7, 7]
        {
            { 1, 3, 2, 2, 2, 3, 3 },
            { 3, 3, 3, 2, 4, 3, 9 },
            { 4, 3, 1, 2, 3, 3, 9 },
            { 4, 3, 1, 3, 3, 1, 9 },
            { 4, 3, 3, 3, 1, 1, 9 },
            { 4, 3, 3, 3, 1, 1, 3 },
            { 4, 3, 3, 3, 1, 1, 9 }
        };

        var rs = _obj.GetLargestArea(arr);

        Assert.Equal(22, rs);
    }

    [Fact]
    public void Test6()
    {
        var arr = new int[4, 4]
        {
            { 1, 3, 2, 2 },
            { 3, 3, 3, 2 },
            { 4, 3, 1, 2 },
            { 4, 3, 1, 3 }
        };

        var rs = _obj.GetLargestArea(arr);

        Assert.Equal(6, rs);
    }

    [Fact]
    public void Test7()
    {
        var arr = new int[2, 2]
        {
            { 1, 2 },
            { 3, 4 }
        };

        var rs = _obj.GetLargestArea(arr);

        Assert.Equal(1, rs);
    }

    [Fact]
    public void Test8()
    {
        var arr = new int[2, 2]
        {
            { 1, 2 },
            { 3, 4 }
        };

        var rs = _obj.GetLargestArea(arr);

        Assert.Equal(1, rs);
    }

    [Fact]
    public void Test9()
    {
        var arr = new int[1, 1]
        {
            { 1 }
        };

        var rs = _obj.GetLargestArea(arr);

        Assert.Equal(1, rs);
    }
}
