""" **Fibonacci Sequence** - 
Enter a number and have the program generate the Fibonacci sequence to that number or to the Nth number.
"""

import sys

print("This program is a Fibonacci Sequence Generator.\n")

 while True:
    try:
        x = (int) input("Enter a number")
    except ValueError:
        print("Sorry, enter a whole number please")
        continue
    else: 
        break

i = 0  
n = 1
m = 1
for a to x:
    print(n)
    n = m
    m += n
    i += 1
    if i == 50:
        print("")
