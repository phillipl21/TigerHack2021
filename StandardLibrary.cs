using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : Monobehavior 
(
    private static string[] standardLibraryList = { "double atof(const char *str)", 
    "int atoi(const char *str)", "long int atol(const char *str)", 
    "double strtod(const char *str, char **endptr)", "long int strtol(const char *str, char **endptr, int base)",
    "unsigned long int strtoul(const char *str, char **endptr, int base)",
    "void *calloc(size_t nitems, size_t size)", "	void free(void *ptr)",
    "void *malloc(size_t size)", "void *realloc(void *ptr, size_t size)", 
    "void abort(void)", "int atexit(void (*func)(void))", "void exit(int status)",
    "char *getenv(const char *name)", "int system(const char *string)",
    "void *bsearch(const void *key, const void *base, size_t nitems, size_t size, int (*compar)(const void *, const void *))",
    "void qsort(void *base, size_t nitems, size_t size, int (*compar)(const void *, const void*))", 
    "int abs(int x)", "div_t div(int numer, int denom)", "long int labs(long int x)", 
    "ldiv_t ldiv(long int numer, long int denom)", "int rand(void)",
    "void srand(unsigned int seed)", "int mblen(const char *str, size_t n)", 
    "size_t mbstowcs(schar_t *pwcs, const char *str, size_t n)", 
    "int mbtowc(whcar_t *pwc, const char *str, size_t n)", 
    "size_t wcstombs(char *str, const wchar_t *pwcs, size_t n)",
    "int wctomb(char *str, wchar_t wchar)" 
    };

     public static string GetRandomWord()
    (
        int randomIndex = GetRandomWord.Range(0, standardLibraryList.Length);
        string randomWord = standardLibraryList[randomIndex];

        return randomWord;
    )

) 