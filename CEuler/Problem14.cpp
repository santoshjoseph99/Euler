
#include "Problem14.h"

bool is_even(ULONG num)
{
    return num % 2 == 0 ? true : false;
}

ULONG even(ULONG num)
{
    return num/2;
}

ULONG odd(ULONG num)
{
    return 3*num +1;
}

ULONG get_chain_length(ULONG num)
{
    ULONG length=1;
    while( num != 1 )
    {
        if( is_even(num) )
            num = even(num);
        else
            num = odd(num);
        ++length;
    }
    return length;
}

ULONG find_longest_collatz_sequence(ULONG start)
{
    ULONG num = 0;
    ULONG longest = 0;
    while( start > 0 )
    {
        ULONG length = get_chain_length(start);
        if( length > longest )
        {
            num = start;
            longest = length;
        }
        --start;
    }
    return num;
}