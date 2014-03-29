
#include "Problem14.h"
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
    ULONG num = 999999;
    if( argc > 1 )
        num = atol(argv[1]);
    long result = find_longest_collatz_sequence(num);
    printf("%d", result);
    return 0;
}