<template>
  <div id="app" class="main">
    <h1>{{ product.name }}</h1>
    <p class="description">{{ product.description }}</p>
    <div class="actions">
      <!--a href="/">Back to Products</a-->
      <router-link :to="{ name : 'product-list' }">Back to Products
      </router-link> &nbsp;|

        <router-link :to="{name:'add-review', params:{id:product.id}}">
            Add Review
        </router-link>

      <!--a href="#">Add Review</a-->
    </div>
    <div class="well-display">
      <average-summary />
      <star-summary rating="1" />
      <star-summary rating="2" />
      <star-summary rating="3" />
      <star-summary rating="4" />
      <star-summary rating="5" />
    </div>
    <review-list /> 
  </div>
</template>

<script>

import AverageSummary from '../components/AverageSummary'
import ReviewList from '../components/ReviewList.vue'
import StarSummary from '../components/StarSummary.vue'


export default {
    components:{
        AverageSummary,
        StarSummary,
        ReviewList
    },
    //lifecycle hook automatically called by vue 
    //https://vuejs.org/images/lifecycle.png
    created(){
        this.$store.commit("SET_ACTIVE_PRODUCT", this.$route.params.id)
    },
    computed: {
        product(){
            return this.$store.state.products.find(
                (currentBook) => 
                {
                   return currentBook.id === parseInt(this.$store.state.activeProduct);
                }
            )
        }
    }
}
</script>

<style>

</style>