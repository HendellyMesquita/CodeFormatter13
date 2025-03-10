// Repositorio.js

class Repositorio {
    static async formatarLista(dados) {
        try {
            const RotaFormatar = "formatarLista";
            const CaminhoController = "CodeFormatter";
            const url = `/api/${CaminhoController}/${RotaFormatar}`;
            debugger
            const response = await fetch(url, {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(dados)
            });
    
            if (!response.ok) {
                throw new Error(`Erro HTTP! Código: ${response.status}`);
            }
    
            const data = await response.json();
            console.log('Resposta do servidor:', data);
            return data;
        } catch (error) {
            console.error('Erro ao chamar a API:', error);
            return null;
        }
    }
}

// Exporta a classe Repositorio
export { Repositorio };
