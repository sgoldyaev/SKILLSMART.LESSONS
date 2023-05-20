namespace SkillSmart.Lessons.Lab3.Tests.Data;

public static class ArrayOf20Items
{
    public static readonly int[] Full                 = { 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 };
    public static readonly int[] First4ItemsAreMissed = { 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 00, 00, 00, 00 };
    public static readonly int[] First5ItemsAreMissed = { 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 00, 00, 00, 00, 00 };
    
    public static readonly int[] First7ItemsAreMissed = { 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 00, 00, 00, 00, 00, 00, 00 };
    public static readonly int[] First8ItemsAreMissed = { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 00, 00, 00, 00 };
}
