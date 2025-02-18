### 1. Análisis del programa
Tareas repetitvas que encontramos:
- Imprimir un mensaje en pantalla.

Variables locales vs variables globales
- Es apropiado usar variables globales cuando las vamos a reutilizar en más de un bloque de codigo, si solo se van a usar en una función consideramos que es mejor opción utilizar variables locales que existan solo dentro de ese bloque en específico.

### 2. Modularización
Para modularizar el programa convertimos en funciones:
- El menu
- Definimos una funcion como mensaje para imprimir mensajes en pantalla
- Agregar estudiante
- Lista de estudiantes
- Promedio de calificaciones
- Calificacion más alta
- Salir

### 3. Preguntas Guía
- ¿Qué ventajas tiene dividir el código en funciones?\n
El codigo es más ordenado, nos ayuda a no repetir codigo innecesariamente y nos ayuda a identificar de manera más facil en qué parte del codigo se encuentra alguna funcionalidad en especifico, para que cuando necesitemos implementar algún cambio lo hagamos dentro de la función y se aplicará a todas las partes de nuestro codigo donde la hayamos ejecutado.
- ¿Por qué es importante limitar el uso de variables globales?
Para evitar errores, también nos ayuda a ahorrar memoraria y no mezclar las variables que utilizamos.
- ¿Cómo se puede mejorar la legibilidad del código?
Nombrando las funciones de forma descriptiva respecto a la función que esperamos que se realice, esto mismo aplica para el nombre de nuestras variables, para que se más entendible qué intentamos conseguir o recibir dentro de estas, los comentarios nos pueden servir para identificar en texto normal lo que intentamos hacer en el bloque de codigo, dar pasos a seguir o una guía de la estructura que utilizamos.

### Mejoras adicionales
- Reemplazamos el menú de if para realizarlo con un switch porque consideramos que es más legible y fácil de entender de esta manera.
