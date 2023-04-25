import random

print("Welcome to a guessing game. Guess a number from 1-20, be catious you only have three guesses!")

guess1 = int(input("First guess: "))

generate_val = random.randint(1,20)

number_guess = 0

while number_guess < 3:
    if guess1 == generate_val:
        print(f"Your first guess correct, the value is {generate_val}")
        break
    elif guess1 != generate_val:
        print("Your first guess was incorrect \n")
        guess2 = int(input("Second guess: "))
        number_guess += 1
        if guess2 == generate_val:
            print(f"Your second guess is correct, the value is {generate_val}")
            break
        elif guess2 != generate_val:
            print("Your second guess was incorrect \n")
            guess3 = int(input("Third guess and final be catious: "))
            number_guess += 1
            if guess3 == generate_val:
                print(f"Your third guess is correct, the value is {generate_val}")
                break
            elif guess3 != generate_val:
                print("All three guesses were incorrect. Better luck next time!")
                number_guess += 1
            