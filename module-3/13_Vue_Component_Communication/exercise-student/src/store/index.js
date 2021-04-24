import Vue from "vue";
import Vuex from "vuex";

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    books: [
      {
        title: "Kafka on the Shore",
        author: "Haruki Murakami",
        read: false,
        isbn: "9781400079278",
      },
      {
        title: "The Girl With All the Gifts",
        author: "M.R. Carey",
        read: true,
        isbn: "9780356500157",
      },
      {
        title: "The Old Man and the Sea",
        author: "Ernest Hemingway",
        read: true,
        isbn: "9780684830490",
      },
      {
        title: "Le Petit Prince",
        author: "Antoine de Saint-Exupéry",
        read: false,
        isbn: "9783125971400",
      },
    ],
  },
  mutations: {
    CHANGE_READ(state, isbn) {
      state.books.filter((b) => {
        if (b.isbn == isbn) {
          b.read = !b.read;
          return;
        }
      });
    },
    ADD_ENTRY(state, entry) {
      state.books.push(entry);
    },
  },
  actions: {},
  modules: {},
  strict: true,
});