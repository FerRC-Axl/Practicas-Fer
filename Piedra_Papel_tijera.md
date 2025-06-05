main
  definir opciones como arreglo de texto ["Piedra", "Papel", "Tijera"]
  definir jugador como opciones[0] // Piedra
  definir computadora como opciones[1] // Papel
  mostrar "Jugador eligió: " + jugador
  mostrar "Computadora eligió: " + computadora
  si jugador = computadora entonces
    mostrar "Empate"
  si no si (jugador = "Piedra" y computadora = "Tijera") o
           (jugador = "Papel" y computadora = "Piedra") o
           (jugador = "Tijera" y computadora = "Papel") entonces
    mostrar "Gana el jugador"
  si no
    mostrar "Gana la computadora"
  fin si
finmain
