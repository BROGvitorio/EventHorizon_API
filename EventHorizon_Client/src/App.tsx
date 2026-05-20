// import 'bootstrap/dist/css/bootstrap.min.css';
// import 'bootstrap/dist/js/bootstrap.bundle.min.js';

// import { useEffect, useState } from 'react'
// import './App.css'

// type User = {
//     email: string,
//     loginPassword: string
// }

// const apiUrl = "/EventHorizon_API/api/User";

// function App() {
//     const [users, setUsers] = useState<User[]>([]);
//     const [loading, setLoading] = useState(true);
//     const [error, setError] = useState<string | null>(null);

//     useEffect(() => {
//         fetch(`${apiUrl}/ListAll`)
//             .then(async response => {
//                 if (!response.ok) {
//                     throw new Error(`Erro na requisição: ${response.status}`);
//                 }
//                 const data = (await response.json()) as User[];
//                 setUsers(data);
//             })
//             .catch(err => setError(err.message))
//             .finally(() => setLoading(false));
//     }, []);

//     if (loading) {
//         return <p>Loading user data...</p>
//     }

//     if (error) {
//         return <p>Error: {error}</p>
//     }

//     return (
//         <main style={{ padding: 24 }}>
//             <h1>Lista de Usuários</h1>
//             <table>
//                 <thead>
//                     <tr>
//                         <th>ID</th>
//                         <th>Email</th>
//                         <th>Senha</th>
//                     </tr>
//                 </thead>
//                 <tbody>
//                     {users.map(user => (
//                         <tr key={user.email}>
//                             <td>{user.email}</td>
//                             <td>{user.loginPassword}</td>
//                         </tr>
//                     ))}
//                 </tbody>
//             </table>
//         </main>
//     );
// }

// export default App