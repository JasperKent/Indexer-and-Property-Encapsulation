// CppExample.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "Scores.h"

int main()
{
    try
    {
        Scores skating (9, 1, 6);

        skating[0] = 4;
        skating[1] = 5;
        skating[2] = 5;
        skating[3] = 6;
        skating[4] = 3;
        skating[5] = 4;
        skating[6] = 3;
        skating[7] = 6;
        skating[8] = 14;

       std::cout << "Skating max is " << skating.getMaxScore() << std::endl;
    }
    catch (std::exception ex)
    {
        std::cout << ex.what() << std::endl;
    }
}

