#include <iostream>
#include <cstdlib>
#include <ctime>

int main() {
    std::srand(static_cast<unsigned int>(std::time(0)));
    int numeroSecreto = std::rand() % 100 + 1;
    int intento;
    int intentos = 0;

    std::cout << "Adivina el número entre 1 y 100: ";

    do {
        std::cin >> intento;
        intentos++;

        if (intento < numeroSecreto) {
            std::cout << "Demasiado bajo. Intenta de nuevo: ";
        } else if (intento > numeroSecreto) {
            std::cout << "Demasiado alto. Intenta de nuevo: ";
        } else {
            std::cout << "¡Correcto! Has adivinado el número en " << intentos << " intentos." << std::endl;
        }
    } while (intento != numeroSecreto);

    return 0;
}
