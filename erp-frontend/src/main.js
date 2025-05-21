import { createApp } from 'vue'
import { createPinia } from 'pinia'

import App from './App.vue'
import router from './router'

// CoreUI
import CoreuiVue from '@coreui/vue'
import CIcon from '@coreui/icons-vue'
import { iconsSet as icons } from '@/assets/icons'

// Optional Docs components (if used in your layout or views)
//import DocsComponents from '@/components/DocsComponents'
//import DocsExample from '@/components/DocsExample'
//import DocsIcons from '@/components/DocsIcons'

// Optional but recommended CoreUI and Bootstrap styles
import '@coreui/coreui/dist/css/coreui.min.css'
import 'bootstrap/dist/css/bootstrap.min.css'

const app = createApp(App)

app.use(createPinia())
app.use(router)
app.use(CoreuiVue)

app.provide('icons', icons)        // REQUIRED for <CIcon>
app.component('CIcon', CIcon)      // REQUIRED to use <CIcon> tag

// Optional components
//app.component('DocsComponents', DocsComponents)
//app.component('DocsExample', DocsExample)
//app.component('DocsIcons', DocsIcons)

app.mount('#app')
