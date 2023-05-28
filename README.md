# TopScorer
This program which takes as input a CSV file listing people and the score they achieved in a test, 
and which outputs the top scorers, those people with the highest marks, as well as what that mark was.

Detailed explanation of the design choices and assumptions made in the application:

1. **Separation of Concerns**: The code is structured using a simple modular approach with separate functions for reading the CSV file, Getting the scores, finding the highest scorers, and getting the highest score. This makes the code more organized, readable, and maintainable.

2. **CSV Parsing**: The CSV parsing is implemented manually without using standard libraries to adhere to the requirement of not using CSV-parsing libraries. The code splits each line using the comma as the delimiter and checks if it contains two parts (name and score). It then attempts to parse the score as an integer and stores it in a dictionary. Invalid or duplicate data entries are handled with appropriate error messages.

3. **Data Structure**: The scores are stored in a Dictionary<string, int> where the name of the person is the key, and the score is the value. Using a dictionary allows easy access to scores by name and efficient retrieval of the highest score.

4. **Top Scorers**: The code determines the highest score and then iterates over the scores dictionary to find all the names with that score. The names of the top scorers are stored in a list and sorted alphabetically to fulfill the requirement of outputting them in alphabetical order.

5. **Error Handling**: The code includes basic error handling to handle exceptions that may occur while reading the CSV file or parsing the data. It displays appropriate error messages to provide feedback to the user.

Instructions to run the application:

1. Clone the repository: On the GitHub website, navigate to the repository containing the console application.  

2. Open the project in Visual Studio: Launch Visual Studio and go to `File -> Open -> Project/Solution`. Navigate to the cloned repository directory and select the solution file (usually ending with `.sln`) of your console application. Click "Open" to load the project.

3. Build the project: Once the project is opened in Visual Studio, go to `Build -> Build Solution` or press `Ctrl + Shift + B` to build the application. This step compiles the source code and generates the executable file.

4. Run the application. The application will run in the console window, and you can provide any necessary input or interact with the program as required.

   Alternatively, you can run the application directly from the command prompt or terminal by navigating to the project's output directory (usually located inside the `bin` directory of the project) and executing the executable file.


By following these steps, you should be able to clone, build, and run the console application using Visual Studio.
