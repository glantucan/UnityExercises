# UnityExercises

## Instrucciones generales

En estos ejercicios no hay proyecto asociado. Para tenerlos organizados, te recomiendo que utilices un proyecto diferente por cada grupo de ejercicios y una clase diferente para cada uno de ellos con un nombre como `Ejercicio_XX`.
**Importante**: En los ejericicios en los que haya que crear varias clases, utiliza un proyecto independiente para cada uno de ellos. En estos es importante que los nombres de las clases describan lo que hacen.

Recuerda que es tu responsabilidad tener copias de seguridad de ellos.

## Arrays y Listas
1. Crea un array con 10 **instancias** de un prefab (puede ser un cubo). Después añade las instancias desde dicho array a la escena, haciendo que formen una especie de escalera. Fíjate en que no es lo mismo un array con el mismo prefab en todos sus elementos que un array con una instancia del mismo prefab en cada uno de sus elementos.

2. Utilizando el mismo array de instancias del mismo prefab, haz que aparezca un elemento del array en la escena cada segundo, para que al final queden todos en fila.

3. Crea un array con instancias de un prefab como en el ejercicio 1. Haz que aparezcan, tomándolas de la lista, en la escena separadas 1 metro entre sí y cada una con un color diferente variando el valor del canal rojo (accediendo a la propiedad `material.color` de su `MeshRenderer` para ello)

4. Coloca las instancias de la lista del ejercicio anterior en fila en la escena y haz que cada segundo cambie de color una de ellas. En cada momento sólo puede haber una instancia de color diferente a las demás.

5. Repite los ejercicios anteriores usando `List<T>` en los casos en los que se pueda.

6. Crea una escena con un plano de tamaño 100x100x100 colocado en (0,0,0). Crea un programa que añada a la escena una esfera cada vez que pulses la tecla espacio en una posición aleaotoria sobre el plano. Cuando pulses la tecla Enter todas las esferas deben desaparecer de la escena (eliminándolas con `GameObject.Destroy()`). ¿Por qué no puedes utilizar un array para este ejercicio?

7. Repite el ejercicio anterior, pero además de lo descrito en él la tecla D debe hacer desaparecer una esfera de las que ya hay en la escena pero escogida de forma aleatoria.

8. Crea un programa que genere 10 cubos en fila (horizontal, separado 2 metros entre sí). El cubo debe tener un script que controle su movimiento y que lo haga saltar cuando pulses su número en el teclado. Desde la clase en la que añades las instancias a la escena debes llamar a una función que provoque el salto del script de control del cubo correspondiente. ¿Hay que utilizar listas (`List<T>`) o arrays para que este programa funcione correctamente?
