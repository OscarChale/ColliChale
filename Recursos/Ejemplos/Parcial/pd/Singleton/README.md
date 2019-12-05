# DEFINICIÓN  &nbsp;
Singleton es un patrón de diseño del tipo creacional cuyo propósito es garantizar la existencia de una sola instancia de una clase. Además el acceso a esa única instancia tiene que ser global.  &nbsp;

En C# la instrucción que contiene la palabra “new” sólo se puede ejecutar una vez, así nos aseguramos que  sólo existe una instancia.  &nbsp;
# Cuando Usarlo  &nbsp;
Claves para no olvidar cómo crear este patrón: &nbsp;

Constructor privado &nbsp;
Campo estático privado con inicialización directa (inline) &nbsp;
Propiedad estática pública que devuelve el campo instanciado &nbsp;
De este modo, al iniciarse la aplicación se ejecuta una sola vez la instrucción “new Singleton()” y la instancia queda creada para el resto de vida de la aplicación. &nbsp;

Mediante la propiedad “Instance” se puede acceder a la instancia desde cualquier parte del código. &nbsp;

Una manera de obtener los mismos resultados que con Singleton pero con mayor flexibilidad es añadiendo una función estática de inicialización. &nbsp;
# Uso comun &nbsp;
El patrón Singleton está diseñado para restringir la creación de una clase a una sola instancia. &nbsp;

Este patrón se usa en un escenario donde tiene sentido tener solo uno de algo, como por ejemplo: &nbsp;

una sola clase que organiza las interacciones de otros objetos, ej. Clase de gerente
o una clase que representa un recurso único y único, ej. Componente de registro &nbsp;
