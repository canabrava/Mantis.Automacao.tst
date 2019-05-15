Feature: Criar novo projeto

	Como: Administrador
	Quero: Criar um novo projeto
	Para: Pessoas trabalharem nele


Background: 
	Given eu esteja logado como administrador

Scenario Outline: Criar um novo projeto
	And entre na tela de criar novo projeto
	When eu preencher as informacoes do novo projeto: '<NOME_PROJETO>', '<ESTADO>', '<VISIBILIDADE>', '<DESCRICAO>'
	And clicar para criar um novo projeto
	Then eu devo ver a mensagem de que o projeto foi criado corretamente
	And o novo projeto deve ter sido criado corretamente

	Examples: 
	| NOME_PROJETO | ESTADO          | VISIBILIDADE | DESCICAO                       |
	| projetoTeste | desenvolvimento | público      | Projeto para teste do MantisBT |
	| projetoTeste | release         | público      | Projeto para teste do MantisBT |
	| projetoTeste | estável         | público      | Projeto para teste do MantisBT |
	| projetoTeste | obsoleto        | público      | Projeto para teste do MantisBT |
	| projetoTeste | desenvolvimento | privado      | Projeto para teste do MantisBT |

Scenario: Criar um novo projeto com nome do projeto repetido
	And exista um projeto criado com os dados: 'nomeRepetido', 'desenvolvimento', 'público', 'Projeto para teste do MantisBT'
	And entre na tela de criar novo projeto
	When eu preencher as informacoes do novo projeto: 'nomeRepetido', 'desenvolvimento', 'público', 'Projeto para teste do MantisBT'
	And clicar para criar um novo projeto
	Then eu devo ver a mensagem de que o projeto nao foi criado corretamente