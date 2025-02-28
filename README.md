# Amazon.sa Order Management System

## Overview
This is a basic Amazon.sa web application built using ASP.NET Core MVC. The system allows users to browse products, place orders, and view order history. It follows the MVC architecture, implementing models, views, and controllers to manage user interactions and data processing.

## Features
- **Product Management**: Displays a list of available products with details such as category, price, and stock quantity.
- **Order Placement**: Allows users to place orders for available products.
- **Order History**: Users can view a list of their previous orders.
- **Model Validation**: Ensures proper user input validation when placing an order.
- **Routing**: Uses attribute-based routing to handle requests effectively.

## Technologies Used
- **ASP.NET Core MVC** (.NET Core 8/9)
- **C#** for backend logic
- **Razor Views** for frontend rendering
- **Bootstrap** for styling
- **Entity-based model structure**

## Installation & Setup
### Prerequisites
- Install **.NET SDK (8 or 9)**
- Install **Visual Studio 2022+** with ASP.NET Core development workload

### Steps to Run the Application
1. Clone the repository:
   ```bash
   git clone https://github.com/your-repository-url.git
   ```
2. Navigate to the project directory:
   ```bash
   cd AmazonOrderSystem
   ```
3. Restore dependencies:
   ```bash
   dotnet restore
   ```
4. Build the project:
   ```bash
   dotnet build
   ```
5. Run the application:
   ```bash
   dotnet run
   ```
6. Open your browser and navigate to `http://localhost:5000/`

## Project Structure
```
AmazonOrderSystem/
│── Controllers/
│   ├── OrderController.cs
│   ├── ProductController.cs
│── Models/
│   ├── Order.cs
│   ├── OrderDetails.cs
│   ├── Product.cs
│   ├── User.cs
│── Views/
│   ├── Order/
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   ├── Product/
│   │   ├── Index.cshtml
│── Program.cs
│── appsettings.json
│── Startup.cs
│── README.md
```

## Endpoints
| HTTP Method | Route                 | Description |
|------------|----------------------|-------------|
| GET        | `/Products`          | Fetch all products |
| GET        | `/Orders/{userId}`   | View order history of a user |
| GET        | `/Order/Create`      | Show order placement form |
| POST       | `/Order/Create`      | Place a new order |

## Usage Guide
1. **View Products**:
   - Navigate to `http://localhost:5000/Products`
   - View all available products along with their details.

2. **Place an Order**:
   - Go to `http://localhost:5000/Order/Create`
   - Select a product, specify quantity, and submit the form.

3. **View Order History**:
   - Navigate to `http://localhost:5000/Orders/{userId}` replacing `{userId}` with the actual user ID.

## Future Improvements
- Implement authentication and user roles.
- Connect to a real database using Entity Framework.
- Add an admin panel for managing products and orders.
- Improve UI with a modern design framework.

