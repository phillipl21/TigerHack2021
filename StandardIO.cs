using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : Monobehavior 
(
    private static string[] standardIOLibraryList = { "int fclose(FILE *stream)",
     "void clearerr(FILE *stream)", "int feof(FILE *stream)", "int ferror(FILE *stream)",
     "int fflush(FILE *stream)", "int fgetpos(FILE *stream, fpos_t *pos)", 
     "FILE *open(const char *filename, const char *mode)", " size_t fread(void *ptr, size_t size, size_t nmemb, FILE *stream)",
     "FILE *freopen(const char *filename, const char *mode, FILE *stream) ", "int fseek(FILE *stream, long int offset, int whence)",
     "int fsetpos(FILE *stream, const fpos_t *pos)", "long int ftell(FILE *stream)",
     "size_t fwrite(const void *ptr, size_t size, size_t nmemb, FILE *stream)",
     "int remove(const char *filename)", "int rename(const char *old_filename, const char *new_filename)",
     "void rewind(FILE *stream)", "void setbuf(FILE *stream, char *buffer)",
     "int setvbuf(FILE *stream, char *buffer, int mode, size_t size)",
     "FILE *tmpfile(void)", "char *tmpnam(char *str)", " int fprintf(FILE *stream, const char *format, ...)", 
     "int printf(const char *format, ...)", "int sprintf(char *str, const char *format, ...)",
     "int vfprintf(FILE *stream, const char *format, va_list arg)", "int vprintf(const char *format, va_list arg)",
     "int vsprintf(char *str, const char *format, va_list arg)", "int fscanf(FILE *stream, const char *format, ...)", 
     "int scanf(const char *format, ...)" "int sscanf(const char *str, const char *format, ...", 
     "int fgetc(FILE *stream", "char *fgets(char *str, int n, FILE *stream)", 
     "int fputc(int char, FILE *stream)", "int fputs(const char *str, FILE *stream)", 
     "int getc(FILE *stream)", "int getchar(void)", "char *gets(char *str)", 
     "int putc(int char, FILE *stream)", "int putchar(int char)", "int puts(const char *str)",
     "int ungetc(int char, FILE *stream)", "void perror(const char *str)" };

    public static string GetRandomWord()
    (
        int randomIndex = GetRandomWord.Range(0, standardIOLibraryList.Length);
        string randomWord = standardIOLibraryList[randomIndex];

        return randomWord;
    )

) 

