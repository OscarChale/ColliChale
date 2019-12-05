# Teoria &nbsp;

Defina una interfaz para crear un objeto, pero permita que las subclases decidan qué clase instanciar. Factory Method permite que una clase difiera la creación de instancias en subclases. &nbsp;

# Cuando usar &nbsp;

Podemos utilizar este patrón cuando definamos una clase a partir de la que se crearán objetos pero sin saber de qué tipo son, siendo otras subclases las encargadas de decidirlo.
# Implementacion &nbsp;
Define una interfaz para crear objetos pero deja que sean las subclases las que deciden qué clases instanciar. &nbsp;

Las clases principales en este patrón son el creador y el producto. El creador necesita crear instancias de productos, pero el tipo concreto de producto no debe ser forzado en las subclases del creador, porque las posibles subclases del creador deben poder especificar subclases del producto para utilizar. &nbsp;

https://juanlucodingbinding.files.wordpress.com/2017/09/fm1.png
