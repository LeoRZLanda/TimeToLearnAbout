
# Sección 2: Introduction to Telecommunications

## A brief history of telecom
### Technology Advancement

* Analog
	* Tip & Ring Telephony
	* ![[Pasted image 20240320212439.png]]

* Digital
	* Dedicated Ethernet Connections
	* ![[Pasted image 20240320212817.png]]
* VoIP
	* Shared High-Speed Network Infrastructure
	* ![[Pasted image 20240320213044.png]]

###### Table

|              **Analog**              |             **Digital**              |                 **VoIP**                  |
|:------------------------------------:|:------------------------------------:|:-----------------------------------------:|
|         Tip & Ring Telephony         |    Dedicated Ethernet Connections    | Shared High-Speed Network Infraestructure |
| ![[Pasted image 20240320212439.png]] | ![[Pasted image 20240320212817.png]] |   ![[Pasted image 20240320213044.png]]    |

#### The POTS Line

* Analog
* Plain Old Telephony Service
* Two Wires
* Voltage Sends Ringing
* Closed Circuit Connects Phones
* One Call, or "Channel", per POTS Line

#### T1/E1 PRI

* Digital
* T1 = 24 channels (Most common in US)
* E1 = 32 Channels
* Contain B Channels (Calls) and One D Channel (Signaling)
* Delivered on Dedicated Circuits
* Limited Redundancy Capabilities

#### SIP Trunk

* VoIP
* Unlimited Channels - Constrained by Bandwith
* Delivery over IP Circuits (Internet, Dedicated MPLS, Etc...)
* Many Redundancy Capabilities


## A new Challenger Approaches: SIP

### Session Initiation Protocol

* SIP Changed the playing field
	* Advancements
	* Challenges
* SIP Signaling is similar to EMAIL & HTTP Requests
* SIP is versatile
	* VoIP Calls
	* Instant Messaging
	* Presence
* SIP is a Standard
	* Sort of

# Sección 3: SIP Signaling Messages

## SIP Signaling

### Signaling Overview 

* Keep-Alive Messages
	* SIP Options
	* SIP Register
* I need to make a call
	* SIP Invite
* I'm trying to connect your call
	* SIP Trying
* I've found your destination, and I'm ringing it
	* SIP Ringing
	* SIP Session Progress
* I've Connected your call
	* SIP OK
* I'm Disconnecting your call
	* SIP Bye

### SIP 100 messages

* Provisional Responses
* 100 Trying
	* Confirmation that call is being processed
* 180 Ringing
	* Confirmation that destination is being alerted
* 181 Call is being forwarded
	* Indication that Far-End is Forwarding the call
* 183 Session progress
	* Sent to provide additional information about a call that is still being established
	* Typically used for "Early media"

### SIP 200 Messages

* Successful Responses
* 200 OK
	* Request was completed successfully
* 202 Accepted
	* Request has been received, and is currently being processed

### SIP 300 Messages

* Redirection Responses
* 300 Multiple Choices
	* Destination has been identified ti have more than one option for which to connect to
* 301 Moved permanently
	* The original destination is no longer valid, and provides information on where to send the call now.
* 302 Moved temporarily
	* Same as Moved permanently, only may include an "Expires" time
* 305 Use Proxy
	* Specifies a specific proxy needed to connect to in order to process the request

### SIP 400 Messages

* Client Failure Response
* 400 Bad Request
	* Bad Syntax
* 401 Unauthorized
	* SIP Requested requires authentication that was not provided or correct
* 403 Forbidden
	* Request was valid but deliberately did not process the request
* 404 Not Found
	* The request was valid, but the server is not able to find the destination
* 405 Method not allowed
	* Specific method (Message Type) is not allowed un the session
* 408 Request timeout
	* The server could not process the request in a suitable amount of time
* 480 Temporarily Unavailable
	* Destination is not available currently
* 488 Not acceptable here
	* Some part of the request can not be accepted by the server

### SIP 500 Messages

* Server Failure Response
* 500 Server Internal Error
	* The server failed to processes the request due to some unexpected condition
* 503 Service Unavailable
	* The server is unable to process the request, usually temporally
* 504 Server Time-Out
	* Server forwarded request to another server, but did not receive a response in time

### SIP 600 Message

* Global Failure Responses
* 603 Decline
	* Destination does not wish to participate in the call or cannot do so
* 604 Does not Exist Anywhere
	* Server has information that shows that the destination does not exist anywhere
* 606 Not Acceptable
	* The destination was contacted successfully, but some aspect of the request were not acceptable

# Sección 4: SIP Media

## SIP Media

* RTP - Real Time Protocol
* RTCP - Real Time Control Protocol
* SDP - Session Description Protocol
* Media Path
	* Transmitted via RTP
	* Two Streams - One in Each Direction
	* Media Path communicated during Call setup
* Media Stream can Change Mid Call
	* Changes Communicated via SDP
	* (Music) On Hold
	* Mute
* Call Quality
	* Monitored by RTCP

## Understanding SDP

* Session Description Protocol
* Contains Information about Media Estavlishment
* Found in
	* SIP Invite
	* SIP 200OK
	* SIP 18x Messages (Early Media)

