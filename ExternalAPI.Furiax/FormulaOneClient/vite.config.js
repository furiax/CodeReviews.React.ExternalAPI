import { defineConfig } from 'vite';
import plugin from '@vitejs/plugin-react';

// https://vitejs.dev/config/
export default defineConfig({
    plugins: [plugin()],
    server: {
        https: false,
        host: 'localhost',
        port: 60834,
    }
})