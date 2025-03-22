# 💰 Budget Buddy

**Budget Buddy** is a smart personal finance management app built with **ASP.NET Core MVC**. It helps users track their income, expenses, and transaction history with an intuitive dashboard — all while keeping performance and simplicity at the forefront.

---

## 🚀 Features

- 📊 **Interactive Dashboard** – Real-time tracking of balances and transaction summaries
- 💸 **Transaction Manager** – Add, edit, delete income/expenses
- 🧾 **Category Management** – Classify expenses for better insights
- 💡 Built with clean MVC architecture for maintainability and scalability
- 🔐 Secure by design: ready for authentication and role-based enhancements

---

## 🧰 Tech Stack

- **Backend**: ASP.NET Core MVC (.NET 8)
- **Database**: Entity Framework Core + Migrations
- **Views**: Razor Pages
- **Frontend**: Bootstrap 5, jQuery (optional JS)
- **ORM**: EF Core with LINQ-based queries
- **Environment Config**: `appsettings.json`

---


## 🛠️ Getting Started (Local Setup)

1. Clone the repository  
2. Create your local database connection string in `appsettings.json`  
3. Run EF Core migrations:
   ```bash
   dotnet ef database update
dotnet run

## ✨ Coming Soon

- 🔐 **User Authentication** – Integration with ASP.NET Identity for login & user-level security
- 🧠 **Smart Budget Limits** – Set monthly caps and track spending trends
- ⏰ **Expense Reminders** – Never forget a bill again
