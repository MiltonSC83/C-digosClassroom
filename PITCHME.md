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
´´´
void ordBurbuja (long a[], int n)

{

int interruptor = 1;

int pasada, j;

for (pasada = 0; pasada < n-1 && interruptor; pasada++)

{

/* bucle externo controla la cantidad de pasadas */

interruptor = 0

for (j = 0; j < n-pasada-1; j++)

if (a[j] > a[j+1])

{

/* elementos desordenados, es necesario intercambio */

long aux;

interruptor = 1;

aux = a[j];

a[j] = a[j+1];

a[j+1] = aux;

}

}

}
´´´
