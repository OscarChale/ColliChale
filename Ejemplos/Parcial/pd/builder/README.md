### Teoria

El patrón de diseño Builder separa la creación de un objeto complejo de su representación de modo que el mismo proceso de construcción pueda crear representaciones diferentes.

### uando usarlo

Supongamos que necesitas construir un mismo objeto complejo muchas veces y además con diferentes configuraciones, por ejemplo, una pizza. 
Cada pizza de la carta va a tener características concretas y diferenciadas de las demás.

Si no queremos tener que recordar cada vez que creemos una pizza "CuatroQuesos" su tamaño, masa, salsa y relleno, podríamos utilizar el patrón Builder y olvidarnos de sus parámetros.

### Uso comun

El patron de diseño Builder nos permitira crear una estructura completa de un empleado con todas sus dependencias, como lo son:
-Direccion, Telefonos, Contactos, etc.