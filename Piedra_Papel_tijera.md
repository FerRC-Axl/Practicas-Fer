PiedraPapelTijera 
  public static void main(String[] args) 
    // Arreglo de opciones
    String[] opciones = {"Piedra", "Papel", "Tijera"}
    // Puntos clave
    int jugadorPuntos = 0;
    int computadoraPuntos = 0;
    // Selección de la computadora 
    String computadora = opciones[1]; // Papel
    // Selección del jugador 
    String jugador = opciones[0]; // Piedra
    // Mostrar elecciones
    System.out.println("Jugador eligió: " + jugador);
    System.out.println("Computadora eligió: " + computadora);
    // Lógica del juego
    if (jugador.equals(computadora)) 
      System.out.println("Empate");
    else if ((jugador.equals("Piedra") && computadora.equals("Tijera"))
               (jugador.equals("Papel") && computadora.equals("Piedra"))
               (jugador.equals("Tijera") && computadora.equals("Papel")))
      System.out.println("Gana el jugador");
      jugadorPuntos++;
    else 
      System.out.println("Gana la computadora");
      computadoraPuntos++;
    // Mostrar puntuación
    System.out.println("Puntos del jugador: " + jugadorPuntos);
    System.out.println("Puntos de la computadora: " + computadoraPuntos);
