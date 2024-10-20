## Purpose
Our Application is used as a Marketing App. In this  One seller is able to Sell the Products to buyer.

## Roles & Functionality

### Admin

> Add & Edit Category

- Admin will able To add Category and also Edit the Category

> See User Review and Ban User

- Admin  is able to See the Review about Product Written by Users
- If Admin Found  unwanted behaviour from  user then he is able to Ban  that Particuler User and He also have rights to Unban users

### Customer

> Create Products

- Customer is able to create Products for Selling Purpose.

 > See Products

- Customer is able to see their created Products as well as products bought by them and products sell by them
- Customer can review the seller as well
- customer caan Edit their Profile

  

## How to Run this project ?

> Clone this Repository
> 
git clone https://github.com/Nana-4gohil/MarketApp.git


### 1. appsettings.json

json
 "ConnectionStrings": {
   "DefaultConnection": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Database=MarketDB;Integrated Security=True;Connect 
    Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"
 },


### 2. Install Nuget Packages


Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.Design

Microsoft.AspNetCore.Identity.EntityFrameworkCore


### 3. Create Database Model

> You can go with only *update-database* if you have *Migrations* folder


add-migration "message"
update-database


## Tech Stack

| Application        | Tech                  |
| ------------------ | --------------------- |
| Backend / Frontend | ASP .NET 5 / Boostrap |
| DataBase           | SQL (SSMS)            |

> Team members


<table>
  <tr>
    <td align="center">
        <a href="https://github.com/Nana-4gohil/MarketApp.git">
            <br />
            <sub><b>Hadiyal Mehul</b></sub>
        </a>
        <br />
    </td>
    <td align="center">
        <a href="https://github.com/Nana-4gohil/MarketApp.git">
            <br />
            <sub><b>Gohil Nana</b></sub>
        </a>
        <br />
    </td>
    </tr>
</table>
