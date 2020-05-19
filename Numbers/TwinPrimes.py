"""
**Twin Primes** - Have the program find n twin primes
"""

import math
import sys
from datetime import datetime

startTime = datetime.now()

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

print("The first " + str(x) + " twin prime pairs are: \n")

i = 2
lastPrime = 1
n = 0

# Start a counter n, increment every time a twin prime is found. Primes are calculated by dividing
# each number by its factors to find if there is a remainder of 0. E.g 6%2 = 0, therefore 6 is not prime.
# Twin primes are found by saving a prime in storage and comaparing with a new prime
while n < x:
	if i % 2 == 0:
		i += 1
		continue
	for j in range(2, i):
		if i % j == 0:
			break
		elif j == i - 1:
			if i - lastPrime == 2:
				print('"' + str(lastPrime) + ", " + str(i) + '"', end = '\n')
				n += 1
			lastPrime = i

	i += 2

print('The ' + str(x) + 'th twin prime pair is "' + str(lastPrime) + ", " + str(i) + '"')
print(datetime.now() - startTime)