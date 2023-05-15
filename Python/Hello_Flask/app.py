from flask import Flask
app = Flask(__name__)


@app.route('/')
def hello_world():
    return 'Hello World!'

@app.route('/number')
def numbers():
    return[1,2,3,4,5,32,2,34,3,4]