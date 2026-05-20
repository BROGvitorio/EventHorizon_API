import { defineConfig } from 'vite';
import react from '@vitejs/plugin-react';

export default defineConfig({
    plugins: [react()],
    server: {
        proxy: {
            '/EventHorizon_API': {
                target: 'http://localhost:5042',
                changeOrigin: true,
                secure: false,
                rewrite: (path) => path.replace(/^\/EventHorizon_API/, ''),
            },
        },
    },
})