**LABORATORIO 2. C#**

1. Declaraci�n y Uso de Variables

un valor verdadero o falso. Pedimos que el usuario ingrese estos
valores y luego los convertimos al tipo correcto, por ejemplo,
si el usuario pone un numero entero, lo convertimos con int.Parse().
Despues mostramos todo lo que el usuario puso en la pantalla 
para que vea lo que ingreso.


2. Operaciones Matem�ticas

Luego pedimos dos numeros enteros y hacemos las operaciones basicas 
como suma, resta, multiplicacion y division. Mostramos los resultados
de cada operacion para que el usuario vea como quedo todo. Tambien 
verificamos si el divisor es cero antes de hacer la division, porque no
podemos dividir por cero, y si eso pasa, mostramos un mensaje para
avisar que no se puede. Luego repetimos todo el proceso, pero ahora 
con numeros decimales, haciendo las mismas operaciones.


3. Operaciones L�gicas

Por ultimo, pedimos dos numeros y comparamos si uno es mayor, menor o
igual que el otro. Mostramos los resultados de esas comparaciones para
que el usuario vea el resultado. Tambien usamos operadores logicos como 
AND (&&) y OR (||) para hacer comparaciones mas complejas, por ejemplo, 
si ambos numeros son mayores que cero o si al menos uno lo es, y mostramos
esos resultados en la consola para que el usuario vea el resultado
de esas comprobaciones.


*PREGUNTAS A RESPONDER*

-�Para qu� crees que se usan los operadores l�gicos en programaci�n?

Los operadores l�gicos, como AND (&&) y OR (||), se utilizan en programaci�n 
para combinar m�ltiples condiciones en una sola expresi�n. En el c�digo que 
me diste, los operadores l�gicos ayudan a comparar dos n�meros y evaluar si 
ambos son mayores que cero con AND (&&), o si al menos uno de los dos lo es 
con OR (||). Estas operaciones nos permiten tomar decisiones m�s complejas y 
controlar el flujo del programa seg�n las condiciones que definimos.


-�Por qu� es importante declarar correctamente el tipo de dato de una variable?

Declarar correctamente el tipo de dato de una variable es crucial porque cada tipo
de dato tiene un prop�sito espec�fico en el programa. En el c�digo proporcionado,
usamos int para almacenar n�meros enteros, double y float para n�meros decimales,
string para textos y bool para valores l�gicos como true o false. Si no se declara
correctamente el tipo de dato, el programa puede fallar al intentar realizar 
operaciones incompatibles o dar resultados err�neos, como intentar hacer c�lculos
con un texto o convertir un n�mero decimal en un tipo que no puede manejarlo.



**ENUNCIADO 1**

-*�Qu� estructura usar�as? �if-else o switch? �Por qu�?*
Utilize if-else porque estamos comparando rangos de edad (por ejemplo, menor de 12,
entre 12 y 17, etc.), y switch solo funciona bien para valores espec�ficos. 
if-else es m�s flexible para comparar rangos.
 
 
 
**ENUNCIADO 2**

-*�Qu� estructura usar�as? �if-else o switch? �Por qu�?*
Utilice el switch: utilize switch para comparar ese n�mero con varios valores fijos.
switch es ideal cuando tenemos muchos casos posibles con valores espec�ficos como 
en este caso (1 = Lunes, 2 = Martes, etc.).


**ENUNCIADO 3**

-*�Qu� estructura usar�as? �if-else o switch? �Por qu�?*
Utilize if-else porque necesitamos comparar no solo un valor, sino condiciones compuestas: 
el nombre de usuario y la contrase�a. Un switch solo funciona bien para comparar un solo
valor contra varios casos fijos, pero aqu� estamos comparando dos valores y haciendo
condiciones l�gicas (como && para "Y").
