import React from 'react';
import './style.css';

export default function AccessBar() {
    return(
        <div className="Access">
            <section class="barra">
                <div class="between">
                    <ul class="flex">
                        <li class="links"><a href="#menu" alt="Tecla de acesso para navegar no menu - alt + 1" accesskey="1" class="topbar"><b>1</b> Menu</a></li>
                    <li class="links"><a href="#conteudo" alt="Tecla de acesso para conteúdo - alt + 2" accesskey="2" class="topbar"><b>2</b> Conteúdo</a></li>
                    <li class="links"><a href="#bar" alt="Tecla de acesso para menu de acessibilidade - alt + A" accesskey="a" class="topbar" id="btnbar1"><b>A</b> Menu de acessibilidade</a></li>
                    </ul>
                <ul class="flex">
    
            <li class="links"><a href="https://www.instagram.com/team.code.alliance/" alt="Instagram da Code Alliance - Time 163 do Hackatthon CCR 2021" class="topbar fa fa-instagram" target="_black" rel="noopener" aria-label="Instagram da Code Alliance - Time 163 do Hackatthon CCR 2021"></a></li>
    
            <li class="links"><a href="https://www.youtube.com/channel/UCC-JTTRQkMqjkqmVcKSM0aA" class="topbar fa fa-youtube" target="_black" rel="noopener" aria-label="Youtube da Code Alliance - Time 163 do Hackatthon CCR 2021"></a></li>
    
            <li class="links"><a href="https://github.com/senai-desenvolvimento" aria-label="Github da Code Alliance - Time 163 do Hackatthon CCR 2021" rel="noopener" class="topbar fa fa-github" target="_black"></a></li>
    
                </ul>
                </div>
        </section>
        </div>
    );
}