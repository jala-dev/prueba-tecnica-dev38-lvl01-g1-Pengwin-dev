# Before you start:
* Try not to read ahead.
* Do one task at a time. The trick is to learn to work incrementally.
* Make sure you only test for correct inputs, there is no need to test for invalid inputs.
* Apply any good practice you consider necesary in the code.
* Test First!

# Description
Water is a simple console application for the collection of water consumption for cooperatives in rural areas. The application is currently under development and it has a beta version.
We need your help to complete the functionalities and offer a complete user experience.
 
## Current features
Currently we support the following features:
* Register consumption. The system registers the water consumption for a member code in the system.  
* Get current debt. The system can calculate the total amount owed for a particular member. 
* Get member info. Currently we can return the full name associated to a member code. 

## Pending features to implement
1. Currently, the option 2 only displays the debt amount. Implement changes to display also the member code and total of cubes. Update the message to "El consumo del socio [member-code] es de [total] cubos. La deuda actual es de [amount] Bs."
2. In option 3, when you request a member code that doesn't exist in the system, the applications throws an exception. Fix this behavior and instead of the exception, shows a new message "el codigo ingresado no existe en el sistema".
3. Register new member. We need register new members into the application assigning a name to a member code. Implement the necessary support (UI and backend)
   
    3.1. Implement the register of a new member in the option 4.

    3.2. Update the message in option 2: "El consumo del socio [member-code], correspondiente a [name] es de [total] cubos. La deuda total es de [amount] Bs."

4. Make payment. We need to record the payment of consumption by a partner. Initially, only full payment of debts is allowed. Once paid, the consumptions must be marked as paid and they are not considered in the calculation of the current debt.
   
    4.1. Add a new boolean field called Paid in the consumption class and set the default value as FALSE.

    4.2. Update the calculation of total and amount to only consider records with Paid fields as FALSE.

    4.3. Implement the option 5 (UI)

    4.4. Once you select the code member update the consumption Paid field as TRUE.

### Validations
5. To have a robust application, we need to add certain controls to the information that we include in the system.

    5.1. Member code. A member code always has to be positive and it be a value between 5000 and 5999.

    5.2. Member name. A member names needs 4 chars as minimun length.

    5.3. Consumption. The consumption always is a positive values.

    5.4. Validate that consumption always be associated to an already registered member. Currently the application acepts that any memberID can register consumptions.
     
### Refactoring

6. Menu. Refactor the executeOption method in Watersystem class to avoid the switch clause. Provide a better alternative that helps in the maintainability.

### Reports

7. MemberID and Debts. Create a new option to display a report with following information: MemberID, MemberName and TotalDebt.

### Persistence
Currently all the information is stored on memory, that means data is lost after finishing the application. 

8. Implement a persistence module so that the information is always available when the application is started again.

### Unit testing
There is a unit testing project empty where you can add any test you consider usefull.

9. Add additional unit tests.

# Submit your task
You have 2.5 hours for this assignment, the way to submit your work is:
 * If you have a github account, you can accept the invite the Jalasoft Trainers will send you. By accepting this invite you'll have your GitHub repository ready for you. Clone it and ensure to push your changes when your are ready.
 
 * If you are not familiar with Git repositories or you don't have an account, you can download the project from the next url:
 https://github.com/jala-dev/WACO_DotNet/archive/refs/heads/main.zip
 
 To submit your changes, you can zip your project folder and send it to jose.ecos@fundacion-jala.org before the time limit.
 
 **NOTE:** Please make sure only include project files. 