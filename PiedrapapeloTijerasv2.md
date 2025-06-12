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
