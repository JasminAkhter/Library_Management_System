# 📚 Library Management System API

An ASP.NET Core Web API project for managing a library's core operations including books, authors, members, borrow/return records, and penalties.

---

## 🛠 Technologies Used

- **.NET Core 8** (based on your setup)
- **Entity Framework Core**
- **SQL Server**
- **Swagger** (for API testing)
- **Visual Studio**
- **Git & GitHub**

---

## 🧱 Features

- ✅ Manage Books (Add, Update, Delete, Search)
- ✅ Manage Authors and Publishers
- ✅ Categorize books into Genres
- ✅ Register Members and track membership
- ✅ Issue and Return Books
- ✅ Auto-calculate availability of books
- ✅ Penalty system for late returns
- ✅ RESTful API with proper routing and responses

---
## 🧩 Database Models

- **Book**: Title, ISBN, Author, Publisher, Category, Total & Available Copies
- **Author**: Name, Bio
- **Publisher**: Name, Address
- **Category**: Name
- **Member**: Name, Email, Phone, Join Date
- **BorrowRecord**: Book, Member, Borrow & Return Dates, Status
- **Penalty** *(optional)*: BorrowId, Amount, Date, Paid Status

---

## 🔌 Getting Started

### 1️⃣ Clone the Repository
git clone https://github.com/your-username/library-management-system.git
cd library-management-system


2️⃣ Update DB Connection
Update your appsettings.json file with your local SQL Server connection string:

json
Copy
Edit
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=LibraryDB;Trusted_Connection=True;"
}


3️⃣ Run EF Core Migrations
dotnet ef migrations add InitialCreate
dotnet ef database update


4️⃣ Run the API
dotnet run
Open your browser or Postman at:
https://localhost:5001/swagger
