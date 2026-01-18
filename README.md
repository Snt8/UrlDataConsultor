# URL Data Consultor

**URL Data Consultor** is a lightweight tool designed to monitor and analyze the status of your web services. 

I developed this tool for users who need to verify their website's availability and performance quickly and efficiently.

---

### Key Features

* **Asynchronous Execution**: Built with a fully asynchronous architecture, leveraging .NET `async` and `await` keywords to ensure non-blocking I/O operations.

* **SOLID Principles**: Developed following SOLID principles to ensure the codebase is easy to maintain, test, and update.

* **Detailed Reporting**: Generates a comprehensive JSON report containing status codes, response times, and error details for every consult.

### Tech Stack
* **Runtime**: .NET 10
* **Language**: C# 14
* **Libraries**: 
    * `System.Text.Json` for data serialization.
    * `System.Net.Http` for web requests and connectivity checks.

---

### How To Run

#### **Prerequisites**
* Ensure you have the **.NET 10 SDK** installed (verify with `dotnet --version`).

#### **Setup**

1. **Clone the repository** to your local machine.

2. **Navigate** to the project root directory.
3. **Prepare the input**: Create or edit a file named `test.txt` inside `src/UrlProcessor.App/`.
4. **Add URLs**: List the URLs you want to check (one per line).

#### **Execution**
Open your terminal inside src/UrlProcessor.App and run:
```bash

dotnet run