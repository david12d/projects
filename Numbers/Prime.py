"""
**Next Prime Number** - Have the program find prime numbers 
until the user chooses to stop asking for the next one.
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
		if (x < 0):
			print("Sorry, keep it positive Mr Negative.")
			continue
		else: 
			break

print("The first " + str(x) + " prime numbers are: \n")

i = 1
n = 0

# Start a counter n, increment every time a prime number is calculated. Primes are calculated by dividing
# each number by its factors to find if there is a remainder of 0. E.g 6%2 = 0, therefore 6 is not prime.
while n < x:
	if i == 1 or i == 2:
		print(str(i), end = ", ")
		n += 1
		i += 1
		continue
	for j in range(2, i + 1):
		if i % j == 0:
			break
		elif j == i - 1:
			print(str(i), end = ", ")
			n += 1

	if i % 100 == 0:
		print("\n")

	i += 1