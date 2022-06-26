#include <stdio.h>

int main(void)
{
    int i = 10;
    int *p;
    p = &i; // *p가 가리키는 값이 i가 되었다.
    printf("i = %d\n", i);
    *p = 20; // i의 값은 20으로 변경된다.
    printf("i = %d\n", i);
    return 0;
}