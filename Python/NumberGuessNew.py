# coded along with Jani


answer = random.randint(1,20)
print(answer)


for round in range(3):
    print("Enter value between 1 and 20:")

    guess_value = int(input())

    if guess_value == answer:
        print(f"You guessed correct the value is {guess_value}")
    elif guess_value < answer:
        print("Your guess was low")
    else:
        print("Your guess was high")

