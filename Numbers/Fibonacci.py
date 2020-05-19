""" **Fibonacci Sequence** - 
Enter a number and have the program generate the Fibonacci sequence to that number or to the Nth number.
"""

import sys

print("This program is a Fibonacci Sequence Generator.\n")

while True:
    try:
        x = int(input("Enter a number: \n"))
        if x < 0:
            continue
    except ValueError:
        print("Sorry, enter a whole number please")
        continue
    else: 
        break


n = 1
m = 1
result = 1
print("1, ")
for a in range(0, x):
    print(result,end = ", ")
    n = m
    m = result
    result = n + m
