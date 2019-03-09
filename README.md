# Arduino-Controle-Toy
Transforma um controle remoto de TV em um joystick para computador usando arduino

*******
Tabelas de conteúdo 
 1. [Como Colocar Para Funcionar Pela Primeira Vez](#1)
 2. [Programa Necessarios](#2)
 3. [Editar](#3)
 4. [Informações Adicionais](#4)
 5. [Creditos e Informações Finais](#5)

******* 

<div id='1'/> 

# Como Colocar Para Funcionar Pela Primeira Vez
simples, compile o arquivo da pasta `WindowsApp5`, depois passe o conteudo da pasta `controle-toy_Vers_o_0.2`
para o arduino (caso não tenha passado ainda), depois de passar deixe o arduino conectado ao computador
e abra o arquivo `WindowsApp5.exe` (que você compilou) click na seta da caixinha selecione a porta correspondente
na maioria das vezes so vai ter 1 item, depois clicka no botão e pronto ja vai esta rodando.

<div id='2'/> 

# *Programa Necessarios*
* **Visual Studio 2017**  (somente para editar e copilar, nada mais)
* **Arduino**  (software)
* **`Ambos(os dois) são gratuitos.`**

<div id='3'/> 

#  *Editar*
abra a pasta `WindowsApp5` e inicie o arquivo `WindowsApp5.sln`
edite o `Form1`, onde esta `F1` e `F2` edite para a tecla que você desejar.

![Alt Text](https://github.com/cybernerd007/Arduino-Controle-Toy/blob/master/Screenshot_2.jpg)

<div id='4'/> 

# Informações Adicionais
e um codigo super simples dando uma olhada você vai notar como ele funciona, ao clickar em um tecla do controle
remoto ele vai pegar pelo sensor receptor infravermelho e vai mandar para o arduino onde mandara em forma de
texto uma tecla no caso a letra `a` e `b`, no programa aberto ele capta a tecla e manda para o computador
qualquer outra tecla correspondente no caso `F1` e `F2`.

<div id='5'/> 

# Creditos e Informações Finais
Feito por Otávio Augusto - [GitHub](https://github.com/cybernerd007)

Peço desculpa por algum erro de portugues ou pela explicação meio confusa, 
porem o codigo e simples vendo você vai entender como funciona.
