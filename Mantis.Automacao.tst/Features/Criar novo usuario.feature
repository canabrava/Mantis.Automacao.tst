Feature: Criar nova conta

	Como: Administrador
	Quero: Criar nova conta
	Para que:: Que outrar pessoas possam usar o Mantis

Background: 
	Given eu esteja logado como administrador

@CriarConta
Scenario Outline: Criar nova conta valida
	And entre na tela de criar nova conta
	When eu preencher as informacoes do novo usuario: '<USERNAME>', '<REAL_NAME>', '<E-MAIL>' e <'ACCESS_LEVEL'>
	And clicar para criar nova conta
	Then eu tenho a confirmacao de que o usuario foi criado corretamente
	And o novo usuario dever ter sido criado corretamente
	
		Examples: 
		| USERNAME     | REAL_NAME     | E-MAIL                 | ACCESS_LEVEL  |
		| usuarioTeste | nomeRealTeste | usuarioteste@teste.com | vizualizador  |
		| usuarioTeste | nomeRealTeste | usuarioteste@teste.com | relator       |
		| usuarioTeste | nomeRealTeste | usuarioteste@teste.com | atualizador   |
		| usuarioTeste | nomeRealTeste | usuarioteste@teste.com | desenvolvedor |
		| usuarioTeste | nomeRealTeste | usuarioteste@teste.com | gerente       |
		| usuarioTeste | nomeRealTeste | usuarioteste@teste.com | administrador |

Scenario: Criar nova conta com nome do usuario repetido
	And entre na tela de criar nova conta
	When eu preencher as informacoes do novo usuario: 'usuarioTeste', 'nomeDiferente', 'teste@teste.com' e 'vizualizador'
	And clicar para criar nova conta
	Then eu vejo uma mensagem de que nao e possivel criar usuario com nome repetido


Scenario Outline: Criar nova conta com nome do usuario invalido
	And entre na tela de criar nova conta
	When eu preencher as informacoes do novo usuario: '<USERNAME>', '<REAL_NAME>', '<E-MAIL>' e <'ACCESS_LEVEL'>
	And clicar para criar nova conta
	Then eu vejo uma mensagem de erro dizendo que o nome do usuario esta invalido
	And o novo usuario dever ter sido criado corretamente
	
		Examples: 
		| USERNAME | REAL_NAME     | E-MAIL                 | ACCESS_LEVEL  |
		| teste*   | nomeRealTeste | usuarioteste@teste.com | vizualizador  |
		| teste.   | nomeRealTeste | usuarioteste@teste.com | relator       |
		| teste?   | nomeRealTeste | usuarioteste@teste.com | atualizador   |
		| teste%   | nomeRealTeste | usuarioteste@teste.com | desenvolvedor |
		| teste#   | nomeRealTeste | usuarioteste@teste.com | gerente       |
		|          | nomeRealTeste | usuarioteste@teste.com | administrador |


Scenario Outline: Criar nova conta com e-mail invalido
	And entre na tela de criar nova conta
	When eu preencher as informacoes do novo usuario: '<USERNAME>', '<REAL_NAME>', '<E-MAIL>' e <'ACCESS_LEVEL'>
	And clicar para criar nova conta
	Then eu vejo uma mensagem de erro dizendo que o e-mail esta invalido
	And o novo usuario nao dever ter sido criado corretamente

		Examples: 
		| USERNAME     | REAL_NAME     | E-MAIL             | ACCESS_LEVEL  |
		| usuarioTeste | nomeRealTeste | teste.com          | vizualizador  |
		| usuarioTeste | nomeRealTeste | @teste.com         | relator       |
		| usuarioTeste | nomeRealTeste | usuarioteste       | atualizador   |


