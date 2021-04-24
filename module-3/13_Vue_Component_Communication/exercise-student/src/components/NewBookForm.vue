<template>
  <form class="new-book-form">
    <input placeholder="title" v-model="title" class="title-input" />
    <input placeholder="author" v-model="author" class="author-input" />
    <input placeholder="isbn" v-model="isbn" class="isbn-input" />
    <button class="btn btn-primary" v-on:click="addEntry">Add</button>
  </form>
</template>

<script>
export default {
  name: "NewBookForm",
  data: function() {
    return { title: "", author: "", isbn: "" };
  },
  methods: {
    addEntry: function(e) {
      e.preventDefault();

      this.$store.commit("ADD_ENTRY", {
        title: this.title,
        author: this.author,
        isbn: this.isbn,
        read: false,
      });

      this.title = "";
      this.author = "";
      this.isbn = "";
    },
  },
};
</script>

<style></style>
