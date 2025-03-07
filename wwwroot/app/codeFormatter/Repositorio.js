// Repositorio.js

class Repositorio {
    static async enviarDados(dados) {
        try {
            debugger
            const response = await fetch('https://api.exemplo.com/dados', {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(dados),
            });

            if (response.ok) {
                const resultado = await response.json();
                return resultado;
            } else {
                throw new Error('Erro ao enviar os dados');
            }
        } catch (error) {
            console.error('Erro na requisição:', error);
        }
    }
}

// Exporta a classe Repositorio
export { Repositorio };
