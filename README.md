![Banner](./Assets/taller.jpg)

![UCU](https://github.com/ucudal/PII_Conceptos_De_POO/raw/master/Assets/logo-ucu.png)

### FIT - Universidad Católica del Uruguay

# El Taller Mécanico

Un empresa de desarrollo de software los contrata para que lleven a cabo su nuevo producto. Su trabajo será implementar un sistema para le gestión de talleres mecánicos. El sistema deberá de ser capaz de poder, registrar, consultar y actualizar todos los trabajos del taller que se hayan hecho, que harán o que estén en proceso. 

Se sabe del negocio que las ordenes de trabajo tienen un identificador único, la orden debe de tener una fecha, un tipo de trabajo (mecánica ligera, gomería, etc), deben tener la referencia al vehículo que se va a reparar o chequear, una lista de repuestos, las horas que se deben invertir en el trabajo y el estado de la misma (planificada, en curso, finalizada). 

Es importante que la orden de trabajo tenga un mecánico asignado, el trabajo se dará por iniciado o finalizado unicamente cuando el supervisor de calidad de su aprobación. De los repuestos, se quiere saber el número de parte, marca y precio. Del vehículo se requiere saber el VIN, marca, modelo, año, matricula. De los empleados del talles se quiere saber  la cédula de identidad, nombre, apellido, tipos de trabajo que puede realizar, rol que desempeña en el taller y el valor hora del mismo. Del Cliente se quiere saber la cédula de identidad, el nombre y el número de contacto.

De la orden se quiere saber el costo total de la misma la cual se calcula de la siguiente manera

**Costo Costo Orden = costo repuestos + costos horas del personal involucrado en la orden**

Es importante saber el taller tiene un espacio de trabajo limitado y no puede atender a mas de dos vehículos a la vez, es decir que tendremos determinados vehículos en una lista de espera.

## Parte 0: Repo
Crear la estrura de proyectos y crear un repositorio.

## Parte 1: Modelado
Se debe diseñar el diagrama de clases de la solución completa

## Parte 2: Implementación.
Implementar la solución planteada

## Pate 3: Justificación
Justificar detalladamente el uso patrones y principios.

## Parte 4: Calidad 
Se deben crear **TODOS** los casos de test para verificar el correcto funcionamiento de la solución planteada. 