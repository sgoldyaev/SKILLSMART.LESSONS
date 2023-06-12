using System;

namespace SkillSmart.Lessons.Lab10.Tests;

public class StringGenerator
{
    private readonly Random random = new Random();
    private readonly string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

    public string Generate()
    {
        var stringChars = new char[16];

        for (int i = 0; i < stringChars.Length; i++)
            stringChars[i] = chars[random.Next(chars.Length)];

        return new String(stringChars);
    }

    public string[] Generate(int corpus)
    {
        var result = new string[corpus];
        for(var i = 0; i < result.Length; i ++)
            result[i] = Generate();

        return result;
    }
}
