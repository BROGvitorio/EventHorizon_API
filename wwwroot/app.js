const apiUrl = 'api/User';
const authApiUrl = 'api/Auth';

// localstorage.setItem

async function Login() {
    const userLogin = {
        Email: document.getElementById('loginEmail').value,
        LoginPassword: document.getElementById('loginPassword').value
    }

    try {
        const response = await fetch(authApiUrl, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(userLogin)
        });

        const data = await response.json();

        if (response.ok) {
            localStorage.setItem("token", data.token);
            alert(data.message);
            console.log(data.message);
            window.location.href = '/dashboard.html';
        }

    } catch (error) {
        console.error(error);
    }
}

async function ShowUsers() {
    try {
        const response = await fetch(apiUrl);
        const users = await response.json();

        const tbody = document.getElementById('tableBody');
        tbody.innerHTML = '';

        users.forEach(user => {
            tbody.innerHTML += `
                <tr>
                    <td>${user.id}</td>
                    <td>${user.email}</td>
                    <td>${user.loginPassword}</td>
                </tr>
            `
        }
    )
    } catch (erro) {
        alert("Erro ao buscar dados.")
        console.error(erro);
    }
}

async function AddUser() {
    const userEmail = document.getElementById('userEmail').value;
    const userPassword = document.getElementById('userPassword').value;

    const token = document.getElementById('jwtToken').value.trim();
    console.log("Header enviado:", `Bearer ${token}`);

    const newUser = {
        Email: userEmail,
        LoginPassword: userPassword
    }

    try {
        const response = await fetch(apiUrl, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
                'Authorization': `Bearer ${token}`
            },
            body: JSON.stringify(newUser)
        });

        if (response.ok) {
            alert("Usuário cadastrado com sucesso!");
            ShowUsers();
        } else {
            alert("Erro 401: Token inválido");
        }
    } catch (erro) {
        console.error(erro);
    }
}

async function DeleteUser() {
    const userId = document.getElementById('userIdInput').value;

    
}