# Diagramme UML Question 1

```mermaid
	ClassDiagram
		class A{
			<<abstract>>
			#a1
			#a2
			#a3

			*+Somme();*
			+Multiplication(int y){y=y*a1*a2*a3; return y}
			+Moyenne(int z){return Somme()/z;}
		}

		class B{
			-b1

			+Somme(){return (a1+a2+a3+b1);} <<override>>
			+Multiplication(C obj){
				objc.a3 = a3*a2; return objc.a3;
			}
		}

		class C{
			+Somme(int x) {return a3+x;}
			+Multiplication(int y){y=y*a2; return y;}
		}

```