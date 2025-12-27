# C-Sharp Abstraction
## ABSTRACTION:-
   Abstraction is the property by which only the essential details are shown to the user, and non-essential details or implementations are hidden from the user. In Abstraction, data is considered theoretically and is not well defined. Abstraction tells what should be done but not how it is done. Abstraction works on *“Inheritance”* and *“Polymorphism”*. 
There are two levels of Abstractions:
	
- Higher level of Abstraction.
- Lower level of Abstraction.
  
## Abstract Classes:

*“Abstract”* keyword is used to declare an abstract class. In C#, it’s not allowed to create objects of an abstract class, for this reason derived class is made to achieve abstraction. 
An abstract method cannot be declared outside the abstract class. We cannot define properties directly to the abstract class that is why derived class is made.

## Interface:
The interface is declared using the *“interface”* keyword. We can create abstract methods inside the interface like abstract classes and declare their functionality in the derived class. From the derived class we can then access those properties using the derived class by creating the instance of the derived class.

## CODE#1:
In the first code example, an Interface *“Animal”* is made having an abstract method *“speak”*. This method is further called by the two derived classes *“cat”* & *“dog”*. The object of class the *“Animal”* cannot be made because of one of its properties, the derived classes will access the properties of the base class *“Animal”* and creating instances of their own. The method will be called of the derived classes *“cat & dog”*.

<img width="230" height="410" alt="Screenshot 2025-12-28 040215" src="https://github.com/user-attachments/assets/4578d800-c002-4602-b8a2-d48fb29af093" />


## CODE#2:
Just like the previous example, an interface *“payment”* is made having an abstract method *“pay”*. This method is then used by the derived classes *“cash”* & *“card”* to tell what payment method is being used to pay.

<img width="283" height="413" alt="Screenshot 2025-12-28 040549" src="https://github.com/user-attachments/assets/dd025f8e-0142-4417-8677-2c4bc8b7063c" />


## CODE#3:
This code example is working on the interface *“Switchable”*. It has an abstract method *“turn on”*, this method turns on the derived classes having this method.

<img width="275" height="427" alt="Screenshot 2025-12-28 040754" src="https://github.com/user-attachments/assets/36bb6236-91a9-4828-bffb-02066f0dcc36" />


