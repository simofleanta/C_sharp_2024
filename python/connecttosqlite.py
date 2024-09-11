import sqlite3

# Replace 'abc.sqlite' with the path to your SQLite database file
database_path = 'demoDb.sqlite'

# Connect to the SQLite database
connection = sqlite3.connect(database_path)

# Create a cursor object using the connection
cursor = connection.cursor()

# Retrieve data from the Artist table
cursor.execute('SELECT * FROM clusters c ')
rows = cursor.fetchall()

# Print the results
for row in rows:
    print(row)

# Close the connection
connection.close()
