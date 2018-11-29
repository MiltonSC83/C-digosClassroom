  ### **Caso de prueba**

Condiciones previas: El dispositivo de prueba debe de ser un dispositivo con sistema operativo android IceScream Sandwich o mayor. La herramienta debe de estar previamente instalada. 

*TestCase ID* TC1R1 
*TestCaseScenario:* Probar que la herramienta permita calcular la suma de dos números reales tanto positivos como negativos.  
*TestSteps:*
1. Ingresar 10 como valor en el primer dato. 
2. Ingresar -20 como segundo dato.
3. Seleccionar la opción de Suma.
4.Presionar el botón de resultado.

*Expect Results:* 
La aplicación debe de desplegar el resultado igual a -10.

*Pass/Fail:*

<p align="center">
  <img width="300" height="400" src="https://scontent.fmex6-1.fna.fbcdn.net/v/t1.15752-9/47191419_1202533543220604_7059571494564659200_n.png?_nc_cat=105&_nc_ht=scontent.fmex6-1.fna&oh=c537c1774e9c7e270fc08d1bbc4623c4&oe=5C76F585">
</p>

*TestCase ID* TC2R1 
*TestCaseScenario:* Probar que la herramienta permita calcular la resta de dos números reales tanto positivos como negativos.  
*TestSteps:*
1. Ingresar 6 como valor en el primer dato
2. Ingresar -2 como valor en el segundo dato.
3. Seleccionar la opción resta
4. Presionar el botón resultado.

*Expect Results:*  
La aplicación debe de desplegar el resultado igual a 8.

*Pass/Fail:*

<p align="center">
  <img width="300" height="400" src="https://scontent.fmex6-1.fna.fbcdn.net/v/t1.15752-9/47069147_954909914714933_5858159860725579776_n.png?_nc_cat=109&_nc_ht=scontent.fmex6-1.fna&oh=79d670faa2bece75063b33a8be1d777b&oe=5C7291DB">
</p>

*TestCase ID* TC3R1 
*TestCaseScenario:* Probar que la herramienta contiene un botón que borra la operación anteriormente realizada.
*TestSteps:*
1. presionar el botón borrar.

*Expect Results:* 
La aplicación debe de volver nulo el contenido en el espacio de los dos valores iniciales.

*Pass/Fail:*

<p align="center">
  <img width="300" height="400" src="https://scontent.fmex6-1.fna.fbcdn.net/v/t1.15752-9/47158952_1900388003341886_427448459696537600_n.png?_nc_cat=107&_nc_ht=scontent.fmex6-1.fna&oh=9705f2544122b8a8a1a8637f874cda26&oe=5CAD4AF6">
</p>

*TestCase ID* TC4R1 
*TestCaseScenario:* Probar que la herramienta despliegue un error al faltar uno de los datos a operar.
*TestSteps:*
1. Presionar el botón de borrar
2. Ingresar 12.9 como valor en el segundo dato.
3. Seleccionar la opción Suma.
4. Presionar el botón resultado.

*Expect Results:* 
La aplicación debe de desplegar el mensaje: Hacen falta datos, compi.

*Pass/Fail:*



<p align="center">
  <img width="300" height="400" src="https://scontent.fmex6-1.fna.fbcdn.net/v/t1.15752-9/47062841_1187700748061634_1422624607319359488_n.png?_nc_cat=103&_nc_ht=scontent.fmex6-1.fna&oh=e31a91892147b8d6a1b91e46c14b9dc1&oe=5C6F97E5">
</p>

*TestCase ID* TC5R1 
*TestCaseScenario:* Probar que la herramienta despliegue un error al no haber seleccionado una operación a realizar.  
*TestSteps:*
1. Ingresar 3.6 como valor en el primer dato.
2. Ingresar 6.87 como valor  en el segundo dato.
3. Presionar el botón resultado.

*Expect Results:* 
La aplicación debe de desplegar el mensaje: Selecciona una operación.

*Pass/Fail:*

<p align="center">
  <img width="300" height="400" src="https://scontent.fmex6-1.fna.fbcdn.net/v/t1.15752-9/46940938_906951999694973_1245221507144089600_n.png?_nc_cat=106&_nc_ht=scontent.fmex6-1.fna&oh=33062906f1eee4044e113e4e7af20cac&oe=5CA4DE8B">
</p>

*TestCase ID* TC6R1 
*TestCaseScenario:* Probar que la herramienta despliega un error cuando uno de los datos supera los 3 dígitos después del punto.  
*TestSteps:*
1. Ingresar 1000 como valor en el primer dato.
2. Ingresar 1 como valor en el segundo dato.
3. Seleccionar la opción Resta.
4.Presionar el botón resultado.

*Expect Results:* 
La aplicación debe de desplegar el mensaje 3 dígitos máximo, prro.

*Pass/Fail:*


<p align="center">
  <img width="300" height="400" src="https://scontent.fmex6-1.fna.fbcdn.net/v/t1.15752-9/46975318_404839226720920_2326421632047906816_n.png?_nc_cat=102&_nc_ht=scontent.fmex6-1.fna&oh=1582102aa93c6ff8ea9265b197fa899e&oe=5C6A84A8">
</p>

