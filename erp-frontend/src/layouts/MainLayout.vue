<script setup>
import { ref } from 'vue'
import { CContainer } from '@coreui/vue'
import AppFooter from '@/components/AppFooter.vue'
import AppHeader from '@/components/AppHeader.vue'
import AppSidebar from '@/components/AppSidebar.vue'

const sidebarMinimized = ref(false)

function toggleSidebar() {
  sidebarMinimized.value = !sidebarMinimized.value
}
</script>

<template>
  <div :class="['app', { 'sidebar-minimized': sidebarMinimized }]">
    <AppSidebar />
    <div class="wrapper d-flex flex-column min-vh-100">
      <!-- Pass toggleSidebar to AppHeader so the button can trigger it -->
      <AppHeader @toggle-sidebar="toggleSidebar" />
      <div class="body flex-grow-1">
        <CContainer class="px-4" lg>
          <router-view />
        </CContainer>
      </div>
      <AppFooter />
    </div>
  </div>
</template>
