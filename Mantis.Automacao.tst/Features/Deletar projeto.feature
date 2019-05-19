@Projetos
Feature: Deletar projeto

	Como: Administrador
	Quero: Deletar um novo projeto
	Para que: Pessoas não trabalharem mais nele

Background: 
	Given exista um projeto criado com os dados: 'nomeProjeto', 'desenvolvimento', 'público', 'Projeto para teste do MantisBT'
	And eu esteja logado como administrador

Scenario: Deletar projeto
	Given eu entre na tela de gerenciar o projeto 'nomeProjeto'
	When eu clicar em apagar projeto
	And confirmar a que o projeto será deletado
	Then o projeto deve ter sido apagado

Scenario: Não confirmar que o projeto deve ser deletado
	Given eu entre na tela de gerenciar o projeto 'nomeProjeto'
	When eu clicar em apagar projeto
	And clicar em voltar
	And o projeto deve estar salvo

        

        

        

