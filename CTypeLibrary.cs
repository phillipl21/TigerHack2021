using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WordGenerator : Monobehavior 
(
     private static string[] cTypeList = { "int isalnum(int c)", "int isalpha(int c)", 
     "int iscntrl(int c)", "int isdigit(int c)", "int isgraph(int c)",
     "int islower(int c)", "int isprint(int c)", "int ispunct(int c)", 
     "int isspace(int c)", "int isupper(int c)", "int isxdigit(int c)",
     "int tolower(int c)", "int toupper(int c)"
     };

      public static string GetRandomWord()
    (
        int randomIndex = GetRandomWord.Range(0, cTypeList.Length);
        string randomWord = cTypeList[randomIndex];

        return randomWord;
    )
)