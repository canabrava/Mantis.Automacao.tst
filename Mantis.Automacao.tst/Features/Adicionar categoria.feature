Feature: Adicionar categoria
	
	Como: Administrador
	Quero: Adicionar uma nova categoria
	Para que: Eu possa organizar melhor minhas tarefas

Background: 
	Given eu esteja logado como administrador

Scenario: Adicionar uma nova categoria
	Given eu entre na tela de gerenciar projetos
	When eu preencher o nome da categoria com 'nomeCategoria'
	And clicar em adicionar categoria
	Then o sistema deve criar a nova categoria

Scenario: Adicionar uma categoria com nome repetido
	Given exista uma categoria com o nome 'nomeCategoria'
	Given eu entre na tela de gerenciar projetos
	When eu preencher o nome da categoria com 'nomeCategoria'
	And clicar em adicionar categoria
	Then eu devo ver a mensagem de que já existe uma categiria com esse nome