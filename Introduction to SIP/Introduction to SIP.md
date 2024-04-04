
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

