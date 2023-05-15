from flask import Flask, request, render_template
import random

app = Flask(__name__)
CORS(app)




@app.route('/')
def home():
    return('print("Welcome to a guessing game. Guess a number from 1-20, be catious you only have three guesses!")')



@app.route('/guess', methods=['POST'])
def guess():
    num_guess = 0
    while num_guess<3:
        guess = int(request.form['guess'])
        answer = random.randint(1, 20)
        if guess == answer:
            result = "You win!"
        elif guess < answer:
            result = "Your guess was low"
        else:
            result = "Your guess was high"
        num_guess += 1
            