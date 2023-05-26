# How to start coding

1. **Fork this Repository**
   - Click on the "Fork" button in the upper right-hand corner of the page. This will create a copy of the repository in your GitHub account.

2. **Clone the Repository to Your Local Drive**
   - Go to your forked repository on GitHub.
   - Click the "Code" button and copy the HTTPS or SSH URL.
   - Open a terminal or command prompt on your local machine.
   - Navigate to the directory where you want to store the local copy of the repository.
   - Run the following command to clone the repository: `git clone <REPOSITORY_URL>`
   - Replace `<REPOSITORY_URL>` with the URL you copied earlier.

3. **Open the Repository in Visual Studio Code**
   - Open Visual Studio Code.
   - Click "Open Folder" or go to File > Open Folder.
   - Navigate to the directory where you cloned the repository, and select the folder containing the repository.
   - Click "Open" to open the repository in Visual Studio Code.

4. **Open the Repository from Command Prompt**
   - Open a terminal or command prompt on your local machine.
   - Navigate to the directory where you cloned the repository.
   - Type `code .` and press Enter. This will open the repository in Visual Studio Code.

5. **Start Coding**
   - Once the repository is open in Visual Studio Code, you can start coding by opening or creating files in the Explorer panel on the left side.
   - To commit and push your changes to your forked repository, use the Source Control panel (click the Git icon in the left sidebar) to stage, commit, and push your changes.

6. **Using Code Spaces**
   - Go to your forked repository on GitHub.
   - Click the "Code" button and then click the "Open with Codespaces" dropdown.
   - Select "New codespace" or choose an existing codespace to open the repository in a web-based development environment.
   - Start coding in the codespace. Your changes will be saved in your forked repository. You can also commit and push your changes from the codespace.

## Recommended Visual Studio Code Extensions

- To improve your development experience in Visual Studio Code, consider installing the following recommended extensions:

  - *C#*: This extension provides support for C# syntax highlighting, IntelliSense, debugging, and more. It was developed and maintained by Microsoft.

  - *C# Extensions*: This extension offers additional features for C# development, such as the ability to generate code snippets, create classes, and more.

  - *Roslynator*: Roslynator is a collection of code analyzers, refactorings, and fixes for C#. It helps you write more efficient and maintainable code.

  - *Test Adapter Converter*: This extension allows you to use test adapters initially developed for Visual Studio in Visual Studio Code. This is useful if you are working with a testing framework that does not have a dedicated extension for Visual Studio Code.

  - *Test Explorer UI*: This extension provides a user interface for running and debugging tests in Visual Studio Code. It supports many testing frameworks and can be extended with additional test adapters.

## Running the code and tests

### Running the Code using `dotnet run`
  
  1. Open a terminal window.
  2. Navigate to the directory containing the `Program.cs` file.
  3. Run the program by executing the following command:

      ``` bash
      dotnet run
      ```

### Running Tests
  
 1. Open a terminal window.
 2. Navigate to the root directory of the solution.
 3. Run the tests by executing the following command:

    ```bash
    dotnet test
    ```

### Using `dotnet-format`

   `dotnet-format` is a code formatter for C#. It can automatically format your code according to the rules specified in `.editorconfig`.

   1. Install the `dotnet-format` tool globally by running the following command:

      ```bash
      dotnet tool install -g dotnet-format
      ```

   2. Navigate to the root directory of the solution.
   3. Run the `dotnet-format` tool on the solution by executing the following command:

      ```bash
      dotnet format
      ```
