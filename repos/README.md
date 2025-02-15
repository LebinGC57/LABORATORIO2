**LABORATORIO 2. C#**

1. Declaración y Uso de Variables

un valor verdadero o falso. Pedimos que el usuario ingrese estos
valores y luego los convertimos al tipo correcto, por ejemplo,
si el usuario pone un numero entero, lo convertimos con int.Parse().
Despues mostramos todo lo que el usuario puso en la pantalla 
para que vea lo que ingreso.


2. Operaciones Matemáticas

Luego pedimos dos numeros enteros y hacemos las operaciones basicas 
como suma, resta, multiplicacion y division. Mostramos los resultados
de cada operacion para que el usuario vea como quedo todo. Tambien 
verificamos si el divisor es cero antes de hacer la division, porque no
podemos dividir por cero, y si eso pasa, mostramos un mensaje para
avisar que no se puede. Luego repetimos todo el proceso, pero ahora 
con numeros decimales, haciendo las mismas operaciones.


3. Operaciones Lógicas

Por ultimo, pedimos dos numeros y comparamos si uno es mayor, menor o
igual que el otro. Mostramos los resultados de esas comparaciones para
que el usuario vea el resultado. Tambien usamos operadores logicos como 
AND (&&) y OR (||) para hacer comparaciones mas complejas, por ejemplo, 
si ambos numeros son mayores que cero o si al menos uno lo es, y mostramos
esos resultados en la consola para que el usuario vea el resultado
de esas comprobaciones.


*PREGUNTAS A RESPONDER*

-¿Para qué crees que se usan los operadores lógicos en programación?

Los operadores lógicos, como AND (&&) y OR (||), se utilizan en programación 
para combinar múltiples condiciones en una sola expresión. En el código que 
me diste, los operadores lógicos ayudan a comparar dos números y evaluar si 
ambos son mayores que cero con AND (&&), o si al menos uno de los dos lo es 
con OR (||). Estas operaciones nos permiten tomar decisiones más complejas y 
controlar el flujo del programa según las condiciones que definimos.


-¿Por qué es importante declarar correctamente el tipo de dato de una variable?

Declarar correctamente el tipo de dato de una variable es crucial porque cada tipo
de dato tiene un propósito específico en el programa. En el código proporcionado,
usamos int para almacenar números enteros, double y float para números decimales,
string para textos y bool para valores lógicos como true o false. Si no se declara
correctamente el tipo de dato, el programa puede fallar al intentar realizar 
operaciones incompatibles o dar resultados erróneos, como intentar hacer cálculos
con un texto o convertir un número decimal en un tipo que no puede manejarlo.



**ENUNCIADO 1**

-*¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?*
Utilize if-else porque estamos comparando rangos de edad (por ejemplo, menor de 12,
entre 12 y 17, etc.), y switch solo funciona bien para valores específicos. 
if-else es más flexible para comparar rangos.
 
 
 
**ENUNCIADO 2**

-*¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?*
Utilice el switch: utilize switch para comparar ese número con varios valores fijos.
switch es ideal cuando tenemos muchos casos posibles con valores específicos como 
en este caso (1 = Lunes, 2 = Martes, etc.).


**ENUNCIADO 3**

-*¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?*
Utilize if-else porque necesitamos comparar no solo un valor, sino condiciones compuestas: 
el nombre de usuario y la contraseña. Un switch solo funciona bien para comparar un solo
valor contra varios casos fijos, pero aquí estamos comparando dos valores y haciendo
condiciones lógicas (como && para "Y").
