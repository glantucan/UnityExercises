# UnityExercises

## Instrucciones generales

En estos ejercicios no hay proyecto asociado. Para tenerlos organizados, te recomiendo que utilices un proyecto diferente por cada grupo de ejercicios y una clase diferente para cada uno de ellos con un nombre como `Ejercicio_XX`.
**Importante**: En los ejericicios en los que haya que crear varias clases, utiliza un proyecto independiente para cada uno de ellos. En estos es importante que los nombres de las clases describan lo que hacen.

Recuerda que es tu responsabilidad tener copias de seguridad de ellos.

## Arrays y Listas
1. Crea un array con 10 **instancias** de un prefab (puede ser un cubo). Para rellenar dicho array utiliza un bucle. Después coloca las instancias desde dicho array, haciendo que formen una especie de escalera. Para esto último utiliza un segundo bucle. Fíjate en que no es lo mismo un array con el mismo prefab en todos sus elementos que un array con una instancia del mismo prefab en cada uno de sus elementos.

2. Utilizando el mismo array de instancias del mismo prefab, haz que aparezca un elemento del array en la escena cada segundo, para que al final queden todos en fila.

3. Crea un array con instancias de un prefab como en el ejercicio 1. Haz que aparezcan, tomándolas de la lista, en la escena separadas 1 metro entre sí y cada una con un color diferente variando el valor del canal rojo (accediendo a la propiedad `material.color` de su `MeshRenderer` para ello)

4. Coloca las instancias de la lista del ejercicio anterior en fila en la escena y haz que cada segundo cambie de color una de ellas. En cada momento sólo puede haber una instancia de color diferente a las demás.

5. Repite los ejercicios anteriores usando `List<T>` en los casos en los que se pueda.

6. Crea una escena con un plano de tamaño 100x100x100 colocado en (0,0,0). Crea un programa que añada a la escena una esfera, en una posición aleaotoria sobre el plano, cada vez que pulses la tecla ESPACIO. Cuando pulses la tecla ENTER, todas las esferas deben desaparecer de la escena (eliminándolas con `GameObject.Destroy()`). Después de eliminar todas las esferas con ENTER tengo que poder seguir añadiendo esferas con ESPACIO. ¿Por qué no puedes utilizar un array para este ejercicio?

7. Repite el ejercicio anterior, pero además de lo descrito en él la tecla D debe hacer desaparecer una esfera de las que ya hay en la escena, pero escogida de forma aleatoria.  
<br />



## Comunicación entre diferentes instancias de scripts.  

8. Crea un programa que genere 10 cubos en fila (horizontal, separado 2 metros entre sí). El cubo debe tener un script que controle su movimiento y que lo haga saltar cuando pulses su número en el teclado. Desde la clase en la que añades las instancias a la escena debes llamar a una función que provoque el salto del script de control del cubo correspondiente. ¿Hay que utilizar listas (`List<T>`) o arrays para que este programa funcione correctamente?

9. Utiliza arrays o List<T> según convenga y explica en los comentarios del script por qué (si la explicación está mal aunque el programa funcione, el ejercicio no estará bien). Lee el enunciado entero antes de decidir.

 Escribe un programa que cree un conjunto de 20 esferas que se posicionen aleatoriamente en
un volumen de 10x10x10 unidades de Unity. Cada esfera debe tener, a su vez, un script que
controle su movimiento: el línea recta, con dirección aleatoria y con una magnitud de la
velocidad de 4.

 Cada 2 segundos el script principal (el que ha creado las esferas) debe lanzar la orden de
cambiar de dirección, de forma que sea cada esfera la que decida aleatoriamente su nueva
dirección de movimiento.

10. Utiliza arrays o List<T> según convenga. Lee el enunciado entero antes de decidir.
 Crea una pila de cubos usando el gameobject PileA como referencia para la posición de forma que se añada un cubo a la misma cada 2 segundos. Cada nuevo cubo debe quedar encima de los demás. Hazlo desde un script que pongas como componente al gameobject GameController.
 Una vez que lo anterior funcione. Modifica el script anterior para que se pueda activar la selección de cubos:
 * Al pulsar espacio se selecciona un cubo de la lista o array (inicialmente el 0)
 * Al pulsar las teclas arriba o abajo se selecciona el cubo de encima o de debajo del seleccionado actualmente, y este último se deselecciona.
 * Al pulsar Return, el cubo seleccionado se pasa de la pila A a la pila B (no solo por su posición también pasa a una lista o array diferente)

 La selección de un cubo debe tener feedback visual. Pon un script al prefab del cubo que tenga las funciones públicas necesarias para que el cubo llamado cubeSelector que hay dentro del mismo se cambie a color rojo cuando sea seleccionado.
Debes gestionar bien la lista o array en cada operación de forma que no aparezcan errores de índice fuera de rango.

11. Crea, desde un script en un gameobject vacío, una fila de 10 cubos con una separación de 2 metros entre sí. Cada cubo debe llevar un componente que sea instancia de un script con varios métodos públicos. 
	* Uno que permita fijar un target
	* Otro que permita iniciar el movimiento hacia el target fijado previamente.  
 El target de cada cubo será el cubo siguiente. Cuando un cubo toca su target debe pararse e iniciar, llamando al método público correspondiente, el movimiento del siguiente. El último cubo se quedará quieto.
 EL movimiento del primer cubo lo lanza el script que crea y configura la fila. No hay que usar ni listas ni arrays, pero puede que necesites varios bucles en el script principal.

 