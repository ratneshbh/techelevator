<template>
  <div>
    <div class="loading" v-if="isLoading">
      <img src="../assets/ping_pong_loader.gif" />
    </div>
    <div v-else>
      <router-link v-bind:to="{name:'Board', params:{id: $route.params.boardID}}">
        Go Back to Board
      </router-link>
      <h1>
        {{ card.title }}
      </h1>
      <p>
        {{ card.description }}
      </p>

      <comments-list 
        v-for="comment in card.comments" 
        v-bind:key="comment.id" 
        v-bind:childComponentProp="comment"
        />
    </div>
  </div>
</template>

<script>
import BoardService from "../services/BoardService.js";
import CommentsList from "../components/CommentsList.vue";

export default {
  name: "card-detail",
  components: {
    CommentsList,
  },
  data() {
    return {
      isLoading: true,
      card: {},
    };
  },
  created() {
    BoardService.getCard(
      this.$route.params.boardID,
      this.$route.params.cardID
    ).then((resp) => {
      this.card = resp;
      this.isLoading = false;
    });
  },
};
</script>
