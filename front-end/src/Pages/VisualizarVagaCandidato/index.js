import React from "react";

// style
import "./visualizarvaga.css";

// components
import Tag from "../../Components/Tag/Index";
import InfoVaga from "../../Components/InfoVaga/Index";
import Footer from "../../Components/Footer/index";
import AccessBar from "../../Components/AccessBar";
import Header from "../../Components/Header";
import AccessMenu from "../../Components/AccessMenu";

// imagens
import imgDesenvolvimento from "../../assets/web-programming.webp";
import imgGlobal from "../../assets/global.png";
import imgLocalizacao from "../../assets/big-map-placeholder-outlined-symbol-of-interface.webp";
import imgSalario from "../../assets/money (1).webp";
import imgTipoContrato from "../../assets/gears.webp";
import imgFuncao from "../../assets/rocket-launch.webp";
import IconEmpresa from "../../assets/building.webp";
import user from '../../assets/images/user.webp'
import { useHistory } from "react-router-dom";

export default function VisualizarVaga() {
  let history = useHistory();

  return (
    <div className="VisualizarVaga">
      <AccessBar />
      <Header />
      <AccessMenu />
      <main className="sessaoVisualizarVaga">
        <section className="imgBannerDescriVaga">
          <div className="divisionIntroVaga">
            <h2 className="v-titleVaga">Desenvolvedor Full Stack</h2>

            <div className="divisionTagsLinguagem">
              <Tag NomeTag={"C#"} />
              <Tag NomeTag={"Entity Framework"} />
              <Tag NomeTag={"C++"} />
              <Tag NomeTag={"Forms"} />
              <Tag NomeTag={"Android"} />
            </div>
          </div>
        </section>

        <div className="vaga">
          <div className="VagaCompleta">
            <img
              src={user}
              className="ImagemEmpresa"
              alt="Imagem de perfil da empresa"
            />
            <div className="MainVaga">
              <h3
                onClick={(e) => {
                  e.preventDefault();
                  history.push("/VagaEmpresa");
                }}
                className="UnderlineText"
              >
                {"Desenvolvedor Full Stack"}
              </h3>
              <div className="InfoVagas">
                <InfoVaga NomeProp={"Code Enterprise"} source={IconEmpresa} />
                <InfoVaga
                  NomeProp={"São Paulo"}
                  source={imgLocalizacao}
                />
                <InfoVaga NomeProp={"Júnior"} source={imgFuncao} />
                <InfoVaga
                  NomeProp={"CLT"}
                  source={imgTipoContrato}
                />
                <InfoVaga NomeProp={"R$4.000,00"} source={imgSalario} />
                <InfoVaga
                  NomeProp={"Desenvolvimento"}
                  source={imgDesenvolvimento}
                />
                <InfoVaga NomeProp={"Presencial"} source={imgGlobal} />
              </div>
              <div className="TecnologiasVaga">
                <Tag NomeTag={"Entity framework"}></Tag>
                <Tag NomeTag={"C#"}></Tag>
                <Tag NomeTag={"C++"}></Tag>
                <Tag NomeTag={"SQL"}></Tag>
                <Tag NomeTag={"React"}></Tag>
              </div>
            </div>
          </div>
        </div>

        <section className="sessao-svempresa">
          <div className="descri-empresa">
            <h2>Descrição da empresa</h2>

            <p>A melhor empresa do mercado, quem fez parte recomenda !!!</p>
          </div>

          <div className="descri-vaga">
            <h2>Requisitos da vaga</h2>
            <p>A melhor vaga que você encontrará nos proximos meses</p>
          </div>
        </section>

        <section className="divisionBeneVaga">
          <div className="centerBene">
            <h2>O que oferecemos</h2>

            <div className="divisionPlan">
              <div className="divisionPlan">
                <p>Vale transporte</p>
              </div>
            </div>
            <button
              className="btnCandidatase"
              type="submit"
              onClick={() => alert("Inscrição realizada com sucesso")}
            >
              Me Candidatar
            </button>
          </div>
        </section>
      </main>
      <Footer />
    </div>
  );
}
