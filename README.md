# GerenciadorTI

Este projeto � a �ltima vers�o melhorada do meu outro projeto [Ferramentas T.I](https://github.com/Marchinner/FerramentasTI). 
Esta vers�o foi desenvolvida em C# com o int�ito de otimizar a velocidade de execu��o do programa, suas
fun��es e tamb�m colocar em pr�tica conhecimentos obtidos enquanto eu estava estudando C# e seus usos.

As diferen�as mais marcantes deste projeto para o outro s�o:
	-	Implementa��o e busca de informa��es totalmente automatizada, sem a necessidade de inserir informa��es privadas no c�digo do programa.
	-	Funcionamento em qualquer computador com acesso Administrativo a um Active Directory.
	-	Arquivo de configura��es em XML para envio de e-mails.

## Screenshots
![Menu Usu�rios](images/menu_usuarios.png)
![Menu Computadores](images/menu_computadores.png)
![Menu Movimentar Patrim�nio](images/menu_patrimonio_movimentar.png)
![Menu Criar Patrim�nio](images/menu_patrimonio_criar.png)
![Menu Credenciais](images/menu_credenciais.png)
![Menu Configura��es](images/menu_configuracoes.png)

## Funcionalidades
- Buscar e editar informa��es do usu�rio, mover, ativar, alterar e-mail e computador liberado para logon
- Buscar e habilitar/desabilitar computadores da rede
- Enviar uma mensagem autom�tica conforme o formul�rio para informar a movimenta��o de um item de patrim�nio
- Enviar uma mensagem autom�tica para um novo item de patrim�nio e anexar as fotos necess�rias para cadastro
- Enviar uma mensagem autom�tica de "boas vindas" que informa ao novo colaborador sobre suas credenciais e acessos


## Tecnologias
- C#
- Windows Forms
- DirectoryServices
- Net.Mail
