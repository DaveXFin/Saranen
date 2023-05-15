from flask import Flask,Response, request
import random

app = Flask(__name__)
answer=0

@app.route('/')
def hello_world():
    return 'Hello World!'

@app.route("/api/startgame")
def start_game():
    answer = random.randint(1,20)
    print(answer)
    json = '{"status": "Game started"}'
    return Response(json, mimetype='application/json')

@app.route("/api/guess")
# chekcs the guess answer
def checkguess():
    guess =  int(request.args.get('guess', '0'))
    print(guess)

    statusText = ""

    if (guess == answer):
        statusText = "Correct! You win the game!"
    elif (guess < answer):
        statusText = "The correct number is larger."
    else:
        statusText = "The correct number is smaller."

    json = '{ "guess": "' + str(guess) + '", "status": "' + statusText + '" }'
    return Response(json, mimetype='application/json')

