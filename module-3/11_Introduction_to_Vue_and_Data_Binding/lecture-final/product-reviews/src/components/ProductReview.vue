<template>
  <div class="main">
     <h2>{{name}}</h2>
     <p class="description">{{description}}</p>

    <div class="well-display">
        <div class="well">
            <span class="amount"> {{averageRating}} </span>
            Average Rating
        </div>

        <div class="well">
            <span class="amount">{{numberOfOneStarReviews}} </span>
            1 Star Review
        </div>
        <div class="well">
            <span class="amount"> </span>
            2 Star Review
        </div>
    </div>

    <div class="review" v-for="review in reviews" v-bind:key="review.id" v-bind:class="{favorited: review.favorited}">
        <h4>{{review.reviewer}}</h4>
        <div class="rating">
            <img v-for="n in review.rating" v-bind:key="n" src="../assets/star.png" alt="">
        </div>
        <h3>{{review.title}}</h3>
        <p>{{review.review}}</p>
        <p>
            Favorite?
            <input v-model="review.favorited" type="checkbox" name="checkbox" id="checkbox">
        </p>

    </div>

  </div>
</template>

<script>
export default {
    //optional, apparently /shrug
    name:"product-review",
    data: function(){
        return {
            name: "Cigar Parties for Smart People",
            description:"Host and plan the perfect cigar party for all your squirrely friends",
            reviews: [
                {
                    reviewer: "Malcolm Gladwell",
                    title: 'What a book!',
                    review: "It certainly is a book. I mean, I can see that. Pages kept together with glue and there's writing on it, in some language.",
                    rating: 1,
                    id: 1,
                    favorited: false
                }, {
                    reviewer: "test",
                    title: 'has pages!',
                    review: "It testtest is a book. I mean, I can see that. Pages kept together with glue and there's writing on it, in some language.",
                    rating: 3,
                    id: 2,
                    favorited: false
                }
        ]
        }
    },
    computed :{
        averageRating(){
            let sum = this.reviews.reduce(
                (acc, review) => {
                    return acc + review.rating;
                },0
            )
            return sum / this.reviews.length;
        },
        numberOfOneStarReviews(){
            let count = this.reviews.filter(
                rev => {
                    return rev.rating === 1;
                }
            )
            return count.length;
        }
    }

}
</script>

<style scoped>

div.main{
    margin: 1rem 0;
}
div.main div.well-display {
    display: flex;
    justify-content: space-around;
}

div.main div.well-display div.well {
    display: inline-block;
    width: 15%;
    border: 1px black solid;
    border-radius: 6px;
    text-align: center;
    margin: 0.25rem;
}

div.main div.well-display div.well span.amount {
    color: darkslategray;
    display: block;
    font-size: 2.5rem;
}

div.main div.review {
    border: 1px black solid;
    border-radius: 6px;
    padding: 1rem;
    margin: 10px;
}

div.main div.review div.rating {
    height: 2rem;
    display: inline-block;
    vertical-align: top;
    margin: 0 0.5rem;
}

div.main div.review div.rating img {
    height: 100%;
}

div.main div.review p {
    margin: 20px;
}

div.main div.review h3 {
    display: inline-block;
}

div.main div.review h4 {
    font-size: 1rem;
}

.favorited {
    background-color: lightgoldenrodyellow;
}

</style>