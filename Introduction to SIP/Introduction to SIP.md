
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
* I've found your destination, and i'm ringing it
	* 