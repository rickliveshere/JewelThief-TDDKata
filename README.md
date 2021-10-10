# Jewel Thief TDD Kata
Based on the following code kata found at https://www.codewars.com/kata/5954584610080b7252000003/javascript


## TASK
Some people have long queues in front of the cash machine. Some people need to withdraw money. They are ordinary people; Some people want to steal other people's money, yes, they are thieves ;-) Some people are policemen. They are looking for thieves.

Given a queue in string format, like this: "X1X#2X#XX". # represents the ordinary people; "X" represents the thief; digit 1-9 represents the policeman. The numerical value represents the police's watching range. For example, 1 means the police could see 1 people in front of him and 1 people in the back.

All the thieves in the line of sight of the police will be caught!

Your task is to calculate the number of thieves who have been caught.

###  EXAMPLE
For queue = `X1X#2X#XX` the output should be 3.

For queue = `X5X#3X###XXXX##1#X1X` the output should be 5.

For queue = `X#X1#X9XX` the output should be 5.

## Get Started
Open the `TDDKatas.sln` in Visual Studio and build the solution. Upon first build, NuGet dependencies will download and install.

View and run unit tests using Test Explorer, or the xUnit Test Runner.

Run the `JewelThief`console application to see output from the excercise.