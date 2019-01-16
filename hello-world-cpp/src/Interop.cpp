#include <iostream>
#include "Interop.h"


int RetornoInt(int x) {
    return x;
}

float RetornoFloat(float x) {
    return x;
}

double RetornoDouble(double x) {
    return x;
}

bool RetornoBool(bool x) {
    return x;
}

void ImprimePalavra(char *palavra) {
    std::cout << "Interopabilidade Nativa! count em C++! Palavra: " << palavra << std::endl;
}