print("Hello World!")
print(type(123))
print(type("Hello"))
print(type(0.123))
print(type([1,2,3]))

# adds values to the end of the list.
list_val = [1,2,3,4]
list_val.append("Hello")
print(list_val)

# inserts a value into list of a specified location.
list_val.insert(1, "Hello")
print(list_val)

# removes value specified item in the list.
list_val.remove(4)
print(list_val)

# removes item based on index.
list_val.pop(4)
print(list_val)