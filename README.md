
# RetailStore
## Problem Statement: 
On a retail website, the following discounts apply: 
1. If the user is an employee of the store, he gets a 30% discount 
2. If the user is an affiliate of the store, he gets a 10% discount 
3. If the user has been a customer for over 2 years, he gets a 5% discount. 
4. For every $100 on the bill, there would be a $ 5 discount (e.g. for $ 990, you get $ 45 as a discount). 
5. The percentage based discounts do not apply on groceries. 
6. A user can get only one of the percentage based discounts on a bill. 

Write a program in a programming language of your choice with test cases such that given a bill, it finds the net payable amount.

## Solution Details:
- The solution has been built using Visual Studio 2017. The target runtime version is .NET Core 2.0, so you need this version installed on the target machine.
- The solution consists of just 2 class libraries, their details as follows:
	>	RetailStore, the main project where the core logic is implemented. I have opted for Class Library project type since we do not require any client code. 
	
	>	RetailStore.Tests, is also a Class Library project generated from xUnit Test Project template provided by VS 2017 which has preinstalled xUnit testing framework for creating and running tests. Currently, there are 15 tests which cover all the major scenarios and it's very simple to follow them and understand the code easily.
- To run the tests, open Test Explorer using VS menu - 'Test' -> 'Windows' -> 'Test Explorer' -> 'Run All'. This will build the solution first after downloading all required package dependencies and then run the unit tests. If all goes well, you will see all the tests becoming green.  
- For test coverage, you can get the coverage result from inside VS using 'Test' -> 'Windows' -> 'Test Coverage Results'.
  
