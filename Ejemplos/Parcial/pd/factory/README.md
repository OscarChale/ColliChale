# Teoria &nbsp;

El método Factory es un patrón de diseño de creación que proporciona una interfaz para crear objetos sin especificar sus clases concretas. Define un método que podemos usar para crear un objeto en lugar de usar su constructor. Lo importante es que las subclases pueden anular este método y crear objetos de diferentes tipos. &nbsp;

# Cuando usar &nbsp;
Este patrón se utiliza en el caso que queramos crear varias familias de objetos, osea si tenemos varias clases y queremos crear y agrupar algunas de esas clases en combinaciones diferentes, recurrimos a este patrón. &nbsp;

# Uso común &nbsp;
"Factoría" = "Factory"
Cuando en nuestro código aparece un "switch" o un "else-if" con numerosos casos podemos empezar a sospechar. Si el "switch/else-if" solo aparece una vez en nuestro código, lo peor que puede pasar es que vaya creciendo más de lo que nos gustaría. Pero en cuanto a mantenimiento, si la clase no es muy grande, puede pasar. &nbsp; 

Cuando realmente es útil este patrón es cuando los "switch/else-if" se empiezan repetir en varios lugares del código. Y ¡ojo, que los "switch/else-if" suelen ser muy contagiosos! Cuantos más haya en tu código más problemas de mantenibilidad tendrás. &nbsp;

Lo ideal es cortar cuanto antes por los sano y crear una Factoría Simple. &nbsp;
