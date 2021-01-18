import React from "react";
import { useHistory, Link } from "react-router-dom";

import Header from "../../Components/Header";
import Footer from "../../Components/Footer";
import AccessBar from "../../Components/AccessBar";
import AccessMenu from "../../Components/AccessMenu";

import Eneagrama from "../../assets/eneagrama.png";
import Person from "../../assets/disco.png";
import disc from "../../assets/person.png";
import aguia from "../../assets/aguia.webp";
import "./style.css";

export default function Home() {
  let history = useHistory();
  return (
    <div>
      <AccessBar />
      <Header />
      <AccessMenu />
      <div id="content-banner" classNameName="flex">
        <div>
          <h1>Seja bem-vindo(a) ao topo!</h1>
          <h2>A plataforma de empregos que te ajuda a chegar lá</h2>
        </div>
        <div id="content-btn-banner">
          <button
            className="btn-signup"
            onClick={() => history.push("/cadastro")}
          >
            Cadastre-se candidato
          </button>
          <button
            className="btn-signup"
            onClick={() => history.push("/cadastro/empresa")}
          >
            Cadastre-se empresa
          </button>
        </div>
        <div className="bg-home"></div>
      </div>

      <section id="vagas-content-section">
        <div id="vagas-content">
          <br />
          <h2 class="tittle-section">Vagas em destaques!</h2>
          <hr class="line-blue" />
          <div class="vagas-card">
            <div class="card">
              <div class="card-header-white">
                <h4>Desenvolvedor Front-end Pleno</h4>
                <hr />
              </div>
              <div class="card-body">
                <div class="card-flex">
                  <span>R$ 4.000</span>

                  <div class="card-footer">
                    <Link to="/cadastro">Saiba mais</Link>
                  </div>
                </div>
              </div>
            </div>

            <div class="card">
              <div class="card-header-white">
                <h4>Gerenciador comercial</h4>
                <hr />
              </div>
              <div class="card-body">
                <div class="card-flex">
                  <span>R$ 6.000</span>

                  <div class="card-footer">
                    <Link to="/cadastro">Saiba mais</Link>
                  </div>
                </div>
              </div>
            </div>

            <div class="card">
              <div class="card-header-white">
                <h4>Desenvolvedor Front-end Pleno</h4>
                <hr />
              </div>
              <div class="card-body">
                <div class="card-flex">
                  <span>R$ 4.000</span>

                  <div class="card-footer">
                    <Link to="/cadastro">Saiba mais</Link>
                  </div>
                </div>
              </div>
            </div>

            <div class="card">
              <div class="card-header-white">
                <h4>Atendente de fast-food</h4>
                <hr />
              </div>
              <div class="card-body">
                <div class="card-flex">
                  <span>R$ 1.200</span>

                  <div class="card-footer">
                    <Link to="/cadastro">Saiba mais</Link>
                  </div>
                </div>
              </div>
            </div>
          </div>

          <div class="vagas-card">
            <div class="card">
              <div class="card-header-white">
                <h4>Desenvolvedor Front-end Pleno</h4>
                <hr />
              </div>
              <div class="card-body">
                <div class="card-flex">
                  <span>R$ 4.000</span>

                  <div class="card-footer">
                    <Link to="/cadastro">Saiba mais</Link>
                  </div>
                </div>
              </div>
            </div>

            <div class="card">
              <div class="card-header-white">
                <h4>Nutricionista</h4>
                <hr />
              </div>
              <div class="card-body">
                <div class="card-flex">
                  <span>R$2.800</span>

                  <div class="card-footer">
                    <Link to="/cadastro">Saiba mais</Link>
                  </div>
                </div>
              </div>
            </div>

            <div class="card">
              <div class="card-header-white">
                <h4>Desenvolvedor Front-end Pleno</h4>
                <hr />
              </div>
              <div class="card-body">
                <div class="card-flex">
                  <span>R$ 4.000</span>

                  <div class="card-footer">
                    <Link to="/cadastro">Saiba mais</Link>
                  </div>
                </div>
              </div>
            </div>

            <div class="card">
              <div class="card-header-white">
                <h4>Desenvolvedor Front-end Pleno</h4>
                <hr />
              </div>
              <div class="card-body">
                <div class="card-flex">
                  <span>R$ 4.000</span>

                  <div class="card-footer">
                    <Link to="/cadastro">Saiba mais</Link>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>

      <section id="test-content-section">
        <div id="test-content">
          <br />
          <h2 class="tittle-section">Testes de personalidades</h2>
          <hr class="line-blue" />
          <div class="vagas-card">
            <div class="card card-test">
              <div class="header-color-card">
                <img src={aguia} alt="Teste comportamental" />
              </div>
              <div class="card-body body-color-card">
                <div class="card-flex">
                  <span>Perfil comportamental</span>

                  <div class="card-footer">
                    <Link to="/TesteDePersonalidade">Fazer o teste</Link>
                  </div>
                </div>
              </div>
            </div>

            <div class="card card-test">
              <div class="header-color-card">
                <img src={disc} alt="Teste Disc" />
              </div>
              <div class="card-body body-color-card">
                <div class="card-flex">
                  <span>Teste DISC</span>

                  <div class="card-footer">
                    <a href="#" id="testebtn">
                      Fazer teste!
                    </a>
                  </div>
                </div>
              </div>
            </div>

            <div class="card card-test">
              <div class="header-color-card">
                <img src={Eneagrama} alt="Teste Eneagrama" />
              </div>
              <div class="card-body body-color-card">
                <div class="card-flex">
                  <span>Teste Eneagrama</span>

                  <div class="card-footer">
                    <a href="#" id="testebtn1">
                      Fazer teste!
                    </a>
                  </div>
                </div>
              </div>
            </div>

            <div class="card card-test">
              <div class="header-color-card">
                <img src={Person} alt="Teste Vocacional" />
              </div>
              <div class="card-body body-color-card">
                <div class="card-flex">
                  <span>Teste Vocacional</span>

                  <div class="card-footer">
                    <a href="#" id="testebtn2">
                      Fazer teste!
                    </a>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>
      <a href="/informacao"><div className="btnInfo">
        ?
      </div></a>
      <Footer />
    </div>
  );
}
