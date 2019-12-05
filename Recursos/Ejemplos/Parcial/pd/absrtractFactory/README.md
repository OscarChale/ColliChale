# Teoria &nbsp;
Este patrón resulta útil en casos en los que necesitemos crear familias de objetos relacionados o dependientes entre sí, sin especificar sus clases concretas. &nbsp;
Abstract Factory define una interfaz para crear todos los productos distintos, pero deja la creación real del producto a clases concretas de fábrica. Cada tipo de fábrica corresponde a una determinada variedad de productos. &nbsp;
Proporcione una interfaz para crear familias de objetos relacionados o dependientes sin especificar sus clases concretas. &nbsp;

# Cuando usarlo &nbsp;
Lo usamos cuando tenemos el requisito de crear un conjunto de objetos relacionados u objetos dependientes que deben usarse juntos como familias de objetos. Las clases concretas se deben desacoplar de los clientes.

# Uso comun &nbsp;
El patrón Abstract Factory es bastante común en el código C #. Muchos marcos y bibliotecas lo usan para proporcionar una manera de extender y personalizar sus componentes estándar.
