import Vue from 'vue'
import VueRouter, { RouteConfig } from 'vue-router'

Vue.use(VueRouter)

const routes: Array<RouteConfig> = [
  {
    path: '/',
    name: 'AccountTransactions',
    component: () => import('../views/account-transactions.vue')
  }
]

const router = new VueRouter({
  routes
})

export default router
