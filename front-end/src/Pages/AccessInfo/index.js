import React from "react";

import Header from "../../Components/Header";
import Footer from "../../Components/Footer";
import AccessBar from "../../Components/AccessBar";
import AccessMenu from "../../Components/AccessMenu";

import conta from "../../assets/contrast.png";
import font from "../../assets/font.png";
import libras from "../../assets/libras.png";
import mic from "../../assets/mic.png";

import "./style.css";

export default function AcessInfo() {
  return (
    <body>
      <AccessBar />
      <Header />
      <AccessMenu />

  <div id="content-banner" className="flex">
    <div>
      <h1>Saiba usar nossos recursos acessíveis</h1>
    </div>

    <div className="flex recuo">
      <img src="./img/menu.png" alt="Uma ilustração de dois homens apertando as mãos" className="imgabout"/>
      
      <div className="justdiv1">
      <br/>
      <p>Se existe de fato uma lei ou decreto de inclusão, uma das mais efetivas iniciativas para que todos possam ter os mesmos direitos de usufruir do conteúdo digital é o Decreto Nº 6.949 que surgiu através da Convenção Nacional sobre os Direitos das Pessoas com Deficiência, assinado em Nova Iorque, do dia 30 de março do ano de 2007, tem como nos seus artigos que também foram reforçados no decreto:</p><br/><p>
Artigo 9, parágrafo 1: "Os estados tomarão suas próprias medidas para promover o acesso de pessoas com deficiência para novas tecnologias da informação, inclusive através da internet".</p><br/><p>
No Artigo 21, em sua total constituição, está determinado que: "Estabelece-se portanto o compromisso com a liberdade de expressão destas pessoas que possuem limitações de compartilhar, buscar e receber informações sem nenhuma limitação dos estados".</p><p>
Temos também a LBI (Lei Brasileira de Inclusão) sancionada no dia 6 de Julho de 2015 onde se encontra os seguintes termos:</p><br/><p>
“assegurar e a promover, em condições de igualdade, o exercício dos direitos e das liberdades fundamentais por pessoa com deficiência, visando à sua inclusão social e cidadania”.</p><br/><p>
E junto desta lei, no Artigo 63: "Tem então como obrigatoriedade a inclusão de pessoas com deficiência, dando então o acesso de órgãos e serviços governamentais, garantido o acesso as informações que lhe competem ou necessitam".Mas em contrapartida, se existem todas estas leis, por qual razão mais de 90% dos sites na internet não possui ou estas funções simplesmente não funcionam? Pensando num âmbito geral, já estamos num momento onde a inclusão deveria ser obrigatória e 100% presente para todos.A solução são inciativas como a nossa, onde podemos através de um mercado tão importante, neste caso, o mercado de trabalho, onde a partir de ferramentas efetivas para o uso de quem tem limitações possa ser positivo, proporcionando um ambiente igualitário.</p>
      <br/>
      <p>Nosso site é contém alguns funções que podem melhorar a experiência dessas pessoas.</p>
      </div>
    </div>

    <div className="flex recuo">
     
      <div className="justdiv1">
      <br/>
      <p>Vocês podem ver que durante as páginas, um botãozinho acompanhou vocês todos esse tempo. Esse é o menu de acessibilidade, ele está aqui para desempenhar algumas funções. :)</p>
      </div>

       <img src="./img/taaqui.png" alt="Uma ilustração de dois homens apertando as mãos" className="imgabout" />
    </div>


    <div className="flex recuo">
     
      
      <div className="justdiv1">
      <br/>
      <p>Clicando nesse botãozinho, verá que ele se abrirá para uma gama de opções para tratar alguns recursos do nosso site que foi feito com tanto amor e carinho para TODOS vocês!</p>
      </div>

       <img src="./img/abrido.png" alt="Uma ilustração de dois homens apertando as mãos" className="imgabout"/>
    </div>

  <h2>Quais são as funcionalidades?</h2>

        <div className="flex recuo"> 
       <img src={conta} alt="Uma ilustração de dois homens apertando as mãos" className="icones"/>
      <div className="justdiv1">
        <h5 className="tittle-section">Contraste</h5>
      <p>As cores usadas no nosso layout já estão dentro das normas de contraste, entretanto é importânte para daltonicos, acromatopsia e outros que precisam dessa funcionalidade.</p>
      </div>

    </div>

        <div className="flex recuo"> 
       <img src={font} alt="Uma ilustração de dois homens apertando as mãos" className="icones"/>
      <div className="justdiv1">
        <h5 className="tittle-section">Aumento de fonte</h5>
      <p>Para garantir que todos os nossos usuáris possam acessar a plataforma, aumentamos bem a fonte para que qualquer pessoa com problemas de vista possam usufruir de nossos serviços.</p>
      </div>
    </div>

        <div className="flex recuo"> 
       <img src={libras} alt="Uma ilustração de dois homens apertando as mãos" className="icones"/>
      <div className="justdiv1">
        <h5 className="tittle-section">Libras</h5>
      <p>Estamos cientes de que muitas vezes a primeira linguagem aprendida por pessoas que portam deficiência auditiva, mudo ou níveis de surdez podem ser a Libras. Nós utilizamos aqui o VLibras, um software desenvolvedo pelo governo com o intuito de interpretar o texto clicado da página.</p>
      </div>
    </div>


        <div className="flex recuo"> 
       <img src={mic} alt="Ícone de um microfone" className="icones"/>
      <div className="justdiv1">
        <h5 className="tittle-section">Comando de voz</h5>
      <p>Não esquecemos também das pessoas que sofrem algum tipo de limitação física, e para que seja possível navegar sem muitos problemas, desenvolvemos o comando de voz.</p><br/><p>Ele funciona da seguinte maneira: aperte o ícone do microfone com o mouse ou usando a tecla de atalha ALT + V (ALT + SHIT + V para o navegador Firefox) e diga o nome da página que gostaria de ir.</p><br/>
      <p>Exemplo: *Click, diga "home".</p><br/>
      <p>Exemplo: *Click, diga "sobre".</p>
      </div>
    </div>
  </div>
  <a href="/informacao"><div className="btnInfo">
        ?
      </div></a>
      <Footer />
    </body>
  );
}
