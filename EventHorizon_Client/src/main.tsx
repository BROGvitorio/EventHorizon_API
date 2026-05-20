import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import { BrowserRouter, Routes, Route } from 'react-router'

import './index.css'
import Login from './pages/Login'
import Register from './pages/Register'
import Dashboard from './pages/Dashboard'
// import App from './App.tsx'

createRoot(document.getElementById('root')!).render(
  <StrictMode>
    <BrowserRouter>
      <Routes>
          {/* <Route path="/" element={<Login/>}></Route> */}
        
        <Route path="/auth">
          <Route path="login" element={<Login/>}></Route>
          <Route path="register" element={<Register/>}></Route>
        </Route>


        <Route>
          <ProtectedRoute>
              <Route path="dashboard" element={<Dashboard/>}></Route>
          </ProtectedRoute>
        </Route>
        
      </Routes>
    </BrowserRouter>
  </StrictMode>
)
