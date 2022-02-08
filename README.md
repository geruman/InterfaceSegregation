# Interface Segregation

Un problema muy común es tener una interfaz obesa, es decir con mucha funcionalidad y el problema radica cuando queremos hacer uso de esta tenemos métodos que no vamos a poder usar.

## En este ejemplo, creamos interfaces separadas para las tareas de lectura, escritura y eliminación de datos en un repositorio, luego cada repositorio implementa las tareas mínimas 
necesarias para poder realizar la tarea que necesita.
