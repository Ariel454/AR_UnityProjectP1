# Aplicación de principios y arquitecturas de sistemas hipermedia
# AR_UnityProjectP1
Descripción
Este proyecto de Unity te guiará a través de la creación de un juego simple en el que un jugador recoge basura para acumular puntaje. El juego incluirá elementos como animaciones, gestión de puntajes, grabación de keyframes, recogida de objetos, generadores de prefabs, power-ups, menu pause, cambios de escenas, score, y cronometrado del tiempo de juego.

# Configuración Inicial
Configuración del Personaje:

Añade un personaje controlado por el jugador (First Person Controller o Third Person Controller).
Adjunta un script (Personaje.cs) al personaje para gestionar la recogida de basura y la puntuación.
Configuración de Objetos en el Escenario:

Coloca objetos en el escenario que representen la basura para recoger.
Creación del Enemigo (Opcional):

Si deseas añadir un enemigo, configura un modelo y animaciones.
Crea un Animator Controller y programa su comportamiento (ver ejemplo Enemigo.cs).
Configuración del Puntaje:

Crea un script (ScoreManager.cs) para gestionar la puntuación.
Guarda la puntuación en un archivo JSON y carga los mejores puntajes.
Cronometrado del Juego:

## Features extras
#

Implementa un temporizador para limitar la duración del juego.
Finaliza el juego después del tiempo límite y guarda la puntuación.
Scripts
Personaje.cs
Descripción:
Gestiona la recogida de basura, puntaje, y eventos de colisión con objetos.
ScoreManager.cs
Descripción:
Maneja la puntuación del juego.
Guarda y carga las puntuaciones más altas en un archivo JSON.
Enemigo.cs (Opcional)
Descripción:
Controla el comportamiento del enemigo.
Detecta la presencia del jugador y realiza acciones en consecuencia.
Escenas
Escena del Juego:

Contiene el entorno del juego, objetos de basura, el personaje y el enemigo (si está presente).
Escena de Inicio:

Incluye un menú principal con opciones para iniciar el juego, ver puntajes y salir.
Uso del Temporizador
El juego tiene un temporizador que limita la duración de la partida.
Al alcanzar el tiempo límite, se finaliza el juego y se guarda la puntuación del jugador.
Instrucciones de Uso
Menú Principal:

Desde el menú principal, puedes iniciar el juego, ver los mejores puntajes o salir del juego.
Jugabilidad:

Mueve al personaje usando los controles designados.
Recoge objetos de basura para acumular puntos.
Evita al enemigo (si está presente).
El juego termina después del tiempo límite, o si mueres por los enemigos.
Puntajes:

Después de cada juego, se mostrarán los mejores puntajes en la pantalla de inicio.
Reiniciar:

Puedes reiniciar el juego desde la pantalla de inicio, o desde el menu de pausa.
¡Disfruta del juego y compite por el puntaje más alto!






