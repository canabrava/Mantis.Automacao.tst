@login
Feature: Login
	
	Como: Usuário
	Quero: Logar no sistema
	Para: Ter acesso às minhas informações


Scenario: Entrar com caracteres válidos no nome do usuário 
	Given eu entro com o nome do usuário 'administrator' no campo do nome do usuário
	When clicar em entrar na pagina de senha
	Then devo ir para a página de senha

Scenario: Entrar com carecteres inválidos no nome do usuário
	Given eu entro com o nome do usuário '"administrator"' no campo do nome do usuário
	When clicar em entrar na pagina de senha
	Then eu devo ver uma mensagem avisando que houve um erro no login

Scenario: Entrar com nome do usuário e senha corretos
	Given eu entro com o nome do usuário 'administrator' no campo do nome do usuário
	When clicar em entrar na pagina de senha
	And eu entro com a senha 'administrator' no campo senha
	And clicar em entrar no sistema
	Then eu devo entrar na pagina principal

Scenario Outline: Entrar com nome do usuário ou senha errados
	Given eu entro com o nome do usuário '<USERNAME>' no campo do nome do usuário
	When clicar em entrar na pagina de senha
	And eu entro com a senha '<PASSWORD>' no campo senha
	And clicar em entrar no sistema
	Then eu devo ver uma mensagem avisando que houve um erro no login

		Examples: 
		| USERNAME      | PASSWORD      |
		| administrator | 12345         |
		| usuarioerrado | administrator |

	