### SDP Example

![[Pasted image 20240321221643.png]]

# Sección 5: How to speak SIP

## The back to back user agent (B2B-UA) & The ladder diagram

### The back to back user agent (B2B-UA)

* A Server or Device will Act as a B2B-UA
	* PBX
	* SBC (Session Border Controller)
	* Provider Equipment
* B2B-UA Manages calls that traverse it
	* Allows for a call control & advanced call routing
* UAC - User Agent Client
	* Originator of the call
* UAS - User Agent Server
	* Destination of the call

### The ladder diagram

![[Pasted image 20240322193249.png]]

## Wireshark 101

Descargaremos wireshark [aquí](https://www.wireshark.org/download.html)

## Contents of SIP Packets

Vamos a descargar la siguiente muestra [aquí](https://wiki.wireshark.org/uploads/__moin_import__/attachments/SampleCaptures/SIP_CALL_RTP_G711)



Y abriremos el reporte sip con wireshark, de ahi le daremos click a Telephony -> SIP Flows

![[Pasted image 20240322205507.png]]


A continuación seleccionas un perfil y das clic en Flow sequence

![[Pasted image 20240322205609.png]]

Tambien al seleccionar el primer paquete INVITE y vemos el cuerpo del mensaje podemos ver un ejemplo mas claro de SDP, como lo habíamos visto anteriormente

![[Pasted image 20240322205943.png]]


# Sección 6: SIP Tracking 101 - Practice Examples

## Installing FreePBX in virtualBox

Para empezar necesitaremos la siguiente [iso](https://downloads.freepbxdistro.org/ISO/FreePBX-64bit-10.13.66.iso) de freePBX.

De ahi crearemos una maquina virtual con minimo 1gb de ram y 20gb de espacio junto con un procesador, en mi caso sigo las instrucciones del video con 4GB ram 80GB de espacio y un procesador.

Modificaremos las configuraciones de red y pondremos que sea Bridged adapter, para utilizar la misma ip de nuestra computadora.


De ahi solo procede el ejecutar la maquina virtual, darle a full installation  y seguir las siguientes instrucciones, al finalizar.

Nos pedirá iniciar sesión con las credenciales previas, root y la contraseña que seleccionamos.

Para a partir de ahi nos mostrara la ip en donde estará el servicio activo, al ingresar a dicha ip en un navegador, nos pedirá crear un usuario, para después mandarnos al siguiente interfaz.

![[Pasted image 20240327201509.png]]

De ahi daremos clic a FreePBX administration y digitaremos nuestro usuario previo.

Si te aparecen popups de ellos solo ignóralos y dales skip o abort.

Si te pide seleccionar idioma puedes ponerlo en español, en mi caso lo dejare en ingles.

Bueno, hasta este punto deberíamos de tener la siguiente interfaz.

![[Pasted image 20240327202325.png]]

## Configuring FreePBX Extensions

Ahora es momento de configurar un par de extensiones para poder realizar que dos teléfonos puedan hacer llamadas.

No dirigiremos al menu de applications -> Extensions

![[Pasted image 20240327202658.png]]

de ahi a add extension -> add new PJSIP extension

![[Pasted image 20240327202753.png]]

A continuación le modificaremos los siguientes datos.

![[Pasted image 20240327203004.png]]

User extension
Display Name
Secret
Password for new user


Las que se muestran en la imagen son solo demostrativas, puedes poner lo que gustes.


Realizaremos esto mismo dos veces, para dos usuarios.

Al finalizar no hay que olvidar de presionar el botón Apply Config.

![[Pasted image 20240327203630.png]]

## Setting up Zoiper Soft-Phone

primero antes que nada hay que tener dos servidores o maquina avirtual externa, en mi caso tengo windows server 2022, a continuación hay que apagar la configuración, IE Enhanced Security COnfiguration, de momento.

![[Pasted image 20240404114324.png]]


De ahi ir a descargar [Zoiper](https://www.zoiper.com/en/voip-softphone/download/current) 

iniciaremosel programa de instalación y como culaquiera, next e install, para que al final nos solicite iniciar sesión con las credenciales previas que hemos creado en FreePBX.

![[Pasted image 20240404125742.png]]

nos iremos a free user

![[Pasted image 20240404125814.png]]

colocamos la ip que esta dirigida nuestro frePBX

![[Pasted image 20240404125933.png]]

si solicita info adicional, skip


despues nos brindara información de que configuración usar, y como es logigo usaremos SIP UDP

![[Pasted image 20240404130027.png]]

daremos next y skip despues, realizaremos este proceso en el siguiente servidor



![[Pasted image 20240404130547.png]]


## Tracing a Real phone call and reviewing wireshark


AL tener los articulos listos es momento de realizar un analisis

Primero hay que regresar a la terminal de nuestro FreePBX

y ejecutar los siguientes comandos

```bash
cd /
```

```bash
tcpdump -w callcapture.pcap
```

y lo que hara sera dentro de su red un analisis de paquetes

ahora nos regresaremos a nuestro usuario 100 en zoiper y realizaremos una llamada al cliente 200

y como podemos ver si reciben llamdas

![[Pasted image 20240404133407.png]]


contestaremos como usuario 200, mantendremos la llamada en espera por 5 segundos y colgaremos

de ahi regresamos a la terminal de FreePBX y haremos ctrl+c para detener el proceso de captura para despues

Nos conectaremos mediante ssh usando winspc, puedes descargarlo [aqui](https://winscp.net/eng/index.php)

Como simple actualización todo next he install, para despues al abrirlo poder iniciar sesión dentro del servidor en donde esta el reporte previo de FreePBX.

AHora estaremos dentro de una interfaz grafica de documentos de nuestra computadora, izquierda y del servidor, derecha.

![[Pasted image 20240404135006.png]]

Nos iremos al directorio raíz del servidor, dando clic a la carpeta y los tres puntos.

De ahi como podemos ver esta el documento callcapture.pcap, arrastremoslo a nuestra caroeta de documentos e nuestra computadora local.

AHora para poder leeer o apreciar mejor el documento tenemos que descargar [wireshark](https://www.wireshark.org/download.html)

Al abrirlo podemos filtrarlo por SIP.


![[Pasted image 20240404143300.png]]

De ahi nos iremos a Telephony -> SIP FLows

Y como podemos ver, hubo una correcta comunicaciones netre nuestro servidores.

![[Pasted image 20240404143727.png]]

Y si seleccionamos flow sequence podremos apreciar como fue el intercambio de datos.

![[Pasted image 20240404143805.png]]


Como podemos ver hay tres ip, dos de nuestros servidores, 50.99 y 50.148, y parte de frePBX la 50.175

Como primer paso al usuario 1, 50.99, manda una invitación a frepbx, sin embargo le responde de que no lo conoce,con un unauthorized, primero tiene que mandar un tag el usuario 1, le responde con un acknowledge, dnaod comprencion a lo que necesita el servidor.

![[Pasted image 20240404144640.png]]

Para despues, mandarle otro invite sin embargo ahora con sus credenciales.

![[Pasted image 20240404144732.png]]

AHora frepbx le da incapie he intenta conectarse con el usuario dos.

![[Pasted image 20240404144901.png]]

Propiamente vemos de donde  a donde se quieren comunicar.

Ahora el servidor frpbx le manda un invite al ususario 2 y un ringing al ususario 1, para despues el usuario 2 responder con un 200 okay que ha respondido la llamada.

Sobre poner en espera la llamada, lo podremos apreciar en un invite hacia el servidor freepbx en donde muestra inactivo como atributo de media.


![[Pasted image 20240404150847.png]]



Y al momento que el usuario dos quita la espera, se muestra por parte de el que ya esta dispuesto a mandar y recibir media.


![[Pasted image 20240404151136.png]]

Recibiendo un okay por parte de freePBX, manda un entendido el usuario dos y para finalizar manda un adios, bye, freePBX le dice okay y le manda un bye al usuario 1 y el le responde con un okay y así se finaliza la llamada.


# Sección 7: Troubleshooting Tips & War stories

## Phone call with noise

Esto sucede frecuentemente con lineas analógicas, teóricamente es imposible que suceda con VoIP digital, por ende hay que investigar la infraestructura analógica para resolver el problema. Lo mas frecuente es que sea los audífono alambricos que estén conectados al teléfono o dispositivo que este hablando. SI el problema persiste debería de encontrarse el problema con el proveedor de llamadas, a razón de que no conoces plenamente de sus infraestructura o si tiene alguna alianza con otro proveedor para ampliar la zona y que algunos de ellos tengan infraestructura analógica, en donde se pueda generar dicho ruido. 


## Troubleshoothing no ringback

Estop puedes validar que es lo que esta pasando principalmente de dos maneras, revisar el flujo de paquetes, más bien confirmar si sucede  el 180 ringing o el segundo que seria por early media SIP 183 session progress, que indica que existe un intento de conexión que aun no se a establecido completamente.


Lo que sucede a veces es que si tu sistema si manda de forma correcta un 180 sin embargo el proveedor de telefonía no te manda de regreso un 183 puedes descartar que no es tu falla sino del proveedor.

Si aun así el proveedor si te manda un 183, puede ser interno y que algo este bloqueando la llegada como un firwall, posiblemente de l proveedor, o también que el paquete no tenga media de audio.

## Troubleshooting bad quality cal

en si lo que sucede es una mala conexión por parte del cliente, sin embargo también el servidor puede ayudar a tener una mejor comprensión de paquetes he intentar no perder nigun porcentaje de ellos.

# Sección 8: Additional information

## The SIP RFCs

SIP RFC es básicamente un documento que ilustra que esta y que no esta permitido dentro del protocolo.


Para algún tema tecnológico en especifico, [SIP RFC 3261](https://www.ietf.org/rfc/rfc3261.txt)


Cuando se tiene que presionar un numero en el teléfono y mandar al servidor para continuar,dual tone multi frequency, [DTMF RFC 2833](https://www.ietf.org/rfc/rfc2833.txt)


[Early media RFC 3960](https://www.ietf.org/rfc/rfc3960.txt)



