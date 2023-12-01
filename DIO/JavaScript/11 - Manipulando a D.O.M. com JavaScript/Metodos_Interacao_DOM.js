document.getElementById('titulo');
//<h1 id="titulo">Minha página</h1>

document.getElementsByTagName('li');
/*
[
    <li>Projeto 1</li>,
    <li>Projeto 2</li>,
    <li>Projeto 3</li>
]
*/

document.getElementsByClassName('textos')
/*
[
    <section class="textos">
        <h2>Sobre mim</h2>
        <p>Texto sobre a pessoa aqui.</p>
    </section>,

    <section class="textos">
        <h2>Meus projetos</h2>
        <ul>
            <li>Projeto 1</li>
            <li>Projeto 2</li>
            <li>Projeto 3</li>
        </ul>
    </section>
]
*/

document.querySelectorAll('.primeira-classe .segunda-clase');
/*
[
    <div class="primeira-classe segunda-classe">
        <ul>
            <li class="opcao">Opção 1</li>
            <li class="opcao">Opção 2</li>
            <li class="opcao">Opção 3</li>
        </ul>
    </div>
]
*/

document.querySelectorAll('li .opcao');
/*
[
    <li class="opcao">Opção 1</li>,
    <li class="opcao">Opção 2</li>,
    <li class="opcao">Opção 3</li>,
]
*/

document.createElement(element);
// Cria um novo element HTML
document.removeChild(element);
// Remove um elemento
document.appendChild(element);
// Adiciona um elemento
document.replaceChild(novo, old);
// Substitui um elemento