# MiRelojDigital

 Este proyecto hace uso del del objeto Timer para m
 mostrar por pantalla un formulario donde se le da
 al usuario la oportunidade de elegir ver solo la
 hora o la hora y la fecha.

# Descripcion

 Este proyecto consiste en una aplicacion que emplea
 un objeto timer para mostrar la hora en un formato
 preestablecido. El proyecto tiene dos botones:
 "Mostrar la hora", que usa una etiqueta para mostrar
 en su propiedad Text la hora con el metodo TimerString
 o puede usar el boton "Mostrar Hora y Fecha" que emplea
 el espacio de nombres System.DateTime para usar el metodo
 Now() que devuelve en la propiedad Text de la etiqueta
 la hora y la fecha que se actualizara cada vez que se 
 haga click en cada boton segun el formato que elija ver
 el usuario.
 
 # Actualizacion: 05/01/2025
 # Hora: 12:48

Detalles técnicos del proyecto:
Idioma: Visual Basic.NET
Versión del framework: 4.7.2

# MyDigitalClock

This project makes use of the Timer object to
display a form where the user is given 
the opportunity to choose to see only the time 
or the time and the date.

# Description

This project consists of an application that uses
a timer object to display the time in a preset format. 
The project has two buttons:"Show the time", which uses 
a label to display the time in its Text property with 
the TimerString method or you can use 
the "Show Time and Date" button that uses 
the System.DateTime namespace to use the Now() method 
that returns in the label's Text property the time and date 
that will be updated each time each button is clicked 
according to the format the user chooses to see.

# Update: 01/05/2025
# Time: 12:48

Technical details of the project:
Language: Visual Basic.NET
Framework version: 4.7.2

![imagen](https://github.com/user-attachments/assets/27c2c281-3161-4857-85f5-8b2a10bb3f05)

![imagen](https://github.com/user-attachments/assets/225e4ebd-ef1d-40b8-9858-b9f0e3cbcf96)

Code of the Project:

Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


    End Sub

    Private Sub btnHora_Click(sender As Object, e As EventArgs) Handles btnHora.Click
        Label1.Text = TimeString 'Da solo la hora
    End Sub

    Private Sub btnMostrarHoraFecha_Click(sender As Object, e As EventArgs) Handles btnMostrarHoraFecha.Click
        Label1.Text = System.DateTime.Now() 'Da la hora y la fecha
    End Sub
End Class
