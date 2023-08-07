using GeneralProgramming.Tasks;
using Xunit;

namespace AutomatedTests;

public class Tests_Task_3
{
    private readonly Task_3 _obj;

    public Tests_Task_3()
    {
        _obj = new Task_3();
    }

    [Theory]
    [InlineData(0, "Нула")]
    [InlineData(12, "Дванадесет")]
    [InlineData(18, "Осемнадесет")]
    [InlineData(20, "Двадесет")]
    [InlineData(48, "Четиридесет и осем")]
    [InlineData(98, "Деведесет и осем")]
    [InlineData(273, "Двеста седемдесет и три")]
    [InlineData(400, "Четиристотин")]
    [InlineData(418, "Четиристотин и осемнадесет")]
    [InlineData(501, "Петстотин и едно")]
    [InlineData(711, "Седемстотин и единадесет")]
    public void Test1(int num, string bgPronounciation)
    {
        var rs = _obj.GetBgPronounciation(num);

        Assert.Equal(bgPronounciation.ToUpper(), rs.ToUpper());
    }
}
