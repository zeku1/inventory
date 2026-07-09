# Product Requirements Document (PRD)

## Project Information

**Project Title:** Inventory Management ERP

**Student:** LABRA

## Technology Stack

-   Frontend: C# (.NET Windows Forms / WPF / ASP.NET MVC)
-   Backend: C#
-   Database: Microsoft SQL Server
-   ORM: Entity Framework (Recommended)
-   Reporting: RDLC / Crystal Reports

# 1. Product Overview

The Inventory Management ERP is a desktop/web-based application designed
to help businesses efficiently manage products, inventory, suppliers,
purchasing, and sales.

The system minimizes manual inventory tracking while providing real-time
stock monitoring and reporting.

# 2. Objectives

-   Track inventory accurately
-   Reduce stock shortages
-   Record purchases and sales
-   Manage supplier information
-   Generate inventory reports
-   Notify users of low-stock products

# 3. Target Users

## Administrator

-   Manage users
-   Manage products
-   Manage suppliers
-   View reports
-   Configure settings

## Inventory Staff

-   Stock In
-   Stock Out
-   Purchase Entry
-   Inventory Monitoring

## Sales Staff

-   Record sales
-   View available products
-   Print receipts

# 4. Functional Requirements

## Module 1 -- Product Management

-   Add, Edit, Delete, Search Products
-   Categorize Products
-   Barcode Support (Optional)

### Product Fields

-   Product Code
-   Product Name
-   Category
-   Unit
-   Selling Price
-   Cost Price
-   Current Stock
-   Reorder Level
-   Status

## Module 2 -- Stock In / Stock Out

### Stock In

-   Receive Products
-   Update Stock
-   Record Supplier
-   Record Purchase Reference

### Stock Out

-   Remove Stock
-   Record Reason
-   Update Inventory Automatically

Reasons:

-   Sales
-   Damaged
-   Expired
-   Adjustment

## Module 3 -- Supplier Management

-   Add Supplier
-   Edit Supplier
-   Delete Supplier
-   Search Supplier

Supplier Information:

-   Supplier ID
-   Company Name
-   Contact Person
-   Phone Number
-   Email
-   Address

## Module 4 -- Purchase Management

-   Create Purchase Orders
-   Add Products
-   Compute Total Cost
-   Receive Deliveries
-   Update Inventory

Purchase Status:

-   Pending
-   Received
-   Cancelled

## Module 5 -- Sales Management

-   New Sale
-   Product Search
-   Quantity Selection
-   Automatic Total
-   Receipt Printing

Sales Information:

-   Invoice Number
-   Customer Name (Optional)
-   Products
-   Quantity
-   Total
-   Payment
-   Change

## Module 6 -- Low Stock Alert

The system shall:

-   Display dashboard notifications
-   Highlight low-stock products
-   Generate low-stock reports

Condition:

Current Stock ≤ Reorder Level

## Module 7 -- Reports Module

-   Inventory Report
-   Sales Report (Daily, Weekly, Monthly, Yearly)
-   Purchase Report
-   Supplier Report
-   Low Stock Report

# 5. Non-Functional Requirements

## Performance

-   Response time under 3 seconds
-   Support 10--30 concurrent users
-   Fast report generation

## Security

-   User Login
-   Password Encryption
-   Role-Based Access Control
-   SQL Injection Protection
-   Activity Logging

## Reliability

-   Automatic transaction rollback
-   Daily database backup
-   Data validation

## Usability

-   User-friendly interface
-   Simple navigation
-   Search functionality

## Compatibility

-   Windows 10/11
-   SQL Server 2019+
-   .NET 8

# 6. Database Requirements

Main Tables:

-   Users
-   Products
-   Categories
-   Suppliers
-   Purchases
-   PurchaseDetails
-   Sales
-   SaleDetails
-   StockTransactions

# 7. Business Rules

-   Product codes must be unique.
-   Stock cannot become negative.
-   Every stock movement must be recorded.
-   Purchases increase inventory automatically.
-   Sales decrease inventory automatically.
-   Suppliers with purchase history cannot be deleted.
-   Low stock is based on the reorder level.

# 8. Future Enhancements

-   Barcode Scanner Integration
-   QR Code Support
-   Mobile Inventory App
-   Multi-Branch Inventory
-   Cloud Backup
-   Email Notifications
-   Dashboard Analytics
-   Supplier Purchase Forecasting
