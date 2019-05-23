Feature: Criar Tarefa

	Como: Usuario
	Quero: Criar tarefas
	Para que: Minha equipe possa realiza-las

Background: 
	Given eu esteja logado como administrador

Scenario: Criar uma tarefa
	Given eu entre na tela de criar tarefas
	When eu entrar com as informações da nova tarefa com as informações:
		| CATEGORIA | FREQUENCIA | GRAVIDADE | PRIORIDADE | ATRIBUIR_A      | REUSMO   | DESCRIÇÃO   | PASSOS_PARA_REPRODUZIR   | INFORMAÇÕES_ADICIONAIS   | VISIBILIDADE |
		| "General" | "sempre"   | "pequena" | "normal"   | "administrador" | "Resumo" | "Descrição" | "Passos para reproduzir" | "Informações adicionais" | "público"    |
	And clicar para criar uma nova tarefa
	Then o sistema deve mostra a tela confirmando a criação da tarefa
	And o sistema deve criar a tarefa


Scenario: Continuar relatando tarefas
	Given eu entre na tela de criar tarefas
	When eu entrar com as informações da nova tarefa com as informações:
		| CATEGORIA | FREQUENCIA | GRAVIDADE | PRIORIDADE | ATRIBUIR_A      | REUSMO   | DESCRIÇÃO   | PASSOS_PARA_REPRODUZIR   | INFORMAÇÕES_ADICIONAIS   | VISIBILIDADE |
		| "General" | "sempre"   | "pequena" | "normal"   | "administrador" | "Resumo" | "Descrição" | "Passos para reproduzir" | "Informações adicionais" | "público"    |
	And eu marco a opção de criar mais tarefas
	And clicar para criar uma nova tarefa
	Then o sistema deve mostra a tela confirmando a criação da tarefa
	And o sistema deve exibir a opção de criar mais tarefas
	And o sistema deve criar a tarefa


	    
        
        
        
