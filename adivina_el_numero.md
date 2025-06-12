#include <iostream>
#include <cstdlib>   // Para rand() y srand()
#include <ctime>     // Para time()

using namespace std;

int main() {
    int numeroSecreto, numeroUsuario;
    bool gano = false;

    // Inicializar la semilla para números aleatorios
    srand(time(0));
    numeroSecreto = rand() % 100 + 1;  // Número aleatorio entre 1 y 100

    // Intentos del 1 al 7
    for (int intento = 1; intento <= 7; intento++) {
        cout << "Intento " << intento << ": Ingresa un número entre 1 y 100: ";
        cin >> numeroUsuario;

        if (numeroUsuario == numeroSecreto) {
            cout << "¡Felicidades! Adivinaste el número ganador." << endl;
            gano = true;
            break;  // Termina el ciclo si acierta
        } else {
            cout << "Ese no es el número. Intenta de nuevo." << endl;
        }
    }

    // Si no acertó en los 7 intentos
    if (!gano) {
        cout << "Mala suerte, no encontraste el número ganador. Era: " << numeroSecreto << endl;
    }

    return 0;
}
