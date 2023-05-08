// Coded along with Jani.
// rememebr to run npm install.

const sqlite3 = require('sqlite3');
const db = new sqlite3.Database('../Databases/northwind.db');



const readline = require('readline').createInterface({
    input: process.stdin,
    output: process.stdout,
});
readline.question(`Please select your choice:
        1. List Finnish customers
        2. List London employees
        3. List Tofu sales.
        Please enter your choice (1-3): `, choice => {
    console.log(`You selected choice ${choice}.`);
    readline.close();

    
    switch (choice) {
        case "1":
            listFinnishCustomers();
            break
        case "2":
            listEmployeesInLondon();
            break
        case "3":
            listTofuSales();
            break
    }
});

// Used to test the functions
// listFinnishCustomers();

// listEployeesInLondon();

// listTofuSales();






function listFinnishCustomers() {
    const sql = "SELECT * FROM Customers WHERE Country = 'Finland'";
    db.all(sql, (err, rows) => {
        rows.forEach(row => {
            console.log(row.CompanyName);
           
        });
        console.log("--------------------")
    });
}

function listEmployeesInLondon() {
    const sql = "SELECT * FROM Employees WHERE City = 'London'";
    db.all(sql, (err, rows) => {
        rows.forEach(row => {
            console.log(row.FirstName + " " + row.LastName);
        });
        console.log("--------------------")
    });
}

function listTofuSales() {
    const sql = `SELECT SUM(UnitPrice * Quantity * (1-Discount)) AS TofuSales
                 FROM [Order Details]
                 WHERE ProductID IN (SELECT ProductID
                                     FROM Products
                                     WHERE ProductName LIKE '%Tofu%')`;
    db.all(sql, (err, rows) => {
        rows.forEach(row => {
            console.log(row.TofuSales);
        });
        console.log("--------------------")
    });
}