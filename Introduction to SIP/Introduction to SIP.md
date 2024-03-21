
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
* 302 Moved temporarly
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
	* The server could not process the request in a sultable amount of time
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

