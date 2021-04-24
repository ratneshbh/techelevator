import Vue from 'vue'
import VueRouter from 'vue-router'
import ProductList from '../views/ProductList.vue'
import ProductDetail from '../views/ProductDetail.vue'
import AddReviewView from '../views/AddReviewView.vue'

Vue.use(VueRouter)

const routes = [

{
  path: '/',
  component: ProductList,
  name: 'product-list'
},
{
  path: '/product/:id',
  component: ProductDetail,
  name: 'product-detail'
},
{
  path: '/add-review/:id',
  component: AddReviewView,
  name: 'add-review'
},
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
