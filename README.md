# Detectar números repetidos en un arreglo (C#)

## Descripción

Este programa en C# para consola tiene como objetivo detectar los números que se repiten dentro de un arreglo de números enteros positivos.

El programa recibe un arreglo como entrada y retorna otro arreglo únicamente con los valores que aparecen más de una vez.

---

## Ejemplo

### Arreglo de entrada

```
[10, 3, 5, 3, 10]
```

### Resultado esperado

```
[3, 10]
```

Porque son los números que se repiten dentro del arreglo original.

---

## Condición importante

El arreglo original **no debe modificarse**.
El programa únicamente analiza los datos y genera un nuevo arreglo con los números repetidos.

---

## Cómo funciona

El programa utiliza:

* Un `Dictionary<int, int>` para contar cuántas veces aparece cada número.
* Una `List<int>` para guardar únicamente los números que se repiten.
* Finalmente, se convierte la lista en un arreglo para mostrar el resultado.

---

## Estructura del programa

El programa tiene una función principal:

```
ObtenerRepetidos(int[] Arreglo)
```

Esta función:

1. Recorre el arreglo original.
2. Cuenta cuántas veces aparece cada número.
3. Guarda los números que aparecen más de una vez.
4. Retorna un nuevo arreglo con los números repetidos.

---

## Tecnologías usadas

* C#
* .NET
* Consola

---

## Autor

Felipe Corredor
Programación en C# - Ejercicios de arreglos
