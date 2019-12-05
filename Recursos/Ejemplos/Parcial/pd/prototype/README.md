### Teoria

El patrón de diseño Prototype en lugar de crear un objeto, se clona, es decir, se realiza una copia exacta de otro objeto dado, denominado prototipo.

### Cuando usarlo

Cuando la creación de nuevos objetos acarrea un coste computacional elevado.
Los objetos a crear tienen o suelen tener atributos que repiten su valor.

### Uso comun

Este patrón está indicado en los casos en los que el coste de generar una nueva instancia sean altos en comparación al coste de realizar una copia de una instancia ya existente. Por ejemplo, imaginemos que tenemos una clase que se encarga de almacenar datos de una sesión web. 
Al instanciar esta clase, el objeto se comunica con un servidor externo para realizar un proceso de autenticación mediante unas credenciales. Este proceso es costoso, por lo que si a lo largo de la ejecución del programa fuese necesario instanciar un nuevo objeto con los mismos datos, el proceso de instanciación requerirá consumir una gran cantidad de recursos. Sería más sencillo realizar una copia exacta del objeto anterior, evitando de este modo acceder a un servidor externo para rellenar el objeto actual.