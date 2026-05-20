import React, { useState } from 'react';

import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min.js';

export default function LoginPage() {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [showPassword, setShowPassword] = useState(false);

  // Função para lidar com a submissão do formulário
  const handleLogin = (e: React.SyntheticEvent) => {
    e.preventDefault();
    
    console.log('Tentativa de login com:', { email, password });
  };

  return (
    <div 
      id="main-page" 
      className="d-flex align-content-center justify-content-center flex-wrap">

      <main className="d-flex flex-column align-content-center justify-content-center w-25 h-50 bg-light shadow-lg border border-secondary-subtle p-5 rounded-5">
        
        <form 
          onSubmit={handleLogin} 
          className="h-100 d-flex flex-column justify-content-around"
        >
          <h2 className="align-self-center">Login</h2>

          <input 
            type="email" 
            placeholder="Email" 
            id="loginEmail"
            className="bg-transparent border-0 border-bottom border-dark-subtle"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
            required
          />

          <div className="w-100">
            <input 
              type={showPassword ? 'text' : 'password'} 
              placeholder="Senha" 
              id="loginPassword"
              className="bg-transparent border-0 border-bottom border-dark-subtle w-100"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
              required
            />
            
            <div className="form-check form-switch mt-2">
              <input 
                className="form-check-input" 
                type="checkbox" 
                role="switch" 
                id="showPassword"
                checked={showPassword}
                onChange={() => setShowPassword(!showPassword)}
              />
              <label className="form-check-label" htmlFor="showPassword">
                Mostrar senha
              </label>
            </div>
          </div>

          <button 
            type="submit" 
            className="w-50 align-self-center btn btn-dark"
          >
            Login
          </button>
        </form>

        <h6 className="text-center">
          Não tem uma conta?{' '}
          {/* Nota: Em uma app real com rotas, prefira usar o <Link> do react-router-dom */}
          <a href="/signup">Cadastre-se</a>
        </h6>
      </main>
    </div>
  );
}