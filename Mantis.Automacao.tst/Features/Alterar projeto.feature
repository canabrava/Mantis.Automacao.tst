@Projetos
Feature: Alterar projeto

	Como: Administrador
	Quero: Alterar as informações de um projeto
	Para que: Essas informações fiquem corretas

Background: 
	Given exista um projeto criado com os dados: 'nomeProjeto', 'desenvolvimento', 'público', 'Projeto para teste do MantisBT'
	And eu esteja logado como administrador


Scenario Outline: Alterar as informaçcoes de um projeto
	Given eu entre na tela de gerenciar o projeto 'nomeProjeto'
	When eu entrar com as novas informacoes do projeto: '<NOME_PROJETO>', '<ESTADO>', '<VISIBILIDADE>', '<DESCRICAO>'
	And eu clicar em atualizar projeto
	Then o sistema deve me levar para a pagina de gerenciar projetos
	And o projeto deve estar salvo

	Examples: 
	| NOME_PROJETO | ESTADO          | VISIBILIDADE | DESCRICAO                      |
	| projetoTeste | desenvolvimento | público      | Projeto para teste do MantisBT |
	| projetoTeste | release         | público      | Projeto para teste do MantisBT |
	| projetoTeste | estável         | público      | Projeto para teste do MantisBT |
	| projetoTeste | obsoleto        | público      | Projeto para teste do MantisBT |
	| projetoTeste | desenvolvimento | privado      | Projeto para teste do MantisBT |

Scenario: Alterar o nome do projeto para o nome de um projeto já existente
	Given exista um projeto criado com os dados: 'nomeProjeto2', 'desenvolvimento', 'público', 'Projeto para teste do MantisBT'
	And eu entre na tela de gerenciar o projeto 'nomeProjeto2'
	When eu entrar com as novas informacoes do projeto: 'nomeProjeto2', 'desenvolvimento', 'público', 'Projeto para teste do MantisBT'
	And eu clicar em atualizar projeto
	Then eu devo ver a mensagem de que já existe um projeto com esse nome


	    
        

        

        

