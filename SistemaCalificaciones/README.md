# 🧪 Laboratorio 3.6 — Sistema de Calificaciones

Aplicación de consola desarrollada en **C#** para CodeArt Academy como parte de los fundamentos de programación. Su objetivo principal es automatizar y estandarizar la clasificación del desempeño académico a partir de una nota numérica validada.

## 📋 Descripción del Proyecto
El sistema captura el nombre de un estudiante y su calificación numérica (en un rango válido de 0 a 100). Utiliza `decimal.TryParse` para asegurar la integridad de los datos de entrada, evalúa las reglas de negocio mediante estructuras condicionales (`if / else if / else`) y muestra un resumen detallado con la clasificación y la condición académica definitiva (Aprobado o Reprobado).

## 🚀 Escala de Desempeño y Reglas de Negocio
* **Excelente:** 90 ≤ nota ≤ 100 *(Condición: Aprobado)*
* **Muy bueno:** 80 ≤ nota < 90 *(Condición: Aprobado)*
* **Aprobado:** 70 ≤ nota < 80 *(Condición: Aprobado)*
* **Reprobado:** 0 ≤ nota < 70 *(Condición: Reprobado)*
* **Inválida:** Calificaciones menores a 0, mayores a 100, o entradas no numéricas.

## 🛠️ Requisitos Técnicos Implementados
* **Lenguaje:** C# (.NET Core / .NET SDK)
* **Entorno de desarrollo:** Visual Studio / JetBrains Rider
* **Restricciones cumplidas:** Uso exclusivo de variables, operadores relacionales/lógicos, estructuras condicionales (`if / else`) y `decimal.TryParse()`. Sin ciclos ni persistencia.

## 🚦 Casos de Prueba Validados
| ID | Entrada | Resultado Esperado |
|---|---|---|
| CP-01 | Ana / 95 | Excelente / Aprobado |
| CP-02 | Luis / 85 | Muy bueno / Aprobado |
| CP-03 | Sara / 75 | Aprobado / Aprobado |
| CP-04 | José / 69 | Reprobado / Reprobado |
| CP-05 | 0 | Reprobado / Reprobado |
| CP-06 | 70 | Aprobado / Aprobado |
| CP-07 | 90 | Excelente / Aprobado |
| CP-08 | 100 | Excelente / Aprobado |
| CP-09 | -1 | Nota fuera de rango |
| CP-10 | 101 | Nota fuera de rango |
| CP-11 | ABC | Entrada no numérica |

## 👨‍💻 Autor y Agradecimientos
* **Desarrollado por:** Jeico Arias Brito
* **Docentes / Evaluadores:** 
  * Francis Ricardo Ramirez De Leon
  * Manuel Titín