import React from "react";
import { useHistory } from "react-router-dom";

import AccessBar from "../../Components/AccessBar";
import Header from "../../Components/Header";
import AccessMenu from "../../Components/AccessMenu";
import Input from "../../Components/Input";
import BlueButton from "../../Components/BlueButton";
import Footer from "../../Components/Footer";
import Userimg from '../../assets/images/user.webp'

import imagemCadastroCandidato from "../../assets/imgCadastroCandidato.webp";

import "./style.css";

export default function CadastroEmpresa() {
  const history = useHistory();


  return (
    <body>
      <AccessBar />
      <Header />
      <AccessMenu />
      <div className="registerApplicant">
        <div className="box-form">
          <div className="form-content">
            <h1>Cadastre-se como Candidato</h1>
            <p>
              Bem-vindo ao cadastro do candidato. <br />
              Ficamos felizes de tê-lo na nossa plataforma
            </p>
              <div className="imgCadastroPerfil">
              <img className="imagemCadastro" src={Userimg} alt="Imagem de perfil"/>
              <br/>
              <button className="btSelecionar"><label htmlFor="ButtonImage" className="lbBt">Selecione uma imagem</label></button>
              </div>
            <form className="form" onSubmit={e =>{
              e.preventDefault();
              }}>
              <input type="file" className="none" id="ButtonImage"/>
              <Input
                id="fullName"
                name="fullName"
                className="cadastre"
                label="Nome completo:"
                type="text"
                placeholder="Maria dos Santos"
                required
                maxLength={65}
                minLength={5}
              />

              <Input
                id="rg"
                name="rg"
                className="cadastre"
                label="RG:"
                type="text"
                placeholder="00.000.000-0" 
                maxLength={9}
                minLength={9}
                required
              />

              <Input
                id="cpf"
                name="cpf"
                className="cadastre"
                label="CPF:"
                type="text"
                placeholder="000.000.000-00"
                required
                maxLength={11}
                minLength={11}
              />

              <Input
                id="telefone"
                name="telefone"
                className="cadastre"
                label="Telefone:"
                type="text"
                placeholder="(11) 91234-5678"
                maxLength={11}
                minLength={11}
                required
              />

              <Input
              id="linkedin"
                name="linkedin"
                className="cadastre"
                label="LinkedIn:"
                type="text"
                placeholder="linkedin.com/in/maria-dos-santos"
                maxLength={150}
                minLength={5}
              />
              
              <Input
                id="email"
                name="email"
                className="cadastre"
                label="E-mail:"
                type="text"
                placeholder="exemplo@exemplo.com"
                required
                maxLength={254}
                minLength={5}
           
              />

              <Input
                id="password"
                name="password"
                className="cadastre"
                label="Senha:"
                type="password"
                placeholder="Digite sua senha"
                required
                maxLength={15}
                minLength={9}
              />

              <Input
                id="confirmarSenha-cadastroCandidato"
                name="confirmarSenha-cadastroCandidato"
                className="cadastre"
                label="Confirmar senha:"
                type="password"
                placeholder="Confirme a senha"
                required
                maxLength={15}
                minLength={9}
              />
              <p>Ao cadastrar-se, você aceita os nossos termos de uso.</p>

              <div className="form-button">
                <BlueButton type="submit" name="Criar conta" Onclick={()=>history.push("/login")}>
                  Criar conta
                </BlueButton>
              </div>
            </form>
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