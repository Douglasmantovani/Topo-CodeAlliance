import React from "react";

import Header from "../../Components/Header";
import Footer from "../../Components/Footer";
import AccessBar from "../../Components/AccessBar";
import AccessMenu from "../../Components/AccessMenu";

import Azul from "../../assets/cadeira.jpg";
import Rosa from "../../assets/consulta.jpg";
import Empresario from "../../assets/trabalho.jpg";

import "./style.css";

export default function Servicos() {
return(
    <div>
    <AccessBar />
      <Header />
      <AccessMenu />
        <div id="content-banner" className="flex">
        <div>
        <h1>Confira nossos serviços</h1>
        </div>

    <div className="flex">
      <img  src={Azul} alt="Ilustração de uma pessoa construindo uma ponte acessivel para um cadeirante" classNameName="imgabout viewport-img"/>
      <div className="flex-services">
        <h2>Acessibilidade</h2>
        <hr className="line-blue"/>
        <br/>
        <p> Possuimos uma série de recursos que possibilita a navegação, a compreensão e a interação de qualquer pessoa na web (independentemente de suas dificuldades), sem ajuda de ninguém.</p>
      </div>
    </div> 
    </div>

    <div className="flex">
      <div className="flex-services">
        <h2>Consultoria</h2>
        <hr className="line-blue"/>
        <br/>
        <p> Possuímos uma série de recursos que possibilita a navegação, a compreensão e a interação de qualquer pessoa na web (independentemente de suas dificuldades), sem ajuda de ninguém.</p>
      </div>
      <img src={Rosa} alt="Uma ilustração de dua pessoas fazendo consultoria" className="imgabout viewport-img"/>
    </div>

    <div className="flex">
      <img  src={Empresario} alt="ilustração de pessoas pensando em seus futuros" className="imgabout viewport-img"/>
      <div className="flex-services">
        <h2>Oferecendo oportunidades</h2>
        <hr className="line-blue"/>
        <br/>
        <p>Nunca tenha receio de dar um passo em frente. Cada nova escolha que faz é uma oportunidade para iniciar um novo caminho. E quem sabe se não é esse que vai levar você até felicidade que tanto procura?</p><br/>
        <p>
        Viver sem correr riscos é desperdiçar oportunidades que podem valer ouro. Dispense o medo, cultive a ousadia, e coisas incríveis poderão acontecer na sua vida!</p>
      </div>
      
    </div>
    <a href="/informacao"><div className="btnInfo">
        ?
      </div></a>
<Footer/>
    </div>
);
}