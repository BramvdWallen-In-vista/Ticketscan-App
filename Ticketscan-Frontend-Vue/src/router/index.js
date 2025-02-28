import { createMemoryHistory, createRouter } from 'vue-router'

import TicketscanView from '../views/TicketscanView.vue'
import HistoryView from '../views/HistoryView.vue'
import SettingsView from '../views/SettingsView.vue'
import LogoutView from '../views/LogoutView.vue'

const router = createRouter({
  history: createMemoryHistory(),
  routes: [
    {
      path: '/',
      name: 'ticketscan',
      component: TicketscanView
    },
    {
      path: '/history',
      name: 'history',
      component: HistoryView
    },
    {
      path: '/settings',
      name: 'settings',
      component: SettingsView
    },
    {
      path: '/logout',
      name: 'logout',
      component: LogoutView
    }
  ]
})
export default router

