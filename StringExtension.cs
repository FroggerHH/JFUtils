﻿namespace JFUtils;

public static class StringExtension
{
    public static bool IsGood(this string str) { return !string.IsNullOrEmpty(str) && !string.IsNullOrWhiteSpace(str); }

    public static List<string> Split_(this string str)
    {
        return str.Split(new[] { ", " },
            StringSplitOptions.RemoveEmptyEntries).ToList();
    }
}