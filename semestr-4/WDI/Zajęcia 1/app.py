import flask

app = flask.Flask(__name__, static_url_path='')

@app.route('/', methods=['GET'])
def index():
    return open('index.html', encoding='utf-8').read()

@app.route('/', methods=['POST'])
def post():
    print(flask.request.form)
    return flask.Response(status=200)

if __name__ == '__main__':
    app.run(port=80, debug=True)