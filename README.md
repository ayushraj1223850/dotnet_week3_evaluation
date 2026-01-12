# Payroll & Order Processing System  
(OOPS + Generic Collections + Delegates | .NET Console Application)

---

## Overview

This repository contains two console-based applications developed in C# to demonstrate core **Object-Oriented Programming (OOPS)** concepts along with **Generic Collections** and **Delegates**.

Both use cases are implemented using clean design principles, in-memory data storage, and delegate-based notifications, as required for enterprise-level training and evaluation.

---

## Use Case 1: Payroll System

### Description
A payroll processing system that calculates employee salaries based on employee type and notifies HR and Finance teams after salary processing.

### Key Features
- Abstract base class `Employee`
- Derived classes:
  - `FullTimeEmployee`
  - `ContractEmployee`
- Salary calculation using **runtime polymorphism**
- `EmployeeRepository` for managing employee data (in-memory)
- `PayrollProcessor` for payroll logic
- Multicast delegates to notify:
  - HR
  - Finance
- Payroll summary report:
  - Total employees processed
  - Total salary payout
- Input validation for invalid salary data

### Concepts Demonstrated
- Inheritance and Polymorphism
- Encapsulation
- Generic Collections (`List<T>`)
- Delegates (`Action<T>`)
- Repository Pattern
- Static in-memory data storage

---

## Use Case 2: Order Processing System

### Description
An online order processing system that manages orders, tracks order status changes, and notifies customers and logistics teams during the order lifecycle.

### Key Features
- Core domain classes:
  - `Product`
  - `Customer`
  - `Order`
  - `OrderItem`
- Order lifecycle handled using `OrderStatus` enum
- Status history maintained using `OrderStatusLog`
- `OrderRepository` to manage orders and sample data
- `OrderService` to enforce business rules
- Valid order status flow:
  - Created → Paid → Packed → Shipped → Delivered
- Multicast delegate notifications:
  - Customer notification
  - Logistics notification
- Console output with full order status timeline

### Concepts Demonstrated
- Composition (`Order` has `OrderItems`)
- Enum-based state management
- Generic Collections (`Dictionary<TKey, TValue>`, `List<T>`)
- Delegates for decoupled notifications
- Repository Pattern
- Business rule validation

---
## Project Structure
WEEK_EVAL3
│
├── PayrollSystem
│ ├── Employee.cs
│ ├── FullTimeEmployee.cs
│ ├── ContractEmployee.cs
│ ├── PaySlip.cs
│ ├── EmployeeRepository.cs
│ ├── PayrollProcessor.cs
│ ├── Notifications.cs
│ └── Program.cs
│
├── OrderProcessingSystem
│ ├── Product.cs
│ ├── Customer.cs
│ ├── Order.cs
│ ├── OrderItem.cs
│ ├── OrderStatus.cs
│ ├── OrderStatusLog.cs
│ ├── OrderRepository.cs
│ ├── OrderService.cs
│ ├── Notifications.cs
│ └── Program.cs
│
└── .gitignore
---

## How to Run

### Prerequisites
- .NET SDK 6.0 or later
- Command Prompt or PowerShell

### Run Payroll System
```bash
cd PayrollSystem
dotnet run
cd OrderProcessingSystem
dotnet run



