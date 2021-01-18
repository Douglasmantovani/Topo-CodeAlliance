import React from "react";

import Header from "../../Components/Header";
import Footer from "../../Components/Footer";
import AccessBar from "../../Components/AccessBar";
import AccessMenu from "../../Components/AccessMenu";

import img from "../../assets/SobreImg.png";

import "./style.css";

export default function Sobre() {
  return (
    <body>
      <AccessBar />
      <Header />
      <AccessMenu />
      <div id="content-banner" className="flex">
        <div>
          <h1>Conheça a nossa empresa</h1>
        </div>

        <div className="flex">
          <img
            src={img}
            alt="Uma ilustração de dois homens apertando as mãos"
            className="imgabout"
          />
          <p>
            Sabendo que o primeiro passo é o mais difícil, todos que hoje ocupam
            posições do "topo" tiveram que ter o primeiro passo.
          </p>
          <br />
          <p>
            A Topo tem como objetivo fornecer para toda a população, de maneira
            geral, melhores oportunidades no mercado de trabalho para quem já
            tem ou precisa inicar neste mercado, aplicando Provas, com feedback
            das empresas, para saber o que precisa ser aprimorado
          </p>
          <br />
        </div>
        <div className="flex">
          <p>
            Topo não é apenas um site de vagas, não somos apenas mais um no
            mercado, A Topo é uma plataforma que te ajuda no "primeiro passo" e
            como diz o ditado "a primeira impressão é a que fica" então ajudando
            você nesta questão, temos como visão transformar nossos inscritos em
            visionários autônomos, onde todos podem ter uma boa posição, estar
            no "topo".
          </p>
          <br />
          <p>
            Nosso diferencial é te dar o feedback necessário, não se trata
            apenas de dizer não, mas na verdade, promover o progresso de todos
            que competem por uma vaga, tornando o mercado mais acessível e
            inclsuivo.
          </p>
          <br />
          <p>
            Não importa como você seja, com oportunidades ou não, nossa
            plataforma tem como visão de futuro a formação progressiva, a partir
            de iniciativas de Lifelong Learning, onde você define seu afinco e
            desempenho nas áreas necessárias
          </p>
          <br />
          <img
            src={img}
            alt="Uma ilustração de dois homens apertando as mãos"
            className="imgabout"
          />
        </div>
      </div>
      <a href="/informacao"><div className="btnInfo">
        ?
      </div></a>
      <Footer />
    </body>
  );
}
