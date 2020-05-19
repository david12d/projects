"""Find PI to the Nth Digit
 Enter a number and have the program generate PI up to that many decimal places. 
 Keep a limit to how far the program will go.
 """
import math
import sys

x = ""

while True:
	try:
		x = int(input("Enter a number:\n"))
	except ValueError:	
		print("Sorry, I didn't understand that.")
		continue
	else:
        #we're ready to exit the loop.
		if (x > 300):
			print("Sorry, keep it under 300 please.")
			continue
		else: 
			break

def calcPi():
    q, r, t, k, n, l = 1, 0, 1, 1, 3, 3
    while True:
        if 4*q+r-t < n*t:
            yield n
            nr = 10*(r-n*t)
            n  = ((10*(3*q+r))//t)-10*n
            q  *= 10
            r  = nr
        else:
            nr = (2*q+r)*l
            nn = (q*(7*k)+2+(r*l))//(t*l)
            q  *= k
            t  *= l
            l  += 2
            k += 1
            n  = nn
            r  = nr
 
pi_digits = calcPi()
i = 0
j = 0 
for d in pi_digits:
    sys.stdout.write(str(d))
    i += 1
    j += 1
    if j == x:
    	break
    if i == 50:
        print("")
        i = 0

