# Modern C# Web API Starter: Controller-Service-Repository Pattern

This repository contains the complete starter code for the **C# Web API Tutorial for Beginners**. It demonstrates how to build a production-ready REST API using modern .NET standards and clean architecture.

## 📂 Project Architecture Layout

To keep your codebase clean and maintainable, organize your project files into the following directory structure:

```text
MyWebApi/
│
├── Controllers/
│   └── ProductsController.cs       # Layer 3: Handles HTTP requests & responses
│
├── Models/
│   └── Product.cs                  # Data structure representing our entity
│
├── Repositories/
│   ├── IProductRepository.cs       # Data access blueprint
│   └── ProductRepository.cs        # Layer 1: In-memory mock database implementation
│
├── Services/
│   ├── IProductService.cs          # Business logic blueprint
│   └── ProductService.cs           # Layer 2: Core business validation rules
│
├── Program.cs                      # Application startup & Dependency Injection glue
└── appsettings.json                # Configuration settings
```

---

## 🛠️ The Core Model: `Product.cs`

Create a folder named `Models` in the root of your project and add the following file:

```csharp
// Models/Product.cs
namespace MyWebApi.Models
{
    public class Product
    {
        /// <summary>
        /// Unique identifier for the product
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the product (e.g., Laptop, Mouse)
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Product price. Must be greater than zero.
        /// </summary>
        public decimal Price { get; set; }
    }
}
```

---

## 🚀 How to Run This Project Local

### Prerequisites
* 安装 [.NET SDK](https://dotnet.microsoft.com/download) (Version 8.0 or later recommended)
* 安装 [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

### Steps to Run
1. Clone this repository to your local machine.
2. Open your terminal in the root folder containing the `.csproj` file.
3. Run the application using the dotnet CLI:
   ```bash
   dotnet run
   ```
4. Open your browser and navigate to the local Swagger URL displayed in your console (typically `https://localhost:7xxx/swagger`) to test the endpoints live!

---

## 📺 Video Reference
This code accompanies the step-by-step tutorial series on building clean APIs. In the next module, we will replace the in-memory mock repository with a real SQL Database using **Entity Framework Core**. 

*If you found this useful, don't forget to star this repository! ⭐*
