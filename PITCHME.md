## UNIVERSIDAD NACIONAL AUTÓNOMA DE MÉXICO

### FACULTAD DE INGENIERÍA

### Técnicas de programación 👾

#### Brigada 6: Ordenamiento Burbuja 

#### Integrantes: Sosa Corona Milton Osmar



---

## Ordenamiento de burbuja

La Ordenación de burbuja (Bubble Sort en inglés) es un sencillo algoritmo de ordenamiento. 
Funciona revisando cada elemento de la lista que va a ser ordenada con el siguiente, 
intercambiándolos de posición si están en el orden equivocado

---

• La idea básica de este algoritmo consiste en comparar
pares de elementos adyacentes e intercambiarlos
entre sí hasta que todos se encuentran ordenados.

• Se realizan (n-1) pasadas, transportando en cada una
de las mismas el menor o mayor elemento (según sea
el caso) a su posición ideal. Al final de las (n-1)
pasadas los elementos del arreglo estarán ordenados. 

---

![Flux Explained](https://upload.wikimedia.org/wikipedia/commons/c/c8/Bubble-sort-example-300px.gif)

---
##### Análisis de eficiencia del método de burbuja

Comparaciones: C = (n^2 -n)/2 

Movimientos: Mmin = 0

Mmed = 0.75 * (n^2 - n)

Mmáx = 1.5 * (n^2 - n) 
---
### Codificación en c 
```
/*

Ordenación por burbuja : array de n elementos

Se realizan una serie de pasadas mientras indiceIntercambio > 0

*/

void ordBurbuja2 (long a[], int n)

{

int i, j;

int indiceIntercambio;

/* i es el índice del último elemento de la sublista */

i = n-1;

/* el proceso continúa hasta que no haya intercambios */

while (i > 0)

{

indiceIntercambio = 0;

/* explorar la sublista a[0] a a[i] */

for (j = 0; j < i; j++)

/* intercambiar pareja y actualizar indiceIntercambio */

if (a[j+1] < a[j])

{

long aux=a[j];

a[j] = a[j+1];

a[j+1] = aux;

indiceIntercambio = j;

}

/* i se pone al valor del índice del último intercambio */

i = indiceIntercambio;

}

}

```
---
### Gracias por su atención

![Flux Explained](https://pbs.twimg.com/media/Dfh4SiWVMAE0AF9.jpg)
---
### Fuentes de consulta

http://mapaches.itz.edu.mx/~mbarajas/edinf/Ordenamiento.pdf

file:///C:/Users/alumnos/Downloads/A06.pdf

https://es.wikipedia.org/wiki/Ordenamiento_de_burbuja
