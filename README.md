# Aplicación de principios y arquitecturas de sistemas hipermedia
## AR_UnityProjectP1
Descripción
Este proyecto de Unity te guiará a través de la creación de un juego simple en el que un jugador recoge basura para acumular puntaje. El juego incluirá elementos como animaciones, gestión de puntajes, grabación de keyframes, recogida de objetos, generadores de prefabs, power-ups, menu pause, cambios de escenas, score, y cronometrado del tiempo de juego.

## Configuración Inicial
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
## Generador de enemigos y objetos
Primero añadimos dos empty objects en nuestro proyecto a los cuales, añadiremos nuestro script de generador
![image](https://github.com/Ariel454/AR_UnityProjectP1/assets/121766763/41e86d25-c6f7-4bf9-8de5-1fe41b382b6f)
Variables Públicas:

Se declaran variables públicas para los prefabs de los objetos que se generarán.
Se definen límites (minX, maxX, minY, maxY, minZ, maxZ) para la posición de generación.
Se establece la cantidad inicial de zombies y basura que se generarán.
Método Start:

En el inicio del juego, se generan objetos de varios tipos (zombies, basura) en cantidades predefinidas.
Método GenerarObjetos:

Recibe un tipo de objeto y una cantidad como parámetros.
Utiliza un bucle para llamar al método GenerarObjeto el número especificado de veces.
Método GenerarObjeto:
![image](https://github.com/Ariel454/AR_UnityProjectP1/assets/121766763/2fadfec9-fef9-477d-93e7-b1258170fba0)

Genera objetos de diferentes tipos (zombies, basura) en posiciones aleatorias dentro de los límites especificados.
Asigna etiquetas (tags) a los objetos generados según su tipo.
Controla el límite máximo de generación para zombies y basura.
Este script es útil para instanciar objetos de manera aleatoria en una escena de Unity, creando así una especie de generador de elementos en el juego.

## Power UP
Para nuestro power up añadiremos nuestro asset que nos brindara la apariencia visual de nnuestro objeto, a este le posicionaremos, añadiremos un box collider, y activamos la opción isTrigger.
![image](https://github.com/Ariel454/AR_UnityProjectP1/assets/121766763/b062dd5f-bee5-4d22-9982-860e15d7b05e)
Posterior a ello vamos a modificar el script que contiene el collider de nuestro objeto para brindarle la funcionalidad necesaria.
![image](https://github.com/Ariel454/AR_UnityProjectP1/assets/121766763/6dfef9d9-d3ca-4481-b448-74f8bb3d7d2c)
Método Correr:

Este método se llama cuando el jugador colisiona con un objeto que tiene la etiqueta "potion", lo que indica que es un power-up de velocidad.
Incrementa temporalmente la velocidad de carrera (RunSpeed) del jugador a 15.0f. Esto proporciona una sensación de aumento de velocidad inmediato.
Luego, utiliza la función Invoke() para programar la llamada a RestaurarVelocidad() después de 5 segundos.
Durante estos 5 segundos, el jugador se mueve a la velocidad aumentada.
Método RestaurarVelocidad:

Llamado después de 5 segundos por la función Invoke().
Restaura la velocidad de carrera (RunSpeed) del jugador a su valor original de 8.0f.
Este mecanismo simula un efecto de power-up temporal donde el jugador obtiene una mejora significativa en la velocidad de carrera durante un breve período después de recoger la poción. Después de ese tiempo, la velocidad vuelve a su estado normal. Esto añade un elemento dinámico y estratégico al juego, ya que el jugador puede aprovechar temporalmente esta mejora para maniobrar rápidamente o evadir enemigos.

## Grabación de keyframes (Animation)
Para incrustar acciones y funcionalidad en un animator controller, podemos hacerlo mediante la opción de grabar los keyframes en el rango de tiempo de una animación en concreto.
![image](https://github.com/Ariel454/AR_UnityProjectP1/assets/121766763/e7b76130-4cd7-4ffd-a37f-b7b3beec1e24)
Posterior a este punto grabamos nuestros keyframes en un lapso de tiempo en concreto, en este caso hemos elegido al enemigo alzando su espada.
![image](https://github.com/Ariel454/AR_UnityProjectP1/assets/121766763/25372e4c-0ab1-4c5a-8275-29c693298ad8)
Momento preciso donde podemos activar el box collider, para darle funcionalidad a los golpes, y posteriormente tratarlos mediante script.
![image](https://github.com/Ariel454/AR_UnityProjectP1/assets/121766763/41e72102-e1d2-4611-b6a6-e4ce18ff9640)

## Menu Pause
Para nuestro menú de pausa primero vamos a colocar un empty object dentro de nuestro canvas, en el cual vamos a situar la interfaz de nuestro menú
![image](https://github.com/Ariel454/AR_UnityProjectP1/assets/121766763/ce0f5cc7-596d-465e-9ed0-565728318e4e)
Vamos a configurar la interfaz gráfica que deseemos para el menú, y luego de ello a desactivar nuestro lienzo de menu, para posteriormente controlarlo mediante script.
![image](https://github.com/Ariel454/AR_UnityProjectP1/assets/121766763/1df0e1b9-1570-4e77-9628-32cd0c0612ff)
Por último comprobamos la funcionalidad de nuestros botones asigando la lógica correspondiente para cada uno.
![image](https://github.com/Ariel454/AR_UnityProjectP1/assets/121766763/6c04551b-bf44-49f0-965d-aeb6f093cf47)

isPaused:

Una variable privada que rastrea si el juego está pausado o no.
pauseMenu:

Un objeto GameObject que representa el menú de pausa en la interfaz de usuario.
Update():

Detecta la pulsación de la tecla "P" y llama a la función TogglePause().
TogglePause():

Alterna entre el estado de pausa y no pausa del juego.
Si el juego está pausado:
Establece el tiempo en el juego a cero (Time.timeScale = 0), congelando todas las actualizaciones del juego.
Activa el menú de pausa en la interfaz.
Muestra el cursor del mouse.
Si el juego no está pausado:
Restaura el tiempo en el juego a uno (Time.timeScale = 1), reanudando el juego.
Desactiva el menú de pausa.
Oculta el cursor del mouse.
ResumeGame():

Llamado desde el menú de pausa cuando el jugador elige reanudar el juego.
Reanuda el juego, oculta el menú de pausa y restaura la configuración del cursor del mouse.
Este script proporciona una funcionalidad esencial para pausar y reanudar el juego, mejorando la experiencia del jugador al permitir interacciones fuera del flujo principal del juego.
 

## Implementa un temporizador para limitar la duración del juego.
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







