# Coded along with Jani
import sqlite3

# functions that retrives the finnish cutomers 
def list_finnish_customers(con):

    cur = con.cursor()
    cur.execute("SELECT * FROM Customers WhERE Country = 'Finland'")

    rows = cur.fetchall()
    for row in rows:
        print(row)


print("Accessing the northwind database.")

# establishing connection with database
con = sqlite3.connect("..\\Databases\\northwind.db")

# executing the function
list_finnish_customers(con)

# close the connection tot he database
con.close()
print("End.")