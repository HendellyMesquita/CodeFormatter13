import { Repositorio } from "./Repositorio.js";

class BaseController {
    constructor() {
        this.inputLista = document.getElementById('inputLista');
        this.formatarButton = document.getElementById('formatar');
        this.variaveisDaClasse = document.getElementById('variaveisDaClasse');
        this.comparacaoSubstring = document.getElementById('comparacaoSubstring');
        
        // Adiciona o evento de clique no botão de formatação
        this.formatarButton.addEventListener('click', () => this.formatarLista());
    }

    // Função que formata a lista e preenche os campos de saída
    formatarLista() {
debugger
        const lista = this.inputLista.value;

        Repositorio.enviarDados({ lista })
            .then(resultado => {
                this.variaveisDaClasse.textContent = resultado.variaveisDaClasse;
                this.comparacaoSubstring.textContent = resultado.comparacaoSubstring;
            })
            .catch(error => console.error('Erro ao formatar a lista:', error));

    }
}

// Instancia a classe BaseController assim que o documento estiver pronto
document.addEventListener('DOMContentLoaded', () => new BaseController());
