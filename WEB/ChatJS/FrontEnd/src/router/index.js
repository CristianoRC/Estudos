import Vue from 'vue'
import Router from 'vue-router'
import Chat from '@/components/chat'
import VueResource from 'vue-resource';

Vue.use(Router)
Vue.use(VueResource);

export default new Router({
  mode: 'history',
  routes: [
    {
      path: '/',
      name: 'Chat',
      component: Chat
    }
  ]
})
