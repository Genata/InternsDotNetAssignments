using GeneralProgramming.Tasks;
using Xunit;

namespace AutomatedTests;

public class Tests_Task_4
{
    private readonly Task_4 _obj;

    public Tests_Task_4()
    {
        _obj = new Task_4();
    }

    [Fact]
    public void Test1()
    {
        var rs = _obj.GetCharacters("tralala");

        Assert.Equal(4, rs.Count());

        PopAndAssertElement(rs, 3, 'a');
        PopAndAssertElement(rs, 2, 'l');
        PopAndAssertElement(rs, 1, 'r');
        PopAndAssertElement(rs, 1, 't');
    }

    [Fact]
    public void Test2()
    {
        var rs = _obj.GetCharacters("bumbamtrqs");

        Assert.Equal(8, rs.Count());

        PopAndAssertElement(rs, 1, 'a');
        PopAndAssertElement(rs, 2, 'b');
        PopAndAssertElement(rs, 2, 'm');
        PopAndAssertElement(rs, 1, 'q');
        PopAndAssertElement(rs, 1, 'r');
        PopAndAssertElement(rs, 1, 's');
        PopAndAssertElement(rs, 1, 't');
        PopAndAssertElement(rs, 1, 'u');
    }

    [Fact]
    public void Test3()
    {
        var rs = _obj.GetCharacters("k");

        Assert.Equal(1, rs.Count());

        PopAndAssertElement(rs, 1, 'k');
    }

    [Fact]
    public void Test4()
    {
        var rs = _obj.GetCharacters("karta kapan");

        Assert.Equal(6, rs.Count());

        PopAndAssertElement(rs, 4, 'a');
        PopAndAssertElement(rs, 2, 'k');
        PopAndAssertElement(rs, 1, 'n');
        PopAndAssertElement(rs, 1, 'p');
        PopAndAssertElement(rs, 1, 'r');
        PopAndAssertElement(rs, 1, 't');
    }

    private void PopAndAssertElement(List<Task_4_Dto> tmp, int count, char character)
    {
        var tmpEl = tmp.First();
        tmp.RemoveAt(0);

        Assert.Equal(count, tmpEl.Count);
        Assert.Equal(character, tmpEl.Character);
    }
}
