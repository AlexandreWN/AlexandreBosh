import dash
from dash.dependencies import Output, Input
import dash_core_components as dcc
import dash_html_components as html
import plotly
import plotly.graph_objs as go
from collections import deque
import requests


def tempDados():
    proxies = {'https':"https://disrct:saladigital0311@10.224.200.26:8080"}
    url_temperatura = 'https://prova-93832-default-rtdb.firebaseio.com/Sensor/temperatura.json'
    temperatura_data = float(requests.get(url_temperatura, proxies=proxies).content)
    return temperatura_data

def umiDados():
    proxies = {'https':"https://disrct:saladigital0311@10.224.200.26:8080"}
    url_umidade = 'https://prova-93832-default-rtdb.firebaseio.com/Sensor/umidade.json'
    umidade_data = float(requests.get(url_umidade, proxies=proxies).content)
    return umidade_data

X = deque(maxlen = 2000)
X.append(0)
  
Y = deque(maxlen = 200)
  
app = dash.Dash(__name__)



  
colors = {
    'background': '#111111',
    'text': '#7FDBFF'
    }
app.layout = html.Div(
    [
        dcc.Graph(id = 'live-graph', animate = True),
        dcc.Interval(
            id = 'graph-update',
            interval = 30000,
            n_intervals = 1
        ),
        html.H1(
        children='Grafico De Temperatura',
        style={
            'textAlign': 'center',
            'color': colors['text']
              }
        ),
        html.H1(
        children='A Cada 30 Segundos',
        style={
            'textAlign': 'center',
            'color': colors['text']
              }
        )
    ]
)
  
@app.callback(
    Output('live-graph', 'figure'),
    [ Input('graph-update', 'n_intervals') ]
)
  
def update_graph_scatter(n):
    X.append(X[-1]+5)
    Y.append(tempDados())
  
    data = plotly.graph_objs.Scatter(
            x=list(X),
            y=list(Y),
            name='Scatter',
            mode= 'lines+markers'
    )
  
    return {'data': [data],
            'layout' : go.Layout(xaxis=dict(range=[min(X),max(X)]),yaxis = dict(range = [min(Y),max(Y)]),)}
  
    
if __name__ == '__main__':
    app.run_server(debug=False)