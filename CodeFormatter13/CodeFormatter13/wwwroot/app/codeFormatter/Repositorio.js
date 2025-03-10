// Repositorio.js

class Repositorio {
    static async formatarLista(dados) {
        try {
            const CaminhoController = "CodeFormatter";
            const RotaFormatar = "formatarLista";

            const url = `http://localhost:3000/${CaminhoController}/${RotaFormatar}`;

            const response = await fetch(url, {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(dados)
            });

            if (!response.ok) {
                throw new Error(`Erro HTTP! Status: ${response.status}`);
            }

            const resultado = await response.json();
            return resultado; // Retorna o resultado para quem chamar a função
        } catch (error) {
            console.error('Erro na requisição:', error);
            return null;
        }
    }
}

// Exporta a classe Repositorio
export { Repositorio };
