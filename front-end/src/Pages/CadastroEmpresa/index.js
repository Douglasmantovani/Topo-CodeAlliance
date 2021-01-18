import React from "react";

import AccessBar from "../../Components/AccessBar";
import Header from "../../Components/Header";
import AccessMenu from "../../Components/AccessMenu";
import Input from "../../Components/Input";
import BlueButton from "../../Components/BlueButton";
import Footer from "../../Components/Footer";

import imagemCadastroEmpresa from "../../assets/imgCadastroEmpresa.webp";
import Userimg from "../../assets/Teste.webp";


import "./style.css";

export default function CadastroEmpresa() {
  return (
    <body>
      <AccessBar />
      <Header />
      <AccessMenu />

      <div className="registerCompany">
        <div className="box-form">
          <div className="form-content">
            <h1>Cadastre-se como Empresa</h1>
            <p>
              Bem-vindo ao cadastro de empresa. Ficamos felizes de tê-la na
              nossa plataforma
            </p>
            <div className="imgCadastroPerfil">
              <img className="imagemCadastro" src={Userimg} alt="Imagem de perfil" />
              <br />
              <button className="btSelecionar">
                <label htmlFor="ButtonImage" className="lbBt">
                  Selecione uma imagem
                </label>
              </button>
            </div>
            <form className="form">
              <input
                type="file"
                className="none"
                id="ButtonImage"
              />
              <Input
                id="responsibleName"
                name={"responsibleName"}
                className="cadastre"
                label="Nome do responsável:"
                type="text"
                placeholder="Barão de Mauá"
                maxLength={65}
                minLength={5}
                required
                
              />
              <Input
                id="cnpjCadastro"
                name="cnpjCadastro"
                className="cadastre"
                label="CNPJ:"
                type="text"
                placeholder="00.000.000/0001-00"
                maxLength={14}
                minLength={14}
                required
                onKeyPress={(e) => {
                  "return e.charCode >= 48 && e.charCode <= 57";
                }}
              />

              <Input
                id="emailContatoCadastro"
                name="emailContatoCadastro"
                className="cadastre"
                label="E-mail para contato:"
                type="text"
                placeholder="contato@company.com"
                maxLength={254}
                minLength={5}
                required
              />

              <Input
                id="companyFakeNameCadastro"
                name="companyFakeNameCadastro"
                className="cadastre"
                label="Nome fantasia:"
                type="text"
                placeholder="CPTM"
                maxLength={50}
                required
              />

              <Input
                id="companyNameCadastro"
                name="companyNameCadastro"
                className="cadastre"
                label="Razão social:"
                type="text"
                placeholder="São Paulo Railway Company Ltd."
                maxLength={50}
                minLength={5}
                required
              />
              <Input
                id="phoneNumberCadastro"
                name="phoneNumberCadastro"
                className="cadastre"
                label="Telefone da empresa:"
                type="tel"
                placeholder="(11)4002-8922"
                maxLength={11}
                minLength={10}
                required
              />

              <Input
                id="workersCompanyNumberCadastro"
                name="workersCompanyNumberCadastro"
                className="cadastre"
                label="Número de funcionários:"
                type="number"
                maxLength={4}
                minLength={1}
              />

              <Input
                id="cnaeNumberCadastro"
                name="cnaeNumberCadastro"
                className="cadastre"
                label="Número CNAE:"
                type="text"
                placeholder="00.00-0-0"
                maxLength={7}
                minLength={7}
                required
              />

              <div className="Input">
                <label htmlFor="cep">CEP:</label>
                <br />
                <input
                  type="text"
                  className="cadastre"
                  id="cep"
                  maxLength={8}
                  minLength={8}
                />
              </div>

              <Input
                id="rua"
                name="address"
                className="cadastre"
                label="Logradouro da empresa:"
                type="text"
                maxLength={155}
                minLength={5}
              />

              <div className="Input">
                <label htmlFor="ComplementoCadastroEmpresa">Complemento:</label>
                <br />
                <input
                  id="ComplementoCadastroEmpresa"
                  type="text"
                  name="address2"
                  maxLength={255}
                  className="cadastre"
                />
              </div>

              <div className="Input">
                <label>Cidade:</label>
                <br />
                <input
                  type="text"
                  className="cadastre"
                  id="cidade"
                  required
                  disabled
                  maxLength={150}
                  minLength={5}
                />
              </div>

              <div className="Input">
                <label>UF:</label>
                <br />
                <input
                  type="text"
                  className="cadastre"
                  id="uf"
                  required
                  disabled
                  maxLength={2}
                  minLength={2}
                />
              </div>

              <Input
                id="EmailUserCadastroEmpresa"
                name="EmailUserCadastroEmpresa"
                className="cadastre"
                label="Email de acesso:"
                placeholder="email@company.com"
                type="text"
                maxLength={254}
                minLength={5}
                required
              />

              <Input
                id="password-cadastro"
                name="password-cadastro"
                className="cadastre"
                label="Senha de acesso:"
                type="password"
                maxLength={15}
                minLength={9}
                required
              />

              <Input
                id="confirmPassword-cadastro"
                name="confirmPassword-cadastro"
                className="cadastre"
                label="Confirme a senha:"
                type="password"
                maxLength={15}
                minLength={9}
                required
              />
              <p>Ao cadastrar-se, você aceita os nossos termos de uso.</p>
              <div className="form-button">
                <BlueButton type="submit" name="Criar conta">
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
