### Teoria

El patrón object pool es un patrón de diseño de software que usa un conjunto de objetos inicializados preparados para su uso. Esto es más efectivo normalmente que creando y destruyendo los objetos bajo demanda. Un cliente del pool le pedirá un objeto para realizar las operaciones con el objeto. Cuando el cliente termina retorna el objeto al pool para que lo retenga hasta que vuelva a necesitar usarse. Es decir, los objetos no se crean (salvo la primera vez) ni se destruyen, simplemente se van reciclando. 

### Cuando usarlo

Cuando es necesario trabajar con un gran número de objetos que son particularmente costosos para instanciar y cada objeto solo se necesita durante un corto período de tiempo, el rendimiento de una aplicación completa puede verse afectada negativamente. Un patrón de diseño object pool puede resultar útil en casos como estos. 

### Uso comun

Mediante la implementación del patrón de diseño Object Pool desarrollaremos una aplicación multi hilos que controlará muchos procesos de forma simultánea. Dichos procesos estarán controlados por un Object Pool que limitará el número de proceso que pueden ser ejecutados a la vez, con la finalidad de no agotar los recursos del servidor y procesar de forma simultanea el número adecuado de proceso que no afecten el rendimiento, dejando el resto de procesos en una cola de espera que serán procesados una vez que llegue su turno.