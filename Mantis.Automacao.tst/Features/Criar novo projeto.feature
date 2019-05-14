Feature: Criar novo projeto

	Como: Administrador
	Quero: Criar um novo projeto
	Para: Pessoas trabalharem nele


Background: 
	Given eu esteja logado como administrador

Scenario: Criar um novo projeto
	And entre na tela de criar novo projeto
	When eu preencher as informacoes do novo projeto:
	And clicar para criar um novo projeto
	Then eu devo ver a mensagem de que o projeto foi criado corretamente
	And o novo projeto deve ter sido criado corretamente

Scenario: Criar um novo projeto com nome do projeto repetido
	And exista um projeto criado com os dados:
	And entre na tela de criar novo projeto
	When eu preencher as informacoes do novo projeto:
	And clicar para criar um novo projeto
	Then eu devo ver a mensagem de que o projeto nao foi criado corretamente
	And o novo projeto nao deve ter sido criado corretamente