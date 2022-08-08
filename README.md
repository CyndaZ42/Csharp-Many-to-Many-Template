# _Project Name_

#### By _Zachary Waggoner_

#### _Brief description of application_

---
## Table of Contents
[Technologies Used](#technologies-used)  
[Description](#description)  
[Setup/Installation Requirements](#setup-and-installation-requirements)  
[Known Bugs](#known-bugs)  
[License](#License)

---
## Technologies Used

* _C#_
* _.NET_
* _HTML_
* _CSS_
* _SQL Workbench_
* _Entity Framework_
* _MVC_

---
## Description

_This is a detailed description of your application. Give as much detail as needed to explain what the application does as well as any other information you want users or other developers to have._

---
## Setup and Installation Requirements

<details>
<summary><strong>Initial Setup</strong></summary>  

1. Copy the git repository url: https://github.com/CyndaZ42/ProjectName  
2. Open a shell program and navigate to your desktop.
3. Clone the repository for this project using the `git clone` command and including the copied URL.
4. While still in the shell program, navigate to the root directory of the newly created file named `ProjectName.Solution`.
5. From the root directory, navigate to the `ProjectName` directory.
6. Move onto SQL Workbench instructions below to re-create database necessary to run this project.
</details>

<details>
<summary><strong>SQL Workbench Configuration</strong></summary>

1. Create an `appsetting.json` file in the `ProjectName` directory of the project  
   <pre>ProjectName.Solution
   └── ProjectName
    └── <strong>appsetting.json</strong></pre>
2. Insert the following code [^1]  
    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=project_name;uid=root;pwd=[YOUR-PASSWORD-HERE];"
      }
    }
    ```

3. Once `appsettings.json` file has been created, navigate back to SQL Workbench.
</details>

<details>
<summary><strong>To Run</strong></summary>

1. Navigate to:  
   <pre>ProjectName.Solution
   └── <strong>ProjectName</strong></pre>

2. Run `$ dotnet restore` in the console.  
3. Run `$ dotnet database update` in the console.  
4. Run `$ dotnet run` in the console
</details>

<details>
<summary><strong>For Testing</strong></summary>

1. Navigate to  
    <pre>ProjectName.Solution
    ├── ProjectName
    └── <strong>ProjectName.Tests</strong></pre>

2. Run `$ dotnet test` in the console
</details><br>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

---
## Known Bugs

* Any known bugs
* Should go here

---
## [License](/LICENSE)

_Feel free to reach out via [Github](https://github.com/CyndaZ42) to provide feedback on this project or to view my other projects._

[Copyright](/LICENSE) © 2022 Zachary Waggoner

---
### Footnotes

[^1]: You must include your password in the code block section labeled `YOUR-PASSWORD-HERE`.

