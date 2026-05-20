import { BrowserRouter, Routes, Route, useNavigate } from 'react-router'

import { type ReactNode } from 'react';

interface ProtectedRouteProps {
  children: ReactNode;
}

const isAuthenticated = () => {
    const token = localStorage.getItem("token");
    return !(token == null);
}

export const ProtectedRoute = ({children}: ProtectedRouteProps) => {
    if (isAuthenticated())
        return children;

    let navigate = useNavigate();
    navigate("/auth/login")
    return null;
}