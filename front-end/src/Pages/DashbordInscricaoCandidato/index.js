import React from "react";

//style
import "./style.css";

// components
import AccessBar from "../../Components/AccessBar/index";
import Header from "../../Components/Header/index";
import Footer from "../../Components/Footer/index";
import InfoVaga from "../../Components/InfoVaga/Index";
import Tag from "../../Components/Tag/Index";

// images
import imgGlobal from "../../assets/global.png";
import imgDesenvolvimento from "../../assets/web-programming.webp";
import imgLocalizacao from "../../assets/big-map-placeholder-outlined-symbol-of-interface.webp";
import imgSalario from "../../assets/money (1).webp";
import imgTipoContrato from "../../assets/gears.webp";
import imgFuncao from "../../assets/rocket-launch.webp";
import IconEmpresa from "../../assets/building.webp";
import AccessMenu from "../../Components/AccessMenu";

export default function InscricaoDashboardCandidato() {
  return (
    <div className="InscricaoDashboardCandidato">
      <AccessBar />
      <Header />
      <AccessMenu />
        <div className="bannerDashboardCandidato">
          <h2>Bem-vindo, Candidato ;)!</h2>
        </div>
          <div className="title-vagas-inscritas">
            <h3>Vagas que você se inscreveu:</h3>
          </div>

          <div className="vagas">
            <div className="vaga">
              <div className="VagaCompleta">
                <img
                  src={"https://media.discordapp.net/attachments/797237767004356619/800216933223890973/Topo-removebg-preview.png"}
                  className="ImagemEmpresa"
                  alt="Imagem de perfil"
                ></img>
                <div className="MainVaga">
                  <h3>
                    {"Desenvolvedor Full stack"}
                  </h3>
                  <div className="InfoVagas">
                    <InfoVaga
                      NomeProp={"Code Alliance"}
                      source={IconEmpresa}
                    />
                    <InfoVaga NomeProp={"São Paulo"} source={imgLocalizacao} />
                    <InfoVaga NomeProp={"Júnior"} source={imgFuncao} />
                    <InfoVaga NomeProp={"CLT"} source={imgTipoContrato} />
                    <InfoVaga NomeProp={"R$5.000,00"} source={imgSalario} />
                    <InfoVaga
                      NomeProp={"Desenvolvimento"}
                      source={imgDesenvolvimento}
                    />
                    <InfoVaga NomeProp={"Presencial"} source={imgGlobal} />
                  </div>
                  <div className="TecnologiasVaga">
                    <Tag NomeTag={"C#"}></Tag>
                    <Tag NomeTag={"C++"}></Tag>
                    <Tag NomeTag={"Entity framework"}></Tag>
                    <Tag NomeTag={"React"}></Tag>
                    <Tag NomeTag={"Flutther"}></Tag>
                  </div>
                </div>
              </div>
            </div>

            <div
              className="vaga"
            >
              <div className="VagaCompleta">
                <img
                  src={"https://media.discordapp.net/attachments/797237767004356619/800216933223890973/Topo-removebg-preview.png"}
                  className="ImagemEmpresa"
                  alt="Imagem de perfil"
                ></img>
                <div className="MainVaga">
                  <h3>
                    {"Desenvolvedor Full stack"}
                  </h3>
                  <div className="InfoVagas">
                    <InfoVaga
                      NomeProp={"Code Alliance"}
                      source={IconEmpresa}
                    />
                    <InfoVaga NomeProp={"São Paulo"} source={imgLocalizacao} />
                    <InfoVaga NomeProp={"Júnior"} source={imgFuncao} />
                    <InfoVaga NomeProp={"CLT"} source={imgTipoContrato} />
                    <InfoVaga NomeProp={"R$5.000,00"} source={imgSalario} />
                    <InfoVaga
                      NomeProp={"Desenvolvimento"}
                      source={imgDesenvolvimento}
                    />
                    <InfoVaga NomeProp={"Presencial"} source={imgGlobal} />
                  </div>
                  <div className="TecnologiasVaga">
                    <Tag NomeTag={"C#"}></Tag>
                    <Tag NomeTag={"C++"}></Tag>
                    <Tag NomeTag={"Entity framework"}></Tag>
                    <Tag NomeTag={"React"}></Tag>
                    <Tag NomeTag={"Flutther"}></Tag>
                  </div>
                </div>
              </div>
            </div>

            <div
              className="vaga">
              <div className="VagaCompleta">
                <img
                  src={
                    "https://media.discordapp.net/attachments/797237767004356619/800216933223890973/Topo-removebg-preview.png"
                  }
                  className="ImagemEmpresa"
                  alt="Imagem de perfil"
                ></img>
                <div className="MainVaga">
                  <h3>
                    {"Desenvolvedor Full stack"}
                  </h3>
                  <div className="InfoVagas">
                    <InfoVaga
                      NomeProp={"Code Alliance"}
                      source={IconEmpresa}
                    />
                    <InfoVaga NomeProp={"São Paulo"} source={imgLocalizacao} />
                    <InfoVaga NomeProp={"Júnior"} source={imgFuncao} />
                    <InfoVaga NomeProp={"CLT"} source={imgTipoContrato} />
                    <InfoVaga NomeProp={"R$5.000,00"} source={imgSalario} />
                    <InfoVaga
                      NomeProp={"Desenvolvimento"}
                      source={imgDesenvolvimento}
                    />
                    <InfoVaga NomeProp={"Presencial"} source={imgGlobal} />
                  </div>
                  <div className="TecnologiasVaga">
                    <Tag NomeTag={"C#"}></Tag>
                    <Tag NomeTag={"C++"}></Tag>
                    <Tag NomeTag={"Entity framework"}></Tag>
                    <Tag NomeTag={"React"}></Tag>
                    <Tag NomeTag={"Flutther"}></Tag>
                  </div>
                </div>
              </div>
            </div>

            <div
              className="vaga">
              <div className="VagaCompleta">
                <img
                  src={
                    "https://media.discordapp.net/attachments/797237767004356619/800216933223890973/Topo-removebg-preview.png"
                  }
                  className="ImagemEmpresa"
                  alt="Imagem de perfil"
                ></img>
                <div className="MainVaga">
                  <h3>
                    {"Desenvolvedor Full stack"}
                  </h3>
                  <div className="InfoVagas">
                    <InfoVaga
                      NomeProp={"Code Alliance"}
                      source={IconEmpresa}
                    />
                    <InfoVaga NomeProp={"São Paulo"} source={imgLocalizacao} />
                    <InfoVaga NomeProp={"Júnior"} source={imgFuncao} />
                    <InfoVaga NomeProp={"CLT"} source={imgTipoContrato} />
                    <InfoVaga NomeProp={"R$5.000,00"} source={imgSalario} />
                    <InfoVaga
                      NomeProp={"Desenvolvimento"}
                      source={imgDesenvolvimento}
                    />
                    <InfoVaga NomeProp={"Presencial"} source={imgGlobal} />
                  </div>
                  <div className="TecnologiasVaga">
                    <Tag NomeTag={"C#"}></Tag>
                    <Tag NomeTag={"C++"}></Tag>
                    <Tag NomeTag={"Entity framework"}></Tag>
                    <Tag NomeTag={"React"}></Tag>
                    <Tag NomeTag={"Flutther"}></Tag>
                  </div>
                </div>
              </div>
            </div>
          </div>
      <Footer />
    </div>
  );
}
