namespace SkillSmart.Lessons.Lab3.Tests;

public static class ArrayOf16Items
{
    public static readonly int[] Full              = {01, 02, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12, 13, 14, 15, 16};
    public static readonly int[] FirstOneIsMissed  = {02, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12, 13, 14, 15, 16, 00};
    public static readonly int[] FirstTwoIsMissed  = {03, 04, 05, 06, 07, 08, 09, 10, 11, 12, 13, 14, 15, 16, 00, 00};
    public static readonly int[] LastOneIsMissed   = {01, 02, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12, 13, 14, 15, 00};
    public static readonly int[] LastTwoIsMissed   = {01, 02, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12, 13, 14, 00, 00};
    public static readonly int[] MiddleOneIsMissed = {01, 02, 03, 04, 06, 07, 08, 09, 10, 11, 12, 13, 14, 15, 16, 00};
    public static readonly int[] MiddleTwoIsMissed = {01, 02, 03, 04, 07, 08, 09, 10, 11, 12, 13, 14, 15, 16, 00, 00};
}