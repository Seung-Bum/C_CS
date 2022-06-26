#include <stdio.h>

// 두 수의 값을 서로 변환하는 포인터 함수
// & => 특정한 변수의 주소를 의미한다.
// int *y = &x;
// => x의 주소를 *y가 그 값으로 가지게됨을 의미

// swap의 x,y와 main의 x,y는 다르다.
void swap(int *x, int *y)
{
    int temp;
    temp = *x;
    *x = *y;
    *y = temp;
}

int main(void)
{
    int x = 1;
    int y = 2;
    swap(&x, &y);
    // x와 y의 주소를 넣는다.
    // int *x, int *y
    // x = x&, y = y&
    // 와 같은 의미

    printf("x = %d \n y = %d \n", x, y);
    return 0;
}

// 이렇게 할 경우, swap함수 안에서만 swaping이
// 이루어지고 실제 main에서는 값이 변경되지 않는다.
// void swap(int x, int y)
// {
//     int temp;
//     temp = x;
//     x = y;
//     y = temp;
// }

// int main(void)
// {
//     int x = 1;
//     int y = 2;
//     swap(x, y); // x와 y의 주소를 넣는다.
//     printf("x = %d \n y = %d \n", x, y);
//     return 0;
// }