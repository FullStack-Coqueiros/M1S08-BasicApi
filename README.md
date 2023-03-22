# Api Basica

Projetinho para maior compreenção inicial do conceito de apis.

Rotas: 

## /Cliente 
```GET http://localhost:5000/clientes```
```GET http://localhost:5000/clientes?nome=Vitor```

## /Cliente/{id}
```GET http://localhost:5000/clientes/5```
```GET http://localhost:5000/clientes/5?nome=Vitor```

## /Cliente/id/{id}
```GET http://localhost:5000/clientes/id/5```
```GET http://localhost:5000/clientes/id/5?nome=Vitor```


## Veiculos 
Consultar Veículos
```GET http://localhost:5000/veiculos```
```GET http://localhost:5000/veiculos?carro=Clio```


Cadastrar Veículos
```POST http://localhost:5000/veiculos?carro=Clio```

Excluir Veículos
```DELETE http://localhost:5000/veiculos?carro=Clio```

