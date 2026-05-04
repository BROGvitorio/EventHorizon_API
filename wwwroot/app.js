const apiUrl = '/api/EventHorizon';
async function carregarContas() {
    try {
        const resposta = await fetch(apiUrl);
        const bankAccounts = await resposta.json();

        const tbody = document.getElementById('bankAccountsTable');
        tbody.innerHTML = "";

        bankAccounts.forEach(bankAccount => {
            tbody.innerHTML += `
                <tr>
                    <td>${bankAccount.userId}</td>
                    <td>${bankAccount.category}</td>
                    <td>${bankAccount.balance}</td>
                </tr>
            `
        })
    } catch {
        console.log("Erro ao exibir contas.");
    }
}