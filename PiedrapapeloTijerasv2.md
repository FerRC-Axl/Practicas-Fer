main

  definir opciones como arreglo de texto ["Piedra", "Papel", "Tijera"]

  definir jugador como arreglo de texto ["JugadorA", "JugadorB"]
  
  definir jugadaPC como texto
  
  definir jugada como texto

  definir rondas como entero = 0

  mientras rondas < 3 hacer
  
    mostrar "Ronda " + (rondas + 1)
    
    mostrar "Elige Piedra, Papel o Tijera:"
    
    leer jugada

    jugadaPC = opciones[Random(0,2)]

    mostrar jugador[0] + " eligió: " + jugada
    
    mostrar jugador[1] + " eligió: " + jugadaPC
    
    si jugada == jugadaPC entonces
    
      mostrar "Empate"
      
    si no si (jugada == "Piedra" y jugadaPC == "Tijera") o
    
             (jugada == "Papel" y jugadaPC == "Piedra") o
             
             (jugada == "Tijera" y jugadaPC == "Papel") entonces
             
      mostrar "Gana " + jugador[0]
      
    si no
    
      mostrar "Gana " + jugador[1]
      
    fin si

    rondas = rondas + 1
    
  fin mientras
  
finmain
