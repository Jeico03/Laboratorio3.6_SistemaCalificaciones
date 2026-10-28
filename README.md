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

## 🔗 Matriz de Trazabilidad
| Elemento del Sistema | Descripción / Criterio | Casos de Prueba Asociados |
|---|---|---|
| **RF-01** | Captura del nombre del estudiante | CP-01, CP-02, CP-03, CP-04 |
| **RF-02** | Captura de la calificación como texto | CP-01 al CP-11 |
| **RF-03** | Validación de formato numérico con `decimal.TryParse` | CP-11 |
| **RF-04 / RN-01** | Validación de rango permitido (0 a 100) | CP-05, CP-09, CP-10 |
| **RF-05 / RF-06** | Evaluación de escala y condición (Excelente, Muy bueno, Aprobado, Reprobado) | CP-01 al CP-08 |
| **RF-07** | Impresión de resumen detallado en consola | CP-01 al CP-08 |

## 🚦 Casos de Prueba Validados
| ID | Entrada (Nombre / Nota) | Resultado Esperado |
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