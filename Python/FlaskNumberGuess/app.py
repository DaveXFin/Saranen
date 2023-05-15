from flask import Flask,Response
app = Flask(__name__)


@app.route('/')
def hello_world():
    return 'Hello World!'

@app.route("/api/startgame")
def start_game():
    json = '{"status": "Game started"}'
    return Response(json, mimetype='application/json')