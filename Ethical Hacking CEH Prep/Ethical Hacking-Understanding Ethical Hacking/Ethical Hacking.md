I will share with you all my trial through my preparation in the CEH.

I'll start with a simple
# Course Overview

Preparation for the CEH 312-50

* Information Security and Ethical Hacking Overview

	Counts like 6% of total exam

* Reconnaissance Techniques
* System Hacking Phases and Attack Techniques
* Network and Perimeter Hacking
* Web application hacking
* Wireless Network Hacking
* Mobile platform, IoT ad OT Hacking
* Cloud computing
* Criptography


* Create and Configure Containers
	* Review of current security trends
	* Review cyber kill chain methodology and concepts (tactics, techniques and procedures TTP's)
	* Discuss adversary behavioral identification
	* Discuss indicators of compromise and their categories (IOC´s)
	* Discuss hacking concepts, types and phases
	* Discuss ethical hacking concepts and scope
	* Review information security controls
	* Discuss information security laws and standars

I also insert the example exercises to get us some help follow along to the CEH

This preparation consist in 60 hours of course and more than 20 vids

![[Pasted image 20231127122904.png]]

# Classifying Information Security

The porpuse of this, we can understand this thanks to the next quote.

> If you know the enemy and know yourself, you need not fear the result of a hundred of battles. If yu know yourself but not the enemy, for every vitory gained you will also suffer a defeat. If you know neither the enemy nor yourself, you will succumb in every battle.
> 
\- Sun Tzu, the art of war.


## Breaches by Industry

![[Pasted image 20231128190653.png]]


## Some interesting Stats

* 65% of companies have over 1,000 stale user accounts

* 92% of ATMs ae vulnerable to hacker attacks

* Ransomware attacks happen every 14 seconds

* 65% of large companies have more than 500 employees who have never changed their passwords

* More than 77% of organizations do not have a cyber security incident response plan



Know all about this stats its obvious to question ourselfs, How secure i fell?



## A little about the CEH Program

Remember something about ethical hacking and what is happening in the world

>If it wasn´t _hard_, everyone would do it, _hard_ is what makes _it_ great.
> 
> 
>-Tom Hanks - League of their own, 1992


### What Certification Brigs you

* Intrnationally recognized

* Industry standard

* Meets DOD Directive 8570.1

* Benefits your resume

* High demand certification


## What's Expected of You


___Code of Ethics___ __EC-Council__

|                      |                            |
|         -            |              -             |
| ✔ Privacy | ✔ Unauthorized usage |
| ✔ Intellectual property | ✔ Illegal activities  |
| ✔ Disclosure | ✔ Authorized  |
| ✔ Areas of expertise | ✔ No villains allowed  |

Remeber

> Just because you can, doesn´t mean you can.



If you are interesnted to read deep about them, down below you can find  the complete description.



1. Keep private and confidential information gained in your professional work, (in particular as it pertains to client lists and client personal information). Not collect, give, sell, or transfer any personal information (such as name, e-mail address, Social Security number, or other unique identifier) to a third party without client prior consent.

2. Protect the intellectual property of others by relying on your own innovation and efforts, thus ensuring that all benefits vest with its originator.

3. Disclose to appropriate persons or authorities potential dangers to any ecommerce clients, the Internet community, or the public, that you reasonably believe to be associated with a particular set or type of electronic transactions or related software or hardware.

4. Provide service in your areas of competence, being honest and forthright about any limitations of your experience and education. Ensure that you are qualified for any project on which you work or propose to work by an appropriate combination of education, training, and experience.

5. Never knowingly use software or process that is obtained or retained either illegally or unethically.

6. Not to engage in deceptive financial practices such as bribery, double billing, or other improper financial practices.

7. Use the property of a client or employer only in ways properly authorized, and with the owner’s knowledge and consent.

8. Disclose to all concerned parties those conflicts of interest that cannot reasonably be avoided or escaped.

9. Ensure good management for any project you lead, including effective procedures for promotion of quality and full disclosure of risk.

10. Add to the knowledge of the e-commerce profession by constant study, share the lessons of your experience with fellow EC-Council members, and promote public awareness of benefits of electronic commerce.

11. Conduct oneself in the most ethical and competent manner when soliciting professional service or seeking employment, thus meriting confidence in your knowledge and integrity.

12. Ensure ethical conduct and professional care at all times on all professional assignments without prejudice.

13. Not to neither associate with malicious hackers nor engage in any malicious activities.

14. Not to purposefully compromise or allow the client organization’s systems to be compromised in the course of your professional dealings.

15. Ensure all penetration testing activities are authorized and within legal limits. Not to take part in any black hat activity or be associated with any black hat community that serves to endanger networks.

16. Not to be part of any underground hacking community for purposes of preaching and expanding black hat activities.

17. Not to make inappropriate reference to the certification or misleading use of certificates, marks or logos in publications, catalogues, documents or speeches.

18. Not convicted in any felony, or violated any law of the land.



## Understanding Information Security

### Fundamentals of Information Security

1. Authenticity
2. Integrity
3. Availability
4. Confidentiality
5. Non-repudiation

## Types of attacks

Attacks = Motive + Method + Vulnerability

|Motives|
|-|
|Disrupt business continuity|
|Steal Info/Data|
|Create fear and chaos|
|Financial losses|
|Publicize political or religious beliefs|
|Achieve a state's military objectives|
|Reputation of target|
|Revenge|
|Ransomware|

### Classifications

|    Classification    |           Example          |
|         -            |              -             |
| ⚡ Passive attacks| Sniffing or Eyesdropping attacks |
| ⚡ Active attacks| DDoS, MitM, Session highjacking, SQL Injection |
| ⚡ Close-in attacks| Eavesdropping, shoulder surfing, dumpest diving, Social engineering  |
|⚡ Insider attacks| Misuse privileges by stealing physical devices, planting malware, backdoors or even keyloggers |
|⚡Distribution attacks|Trojans|


## The technology triangle


![[Pasted image 20231129155925.png]]

How can we appreciate, as we get closer to any sectin of the environment we lose attetion into the other two.


Usability = Security Risks


## Learning check


1. In classification of attacks,What would sniffing or eavesdropping be an example of?

	<details>
		<summary> Answer </summary>
		<p>Passive attacks<p>
	</details>


2. What would be an example of an employee planting a keylogger or even stealing physical devices?

	<details>
		<summary> Answer </summary>
		<p>Insider attacks<p>
	</details>


3. What about an attack that included social engineering or dumpster diving?

	<details>
		<summary> Answer </summary>
		<p>Close-in attacks<p>
	</details>


4. How about attacks that might include man-in-the-middle or a DoS, session hijack, something to disrupt communication?

	<details>
		<summary> Answer </summary>
		<p>Active attacks<p>
	</details>


5. What about if an attacker tampers with the hardware or software at its source?

	<details>
		<summary> Answer </summary>
		<p>Distribution attacks<p>
	</details>

# Understanding the attackers and their Methods

## Hacking Frameworks

When it comes to ethical hacking, is that you need to think like an attacker. So therefore, we need to understand the attackers ant their methods.

And we do that first by looking at what they refer to

### Cyber Kill chain Methodology

This ilustrate us how attacker typically will go after an organization. And because we can predict, what the attacker will do, based of the methodology, what we're going to do next, it helps us in the protection of our resources and networks.


Created by Lockheed Martin and they broke it down into seven different phases, thses phases are intelligent-driven defenses for identification and prevention of attackers and their activities.

It also acts as a _framework for securing cyberspace_ based on the concept of a military kill chain.

These phases are


<details>
	<summary><h4> 1. Reconnaissance </h4></summary>
		<p>
			Is basically where the attacker goes and gathers as much information as they can about their intended victim. </br> </br> And we do this with various tools and resources, publicly available information that's on the internet, for example social media. </br> </br> We're trying to gather information such as network and system information. Normally the target doesn't realize that we're going after them because we're very passive in this step. </br> </br>Some of the activities that an attacker goes through during this stage are: </br> <ul> <li>Look in detail what technologies are the target using on their website.</li> </br> <li>The interface ofr the email you provide a wbe-bases email service for your employees. </li> </br> <li>Looking at whois information.</li> </br> <li>DNS information.</li> </br> <li>Try to footprint the network.</li> </br> <li>scan network to identify open ports and services that you allow.</li> </ul>
		</p>
</details>

<details>
	<summary><h4> 2. Weaponization </h4></summary>
		<p>
			This is the stage where the attacker go through and analyze the information that gathered during the reconnaissance stage, identifying vulnerabilities and techniques that can use to gain remote access or on-premisse, acomplished thanks to create some malicious payloads that´s customized just for the specific environment, target specific devices like operating systems, desktop machines, switches, this is time to start creatng phishing email campaings maybe even a sperfish campaing where going to target specific individuals.
		</p>
</details>

<details>
	<summary><h4> 3. Delivery </h4></summary>
		<p>
			It's like it sounds, time to delivery the payload, it could be delivered either via a;</br> <ul> <li>Link in a phishing email</li> <li>As an email attachment</li> <li>USB Drop </li> </ul>
		</p>
</details>

<details>
	<summary><h4> 4. Exploitation </h4></summary>
		<p>
			So after transmitted to the target the goal is hat somebody actually runs the exploit. </br></br> In this stage the company's security policies face in to kick out the attack beacause aware you abaout not to click external links or attachments, or get trained about authentication and authorization attacks, but if not, the next stage will be.
		</p>
</details>

<details>
	<summary><h4> 5. Installation </h4></summary>
		<p>
			It's time to install that malicious payload, as well as install even more malicious software, including things like; backdoors. Here take action any type of IDS, Intrusion detection system to prevent doing that, obviously hide the backdoors. If the installation get completed of all the aditional tools then we move on to the
		</p>
</details>

<details>
	<summary><h4> 6. Command and control </h4></summary>
		<p>
			Here is time to create a two-way channel between target systems to ours to be able to command and control the systems via the two-way communication to be able to send issue comands that the system responds to or possibly be notified that the system are up online, so we are going to leverage things like privilege escalation meaning  going to up the privilege so we can possibly do more damage or take control over more systems. Obviously hiding the evidence of the compromise using things like encryption.
		</p>
</details>

<details>
	<summary><h4> 7. Action on objectives </h4></summary>
		<p>
			This is where the attacker goes through and starts stealing your confidential information, your customer lists, your databases, your employee record, or mybe start utilizing DoS techniques to affect the environment or using it like a launching point, to perform other attacks.
		</p>
</details>



### Other Frameworks

#### [MITRE ATT&CK](https://attack.mitre.org/)

That it was done in 2013, and it was designed to document the common tactics and techniques as well as procedures, TTP´s,that advanced persistent threats use against Windows enterprise networks.

The why of the ATT&CK technique or subtechnique is what we refer to as a tactic, the adversarial strategic goal, or the reason behind taking a particular action.

To obtain the desire outcome, techniques are the actions an adversary takes.

Procedures are what the adversary does to carry out th techniques or subtechniwues.

Another framework that is qute popular is the

#### Diamond Model of Intrusion Analysis

In this model provides a strucuture for identifying correlated groups of events, or clusters.

Provide a framework for developing a mor efficient method of stopping attacks and increasing analytics productivity. Not only des this save the defender or your money, but it also makes mounting an attack mor expensive for the attackers.

This model consists of four basic features.

<details>
		<summary><h4>1. Adversary </h4></summary>
		<p>A group or an individual that carries out the attack and the attack vector<p>
</details>

<details>
		<summary><h4>2. Capability </h4></summary>
		<p>Referring to all the strategies, the techniques, the procedures associated with the attack<p>
</details>

<details>
		<summary><h4>3. Infrastructure </h4></summary>
		<p>Refers to the physical or virtual components that make up the network, meaning to the systems an adversary could target to gain access<p>
</details>

<details>
		<summary><h4>4. Victim </h4></summary>
		<p>An individual or organization, even a domain or an IP address<p>
</details>

This model was named because when all the features are arranged according to the relationshio between them, it forms a diamond-shaped structure.

## Tactics, Techniques and Procedures (TTP´s)

TTP's refer to basically the activities ad patterns that attackers, or even grup of attacker, will utilize.

Themselves are extremly helpful to us, and looking at threads and profiling attackers.

Lets first start look at:


### Tactics

Are the way that attackers operateduring the different phases of the attack.


If we properly look at the tactics, we are actually able to profile,the ways they gather information, the methods that they typically follow for the initial compromise.


For example, there's some attackers that will depend solely on information that's availabe to them via public information, like the internet. Others might actually use social enginerring techniques, or even maybe pivoting from a third party into the target organization.

So in many cases, understanding the tactics that are used in the last stage of a hackers or attackers will help us to profile that particular individual.

___Anticipate your attacker(s) next move by understanding their tactics.___

Helping us to create an initial profile by understanding the diferent phases of an APT, Advanced Persistent Threat,  lifecycle.


**Warning:** Now, some attackers will actually change their TTPs so they aren´t profile, but those are typically pretty good hackers.

### Techniques

Refers that the attacker typically use specific techniques during their execution. 

These techniques include things like how did they initially do the exploitation?

What was the setup, the maintaining of the C&C, Comand & Control?

The techniques typically followed by an attacker to conduct an attack will sometimes be a little different, but they're mostly very similar to each other, and again, we can still use it profiling..

### Procedures

Basically looking at the sequence of actions that are performed by attackers to gain or achive certain goals throughout their attack lifecycle. 

For example, the basic procedure of gaining information during reconnaissance,an attacker will typically identify the key targets the employees, gather their detailed information, identify vulnerability systems, as well as different attack vectors. 

## Adversary Behavioral Identification

Involves identifying of some of the methods or techniques that attackers used to launch againts therr targeta and give us the insight into what may be coming at us next.

Take look at some of these behaviors

<details>
	<summary><h3>Internal reconnaissance</h3></summary>
	<p>
		If the attacker's able to get inside the network, they're going to follow specific techniques and methods to carry out additional reconnaissance, but instead of being on the outside, they're now on the inside. </br> </br> Once they make it in, we´re going to start enumerating, we're going to discover what systems are operating. </br> </br> <b>Enumeration:</b> </br> <ul> <li>OS</li> <li>Services</li> <li>Appd and versions</li> <li>Hosts</li> <li>Processes</li> <li>User accounts</li> <li>IP addresses</li> <li>Host names</li> </ul> </br>And what we can do as security professionals is by looking for any unusual commands that are executed, typicaly in some type of a script, maybe even PowerShell, and by using packet capturing tools like Wireshark.
	</p>
</details>

<details>
	<summary><h3>PowerShell</h3></summary>
	<p>
		Attackers can use this structure or this technology wich is built into every single version of Windows, since Windows 7 and we now have it in Linux. And the reason why this is a concern, is that Powershell itself, can tell us a <a href="#plethora"> plethora </a> of information that we can pull using PowerShell. We can even execute commands on a remote machine via PowerShell.  </br> </br>So as a security professional, we need to make sure that we monitor and check the transcription logs and the event logs for PowerSell, typically these logs will identify the IP address that's trying to exfiltrate the data itself, so that would help you in determining where it's coming from. </br> </br> <p id = "plethora"><b>Plethora:</b></br>A very large amount or number: an amount that is much greater than necessary</br><small>-"Plethora", <a href = "https://www.merriam-webster.com/dictionary/plethora.">Merriam-Webster Dictionary</a> </small></p> 
	</p>
</details>

<details>
	<summary><h3>CLI processes</h3></summary>
	<p>
		Attackers are going to use the command line interface 98% of the time to interact with the target, to browse files, to gain access or to look at content, to create new accounts. So similar of PowerShell, we're going to make sure that we are checking logs for process IDs, any processes that have arbitrary letters and numbers in them. Any files that were download off the internet could also be a clue.
	</p>
</details>

<details>
	<summary><h3>Suspicious proxy events</h3></summary>
	<p>
		One of the cool things that attackers love to do is we like to create and configure multiple domains that actually point to the exact same host, it actually allows the attacker to move quickly between domains to avoid detection, or switch these domains. </br> </br> Our job is to look for unspecified domains by, checking our data feed that are gathered by those domains.
	</p>
</details>

<details>
	<summary><h3>HTTP User Agent</h3></summary>
	<p>
		HTTP base communications use what we refer to as user agent field,  attackers can modify the content of the HTTP user agent field to communicate, using C&C we'll trying to comunicate to our compromised systems to control the systems that we've compromised already. </br> </br> How a professional, you need to identify this attack at the initial stage by checking the cintent of the user agent field.
	</p>
</details>

<details>
	<summary><h3>C&C Servers</h3></summary>
	<p>
		C&C allows attackers to issue commands to hundreds of systems with one entry. </br> </br> In order to use C&C environment, we're going to use an encrypted channel, and we use that to also steal data, delete information, and anything else we find we want to do. </br> </br>Professionals can detect compromised hosts by tracking ntwork traffic for outbound connection attempts or unwanted ports that are opening up.  
	</p>
</details>

<details>
	<summary><h3>DNS Tunneling</h3></summary>
	<p>
		  As usual when we wan to visit som web place we type a DNS name, instead of a IP, so and that whole DNS nae resolution takes place. Attackers can actually use DNS to tunnel and hide any malicious traffic. </br> </br> Using DNS tunneling, we can also comunicate with: </br> </br> <ul> <li>Talk with C&C's</li> <li>Bypass security controls</li> <li> Monitor requests </li> <li>DNS Payloads</li> <li> Destinations </li> </ul>
	</p>
</details>

<details>
	<summary><h3>Web-Shells</h3></summary>
	<p>
		  Attackers can use web shells to control web servers by creating a shell whitin the website itself, and just start typing away any typ of commands. Used by transferd/upload files. So you need to be looking at any web shells that mey be runnning on your servers. Look at the error logs, as well and possibly any bizzare-looking strings in your requests.
	</p>
</details>

<details>
	<summary><h3>Data-Staging</h3></summary>
	<p>
		  After we've gained access, i'm going to take the data that i'm looking for and I´m going to stage it up sommeplace fo transmission. Information I'm going to gather are going to be things, like business tactis that your rganization follows, financial information, network infrastructure information and put it in a single location, maybe like an FTP site that I've created or just starting to destroy the data.
	</p>
</details>

## Indicators of Compromise (IoC)

Reason of a constant evolution and creation of new threads and TTP's we need to male sure that we moitor different types of indicators of compromise. It's important to understand that **IoC's are not inteligence**, is rather an IoC is a good source of information about the thread that serves as data points for intelligence.

Take a look at some of teh IoC's that you'll wnant to be aware of:

* Unauthorized software and files

* Suspicious emails

* Suspicious registry nd fil system changes

* unknown ports and protocol usage

* Excessive bandwith usage

* Rogue hardware

* Service disruption and defacement

* Suspicious or unauthorized account usage (like Sharepoint, Exchange, ISS, SQL, etc)

All of these indicators e need to be looking at not only at a host-based level but also at network level.

Network indicators are extremly useful when it comes to looking for those C&C indicators.

## Learning check

Time for another round of question to help you remind all topics we talk before.


In which pahse of the Cyber Kill Chain Methodology,exploits a vulnerabiity by executing code on a system? 

<details>
	<summary>Answer</summary>
	<p>
		Exploitation
	</p>
</details>

Wich phase performs actions to achive the intended objectives or goals?

<details>
	<summary>Answer</summary>
	<p>
		Action on Objectives
	</p>
</details>

We also talked about some of the behaviors that an attacker might have. Wich one of those would be used by an attacker as a tool to automate date exfiltration and possibly launching further attacks using something that's built into every Microsoft plataform, as well as could be added to Linux.

<details>
	<summary>Answer</summary>
	<p>
		PowerShell
	</p>
</details>

It's when the attacker is going to use some type of protocol to obfuscate malicious traffic, and it's something that really hard to block because most everybody allows it through.

<details>
	<summary>Answer</summary>
	<p>
		DNS Tunneling
	</p>
</details>

Another way of identifying an attacker's behavior would be looking at using different techniques to collect and combine as much data as possible, What do we call that?

<details>
	<summary>Answer</summary>
	<p>
		Data Staging
	</p>
</details>

### Key Terms

Tactics: Wich typically show us the way that an attacker is going to perform an attack.

Techniques: Those behaviors.

Procedures: The way that an attacker performs the attack.

# Comparing Hacking and Ethical Hacking

## Hacking Concepts

