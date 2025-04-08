# GUIA_EJERCICIO_PED
Guía de ejercicios realizada en clase.

Proyecto realizado mediante estructura de datos:
en este repositorio estaremos dado solucion a 3 ejercicios, los cuales son los siguientes: 

Ejercicio 1: Tablas Hash

Caso:
Una empresa de mensajería necesita almacenar y buscar los códigos de
rastreo de paquetes de forma eficiente. Se planea usar una tabla hash para
almacenar 7 códigos de seguimiento.

Códigos de seguimiento:
["MZ123", "QK456", "PL789", "MN321", "QK654", "PL987", "MZ321"]
Función hash:
Usar la suma del valor ASCII de los caracteres del string, módulo 7.
hash(k) = (Σ ASCII(caracteres de k)) mod 7
Objetivo:
Insertar todos los códigos en la tabla hash y resolver las colisiones usando
resolución por encadenamiento.

Ejercicio 2: Teoría de Grafos

Caso:
Una ciudad desea modelar su red de carreteras como un grafo no dirigido.
Los puntos representan ciudades y las aristas las carreteras entre ellas con
pesos en kilómetros.

Grafo:
Ciudades: A,B,C,D,E 
Aristas con pesos:
 A-B (5), A-C (2), B-C (1), B-D (3), C-D (4), D-E (2)
Objetivo:
Aplicar el algoritmo de Dijkstra desde el nodo A para determinar la ruta más
corta a E.



Ejercicio 3: Colas de Prioridad
Caso:
Un hospital gestiona la atención de pacientes con una cola de prioridad
según gravedad (prioridad 1 = más grave).

Pacientes:
1. Ana (Prioridad 3)
2. Luis (Prioridad 1)
3. Sofía (Prioridad 2)
4. Marta (Prioridad 1)
5. Pedro (Prioridad 2)
Objetivo:
Determinar el orden de atención usando una cola de prioridad mínima (minheap).


Requisitos: 
Conocimientos en programacion con estructura de datos.
conocimientos en C# 
Entorno de desarrollo .NET 6 o superior

Instrucciones de uso: 
1) Clonar el repositorio
2) Abrir el proyecto en Visula Studio 2022 
3) Ejecutar cada uno de los Ejercicios resueltos

