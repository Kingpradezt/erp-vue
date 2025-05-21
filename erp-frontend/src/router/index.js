import { createRouter, createWebHistory } from 'vue-router'

import LoginPage from '@/views/LoginPage.vue'
import MainLayout from '@/layouts/MainLayout.vue'

// Lazy-load InventoryList
const InventoryList = () => import('@/views/InventoryList.vue')

const routes = [
  {
    path: '/',
    name: 'Login',
    component: LoginPage
  },
  {
    path: '/',
    component: MainLayout,
    children: [
      {
        path: 'inventory',
        name: 'InventoryList',
        component: InventoryList,
      },
      // Add more child routes here if needed
    ]
  },
  // Optionally add a catch-all 404 route here
]

const router = createRouter({
  history: createWebHistory(),
  routes,
  scrollBehavior() {
    return { top: 0 }
  },
})

export default router
