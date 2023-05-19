namespace SkillSmart.Lessons.Lab3.Tests;

public static class ArrayOf16Items
{
    public static readonly int[] Full             = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16};
    public static readonly int[] FirstOneIsMissed = {2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 0};
    public static readonly int[] FirstTwoIsMissed = {3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 0, 0};
    public static readonly int[] LastOneIsMissed  = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0};
    public static readonly int[] LastTwoIsMissed  = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 0, 0};
    public static readonly int[] MiddleOneIsMissed  = {1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 0};
    public static readonly int[] MiddleTwoIsMissed  = {1, 2, 3, 4, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 0, 0};
}
