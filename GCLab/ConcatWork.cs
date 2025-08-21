﻿using System.Text;

namespace GCLab;

// ===================================
// 4) Concatenação de string ineficiente
// ===================================
static class ConcatWork
{
    public static string Bad()
    {
        var s = new StringBuilder();
        for (int i = 0; i < 50_000; i++)
        {
            s.Append(i);

        }
        string b = s.ToString();
        return b;
    }    
}
