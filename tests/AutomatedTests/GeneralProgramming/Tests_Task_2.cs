using GeneralProgramming.Tasks;
using Xunit;

namespace AutomatedTests;

public class Tests_Task_2
{
    private readonly Task_2 _obj;

    public Tests_Task_2()
    {
        _obj = new Task_2();
    }

    [Fact]
    public void Test1()
    {
        var arr = new int[6, 6]
        {
            { 1, 2, 3, 4, 5, 6 },
            { 2, 3, 4, 5, 6, 7 },
            { 3, 4, 5, 6, 7, 8 },
            { 4, 5, 6, 7, 8, 9 },
            { 5, 6, 7, 8, 9, 10 },
            { 6, 7, 8, 9, 10, 11 }
        };

        var rs = _obj.GetMatrix(6);

        Assert.Equal(arr, rs);
    }

    [Fact]
    public void Test2()
    {
        var arr = new int[3, 3]
        {
            { 1, 2, 3 },
            { 2, 3, 4 },
            { 3, 4, 5 }
        };

        var rs = _obj.GetMatrix(6);

        Assert.Equal(arr, rs);
    }

    [Fact]
    public void Test3()
    {
        var arr = new int[1, 1]
        {
            { 1 }
        };

        var rs = _obj.GetMatrix(6);

        Assert.Equal(arr, rs);
    }
}
