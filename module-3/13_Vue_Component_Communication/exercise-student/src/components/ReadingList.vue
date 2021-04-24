<template>
  <div class="book-container"> 
  <div v-for="book in $store.state.books" v-bind:key="book.isbn" >
    <book-card v-bind:book="book"/>
  </div>
  </div>
</template>

<script>
import BookCard from "./BookCard.vue"

export default {
  components: { BookCard },
    name: "reading-list",
    
    
};
</script>

<style>
.book-container {
    display: flex;
    justify-content: space-evenly;
    flex-wrap: wrap;
}
</style>