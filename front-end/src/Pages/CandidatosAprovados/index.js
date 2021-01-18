import React from "react";

import Header from "../../Components/Header";
import Footer from "../../Components/Footer";
import AccessBar from "../../Components/AccessBar";
import AccessMenu from "../../Components/AccessMenu";
import InfoVaga from "../../Components/InfoVaga/Index";
import Tag from "../../Components/Tag/Index";

import imgDesenvolvimento from "../../assets/web-programming.webp";
import imgLocalizacao from "../../assets/big-map-placeholder-outlined-symbol-of-interface.webp";
import imgGlobal from "../../assets/global.png";
import imgSalario from "../../assets/money (1).webp";
import imgTipoContrato from "../../assets/gears.webp";
import imgFuncao from "../../assets/rocket-launch.webp";
import IconEmpresa from "../../assets/building.webp";
import user from '../../assets/images/user.webp'

import { uri } from "../../services/conexao";

import "./style.css";

export default function VizualizarCandidatosAprovados() {
  return (
    <div className="bodyPartVizualizarVagaEmpresa">
      <AccessBar />
      <Header />
      <AccessMenu />
      <div className="BannerVizualizarVagaEmpresa">
        <h1>Veja quem foi aprovado à sua vaga</h1>
      </div>
      <br />
      <div className="vaga">
        <div className="VagaCompleta">
          <img
            src={user}
            className="ImagemEmpresa"
            alt="Iamgem de perfil da empresa"
          />
          <div className="MainVaga">
            <h3>Desenvolvimento</h3>
            <div className="InfoVagas">
              <InfoVaga
                NomeProp={"Code Enterprise"}
                source={IconEmpresa}
              ></InfoVaga>
              <InfoVaga NomeProp={"São Paulo"} source={imgLocalizacao}></InfoVaga>
              <InfoVaga NomeProp={"Júnior"} source={imgFuncao}></InfoVaga>
              <InfoVaga
                NomeProp={"PJ"}
                source={imgTipoContrato}
              ></InfoVaga>
              <InfoVaga NomeProp={"R$4.000,00"} source={imgSalario}></InfoVaga>
              <InfoVaga NomeProp={"Presencial"} source={imgGlobal} />
              <InfoVaga
                NomeProp={"Desenvolvimento"}
                source={imgDesenvolvimento}
              ></InfoVaga>
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

      <div className="ListaDeInscicoes">
      <div  className="Inscricao">
          <div className="CabecaInscricao">
            <img
              className="imgperfilInscricao"
              src={user}
              alt="Imagem de Perfil do candidato"
            />
            <h3>Candidato</h3>
            <hr className="hr" />
            <h5>Desenvolvimento de sistemas</h5>
          </div>
          <div className="CorpoInscricao">
            <Tag NomeTag={"E-mail:Candidato@gmail.com"}></Tag>
            <Tag NomeTag={"Telefone:40028922"}></Tag>
          </div>
        </div>

        <div  className="Inscricao">
          <div className="CabecaInscricao">
            <img
              className="imgperfilInscricao"
              src={user}
              alt="Imagem de Perfil do candidato"
            />
            <h3>Candidato</h3>
            <hr className="hr" />
            <h5>Desenvolvimento de sistemas</h5>
          </div>
          <div className="CorpoInscricao">
            <Tag NomeTag={"E-mail:Candidato@gmail.com"}></Tag>
            <Tag NomeTag={"Telefone:40028922"}></Tag>
          </div>
        </div>

        <div  className="Inscricao">
          <div className="CabecaInscricao">
            <img
              className="imgperfilInscricao"
              src={user}
              alt="Imagem de Perfil do candidato"
            />
            <h3>Candidato</h3>
            <hr className="hr" />
            <h5>Desenvolvimento de sistemas</h5>
          </div>
          <div className="CorpoInscricao">
            <Tag NomeTag={"E-mail:Candidato@gmail.com"}></Tag>
            <Tag NomeTag={"Telefone:40028922"}></Tag>
          </div>
        </div>

        <div  className="Inscricao">
          <div className="CabecaInscricao">
            <img
              className="imgperfilInscricao"
              src={user}
              alt="Imagem de Perfil do candidato"
            />
            <h3>Candidato</h3>
            <hr className="hr" />
            <h5>Desenvolvimento de sistemas</h5>
          </div>
          <div className="CorpoInscricao">
            <Tag NomeTag={"E-mail:Candidato@gmail.com"}></Tag>
            <Tag NomeTag={"Telefone:40028922"}></Tag>
          </div>
        </div>
      </div>
      <Footer />
    </div>
  );
}
