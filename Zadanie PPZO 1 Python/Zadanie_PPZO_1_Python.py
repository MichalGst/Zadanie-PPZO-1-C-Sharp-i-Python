zadanie = int(input("Podaj numer zadania\n"))
if (zadanie == 1):
    a = int(input("podaj liczbe\n"))
    b = int(input ("podaj liczbe\n"))
    c = input("wybierz dzialanie +, -, * lub /\n")
    if (c == "+"):
        print (a + b)
    
    elif (c == "-"):
        print (a - b)
    
    elif (c == "*"):
        print (a * b)
    
    elif (c == "/"):
        print (a / b)
        
elif (zadanie == 2):
    a = input("Wybierz rodzaj konwersji C = Celsjusze na Fahrenheity F = Fahrenheity na Celsjusze\n")
    if (a == "C"):
        a = float(input("Podaj ilosc stopni Celsjusza\n"))
        print(a * 1.8 + 32)
    elif (a == "F"):
        a = float(input("Podaj ilosc stopni Fahrenheita\n"))
        print((a-32)/1.8)
        
elif (zadanie == 3):
    wszystkie = input("Podaj ilosc ocen\n")
    oceny = "0"
    suma = 0
    i = int(wszystkie)
    while i > 0: # tworzê seriê ocen do odczytania przez pêtlê for
        oceny = oceny + input("Podaj ocene\n")
        i -= 1
    for x in oceny: # odczytuje seriê ocen pêtl¹ for
        suma = suma + int(x)
    if ((suma/int(wszystkie)) >= 3.0):
        print(suma/int(wszystkie))
        print("uczen zdal")
    elif ((suma/int(wszystkie)) < 3.0):
        print(suma/int(wszystkie))
        print("uczen nie zdal")
