import React from "react";
import Header from "../../Components/Header";
import Footer from "../../Components/Footer";
import AccessBar from "../../Components/AccessBar";
import AccessMenu from "../../Components/AccessMenu";
import "./style.css";

import Azul from "../../assets/contato.png";

export default function Contato() {
  return (
    <div>
        <AccessBar />
      <Header />
      <AccessMenu />
      <div className="CentralizeAll">
      <form className="form-signin">
        <div className="form-content">
          <img src={Azul} alt="Ilustração Correio de voz" />
          <h1>Entre em contato com a gente!!</h1>
          <label className="form-lbl" for="inputNome">Nome:</label>
          <input
            type="email"
            id="inputNome"
            className="form-control"
            placeholder="Seu nome"
            required
            autofocus
          />
          <label className="form-lbl" for="inputEmail">Email:</label>
          <input
            type="email"
            id="inputEmail"
            className="form-control"
            placeholder="Seu email"
            required
            autofocus
          />
          <label className="form-lbl" for="inputNumber">Número</label>
          <input
            type="tel"
            id="inputPassword"
            className="form-control"
            placeholder="(11) 1111-1111"
            required
          />
          <label className="form-lbl" for="inputAssunt">Assunto:</label>
          <input
            type="text"
            id="inputPassword"
            className="form-control"
            placeholder="Qual assunto"
            required
          />
          <label className="form-lbl" for="inputAssunt">Sua Messagem:</label>
          <textarea
            type="text"
            id="inputPassword"
            className="form-control textarea-container"
            placeholder="Digite sua mensagem..."
            required
          ></textarea>
          <button className="btn-signup" type="submit">
            Enviar
          </button>
        </div>
      </form>
      </div>
      <a href="/informacao"><div className="btnInfo">
        ?
      </div></a>
      <Footer/>
    </div>
  );
}
