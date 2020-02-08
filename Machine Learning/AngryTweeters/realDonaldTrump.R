# Title     : TODO
# Objective : TODO
# Created by: david
# Created on: 08-Feb-20

install.packages("rjson")

# Load the package required to read JSON files.
library("rjson")

# Give the input file name to the function.
result <- fromJSON(file = "input.json")

# Print the result.
print(result)